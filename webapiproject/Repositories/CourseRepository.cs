using System.Collections.Generic;
using System.Linq;
using webapiproject.Entities;
using webapiproject.Model;

namespace webapiproject.Repositories
{
    public class CourseRepository
    {
       
            RepositoriesContext context;
            public CourseRepository(RepositoriesContext context) //DI
            {
                this.context = context;
            }

            public int AddCourse(Course cour)
            {
                context.Courses.Add(cour);
                context.SaveChanges(); // update the data in DB
                return 1;
            }
            public int DeleteCourse(int id)
            {
                var cour = context.Courses.Where(c => c.Id == id).SingleOrDefault();
                if (cour != null)
                {
                    context.Courses.Remove(cour);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;



                }
            }

            public IEnumerable<Course> GetAllCourses()
            {
                return context.Courses.ToList();
            }

            public int ModifyCourse(Course cour)
            {
                var course = context.Courses.Where(c => c.Id == cour.Id).SingleOrDefault();
                if (course != null)
                {
                    course.Name = cour.Name;
                    course.Fees = cour.Fees;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;

                }
            }
        }
    }

