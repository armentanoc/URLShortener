﻿
namespace URLShortener.Infra.Repositories
{
    [Serializable]
    public class EntityAlreadyExistsException : Exception
    {
        public string SpecificEntity { get; private set; }

        public EntityAlreadyExistsException(string specificEntity)
           : base($"Entity {specificEntity} with properties described already exists.")
        {
            SpecificEntity = specificEntity;
        }
    }
}