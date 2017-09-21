using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public interface IPortfolioManager
    {
        Model.Portfolio Load(string fundManagerId);
    }
}
