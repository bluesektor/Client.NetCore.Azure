using AutoMapper;
using GreenWerx.NetCore.Models.Store;
using GreenWerx.WebApplication.Data;
using GreenWerx.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenWerx.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var products = ProductContext.GetProducts();
            var pvm =  _mapper.Map<List<Product>, List<ProductViewModel>>(products);
            return View(pvm);
        }
    }
}
