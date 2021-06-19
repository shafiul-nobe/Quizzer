using Entities;
using Quizzer.Queries.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer.Queries.Builders
{
    public static class Mapper
    {
        public static QuestionByIdQueryResponseModel QuestionByIdQueryResponseModel(this Question question)
        {
            return new QuestionByIdQueryResponseModel()
            {
                ItemId = question.ItemId,
                CorrectOption = question.CorrectOption,
                Options = question.Options,
                Question = question.QuestionDetail,
                ClassId = question.ClassId,
                SubjectId = question.SubjectId
            };
        }

        public static QuestionsByClassQueryResponseModel QuestionsByClassQueryResponseModel(this List<Question> questions)
        {
            var QuestionsByClassQueryResponseModel = new QuestionsByClassQueryResponseModel();
            foreach (var question in questions)
            {
                QuestionsByClassQueryResponseModel.Questions.Add(question.QuestionByIdQueryResponseModel());
            }
            return QuestionsByClassQueryResponseModel;
        }
    }
}
