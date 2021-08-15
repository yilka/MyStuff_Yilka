using System;
using System.Collections.Generic;
using System.Text;
using MyStuff_Yilka.Models;
using MyStuff_Yilka.Clases;
using System.Threading.Tasks;

namespace MyStuff_Yilka.ViewModels
{
    class ItemLocalizationViewModel : BaseViewModel
    {

        public ItemLocalization MyLocalization { get; set; }

        public ItemLocalizationViewModel()
        {
            MyLocalization = new ItemLocalization();
        }

        public async Task<bool> GuardarLocalization(string PLocalization)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MyLocalization.Localization = PLocalization;
                


                bool R = await MyLocalization.GuardarLocalization();

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
