using ResourceManagement.Commands;
using ResourceManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Contracts
{
    public interface IResourceManagementService
    {
       void CreateQuestion(CreateQuestionCommand command);
            
    }
}
