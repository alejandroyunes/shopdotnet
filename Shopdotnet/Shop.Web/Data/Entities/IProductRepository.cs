
namespace Shop.Web.Data.Entities
{

    using Shop.Web.Entities;
    using System.Linq;

    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }

}
