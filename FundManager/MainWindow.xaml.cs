using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FundManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string portfolioId = "ABC";

            Logik.PortfolioFundManager manager = new Logik.PortfolioFundManager(new Logik.PortfolioManager(), new Logik.ShareManager(), new Logik.BenchmarkIndexManager());
            manager.Load(portfolioId);

            PortfolioId.Content = portfolioId;
            PortfolioCash.Content = manager.GetPortfolioCashPennies();
            PortfolioTotal.Content = manager.GetTotalPortfolioValue();
            PortfolioGrid.DataContext = manager.PresentationList;
        }
    }
}
