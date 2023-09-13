using BlazorAssignment.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.DataControllers
{
    public class DeviceControllerBase: ComponentBase
    {
     

        [CascadingParameter]
        public State state { get; set; }
        protected bool hide { get; set; } = true;


        //Model Class for Device
        protected Device dev = new Device();
        private int DeviceID = 1;

        protected override Task OnInitializedAsync()
        {
        
            return base.OnInitializedAsync();
        }


        public void AddDevice()
        {
            dev.DeviceID = DeviceID;
            Device ll = new Device
            {
                DeviceID = DeviceID,
                Name = dev.Name,
                DeviceType = dev.DeviceType
            };
         //   Devices.Add(ll);
            state.Devices.Add(ll);
            DeviceID++;
        }

        public void Dev()
        {
            
        }

        public void hideShow()
        {
            hide = !hide;
        }

    }
}
