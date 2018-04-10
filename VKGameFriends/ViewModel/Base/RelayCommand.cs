using System;
using System.Windows.Input;

namespace VKGameFriends
{
    public class RelayCommand : ICommand
    {
        #region Private Members
        private Action mAction;
        #endregion

        #region Public Events
        /// <summary>
        /// Событие изменения значения <see cref="CanExecute(object)"/>
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender,e ) => {};

        #endregion

        #region Constructor
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// КОманда всегда выполнена
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполнение команды Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }

        #endregion
    }
}
