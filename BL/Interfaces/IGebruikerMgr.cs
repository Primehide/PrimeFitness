using Domain.Gebruiker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IGebruikerMgr
    {
        Gebruiker FindGebruikerOnId(int id);
        void UpdateGebruiker(Gebruiker gebruiker);
    }
}
