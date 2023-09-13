using BlazorAssignment.Data.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.DataControllers
{
    public class ControlBase: ComponentBase
    {
        public IList<Device> Devices { get; set; }
        public IList<Operation> Operations { get; set; }

        [CascadingParameter]
        public State state { get; set; }

        //Model Class for Operations
        protected OperationViewModel Oper = new OperationViewModel();

        //Model Class for Device
        protected Device dev = new Device();
        private int DeviceID = 2;

        protected override Task OnInitializedAsync()
        {
            loadDevices();
          //  loadOperations();
            return base.OnInitializedAsync();
        }

        private void loadDevices()
        {
            Device Dev1 = new Device
            {
                DeviceID = 1,
                Name = "Samsung",
                DeviceType = DeviceType.Camera

            };
            Device Dev2 = new Device
            {
                DeviceID = 2,
                Name = "Toshiba",
                DeviceType = DeviceType.Printer
            };

            Devices = new List<Device> { Dev1, Dev2 };
            Operations = new List<Operation>();
          
        }

      public void AddOperation()
        {

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
            Devices.Add(ll);
            state.Devices.Add(ll);
            DeviceID++;
        }

    }
}
