using System.Collections.Generic;
using webapiproject.Model;

namespace webapiproject.Services
{
    public interface IEmployeServices
    {
        IEnumerable<Employe> GetAllEmployes();
        int AddEmploye(Employe emp);
        int ModifyEmploye(Employe emp);
        int DeleteEmploye(int id);
    }
}
