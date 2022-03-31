using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGlobal_DAL.Models;

namespace ModelGlobal_DAL.Repositories
{
    public interface IAppSTRepository
    {
        bool Create(string name);
        IEnumerable<Status> GetAll();
        string GetNameById(int Id);
    }
}
