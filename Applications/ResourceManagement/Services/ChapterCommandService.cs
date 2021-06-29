using Entities;
using Entities.SecondaryEntity;
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
    public class ChapterCommandService : IChapterCommandService
    {
        private readonly IRepository repository;

        public ChapterCommandService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreateChapter(CreateChapterCommand command)
        {
            repository.Save<Chapter>(ResouceManagementMapper.CreateChapter(command));
            var subject = repository.GetItem<Subject>(x => x.ItemId == command.SubjectId);
            subject.SubjectChapters.Add(new SubjectChapter()
            {
                ChapterName = command.ChapterName,
                ChapterNumber = command.ChapterNumber,
                ItemId = command.ItemId
            });
            repository.Update<Subject>(x => x.ItemId == subject.ItemId,subject);
        }
    }
}
