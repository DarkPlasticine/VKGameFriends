using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Input;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VKGameFriends.Security;

namespace VKGameFriends
{

    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
          
        }

        #endregion

        #region MyRegion

        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                //var vk = VkSingleton.getInstance();

                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();

                //await vk.Api.AuthorizeAsync(new ApiAuthParams
                //{
                //    Settings = Settings.All,
                //    Login = this.Email,
                //    Password = pass,
                //    ApplicationId = 4551110
                //});

                await Task.Delay(5000);

            });

           
        }

        #endregion
    }
}
