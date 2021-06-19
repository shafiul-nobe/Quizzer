using Entities;
using Infrastructure.Contracts;
using ResourceManagement.Commands;
using ResourceManagement.Contracts;
using ResourceManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Services
{
    public class ResourceManagementService : IResourceManagementService
    {
        private readonly IRepository repository;

        public ResourceManagementService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreateQuestion(CreateQuestionCommand command)
        {
            repository.Save<Question>(new Question() { QuestionDetail = command.Question, ItemId = command.ItemId, Options = command.Options, CorrectOption = command.CorrectOption });
            var response = new CreateQuestionCommandResponseModel();
            
        }
    }
}
