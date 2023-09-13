using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Models
{
    public class Device
    {
        [Key]
        public int DeviceID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DeviceType DeviceType { get; set; }

        
    }
}
