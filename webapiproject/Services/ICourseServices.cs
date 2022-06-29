using System.Collections.Generic;
using webapiproject.Model;

namespace webapiproject.Services
{
    public interface ICourseServices
    {
        IEnumerable<Course> GetAllCourses();
        int AddCourse(Course cour);
        int ModifyCourse(Course cour);
        int DeleteCourse(int id);
    }
}
