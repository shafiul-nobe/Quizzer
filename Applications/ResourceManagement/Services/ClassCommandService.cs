using Entities;
using Infrastructure.Contracts;
using ResourceManagement.Builders;
using ResourceManagement.Commands;
using ResourceManagement.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Services
{
    public class ClassCommandService : IClassCommandService
    {
        private readonly IRepository repository;

        public ClassCommandService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreatClass(CreateClassCommand command)
        {
            repository.Save<StudentClass>(ResouceManagementMapper.CreateClass(command));
        }
    }
}
