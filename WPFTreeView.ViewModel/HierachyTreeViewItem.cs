using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace WPFTreeView.ViewModel
{
    public class HierachyTreeViewItem : ViewModelBase
    {
        public string Name { 
            
            get; set; }
        public HierachyTreeViewItem Parent { get; set; }


        public ImageSource Image { get; set; }
        private List<HierachyTreeViewItem> _children;

        private bool _isExpanded;
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set
            {
                // IsExpanded = value;
                SetProperty(ref _isExpanded, value, () => IsExpanded);
                //OnPropertyChanged(() => IsExpanded);
            }
        }

        public string _foreground;

        public string TextForeground
        {
            get
            {
                return _foreground;
            }

            set
            {
                _foreground = value;
                OnPropertyChanged("TextForeground");
            }
        }

        public List<HierachyTreeViewItem> Children
        {
            get { return _children; }
            set { _children = value; }
        }


        public HierachyTreeViewItem()
        {
            _isExpanded = false;
            _children = new List<HierachyTreeViewItem>();
        }
    }
}
