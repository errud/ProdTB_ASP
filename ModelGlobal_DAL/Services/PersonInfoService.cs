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
    public class PersonInfoService : IAppPIRepository
    {
        private string _connectionString;

        private readonly IConfiguration _config;

        public PersonInfoService(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("default");
        }


        internal PersonInfo Converter(SqlDataReader reader)
        {
            return new PersonInfo
            {
                IdPers = (int)reader["IdPers"],
                LastName = reader["LastName"].ToString(),
                FirstName = reader["FirstName"].ToString(),
                Tel = reader["Tel"].ToString(),
                Email = reader["Email"].ToString(),
                Address = reader["Address"].ToString(),
                Nationality = reader["Nationality"].ToString(),
                Age = (int)reader["Age"],
                Strengths = reader["Strengths"].ToString(),
                Weaknesses = reader["Weaknesses"].ToString(),
                Objective = reader["Objective"].ToString(),
                Profile = reader["Profile"].ToString(),
                SocialMedia = reader["SocialMedia"].ToString(),
                InfoSup = reader["InfoSup"].ToString()

            };
        }

        public IEnumerable<PersonInfo> GetAll()
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM PersonInfo");

            return cnx.ExecuteReader(cmd, Converter);
        }


        public PersonInfo GetById(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM PersonInfo WHERE IdPers = @id");
            cmd.AddParameter("id", Id);

            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }


        public string GetNameById(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("SELECT [LastName] FROM PersonInfo WHERE IdPers = @Id");
            cmd.AddParameter("Id", Id);

            return cnx.ExecuteScalar(cmd).ToString() ?? "";
        }


        public bool Create(PersonInfo myinfo)
        {
            
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("AddPersonInfo", true);

            cmd.AddParameter("lastname", myinfo.LastName);
            cmd.AddParameter("firstname", myinfo.FirstName);
            cmd.AddParameter("tel", myinfo.Tel);
            cmd.AddParameter("email", myinfo.Email);
            cmd.AddParameter("address", myinfo.Address);
            cmd.AddParameter("age", myinfo.Age);
            cmd.AddParameter("nationality", myinfo.Nationality);
            cmd.AddParameter("strengths", myinfo.Strengths);
            cmd.AddParameter("weaknesses", myinfo.Weaknesses);
            cmd.AddParameter("objective", myinfo.Objective);
            cmd.AddParameter("profile", myinfo.Profile);
            cmd.AddParameter("socialmedia", myinfo.SocialMedia);
            cmd.AddParameter("infosup", myinfo.InfoSup);

            try
            {
                return cnx.ExecuteNonQuery(cmd) == 1;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool Update(PersonInfo myinfo)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("UpdatePersonInfo", true);

            cmd.AddParameter("lastname", myinfo.LastName);
            cmd.AddParameter("firstname", myinfo.FirstName);
            cmd.AddParameter("tel", myinfo.Tel);
            cmd.AddParameter("email", myinfo.Email);
            cmd.AddParameter("address", myinfo.Address);
            cmd.AddParameter("age", myinfo.Age);
            cmd.AddParameter("nationality", myinfo.Nationality);
            cmd.AddParameter("strengths", myinfo.Strengths);
            cmd.AddParameter("weaknesses", myinfo.Weaknesses);
            cmd.AddParameter("objective", myinfo.Objective);
            cmd.AddParameter("profile", myinfo.Profile);
            cmd.AddParameter("socialmedia", myinfo.SocialMedia);
            cmd.AddParameter("infosup", myinfo.InfoSup);
            cmd.AddParameter("idpers", myinfo.IdPers);

            return cnx.ExecuteNonQuery(cmd) == 1;

        }

        public bool Delete(int Id)
        {
            Connection cnx = new Connection(_connectionString);

            Command cmd = new Command("DeletePersonInfo", true);

            cmd.AddParameter("id", Id);

            return cnx.ExecuteNonQuery(cmd) == 1;

        }

    }
}
