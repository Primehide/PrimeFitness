using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Gebruiker;

namespace DAL
{
    public interface IGebruikerRepo
    {
        Gebruiker FindGebruikerOnId(int id);
        void UpdateGebruiker(Gebruiker gebruiker);
    }
}
