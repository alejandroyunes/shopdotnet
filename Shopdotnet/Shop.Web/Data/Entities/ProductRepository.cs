

namespace Shop.Web.Data
{
    using Entities;
    using Shop.Web.Entities;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }

}
