using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UitdagingRepo : IUitdagingRepo
    {
        private EF.FitnessContext ctx;

        public UitdagingRepo()
        {
            ctx = new EF.FitnessContext();
        }
    }
}
