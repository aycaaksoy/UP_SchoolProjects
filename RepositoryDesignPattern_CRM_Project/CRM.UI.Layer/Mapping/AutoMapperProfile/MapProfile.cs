using AutoMapper;
using CRM.Business.Layer.Concrete;
using CRM.DTO.Layer.ContactDTOs;
using CRM.Entity.Layer.Concrete;
using CRM.UI.Layer.Models;

namespace CRM.UI.Layer.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<ContactAddDTO, Contact>();
            CreateMap<Contact, ContactAddDTO>();

            CreateMap<ContactListDTO, Contact>();
            CreateMap<Contact, ContactListDTO>();

            CreateMap<ContactUpdateDTO, Contact>();
            CreateMap<Contact, ContactUpdateDTO>();

            CreateMap<CustomerAddDTO, Customer>();
            CreateMap<Customer, CustomerAddDTO>();
        }
    }
}
