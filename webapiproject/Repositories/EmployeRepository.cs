using System.Collections.Generic;
using System.Linq;
using webapiproject.Entities;
using webapiproject.Model;

namespace webapiproject.Repositories
{
    public class EmployeRepository
    {
       

            RepositoriesContext context;
            public EmployeRepository(RepositoriesContext context) //DI
            {
                this.context = context;
            }

            public int AddEmploye(Employe emp)
            {
                context.Employes.Add(emp);
                context.SaveChanges(); // update the data in DB
                return 1;
            }
            public int DeleteEmploye(int id)
            {
                var emp = context.Employes.Where(e => e.Id == id).SingleOrDefault();
                if (emp != null)
                {
                    context.Employes.Remove(emp);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;



                }
            }

            public IEnumerable<Employe> GetAllEmployes()
            {
                return context.Employes.ToList();
            }

            public int ModifyEmploye(Employe emp)
            {
                var employe = context.Employes.Where(e => e.Id == emp.Id).SingleOrDefault();
                if (employe != null)
                {
                    employe.Name = emp.Name;
                    employe.Salary = emp.Salary;
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

