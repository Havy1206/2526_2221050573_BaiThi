using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using _2526_2221050573_BaiThi.Data; 
using _2526_2221050573_BaiThi.Models.Entities; 
using _2526_2221050573_BaiThi.Models; 
using _2526_2221050573_BaiThi.ViewModels; 
using Microsoft.EntityFrameworkCore;

namespace _2526_2221050573_BaiThi.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SinhVienController(ApplicationDbContext context)
        {
            _context = context;
        }

    
        public IActionResult Index()
        {
            return View();
        }

    }
    }