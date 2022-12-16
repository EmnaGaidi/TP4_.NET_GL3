using CompteRendu2TP4.Models;

namespace CompteRendu2TP4.Data
{
    public interface IStudentRepository:IRepository<Student>
    {
        IEnumerable<String> GetUniqueCourses();
        IEnumerable<Student> GetStudentsWithCourseX(String course);
    }
}
