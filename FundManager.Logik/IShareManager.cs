using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public interface IShareManager
    {
        List<Model.Share> LoadShares(string portfolioId);
        void AddShare(string id, string portfolioId, int quantity, double itemPrice);
        bool RemoveShare(string shareId);
        void EditShare(string id, int quantity, double itemPrice);
    }
}
