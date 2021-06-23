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
    public class QuestionCommandService : IQuestionCommandService
    {
        private readonly IRepository repository;

        public QuestionCommandService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreateQuestion(CreateQuestionCommand command)
        {
            repository.Save<Question>(Mapper.CreateQuestion(command));
        }
    }
}
