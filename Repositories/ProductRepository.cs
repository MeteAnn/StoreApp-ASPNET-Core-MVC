using Entities.Models;
using Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Repositories
{

    public sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
    

        public ProductRepository(RepositoryContext context) : base(context)
        {



        }

        public void CreateOneProduct(Product product) => Create(product);

        public void DeleteOneProduct(Product product) => Remove(product);
    

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        public Product? GetOneProduct(int id, bool trackChanges)
        {

            return FindByCondition(p=>p.ProductId.Equals(id), trackChanges);

        }

        public void UpdaeOneProduct(Product entity) => Update(entity);
       
    }

}