using System.Collections.Generic;
using webapiproject.Model;
using webapiproject.Repositories;

namespace webapiproject.Services
{
    public class CourseServices:ICourseServices
    {
       
            private readonly ICourseRepository _iCourseRepo;
            // Injecition of Dependancy using constructor
            public CourseServices(ICourseRepository iCourseRepo)
            {
                _iCourseRepo = iCourseRepo;
            }
            public int AddCourse(Course cour)
            {
                return _iCourseRepo.AddCourse(cour);
            }
            public int DeleteCourse(int id)
            {
                return _iCourseRepo.DeleteCourse(id);
            }
            public IEnumerable<Course> GetAllCourses()
            {
                return _iCourseRepo.GetAllCourses();
            }
            public int ModifyCourse(Course cour)
            {
                return _iCourseRepo.ModifyCourse(cour);
            }


        }
    }

