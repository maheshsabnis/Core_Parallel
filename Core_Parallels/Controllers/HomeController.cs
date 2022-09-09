using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Core_Parallels.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    EmployeeList employees;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        employees = new EmployeeList();
    }

    public IActionResult Index()
    {
        DataViewModel dataView = new DataViewModel();
        var timerNonParallel = Stopwatch.StartNew();
        for (int i = 0; i < employees.Count; i++)
        {
            employees[i] = ProcessTax.CalculateTax(employees[i]);
            dataView.NonParallelEmployeesResult.Add(employees[i]);
        }
        
        dataView.NonParallelTotalDuration = timerNonParallel.Elapsed.TotalSeconds;
        
        var timerParallel = Stopwatch.StartNew();
        Parallel.For(0, employees.Count, (int i) => {
            employees[i] = ProcessTax.CalculateTax(employees[i]);
            int j = i;
            i++;
            dataView.ParallelEmployeesResult.Add(employees[j]);
        });
      
         
        dataView.ParallelTotalDuration = timerParallel.Elapsed.TotalSeconds;

        return View(dataView);
    }

     

     
}

