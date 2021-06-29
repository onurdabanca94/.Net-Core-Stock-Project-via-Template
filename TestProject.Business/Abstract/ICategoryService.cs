using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Entity.Concrete;

namespace TestProject.Business.Abstract
{
    public interface ICategoryService
    {
        Category Add(Category category);
        Task<Category> AddAsync(Category category);
        Category Update(Category category);
        Task<Category> UpdateAsync(Category category);
        void Delete(Category category);
        Category GetById(int id);
        List<Category> GetList();
    }
}
