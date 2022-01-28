
using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExample
{
    // Build a collection of customers who are millionaires
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class MillyReport
        {
            // include bank, number of millionaire customers
            public string BankName
            {
                get; set;
            }
            public int MillionaireNum
            {
                get; set;
            }
        }

}



// LINQ Limit to criteria
// IEnumerable<int> onlyEvens = sampleNumbers.Where(number => number % 2 == 0);


// LINQ GroupBy
// List<SalesReportEntry> salesReport = (from kid in kids
//              //dealing with kids list
//                 group kid by kid.Neighborhood into neighborhoodGroup
//             //now dealing with neighborhoodGroup list
//                 select new SalesReportEntry {
//                     ReportNeighborhood = neighborhoodGroup.Key, 
//                     ReportTotalSales = neighborhoodGroup.Sum(kidObj => kidObj.Sales)
//                 }).OrderByDescending(sr => sr.ReportTotalSales).ToList();

//             foreach(SalesReportEntry entry in salesReport)
//             {
//                 Console.WriteLine($"{entry.ReportNeighborhood}, {entry.ReportTotalSales}");
//             }