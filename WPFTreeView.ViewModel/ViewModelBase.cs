using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WPFTreeView.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

      

        private bool? _dataChanged = null;
        public bool DataChanged
        {
            get
            {
                if (!_dataChanged.HasValue)
                    return GetDataChanged();
                else
                {
                    if (!(bool)_dataChanged)
                        return GetDataChanged();
                    else
                        return (bool)_dataChanged;
                }
            }
            set { _dataChanged = value; }
        }



        // -----------------------------------------------------
        protected virtual bool GetDataChanged()
        {
            return false;
        }

        // -----------------------------------------------------
        // -----------------------------------------------------
        private static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            var memberExpression = propertyExpression.Body as MemberExpression;
            if (memberExpression == null)
                throw new ArgumentException("Expression must be a MemberExpression.", "propertyExpression");
            return memberExpression.Member.Name;
        }

        // -----------------------------------------------------
        // -----------------------------------------------------
        protected void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        // -----------------------------------------------------
        // -----------------------------------------------------
        protected void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            OnPropertyChanged(ExtractPropertyName(propertyExpression));
        }

        // -----------------------------------------------------
        // -----------------------------------------------------
        protected bool SetProperty<T>(ref T field, T value, Expression<Func<T>> propertyExpression)
        {
            var changed = !EqualityComparer<T>.Default.Equals(field, value);
            if (changed)
            {
                field = value;
                OnPropertyChanged(ExtractPropertyName(propertyExpression));
            }
            return changed;
        }

        // -----------------------------------------------------
        // -----------------------------------------------------
        protected bool SetProperty<T>(ref T field, T value, string propertyName)
        {
            var changed = !EqualityComparer<T>.Default.Equals(field, value);
            if (changed)
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
            return changed;
        }

    }
}
