using ModelGlobal_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Repositories
{
    public interface IAppEXRepository
    {
        IEnumerable<Experience> GetAll();
        Experience GetById(int Id);
        bool Create(Experience expp);
        bool Update(Experience expp);
        bool Delete(int Id);
        IEnumerable<Experience> GetByPers(int Id);
    }
}

