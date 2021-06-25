using Domain.DTOs;
using Entities;
using Quizzer.Queries.Models.Question;
using Quizzer.Queries.Models.Subject;
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
                SubjectId = question.SubjectId,
                ChapterId = question.ChapterId,
                ChapterName = question.ChapterName,
                ClassName = question.ClassName,
                Explanation = question.Explanation,
                ImportantLevel = question.ImportantLevel,
                Level = question.Level,
                Rating = question.Rating,
                SubjectName = question.SubjectName,
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

        public static QuestionsByChapterQueryResponseModel QuestionsByChapterQueryResponseModel(this List<Question> questions)
        {
            var QuestionsByChapterQueryResponseModel = new QuestionsByChapterQueryResponseModel();
            foreach (var question in questions)
            {
                QuestionsByChapterQueryResponseModel.Questions.Add(question.QuestionByIdQueryResponseModel());
            }
            return QuestionsByChapterQueryResponseModel;
        }

        public static SubjectsByClassQueryResponseModel SubjectsByClassQueryResponseModel(this List<Subject> subjects)
        {
            var SubjectsByClassQueryResponseModel = new SubjectsByClassQueryResponseModel();
            foreach (var subject in subjects)
            {
                SubjectsByClassQueryResponseModel.Subjects.Add(new SubjectDto()
                {
                    ItemId = subject.ItemId,
                    ClassId = subject.ClassId,
                    ClassName = subject.ClassName,
                    SubjectChapters = subject.SubjectChapters,
                    Rating = subject.Rating,
                    SubjectName = subject.SubjectName,
                    SUbjectNumber = subject.SUbjectNumber
                });
            }
            return SubjectsByClassQueryResponseModel;
        }

    }
}
