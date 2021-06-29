using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Core.Entities;

namespace TestProject.Entity.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Width { get; set; }
        public string Explanation { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
