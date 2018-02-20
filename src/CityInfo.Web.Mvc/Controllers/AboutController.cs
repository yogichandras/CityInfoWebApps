using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CityInfo.Controllers;

namespace CityInfo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : CityInfoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
