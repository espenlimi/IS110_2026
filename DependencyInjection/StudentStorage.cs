using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class StudentStorage : IStudentStorage
    {
        private List<Student> students = [];
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public IEnumerable<Student> GetStudents()
        {
            return students.AsEnumerable();
        }
    }
}
