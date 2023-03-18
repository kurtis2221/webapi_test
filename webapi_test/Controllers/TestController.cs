using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace webapi_test.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            HttpResponseMessage resp = Request.CreateResponse();
            string tmp = null;
            foreach(string s in Request.RequestUri.Segments)
            {
                tmp += s + "\n";
            }
            resp.Content = new StringContent("URL: " + Request.RequestUri + "\n" + tmp);
            resp.StatusCode = HttpStatusCode.OK;
            return resp;
        }
    }
}