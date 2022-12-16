using CompteRendu2TP4.Models;

namespace CompteRendu2TP4.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly UniversityContext universityContext;


        public StudentRepository(UniversityContext context) : base(context)
        {
            this.universityContext = context;
        }

        public IEnumerable<Student> GetStudentsWithCourseX(string course)
        {
            return universityContext.Student.Where(s=> s.course== course).ToList();
        }

        public IEnumerable<string> GetUniqueCourses()
        {
            return universityContext.Student.Select(s => s.course).Distinct().ToList();
        }
    }
}
