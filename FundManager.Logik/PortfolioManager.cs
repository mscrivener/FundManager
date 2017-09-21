using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public class PortfolioManager : IPortfolioManager
    {
        public Model.Portfolio Load(string fundManagerId)
        {
            Model.Portfolio portfolio = new Model.Portfolio()
            {
                Id = "ABC",
                CashPennies = 308500
            };

            return portfolio;
        }
    }
}
