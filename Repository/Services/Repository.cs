using MongoDB.Bson;
using MongoDB.Driver;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class Repository : IRepository
    {
        public string DatabaseName { get; set; }
        public string TenantId { get; set; }
        public IMongoDatabase DataContext { get; set; }

        public Repository()
        {
            
        }

        public void Initialize()
        {
            if (string.IsNullOrEmpty(DatabaseName) || DatabaseName == Guid.Empty.ToString())
            {
                var dbConnectionSettings = new DatabaseConnectionSettings
                {
                    ConnectionString = "mongodb://localhost:27017",
                    DatabaseName = "Quizzer"

                };
                DataContext = new MongoClient(dbConnectionSettings.ConnectionString).GetDatabase(dbConnectionSettings.DatabaseName);
                DatabaseName = dbConnectionSettings.DatabaseName;
            }
        }



        public IQueryable<T> GetItems<T>(Expression<Func<T, bool>> dataFilters)
        {
            Initialize();
            return DataContext.GetCollection<T>($"{typeof(T).Name}s").AsQueryable().Where(dataFilters);
        }
        public IQueryable<T> GetItems<T>()
        {
            Initialize();
            return DataContext.GetCollection<T>($"{typeof(T).Name}s").AsQueryable();
        }

        public void Save<T>(T data, string collectionName = "")
        {
            Initialize();
            if (string.IsNullOrEmpty(collectionName))
                collectionName = $"{typeof(T).Name}s";
            DataContext.GetCollection<T>(collectionName).InsertOne(data);
        }

        public void Update<T>(Expression<Func<T, bool>> dataFilters, T data)
        {
            Initialize();
            DataContext.GetCollection<T>($"{typeof(T).Name}s").ReplaceOne(dataFilters, data);
        }


        public void UpdateMany<T>(Expression<Func<T, bool>> dataFilters, object data, string collectionName = "")
        {
            var fieldValuePairs = this.GetValues(data);
            UpdateDefinition<T> update = null;

            //TODO Will refactor it
            foreach (var fieldValuePair in fieldValuePairs)
            {
                if (update == null)
                {
                    if (fieldValuePair.Value is string[])
                        update = Builders<T>.Update.Set(fieldValuePair.Key, (string[])fieldValuePair.Value);
                    else
                        update = Builders<T>.Update.Set(fieldValuePair.Key, fieldValuePair.Value);
                }
                else
                {
                    if (fieldValuePair.Value is string[])
                        update = update.Set(fieldValuePair.Key, (string[])fieldValuePair.Value);
                    else
                        update = update.Set(fieldValuePair.Key, fieldValuePair.Value);
                }


            }

            Initialize();
            if (string.IsNullOrEmpty(collectionName))
                collectionName = $"{typeof(T).Name}s";

            DataContext.GetCollection<T>(collectionName).UpdateMany(dataFilters, update);
        }





        public void Delete<T>(Expression<Func<T, bool>> dataFilters)
        {
            Initialize();
            DataContext.GetCollection<T>($"{typeof(T).Name}s").DeleteMany(dataFilters);
        }


        public void Save<T>(List<T> datas)
        {
            Initialize();
            DataContext.GetCollection<T>($"{typeof(T).Name}s").InsertMany(datas);
        }

        public T GetItem<T>(Expression<Func<T, bool>> dataFilters)
        {
            Initialize();
            return DataContext.GetCollection<T>($"{typeof(T).Name}s").AsQueryable().FirstOrDefault(dataFilters);
        }

        private IDictionary<string, object> GetValues(object obj)
        {
            return obj
                    .GetType()
                    .GetProperties()
                    .ToDictionary(p => p.Name, p => p.GetValue(obj) == null ? null : p.GetValue(obj));
        }

        public string ExecuteCommand(string query)
        {
            Initialize();
            var response = DataContext.RunCommand(new BsonDocumentCommand<BsonDocument>(BsonDocument.Parse(query)));
            return response.ToJson();
        }

        public void Delete<T>(Expression<Func<T, bool>> dataFilters, string collectionName)
        {
            Initialize();
            DataContext.GetCollection<T>($"{collectionName}s").DeleteMany(dataFilters);
        }
    }
}
