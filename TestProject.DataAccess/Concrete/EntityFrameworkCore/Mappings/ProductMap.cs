using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProject.Entity.Concrete;

namespace TestProject.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Products", @"dbo");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.AddedBy).HasColumnName("AddedBy");
            builder.Property(d => d.AddedDate).HasColumnName("AddedDate");
            builder.Property(d => d.CategoryId).HasColumnName("CategoryId");
            builder.Property(d => d.Explanation).HasColumnName("Explanation");
            builder.Property(d => d.Height).HasColumnName("Height");
            builder.Property(d => d.Name).HasColumnName("Name");
            builder.Property(d => d.Weight).HasColumnName("Weight");
            builder.Property(d => d.Width).HasColumnName("Width");
        }
    }
}
