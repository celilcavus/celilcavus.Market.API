using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celilcavus.Market.Model.Interfaces
{
    public interface Images
    {
        string ImageUpload(IFormFile formFile,ConstLocation constLocation);
        int DeleteImage(string ImageName, ConstLocation imageLocation);
    }
}
