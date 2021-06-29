using Entities;
using ModelTest.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest.Builders
{
    public static class ModelTestMapper
    {
        public static Package CreatePackage(CreatePackageCommand command)
        {
            return new Package()
            {
                ItemId = command.ItemId,
                ClassId = command.ClassId,
                Description = command.Description,
                SubjectIds = command.SubjectIds,
                StartTime = command.StartTime,
                EndTime = command.EndTime,
                PackageName = command.PackageName,
                GuideLines = command.GuideLines,
                IsComplete = command.IsComplete
            };
        }

        public static ModelTestExam CreateModelTest(CreateModelTestCommand command)
        {
            return new ModelTestExam()
            {
                ItemId = command.ItemId,
                ClassId = command.ClassId,
                ExamDate = command.ExamDate,
                Name = command.Name,
                StartTime = command.StartTime,
                EndTime = command.EndTime,
                RankingPublishingTime = command.RankingPublishingTime,
                TotalQuestion = command.TotalQuestion,
                IsPaid = command.IsPaid,
                PackageId = command.PackageId,
                SubjectId = command.SubjectId,
            };
        }
    }
}
