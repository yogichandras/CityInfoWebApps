using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CityInfo.Controllers;
using Abp.AspNetCore.Mvc.Controllers;

namespace CityInfo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class DataController : AbpController
    {
        public DataController()
        {
            LocalizationSourceName = "MySourceName";
        }

        public ActionResult Index()
        {
            var helloWorldText = L("HelloWorld");

            return View();
        }
    }
}