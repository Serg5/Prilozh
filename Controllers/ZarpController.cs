using System;
using System.Collections.Generic;  
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prj.Entities;
using Prj.Repositories;

namespace Prj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZarpController : ControllerBase
    {
        private readonly ILogger<ZarpController> _logger;

        private readonly IZarpRepository _zarp;

        public ZarpController(ILogger<ZarpController> logger, IZarpRepository zarp)
        {
            _logger = logger;
            _zarp = zarp;
        }

        [HttpGet]
        public IEnumerable<MinZar> GetAllZarps()
        {
            return _zarp.GetAllZarps();
            
        }  
        } 
    }

