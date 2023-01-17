using System.Collections.Generic;
using System.Threading.Tasks;
using UpSchool_ECommerce.Services.Catalogue.Dtos;
using UpSchoolECommerce.Shared.Dtos;

namespace UpSchool_ECommerce.Services.Catalogue.Services
{
    public interface ICategoryService
    {
        Task<ResponseDto<List<CategoryDto>>> GetAllAsync();
        Task<ResponseDto<CategoryDto>> CreateAsync(CategoryDto categoryDto);
        
        Task<ResponseDto<CategoryDto>> GetByIdAsync(string id);
    }
}
