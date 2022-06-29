using System.Collections.Generic;
using webapiproject.Model;
using webapiproject.Repositories;

namespace webapiproject.Services
{
    public class EmployeServices:IEmployeServices
    {
       

            private readonly IEmployeRepository _iEmployeRepo;
            // Injecition of Dependancy using constructor
            public EmployeServices(IEmployeRepository iEmployeRepo)
            {
                _iEmployeRepo = iEmployeRepo;
            }
            public int AddEmploye(Employe emp)
            {
                return _iEmployeRepo.AddEmploye(emp);
            }
            public int DeleteEmploye(int id)
            {
                return _iEmployeRepo.DeleteEmploye(id);
            }
            public IEnumerable<Employe> GetAllEmployes()
            {
                return _iEmployeRepo.GetAllEmployes();
            }
            public int ModifyEmploye(Employe emp)
            {
                return _iEmployeRepo.ModifyEmploye(emp);
            }


        }
    }

