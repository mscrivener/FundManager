using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public class BenchmarkIndexManager : IBenchmarkIndexManager
    {

        public void AddBenchmark(string shareId, string portfolioId, double weight)
        {
            throw new NotImplementedException();
        }

        public void EditBenchmark(string id, double weight)
        {
            throw new NotImplementedException();
        }

        public List<Model.BenchmarkIndex> LoadBenchmarks(string portfolioId)
        {
            List<Model.BenchmarkIndex> benchmarkList = new List<Model.BenchmarkIndex>();

            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "ABC.UK",
                Weight = 7
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "DEF.UK",
                Weight = 12
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "HIJ.UK",
                Weight = 19
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "KLM.UK",
                Weight = 2
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "NOP.UK",
                Weight = 2
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "QRS.UK",
                Weight = 14
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "TUV.UK",
                Weight = 26
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "WX.UK",
                Weight = 7
            });
            benchmarkList.Add(new Model.BenchmarkIndex()
            {
                ShareId = "YZ.UK",
                Weight = 11
            });

            return benchmarkList;
        }

        public bool RemoveBenchmark(string shareId)
        {
            throw new NotImplementedException();
        }
    }
}
