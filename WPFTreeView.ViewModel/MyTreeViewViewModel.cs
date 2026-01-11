using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
namespace WPFTreeView.ViewModel
{
    // https://www.codeproject.com/articles/Simplifying-the-WPF-TreeView-by-Using-the-ViewMode#comments-section
    // https://joshsmithonwpf.wordpress.com/2008/05/
    public class MyTreeViewViewModel : ViewModelBase
    {

        private List<HierachyTreeViewItem> _items;
        private HierachyTreeViewItem _item;
        public List<HierachyTreeViewItem> Items {

            get { return _items; }
        
        }
        // Problems to select an item fromthe TreeView Behaviour or Behind code
        public HierachyTreeViewItem Item
        {
            get { return _item; }
            set { _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }

        public MyTreeViewViewModel()
        {

            _items = new List<HierachyTreeViewItem>();
            Init();
        }

        public void Init()
        {
            HierachyTreeViewItem root = new HierachyTreeViewItem();
            root.Name = "root";
            root.Children = new List<HierachyTreeViewItem>();
            HierachyTreeViewItem wireless = new HierachyTreeViewItem();
            wireless.Name = "wireless";
            HierachyTreeViewItem wired = new HierachyTreeViewItem();
            wired.Name = "wired";
            root.Children.Add(wireless);
            root.Children.Add(wired);

            _items.Add(root);

        }
    }
}
