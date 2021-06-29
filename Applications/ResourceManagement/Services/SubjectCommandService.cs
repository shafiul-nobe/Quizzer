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
    public class SubjectCommandService : ISubjectCommandService
    {
       private readonly IRepository repository;

        public SubjectCommandService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreateSubject(CreateSubjectCommand command)
        {
            repository.Save<Subject>(ResouceManagementMapper.CreateSubject(command));
        }
    }
}
