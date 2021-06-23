using ResourceManagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Contracts
{
    public interface IQuestionCommandService
    {
       void CreateQuestion(CreateQuestionCommand command);            
    }
}
