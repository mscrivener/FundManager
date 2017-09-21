using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Model
{
    public class Share
    {
        public string Id { get; set; }
        public string PortfolioId { get; set; }
        public int Quantity { get; set; }
        public double SharePrice { get; set; }
    }
}
