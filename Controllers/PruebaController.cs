﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoIntegrador.Controllers
{
    public class PruebaController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Pagina con otro controlador";
        }
    }
}
