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
    public partial class TreeViewSelector : TreeView
    {
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(TreeViewSelector), new PropertyMetadata(null));

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public TreeViewSelector()
        {
            InitializeComponent();
            this.SelectedItemChanged += TreeView_SelectedItemChanged;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            SelectedItem = e.NewValue;
        }

        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/finalizers
        ~TreeViewSelector()
        {
            // Unhook the event
            SelectedItemChanged -= TreeView_SelectedItemChanged;
        }
    }
}