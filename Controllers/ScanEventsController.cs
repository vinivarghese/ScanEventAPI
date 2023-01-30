using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScanEventAPI.Models;

namespace ScanEventAPI.Controllers
{
    [Route("v1/scans")]
    [ApiController]
    public class ScanEventsController : ControllerBase
    {
        private readonly ScanEventContext _context;
        private readonly ILogger<ScanEventsController> _logger;

        public ScanEventsController(ScanEventContext context, ILogger<ScanEventsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("scanEvents")]
        public IActionResult GetScanEvents(int FromEventId = 1, int Limit = 100)
        {
            if (_context.ScanEventItems == null)
            {
                _logger.LogInformation("No data found");
                return NotFound();
            }

            var scanEventItems = _context.ScanEventItems.Where(x => x.EventId >= FromEventId).Take(Limit);

            if (scanEventItems.Count() == 0)
            {
                _logger.LogInformation("No data found for the selected query parameters");
                return NotFound();
            }

            _logger.LogInformation("Data retrieved successfully");
            return new OkObjectResult(scanEventItems);
        }
    }
}