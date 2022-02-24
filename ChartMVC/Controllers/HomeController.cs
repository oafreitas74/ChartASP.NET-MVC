using ChartMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChartMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index()
        {
            var model = new HIndexModel();

            var pieChartData = GetPieChartData();

            model.pieChartData = pieChartData;


            return View(model);
        }
        private PieChartModel GetPieChartData()
        {
            var model = new PieChartModel();

            var labels = new List<string>();
            labels.Add("Green");
            labels.Add("Blue");
            labels.Add("Gray");
            labels.Add("Red");
            labels.Add("Black");
            labels.Add("Violet");
            labels.Add("Pink");

            model.labels = labels;

            var datasets = new List<PieChartChildModel>();
            var chilModel = new PieChartChildModel();

            var backgroundColorList = new List<string>();
            var dataList = new List<int>();


            foreach (var item in labels)
            {
                if(item == "Green")
                {
                    backgroundColorList.Add("#2ecc71");
                    dataList.Add(12);
                }
                if (item == "Blue")
                {
                    backgroundColorList.Add("#3498db");
                    dataList.Add(20);
                }
                if (item == "Gray")
                {
                    backgroundColorList.Add("#95a5a6");
                    dataList.Add(18);
                }
                if (item == "Red")
                {
                    backgroundColorList.Add("#FF0000");
                    dataList.Add(50);
                }
                if (item == "Black")
                {
                    backgroundColorList.Add("#000000");
                    dataList.Add(20);
                }
                if (item == "Violet")
                {
                    backgroundColorList.Add("#EE82EE");
                    dataList.Add(18);
                }
                if (item == "Pink")
                {
                    backgroundColorList.Add("#FFC0CB");
                    dataList.Add(50);
                }

            }

            chilModel.backgroundColor = backgroundColorList;
            chilModel.data = dataList;
            datasets.Add(chilModel);
            model.datasets = datasets;

            return model;
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
