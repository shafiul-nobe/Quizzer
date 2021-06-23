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
                ClassName = createQuestionCommand.ClassName,
                SubjectId = createQuestionCommand.SubjectId,
                SubjectName = createQuestionCommand.SubjectName,
                ChapterId = createQuestionCommand.ChapterId,
                ChapterName = createQuestionCommand.ChapterName
            };
        }
        public static StudentClass CreateClass(CreateClassCommand createClassCommand)
        {
            return new StudentClass()
            {
               ItemId = createClassCommand.ItemId,
               ClassName = createClassCommand.ClassName
            };
        }

        public static Subject CreateSubject(CreateSubjectCommand createSubjectCommand)
        {
            return new Subject()
            {
                ItemId = createSubjectCommand.ItemId,
                ClassName = createSubjectCommand.ClassName,
                ClassId = createSubjectCommand.ClassId,
                SubjectName = createSubjectCommand.SubjectName,
            };
        }

        public static Chapter CreateChapter(CreateChapterCommand createChapterCommand)
        {
            return new Chapter()
            {
                ItemId = createChapterCommand.ItemId,
                ChapterName = createChapterCommand.ChapterName,
                ClassName = createChapterCommand.ClassName,
                ClassId = createChapterCommand.ClassId,
                SubjectId = createChapterCommand.SubjectId,
                SubjectName = createChapterCommand.SubjectName,
                ChapterNumber = createChapterCommand.ChapterNumber
            };
        }



    }
}
