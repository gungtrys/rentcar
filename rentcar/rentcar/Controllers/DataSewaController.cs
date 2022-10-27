﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using rentcar.Data;

namespace rentcar.Controllers;

[Authorize(Roles = "Admin")]
public class DataSewaController : Controller
{
    private readonly ApplicationDbContext _db;
    private readonly ILogger<DataSewaController> _logger;

    public DataSewaController(ApplicationDbContext db, ILogger<DataSewaController> logger)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }
}
