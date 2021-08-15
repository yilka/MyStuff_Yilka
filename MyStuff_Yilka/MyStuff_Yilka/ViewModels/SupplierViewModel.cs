using System;
using System.Collections.Generic;
using System.Text;
using MyStuff_Yilka.Models;
using MyStuff_Yilka.Clases;
using System.Threading.Tasks;

namespace MyStuff_Yilka.ViewModels
{
    class SupplierViewModel : BaseViewModel
    {

        public Supplier MySupplier { get; set; }

        public SupplierViewModel()
        {
            MySupplier = new Supplier();
        } 

        public async Task<bool> GuardarSupplier(string PSupplierName, string PSupplierPhone, string PSupplierEmail)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MySupplier.SupplierName = PSupplierName;
                MySupplier.SupplierPhone = PSupplierPhone;
                MySupplier.SupplierEmail = PSupplierEmail;
                

                bool R = await MySupplier.GuardarSupplier();

                return R;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}