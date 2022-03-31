using AdoToolbox;
using Microsoft.Extensions.Configuration;
using ModelGlobal_DAL.Models;
using ModelGlobal_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal_DAL.Services
{
    public class CompetenceService : IAppCTRepository
    {
        private string _connectionString;

        private readonly IConfiguration _config;

        public CompetenceService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }

        internal CompetenceTech Converter(SqlDataReader reader)
        {
            return new CompetenceTech
            {
                IdSk = (int)reader["IdSk"],
                SkillTyp = reader["SkillTyp"].ToString(),
                SkillName = reader["SkillName"].ToString(),
                SkillYear = (DateTime)reader["SkillYear"],
                SkillLevel = reader["SkillLevel"].ToString(),
                StatusId = (int)reader["StatusId"],
                IdPers = (int)reader["IdPers"]
            };
        }

        public IEnumerable<CompetenceTech> GetAll()
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM ITSkills");

            return cnx.ExecuteReader(cmd, Converter);
        }

        public IEnumerable<CompetenceTech> GetByPers(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM ITSkills WHERE IdPers = @Id");
            cmd.AddParameter("Id", Id);

            return cnx.ExecuteReader(cmd, Converter);
        }

        public CompetenceTech GetById(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM ITSkills WHERE IdSk = @id");
            cmd.AddParameter("id", Id);

            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public bool Create(CompetenceTech competence)
        {

            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("AddCompetenceTech", true);

            cmd.AddParameter("skillTyp", competence.SkillTyp);
            cmd.AddParameter("skillName", competence.SkillName);
            cmd.AddParameter("skillLevel", competence.SkillLevel);
            cmd.AddParameter("skillYear", competence.SkillYear);
            cmd.AddParameter("idPers", competence.IdPers);
            cmd.AddParameter("statusId", competence.StatusId);

            try
            {
                return cnx.ExecuteNonQuery(cmd) == 1;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(CompetenceTech competence)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("UpdateCompetenceTech", true);

            cmd.AddParameter("skillTyp", competence.SkillTyp);
            cmd.AddParameter("skillName", competence.SkillName);
            cmd.AddParameter("skillLevel", competence.SkillLevel);
            cmd.AddParameter("skillYear", competence.SkillYear);
            cmd.AddParameter("idSk", competence.IdSk);
            cmd.AddParameter("idPers", competence.IdPers);
            cmd.AddParameter("statusId", competence.StatusId);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("DeleteCompetenceTech", true);

            cmd.AddParameter("id", Id);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }        
                
    }
}
