namespace DependencyInjection
{
    public interface IStudentStorage
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetStudents();
        void RemoveStudent(Student student);
    }
}