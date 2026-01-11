using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WPFTreeView.ViewModel.ViewModels
{
    public class RelayCommand : ICommand, IDisposable
    {
        #region Fields

        List<EventHandler> _canExecuteSubscribers = new List<EventHandler>();
        private Action<object> _execute { get; set; }
        readonly Predicate<object> _canExecute;

        #endregion // Fields

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion // Constructors

        #region ICommand Members

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
                _canExecuteSubscribers.Add(value);
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
                _canExecuteSubscribers.Remove(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            try
            {
                _execute(parameter);
            }
            catch { }
        }

        #endregion // ICommand Members

        public void Dispose()
        {
            _canExecuteSubscribers.ForEach(h => CanExecuteChanged -= h);
            _canExecuteSubscribers.Clear();
            _execute = null;
        }
    }
}
