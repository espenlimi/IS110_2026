using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class StudentProgram : IHostedService
    {
        private readonly IStudentStorage studentStorage;
        private readonly ILogger<StudentProgram> logger;

        public StudentProgram(IStudentStorage studentStorage, ILogger<StudentProgram> logger)
        {
            this.studentStorage = studentStorage;
            this.logger = logger;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Vi starter!");
            studentStorage.AddStudent(new Student { Id = 1, Name = "Esp1" });
            studentStorage.AddStudent(new Student { Id = 2, Name = "Esp2" });
            studentStorage.AddStudent(new Student { Id = 3, Name = "Esp3" });
            studentStorage.AddStudent(new Student { Id = 4, Name = "Esp4" });
            studentStorage.AddStudent(new Student { Id = 5, Name = "Esp5" });

            var allStudents = studentStorage.GetStudents();
            foreach (var student in allStudents)
            {
                Console.WriteLine(student.Name);
            }

            logger.LogInformation("Vi er ferdig");
            
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
