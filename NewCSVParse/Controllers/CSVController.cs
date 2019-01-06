using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewCSVParse.Services;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace NewCSVParse.Controllers
{
    //rrr
    // [Route("api/[controller]")]
    public class CSVController : Controller
    {
        private IParse parsing;
        public CSVController(IParse parsing)
        {
            this.parsing = parsing;
        }

        // POST: CSV/Create
        [HttpPost]
        public ActionResult Create()
        {
            try
            {

                IFormFile file = Request.Form.Files.Single();

                List<string[]> list = parsing.Parse(file);
                string JSONresult = JsonConvert.SerializeObject(list);

                return Ok(JSONresult);
            }
            catch
            {
                return BadRequest();
            }
        }




    }
}