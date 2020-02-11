using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/jess")]
    public class JessController : ControllerBase
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Jessie", "Furigay" };
        }

    }
}