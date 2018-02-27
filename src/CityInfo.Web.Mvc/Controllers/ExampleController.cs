using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class ExampleController : AbpController
    {
        public IActionResult Index()
        {
            return View();
        }
           [HttpPost]
            public async Task<IActionResult> Upload(IFormFile file)
            {
                var uploads = Path.Combine("images");
                if (file.Length > 0)
                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                        await file.CopyToAsync(fileStream);

                return RedirectToAction("Index");
            }
        
    }
}