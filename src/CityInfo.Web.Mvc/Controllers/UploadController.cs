using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AspNetCore.Mvc.Controllers;
using CityInfo.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class UploadController : AbpController
    {
        private IHostingEnvironment _hostingEnvironment;
        private readonly Solution _context;

        public UploadController(Solution context,IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Uploader(Gallery gallery, IList<IFormFile> files)
        {
            foreach (IFormFile item in files)
            {
                string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
                filename = this.EnsureFileName(filename);
                using (FileStream filestream = System.IO.File.Create(this.Getpath(filename)))
                {
                   
                }
                using (var stream = new MemoryStream())
                {
                    await item.CopyToAsync(stream);
                    gallery.image = filename;
                    gallery.id_kategori = 1;
                    gallery.id_tempat = 1;
                }
            }

            _context.Gallery.Add(gallery);
            _context.SaveChanges();
            return this.Content("success");
        }

        private string Getpath(string filename)
        {
            //throw new NotImplementedException();
            string path = _hostingEnvironment.WebRootPath + "\\upload\\";
            if (!Directory.Exists(path))
          
                Directory.CreateDirectory(path);
                return path + filename;
       
        }

        private string EnsureFileName(string filename)
        {
            //throw new NotImplementedException();
            if (filename.Contains("\\"))
            
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;
        }
    }
}