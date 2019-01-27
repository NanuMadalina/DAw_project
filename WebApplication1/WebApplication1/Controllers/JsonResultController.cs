using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    
    [ApiController]
    public class JsonResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JsonResultController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        [Route("api/Investigations")]
        [HttpGet]
        public JsonResult Get()
        {
            var entity = _context.MedicalInvestigations.ToList();
            return new JsonResult(entity);
        }


        [Route("api/Doctors")]
        [HttpGet]
        public JsonResult Get1()
        {
            var entity = _context.Doctors.ToList();
            return new JsonResult(entity);
        }



        [Route("api/Departments")]
        [HttpGet]
        public JsonResult Get3()
        {
            var entity = _context.Departments.ToList();
            return new JsonResult(entity);
        }


    }


}