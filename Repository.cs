using System;
using System.Collections.Generic;
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
                var list = new List<Places>();
                return list;
            }
            
        }

        public List<Requirements> GetRequirements()
        {
            var list = new List<Requirements>();
            return list;
        }

        public List<Sorts> GetSorts()
        {
            var list = new List<Sorts>();
            return list;
        }

        public List<Species> GetSpecies()
        {
            var list = new List<Species>();
            return list;
        }

        public List<Traits> GetTraits()
        {
            var list = new List<Traits>();
            return list;
        }
    }
}
