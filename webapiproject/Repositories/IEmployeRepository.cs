using System.Collections.Generic;
using webapiproject.Model;

namespace webapiproject.Repositories
{
    public interface IEmployeRepository
    {
        IEnumerable<Employe> GetAllEmployes();
        int AddEmploye(Employe emp);
        int ModifyEmploye(Employe emp);
        int DeleteEmploye(int id);

    }
}
