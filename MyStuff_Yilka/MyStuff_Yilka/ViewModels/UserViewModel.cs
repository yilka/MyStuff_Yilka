using System;
using System.Collections.Generic;
using System.Text;
using MyStuff_Yilka.Models;
using MyStuff_Yilka.Clases;
using System.Threading.Tasks;


namespace MyStuff_Yilka.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        public User MyUser { get; set; }

        public UserViewModel()
        {
            MyUser = new User();

           
        }

       
        public async Task<bool> GuardarUsuario(string Pusername, string Pname, string PuserPassword,
                                               string Pphone, string PbackupEmail)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                Crypto MiEncriptador = new Crypto();

                string UserNameEncriptado = MiEncriptador.EncriptarPassword(Pusername);
                string PassEncriptado = MiEncriptador.EncriptarPassword(PuserPassword);

                MyUser.Username = UserNameEncriptado;
                MyUser.Name = Pname;
                MyUser.UserPassword = PassEncriptado;
                MyUser.Phone = Pphone;
                MyUser.BackupEmail = PbackupEmail;

                bool R = await MyUser.GuardarUsuario();

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

        public async Task<bool> ValidarUsuario(string Pusername, string PuserPassword)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                Crypto MiEncriptador = new Crypto();

                string UserNameEncriptado = MiEncriptador.EncriptarPassword(Pusername);
                string PassEncriptado = MiEncriptador.EncriptarPassword(PuserPassword);

                MyUser.Username = UserNameEncriptado;
                MyUser.UserPassword = PassEncriptado;

                bool R = await MyUser.ValidarUsuario();

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
