using DAL;

namespace BL
{
    public class UitdagingMgr : Interfaces.IUitdagingMgr
    {
        private IUitdagingRepo repo;

        public UitdagingMgr()
        {
            repo = new UitdagingRepo();
        }
    }
}
