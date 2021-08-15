using System;
using System.Collections.Generic;
using System.Text;
using MyStuff_Yilka.Models;
using MyStuff_Yilka.Clases;
using System.Threading.Tasks;

namespace MyStuff_Yilka.ViewModels
{
    class BrandViewModel : BaseViewModel
    {

        public Brand MyBrand { get; set; }

        public BrandViewModel()
        {
            MyBrand = new Brand();
        }

        public async Task<bool> GuardarBrand(string PBrandName)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MyBrand.BrandName = PBrandName;

                bool R = await MyBrand.GuardarBrand();

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