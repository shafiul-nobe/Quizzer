using Entities;
using Infrastructure.Contracts;
using ModelTest.Builders;
using ModelTest.Commands;
using ModelTest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTest.Services
{
    public class PackageCommandService : IPackageCommandService
    {
        private readonly IRepository repository;

        public PackageCommandService(IRepository repository)
        {
            this.repository = repository;
        }
        public void CreatePackage(CreatePackageCommand command)
        {
            repository.Save<Package>(ModelTestMapper.CreatePackage(command));
        }
    }
}
