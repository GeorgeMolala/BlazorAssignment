using BlazorAssignment.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.DataControllers
{
    public class State
    {
        public IList<Device> Devices { get; set; } = new List<Device>();
        public IList<Operation> Operations { get; set; } = new List<Operation>();
    }
}
