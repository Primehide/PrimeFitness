using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GebruikerRepo : IGebruikerRepo
    {
        private EF.FitnessContext ctx;

        public GebruikerRepo()
        {
            ctx = new EF.FitnessContext();
        }
    }
}
