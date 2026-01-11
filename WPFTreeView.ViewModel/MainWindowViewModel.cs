using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WPFTreeView.ViewModel.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {


        private MyTreeViewViewModel _myTreeViewModel;

        public MainWindowViewModel()
        {
            _myTreeViewModel = new MyTreeViewViewModel();
        }

        #region Properties

        public MyTreeViewViewModel MyTree
        {
            get
            {
                return _myTreeViewModel;
            }
        }

        #endregion



    }
}
