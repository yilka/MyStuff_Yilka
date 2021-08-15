using System;
using System.Collections.Generic;
using System.Text;
using MyStuff_Yilka.Models;
using MyStuff_Yilka.Clases;
using System.Threading.Tasks;

namespace MyStuff_Yilka.ViewModels
{
    class ItemCategoryViewModel : BaseViewModel
    {

        public ItemCategory MyCategory { get; set; }

        public ItemCategoryViewModel()
        {
            MyCategory = new ItemCategory();
        }

        public async Task<bool> GuardarCategory(string PCategory)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MyCategory.Category = PCategory;

                bool R = await MyCategory.GuardarCategory();

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