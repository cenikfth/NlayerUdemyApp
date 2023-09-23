using Nlayer.Core.DTOs;
using Nlayer.Core.Models;

namespace Nlayer.Core.Services
{
    public interface ICategoryService: IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByWithProductsAsync(int CategoriId);
    }
}
