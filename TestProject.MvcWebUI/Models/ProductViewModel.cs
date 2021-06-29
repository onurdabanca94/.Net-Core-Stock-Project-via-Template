using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestProject.Entity.ComplexTypes;
using TestProject.Entity.Concrete;

namespace TestProject.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductCategoryComplexData> Products { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<IFormFile> FormFiles { get; set; }

    }
}
