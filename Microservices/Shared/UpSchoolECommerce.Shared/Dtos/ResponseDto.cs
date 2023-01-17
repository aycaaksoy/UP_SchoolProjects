using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolECommerce.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccessful { get; set; }
        public List<string> Errors { get; set; }
        public static ResponseDto<T> Success(T data, int StatusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = StatusCode, IsSuccessful= true };
        }
        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSuccessful = true
            };
        }
        public static ResponseDto<T> Fail(string errors, int statusCode)
               
        {
            return new ResponseDto<T>
            {
                Errors=new List<string>() { errors },
                 StatusCode = statusCode,
                IsSuccessful = false
            };
        }
    }

   
}
