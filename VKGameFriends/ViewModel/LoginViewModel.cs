using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Input;

namespace VKGameFriends
{

    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

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
            await Task.Delay(500);
        }

        #endregion
    }
}
