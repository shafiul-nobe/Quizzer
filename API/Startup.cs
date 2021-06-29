using Infrastructure.Contracts;
using Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ResourceManagement.Services;
using ResourceManagement.Contracts;
using Quizzer.Queries.Contracts;
using Quizzer.Queries.Services;
using FluentValidation.AspNetCore;
using ResourceManagement.Commands;
using Quizzer.Queries.Queries.Question;
using API.MiddleWares;
using ModelTest.Contracts;
using ModelTest.Services;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddFluentValidation(config =>
            {
                config.RegisterValidatorsFromAssemblyContaining<CreateQuestionCommand>();
                config.RegisterValidatorsFromAssemblyContaining<QuestionByIdQuery>();
            });
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSingleton<IRepository, Repository>();
            services.AddSingleton<IQuestionQueryService, QuestionQueryService>();
            services.AddSingleton<ISubjectQueryService, SubjectQueryService>();
            services.AddSingleton<IQuestionCommandService, QuestionCommandService>();
            services.AddSingleton<IClassCommandService, ClassCommandService>();
            services.AddSingleton<ISubjectCommandService, SubjectCommandService>();
            services.AddSingleton<IChapterCommandService, ChapterCommandService>();
            services.AddSingleton<IPackageCommandService, PackageCommandService>();
            services.AddSingleton<IModelTestCommandService, ModelTestCommandService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
