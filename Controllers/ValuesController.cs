using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly SinhVienContext _context;

        public ValuesController(SinhVienContext context)
        {
            _context = context;
        }

        [HttpGet("test")]
        public IActionResult test()
        {
            var query = _context.SinhViens
            .Join(
            _context.Lops,
                sv => sv.IdLop,
                lop => lop.Id,
            (sv, lop) => new
            {
                TenLop = lop.TenLop,
                TenSV = sv.HoTen
            }).ToList();
            return new OkObjectResult(query.ToList());
        }


        [HttpGet("Test2")]
        public IActionResult Test2()
        {
            string sql = "select * from sinhvien";
            DataTable dt = _context.ExcuteSqlDataTable(sql);
            string str = JsonConvert.SerializeObject(dt);
            return new OkObjectResult(str);
        }
    }
}
