﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyStuff_Yilka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectorDeAccionPage : ContentPage
    {
        public SelectorDeAccionPage()
        {
            InitializeComponent();
        }
        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarItemPage());
        }

        //private void BtnAdd_Clicked_1(object sender, EventArgs e)
        //{

        //}

        private void BtnVerLista_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnConfig_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnMarcas_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnCategorias_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLoc_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnProveedores_Clicked(object sender, EventArgs e)
        {

        }
    }
}