using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Repository
    {
        public string _connectionString = @"Server=THESHADOWMOSES\SQLEXPRESS;Database=Kwiaciarnia;Trusted_Connection=True;";

        /// <summary>
        /// Metoda dodaje rekord do bazy
        /// </summary>
        /// <param name="flower">
        /// Obiekt będący nośnikiem rekordu
        /// </param>
        /// <returns></returns>
        public bool AddFlower(Flowers flower)
        {
            try
            {
                using (var db = new SqlConnection(_connectionString))
                {
                    string insertQuery = "INSERT INTO Flowers(Name, SpeciesId, PlaceId, SortId, TraitId, RequirementsId) " +
                                            @"VALUES(@Name, @SpecieId, @PlaceId, @SortId, @TraitId, @RequirementId)";

                    db.Execute(insertQuery, new
                    {
                        flower.Name,
                        flower.SpecieId,
                        flower.PlaceId,
                        flower.SortId,
                        flower.TraitId,
                        flower.RequirementId
                    });
                    return true;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool EditFlower(Flowers flower)
        {
            try
            {
                using (var db = new SqlConnection(_connectionString))
                {
                    string insertQuery = "UPDATE Flower SET Name = @Name, SpeciesId = @SpecieId, PlaceId = @PlaceId, SortId = @SortId, TraitId = @TraitId, RequirementId = @RequirementId WHERE Id = @FlowerId";

                    db.Execute(insertQuery, new
                    {
                        flower.Name,
                        flower.SpecieId,
                        flower.PlaceId,
                        flower.SortId,
                        flower.TraitId,
                        flower.RequirementId,
                        flower.FlowerId
                    });
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
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
