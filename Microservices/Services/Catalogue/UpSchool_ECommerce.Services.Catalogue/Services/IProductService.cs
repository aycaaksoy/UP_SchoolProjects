using System.Collections.Generic;
using System.Threading.Tasks;
using UpSchool_ECommerce.Services.Catalogue.Dtos;
using UpSchoolECommerce.Shared.Dtos;

namespace UpSchool_ECommerce.Services.Catalogue.Services
{
    public interface IProductService
    {
        Task<ResponseDto<List<ProductDto>>> GetAllAsync();
        Task<ResponseDto<ProductDto>> CreateAsync(CreateProductDto createproductDto);

        Task<ResponseDto<ProductDto>> GetByIdAsync(string id);
        Task<ResponseDto<NoContent>> UpdateAsync(UpdateProductDto updateProductDto);
        Task<ResponseDto<NoContent>> DeleteAsync(string id);
    }
}
