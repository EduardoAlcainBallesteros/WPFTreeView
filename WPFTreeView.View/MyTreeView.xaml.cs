using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WPFTreeView.View
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MyTreeView : UserControl
    {
        public MyTreeView()
        {
            InitializeComponent();
        }

        //private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        //{
            //var viewModel = DataContext as MyTreeViewViewModel;
            //if (viewModel != null)
            //{
            //    viewModel.Item =(HierachyTreeViewItem) e.NewValue;
            //}
        //}
    }
}
