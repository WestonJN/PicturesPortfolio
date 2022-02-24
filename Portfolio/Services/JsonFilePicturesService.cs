using Microsoft.AspNetCore.Hosting;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class JsonFilePicturesService
    {
        public JsonFilePicturesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "pictures.json"); }
        }

        public IEnumerable<Picture> GetPictures()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName)) 
            {
                return JsonSerializer.Deserialize<Picture[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive =true
                    });
            }
        }
    }
}
