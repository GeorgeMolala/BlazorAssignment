using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Models
{
    public class Operation
    {
        [Key]
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }

     //   [TypeConverter(typeof(Device))]
        public Device Device { get; set; }

    }
}
