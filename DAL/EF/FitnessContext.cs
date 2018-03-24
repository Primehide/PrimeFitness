using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class FitnessContext : DbContext
    {
        public FitnessContext()
            : base("debugConn")
        {
            Database.SetInitializer<FitnessContext>(new FitnessInitialiser());
        }
    }
}
