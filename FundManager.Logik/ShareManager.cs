using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public class ShareManager : IShareManager
    {
        public void AddShare(string id, string portfolioId, int quantity, double itemPrice)
        {
            throw new NotImplementedException();
        }

        public void EditShare(string id, int quantity, double itemPrice)
        {
            throw new NotImplementedException();
        }

        public List<Model.Share> LoadShares(string portfolioId)
        {
            List<Model.Share> shareList = new List<Model.Share>();
            shareList.Add(new Model.Share()
            {
                Id = "ABC.UK",
                PortfolioId = portfolioId,
                Quantity = 2700,
                SharePrice = 4.04
            });
            shareList.Add(new Model.Share()
            {
                Id = "DEF.UK",
                PortfolioId = portfolioId,
                Quantity = 14100,
                SharePrice = 1.28
            });
            shareList.Add(new Model.Share()
            {
                Id = "HIJ.UK",
                PortfolioId = portfolioId,
                Quantity = 8800,
                SharePrice = 3.27
            });
            shareList.Add(new Model.Share()
            {
                Id = "KLM.UK",
                PortfolioId = portfolioId,
                Quantity = 900,
                SharePrice = 3.33
            });
            shareList.Add(new Model.Share()
            {
                Id = "NOP.UK",
                PortfolioId = portfolioId,
                Quantity = 0,
                SharePrice = 10.05
            });
            shareList.Add(new Model.Share()
            {
                Id = "QRS.UK",
                PortfolioId = portfolioId,
                Quantity = 5600,
                SharePrice = 3.75
            });
            shareList.Add(new Model.Share()
            {
                Id = "TUV.UK",
                PortfolioId = portfolioId,
                Quantity = 4700,
                SharePrice = 8.12
            });
            shareList.Add(new Model.Share()
            {
                Id = "WX.UK",
                PortfolioId = portfolioId,
                Quantity = 3500,
                SharePrice = 2.98
            });
            shareList.Add(new Model.Share()
            {
                Id = "YZ.UK",
                PortfolioId = portfolioId,
                Quantity = 1700,
                SharePrice = 9.76
            });

            return shareList;
        }

        public bool RemoveShare(string shareId)
        {
            throw new NotImplementedException();
        }
    }
}
