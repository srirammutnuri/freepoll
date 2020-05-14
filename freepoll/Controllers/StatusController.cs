﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using freepoll.Models;
using Microsoft.AspNetCore.Mvc;

namespace freepoll.Controllers
{
    [Route("api/status")]
    public class StatusController : Controller
    {
        private readonly FreePollDBContext _dBContext;

        public StatusController(FreePollDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        [HttpGet]
        public List<Status> GetStatus()
        {
            return _dBContext.Status.ToList();
        }
    }
}