using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMl.UI.Layer.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Cannot be empty")]
        public string RoleName { get; set; }
    }
}