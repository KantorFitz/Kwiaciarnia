using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Repository
    {
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
            var list = new List<Places>();
            return list;
        }
    }
}
