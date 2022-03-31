using ModelGlobal_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Repositories
{
    public interface IAppCTRepository
    {
        IEnumerable<CompetenceTech> GetAll();
        CompetenceTech GetById(int Id);
        bool Create(CompetenceTech competence);
        bool Update(CompetenceTech competence);
        bool Delete(int Id);       
        IEnumerable<CompetenceTech> GetByPers(int Id);
    }
}
