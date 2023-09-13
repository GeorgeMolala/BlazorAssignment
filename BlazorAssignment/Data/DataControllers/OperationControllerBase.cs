using BlazorAssignment.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace BlazorAssignment.Data.DataControllers
{
    public class OperationControllerBase : ComponentBase
    {
        [CascadingParameter]
        public State state { get; set; }

        protected OperationViewModel Oper = new OperationViewModel();//Unnessary
        public string Base64 { get; set; } //to be removed

        [Required]
        protected byte[] Data { get; set; }

        protected bool hide { get; set; } = true;
        protected bool ModalHide { get; set; } = true;
        protected bool ModalDeleteHide { get; set; } = true;
        private int DeleteID { get; set; }

        protected IFormFile image { get; set; }

        // protected Device ded = new Device();
        public IList<OperationViewModel> Operations { get; set; }


        private int OperationID = 1;

        protected override Task OnInitializedAsync()
        {
           Oper.Device = state.Devices.FirstOrDefault();

         
            return base.OnInitializedAsync();
        }

        public void Delete(int ID)
        {
            DeleteID = ID;
            DeleteModal();


        }

        //If delete is canceled
        public void DeleteCanceled()
        {
            DeleteModal();
        }

        //Incase Delete Is confirmed
        public void DeleteConfirmed()
        {

            var op = new Operation();
            op = state.Operations.Where(s => s.OperationID == DeleteID).FirstOrDefault();
            state.Operations.Remove(op);
            DeleteModal();
        }

        public async Task load(InputFileChangeEventArgs e)
        {

            var img = e.File;

            if (e.File != null)
            {

                using (var stream = new MemoryStream())
                {
                    await img.OpenReadStream().CopyToAsync(stream);
                    Data = stream.ToArray();
                }
            }
            else
            {
                Data = null; 
            }
        }

        //Modal Information tool tips
        public void hideModal()
        {
            ModalHide = !ModalHide;
        }

        //Modal Delete
        public void DeleteModal()
        {
            ModalDeleteHide = !ModalDeleteHide;
        }

        public void AddOperation()
        {
            int ID = Oper.Device.DeviceID;



            Operation Op = new Operation
            {
                Name = Oper.Name,
                OperationID = OperationID,
                OrderInWhichToPerform = Oper.OrderInWhichToPerform,
                Device = Oper.Device,
                ImageData = Data

            };
          //  conversion(Op.ImageData);

            state.Operations.Add(Op);
            OperationID++;
            hideShow();
            hideModal();
        }

        

        public void hideShow()
        {
            hide = !hide;
        }



    }
}

