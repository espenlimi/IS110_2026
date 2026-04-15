using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.UnitTests
{
    public class StudentProgramUnitTests
    {
        private Mock<IStudentStorage> _studentStorageMock;
        private Mock<ILogger<StudentProgram>> _loggerMock;
        [Fact]
        public void StartAsync_AddsCorrectNumberOfStudents()
        {
            //Arrange
            var unitUnderTest = GetUnitUnderTest();

            //Act
            unitUnderTest.StartAsync(CancellationToken.None).GetAwaiter().GetResult();

            //Assert
            _studentStorageMock.Verify(x => x.AddStudent(It.IsAny<Student>()), Times.Exactly(5));
        }
        [Fact]
        public void StartAsync_LogsCorrectAmountOfTimes()
        {
            //Arrange
            var unitUnderTest = GetUnitUnderTest();

            //Act
            unitUnderTest.StartAsync(CancellationToken.None).GetAwaiter().GetResult();

            //Assert
            // logger.LogInformation(..) er en statisk extension, så vi må fange kall på en annen måte
            _loggerMock.Verify(
                x => x.Log(
                    LogLevel.Information,
                    It.IsAny<EventId>(),
                    It.IsAny<It.IsAnyType>(),
                    It.IsAny<Exception>(),
                    It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
                Times.Exactly(2));
        }
        [Fact]
        public void StartAsync_CallsGetStudents()
        {
            //Arrange
            var unitUnderTest = GetUnitUnderTest();
            _studentStorageMock.Setup(x=>x.GetStudents()).Returns(new List<Student>());
            //Act
            unitUnderTest.StartAsync(CancellationToken.None).GetAwaiter().GetResult();

            //Assert
            _studentStorageMock.Verify(x => x.GetStudents(), Times.Exactly(1));
        }
        private StudentProgram GetUnitUnderTest()
        {
            _loggerMock = new Mock<ILogger<StudentProgram>>();
            _studentStorageMock = new Mock<IStudentStorage>();
            return new StudentProgram(_studentStorageMock.Object, _loggerMock.Object);
        }
    }
}
