using Intro.DataAccess.Abstract;
using Intro.DataAccess.Concrete;
using Intro.Entities;

namespace Intro.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {           
            return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
    }
}
