﻿using MongoDB.Bson.Serialization.Attributes;

namespace Entities
{
    [BsonIgnoreExtraElements]
    public class EntityBase : RootEntityBase
    {
        public string[] RolesAllowedToRead { get; set; }
        public string[] IdsAllowedToRead { get; set; }
        public string[] RolesAllowedToWrite { get; set; }
        public string[] IdsAllowedToWrite { get; set; }
        public string[] RolesAllowedToUpdate { get; set; }
        public string[] IdsAllowedToUpdate { get; set; }
        public string[] RolesAllowedToDelete { get; set; }
        public string[] IdsAllowedToDelete { get; set; }
    }
}
