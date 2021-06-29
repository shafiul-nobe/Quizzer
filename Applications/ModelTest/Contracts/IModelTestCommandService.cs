using ModelTest.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest.Contracts
{
    public interface IModelTestCommandService
    {
        void CreateModelTest(CreateModelTestCommand createModelTestCommand);
    }
}
