using Entities;
using ResourceManagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement.Builders
{
    public static class Mapper
    {
        public static Question CreateQuestion( CreateQuestionCommand createQuestionCommand)
        {
            return new Question()
            {
                QuestionDetail = createQuestionCommand.Question,
                ItemId = createQuestionCommand.ItemId,
                Options = createQuestionCommand.Options,
                CorrectOption = createQuestionCommand.CorrectOption,
                ClassId = createQuestionCommand.ClassId,
                SubjectId = createQuestionCommand.SubjectId
            };
        }

    }
}
