using DAL;

namespace BL
{
    public class GebruikerMgr : Interfaces.IGebruikerMgr
    {
        private IGebruikerRepo repo;

        public GebruikerMgr()
        {
            repo = new GebruikerRepo();
        }
    }
}
