using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Core.Entities;

namespace TestProject.Entity.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
