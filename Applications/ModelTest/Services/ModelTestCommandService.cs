using Entities;
using Infrastructure.Contracts;
using ModelTest.Builders;
using ModelTest.Commands;
using ModelTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest.Services
{
    public class ModelTestCommandService : IModelTestCommandService
    {
        private readonly IRepository repository;

        public ModelTestCommandService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreateModelTest(CreateModelTestCommand command)
        {
            repository.Save<ModelTestExam>(ModelTestMapper.CreateModelTest(command));
        }
    }
}
