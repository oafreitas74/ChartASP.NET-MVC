using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartMVC.Models
{
    public class PieChartModel
    {
        public PieChartModel()
        {
            labels = new List<string>();
            datasets = new List<PieChartChildModel>();
        }
        public List<string> labels { get; set; }
        public List<PieChartChildModel> datasets { get; set; }

    }
        public class PieChartChildModel
        {
            public PieChartChildModel()
            {
                backgroundColor = new List<string>();
                data = new List<int>();
            }
            public List<string> backgroundColor { get; set; }
            public List<int> data { get; set; }
        }
        
}
