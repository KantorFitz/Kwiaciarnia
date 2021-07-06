using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Repository
    {
        public string _connectionString = @"Server=THESHADOWMOSES\SQLEXPRESS;Database=Kwiaciarnia;Trusted_Connection=True;";

        public bool AddFlower(Flowers flower)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<Places> GetPlaces()
        {
            string sql = "SELECT * FROM Places";

            using (var connection = new SqlConnection(_connectionString))
            {
                var list = connection.Query<Places>(sql).ToList();
                return list;
            }
            
        }

        public List<Requirements> GetRequirements()
        {
            string sql = "SELECT * FROM Requirements";

            using (var connection = new SqlConnection(_connectionString))
            {
                var list = connection.Query<Requirements>(sql).ToList();
                return list;
            }
        }

        public List<Sorts> GetSorts()
        {
            string sql = "SELECT * FROM Sorts";

            using (var connection = new SqlConnection(_connectionString))
            {
                var list = connection.Query<Sorts>(sql).ToList();
                return list;
            }
        }

        public List<Species> GetSpecies()
        {
            string sql = "SELECT * FROM Species";

            using (var connection = new SqlConnection(_connectionString))
            {
                var list = connection.Query<Species>(sql).ToList();
                return list;
            }
        }

        public List<Traits> GetTraits()
        {
            string sql = "SELECT * FROM Traits";

            using (var connection = new SqlConnection(_connectionString))
            {
                var list = connection.Query<Traits>(sql).ToList();
                return list;
            }
        }
    }
}
