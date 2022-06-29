using System.Collections.Generic;
using webapiproject.Model;

namespace webapiproject.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        int AddCourse(Course cour);
        int ModifyCourse(Course cour);
        int DeleteCourse(int id);

    }
}
