using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsynch(int id);
        Task<IReadOnlyList<Product>> GetProductsAsych();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsyc();
    }
}