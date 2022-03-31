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
    public class ExperienceService : IAppEXRepository
    {
        private string _connectionString;

        private readonly IConfiguration _config;

        public ExperienceService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");

        }

        internal Experience Converter(SqlDataReader reader)
        {
            return new Experience
            {
                IdExp = (int)reader["IdExp"],
                Company = reader["Company"].ToString(),
                Position = reader["Position"].ToString(),
                Description = reader["Description"].ToString(),
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                City = reader["City"].ToString(),
                Country = reader["Country"].ToString(),               
                IdPers = (int)reader["IdPers"]
            };
        }


        public IEnumerable<Experience> GetAll()
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM Experience");

            return cnx.ExecuteReader(cmd, Converter);
        }

        public IEnumerable<Experience> GetByPers(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM Experience WHERE IdPers = @Id");
            cmd.AddParameter("Id", Id);

            return cnx.ExecuteReader(cmd, Converter);
        }


        public Experience GetById(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM Experience WHERE IdExp = @Id");
            cmd.AddParameter("Id", Id);

            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }


        public bool Create(Experience expp)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("AjouterExperience", true);

            cmd.AddParameter("company", expp.Company);
            cmd.AddParameter("position", expp.Position);
            cmd.AddParameter("descr", expp.Description);
            cmd.AddParameter("stadt", expp.StartDate);
            cmd.AddParameter("enddt", expp.EndDate);
            cmd.AddParameter("city", expp.City);
            cmd.AddParameter("country", expp.Country);
            cmd.AddParameter("idpers", expp.IdPers);

            try
            {
                return cnx.ExecuteNonQuery(cmd) == 1;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(Experience expp)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("UpdateExperience", true);

            cmd.AddParameter("company", expp.Company);
            cmd.AddParameter("position", expp.Position);
            cmd.AddParameter("descr", expp.Description);
            cmd.AddParameter("stadt", expp.StartDate);
            cmd.AddParameter("enddt", expp.EndDate);
            cmd.AddParameter("city", expp.City);
            cmd.AddParameter("country", expp.Country);
            cmd.AddParameter("idpers", expp.IdPers);
            cmd.AddParameter("idexp", expp.IdExp);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }

        public bool Delete(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("DeleteExperience", true);

            cmd.AddParameter("id", Id);

            return cnx.ExecuteNonQuery(cmd) == 1;
        }

      


   
    }
}
