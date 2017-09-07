using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{    
    public class New_ApiController : ApiController
    { int i = 5;
        [HttpPost][Route("den")]
        public int Display()
        {
            return 2;
        }
        [HttpGet]
        public string MyName(string str)
        {
            //str = "athira";
            return str;
        }
       [HttpPut][Route("ping")]
       public int change(int i)
        {
            i = 3;
            return i;
        }
        [HttpDelete]
        [Route("pop")]
        public string Pop(int i)
        {
           
            return "hello";
        }
    }
}
