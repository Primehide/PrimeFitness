using DAL;
using Domain.Gebruiker;

namespace BL
{
    public class GebruikerMgr : Interfaces.IGebruikerMgr
    {
        private IGebruikerRepo repo;

        public GebruikerMgr()
        {
            repo = new GebruikerRepo();
        }

        public Gebruiker FindGebruikerOnId(int id)
        {
            return repo.FindGebruikerOnId(id);
        }

        public void UpdateGebruiker(Gebruiker gebruiker)
        {
            repo.UpdateGebruiker(gebruiker);
        }
    }
}
