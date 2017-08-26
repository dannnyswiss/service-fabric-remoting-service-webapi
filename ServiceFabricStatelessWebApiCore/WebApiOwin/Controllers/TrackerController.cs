using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiOwin.Controllers
{
    public class TrackerController : ApiController
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Welcome to Sheepishly 1.0.0 - The Combleat Sheep Tracking Suite";
        }

        [HttpPost]
        [Route("oppBool")]
        public bool Log(bool myBool)
        {
            return myBool ? false : true;
        }

        [HttpGet]
        [Route("returnString/{stringMine}/greatTime")]
        public async Task<string> MyString(string stringMine)
        {
            return await Task.FromResult(stringMine);
        }

        [HttpGet]
        [Route("cat/{cat}/nevergoesaway")]
        public async Task<object> CatReturn(object cat)
        {
            return await Task.FromResult(cat);
        }
    }
}
