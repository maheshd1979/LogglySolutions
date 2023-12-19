using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;

namespace LogglySolutions.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("Testing Microsoft Information");

            try
            {
                var a = 6;
                var b=0;
                var c = 6 / b;
                return new[] { "value1", "value2" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
         //  Log.Information("Log: Log.Information seri");
            //Log.Warning("Log: Log.Warning MD ");
            //Log.Error("Log: Log.Error Megha");
            //Log.Fatal("Log: Log.Fatal Divekar");

           
        }
    }
}
