using System;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EnvatoMarket.Business.Services
{
	public class FileService:IFileService
	{
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileService(IWebHostEnvironment webHostEnvironment)
		{
            _webHostEnvironment = webHostEnvironment;
		}

        public string CreateImage(IFormFile file)
        {
            string fileName = Guid.NewGuid().ToString()+".jpeg";
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images", fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }

        public void DeleteImage(string fileName)
        {
            if (System.IO.File.Exists(Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images", fileName)))
            {
                System.IO.File.Delete(Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images", fileName));
            }
            
        }

        public bool IsImage(IFormFile file)
        {
            return file.ContentType.Contains("image") ? true : false;
        }

        public bool IsLengthSuit(IFormFile file, int value)
        {
            return file.Length / 1024 < value;
        }
    }
}

