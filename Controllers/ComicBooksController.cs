using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
     class ComicBookGallery  : Controller
    {
        public string Detail()
        {
            return "Hello from de comic book controller";
        }
    }
}