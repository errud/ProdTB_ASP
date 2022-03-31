using ModelGlobal_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Repositories
{
    public interface IAppPIRepository
    {
        IEnumerable<PersonInfo> GetAll();
        PersonInfo GetById(int Id);
        string GetNameById(int Id);               
        bool Create(PersonInfo myinfo);
        bool Update(PersonInfo myinfo);
        bool Delete(int Id);
        

    }
}
