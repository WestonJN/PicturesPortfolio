using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using Portfolio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFilePicturesService PictureService { get; }
        public IEnumerable<Picture> Pictures { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFilePicturesService pictureService)
        {
            _logger = logger;
            PictureService = pictureService;
        }

        public void OnGet()
        {
            Pictures = PictureService.GetPictures();
        }
    }
}
