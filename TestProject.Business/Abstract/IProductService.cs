using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Entity.ComplexTypes;
using TestProject.Entity.Concrete;

namespace TestProject.Business.Abstract
{
    public interface IProductService
    {
        Product Add(Product product);
        Task<Product> AddAsync(Product product);
        Product Update(Product product);
        Task<Product> UpdateAsync(Product product);
        void Delete(Product product);
        Product GetById(int id);
        Product GetByName(string name);
        List<Product> GetList();
        List<Product> GetListByCategoryId(int categoryId);
        List<ProductCategoryComplexData> GetProductWithCategory();
    }
}
