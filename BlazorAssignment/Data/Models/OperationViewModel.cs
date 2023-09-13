using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Models
{
    public class OperationViewModel
    {
        [Key]
        public int OperationID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int OrderInWhichToPerform { get; set; }


        public IFormFile Image;

     //   [TypeConverter(typeof(Device))]
     [Required]
     public Device Device { get; set; }
    }
}
