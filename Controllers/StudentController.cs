using CompteRendu2TP4.Data;
using CompteRendu2TP4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompteRendu2TP4.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            UniversityContext universityContext = UniversityContext.Instance;
            List<Student> s = universityContext.Student.ToList();
            return View(s);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UniqueCourses() {
            UniversityContext universityContext = UniversityContext.Instance;
            IStudentRepository studentRep = new StudentRepository(universityContext);
            return View(studentRep.GetUniqueCourses());
        }

        [HttpGet]
        [Route("/StudentByCourse/{course}")]
        public ActionResult GetStudentByCourse(string course) {
            UniversityContext universityContext = UniversityContext.Instance;
            IStudentRepository studentRep = new StudentRepository(universityContext);
            return View(studentRep.GetStudentsWithCourseX(course));
        }
    }
}
