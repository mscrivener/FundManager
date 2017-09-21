using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public interface IBenchmarkIndexManager
    {
        List<Model.BenchmarkIndex> LoadBenchmarks(string portfolioId);
        void AddBenchmark(string shareId, string portfolioId, double weight);
        bool RemoveBenchmark(string shareId);
        void EditBenchmark(string id, double weight);
    }
}
