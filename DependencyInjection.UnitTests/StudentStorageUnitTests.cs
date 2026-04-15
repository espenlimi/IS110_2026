
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.UnitTests
{
    public class StudentStorageUnitTests
    {
        [Fact]
        public void AddStudent_AddsOnlyOneStudent()
        {
            //Arrange
            var student = new Student { Id = 7, Name = "Kaptein Sabeltann" };

            var unitUnderTest= SetupForAddTests(student);

            //Assert
            var expectedResult = 1;
            Assert.Equal(expectedResult, unitUnderTest.GetStudents().Count());
        }

        [Fact]
        public void AddStudent_AddsStudentWithCorrectId()
        {
            //Arrange
            var student = new Student { Id = 7, Name = "Kaptein Sabeltann" };

            var unitUnderTest = SetupForAddTests(student);

            //Assert
           Assert.Equal(student.Id, unitUnderTest.GetStudents().First().Id);
        }
        [Fact]
        public void AddStudent_AddsStudentWithCorrectName()
        {
            //Arrange
            var student = new Student { Id = 7, Name = "Kaptein Sabeltann" };

            var unitUnderTest = SetupForAddTests(student);

            //Assert
            Assert.Equal(student.Name, unitUnderTest.GetStudents().First().Name);
        }
        private static StudentStorage SetupForAddTests(Student student)
        {

            //Act
            var unitUnderTest = new StudentStorage(); ;
            unitUnderTest.AddStudent(student);
            return unitUnderTest;
        }
    }
}
