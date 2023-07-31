using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalysisProblem
{
    public class Program
    {
        public static string path = @"C:\NewBatch288\RFP288-IndianStatesCensusAnalyser_Repo\IndianStatesCensusAnalysisProblem\Files\StateCensusData.csv";
        static void Main(string[] args)
        {
            StateCensusAnalyser stateCensusAnalyser= new StateCensusAnalyser();
            stateCensusAnalyser.ReadStateCensusData(path);
        }
    }
}
