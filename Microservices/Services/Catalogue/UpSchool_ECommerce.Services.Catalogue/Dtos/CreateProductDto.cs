using UpSchool_ECommerce.Services.Catalogue.Models;

namespace UpSchool_ECommerce.Services.Catalogue.Dtos
{
    public class CreateProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }

        public string CategoryId { get; set; }
    }
}
