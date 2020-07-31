using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Products
{
    public class ProductManager : IProductManager
    {
        readonly IRepository<Product> _repository;
        public ProductManager(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Add()
        {
            await _repository.AddAsync(new Product());
        }
    }
}
