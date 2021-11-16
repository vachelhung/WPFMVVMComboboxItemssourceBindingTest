using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFMVVMComboboxItemssourceBindingTest.ViewModels
{
    internal class MainViewModel : NotifyPropertyBase
    {
        List<string> ComboboxItemsSource1 = new List<string> { "a", "b", "c"};
        List<string> ComboboxItemsSource2 = new List<string> { "A", "B", "C" };
        bool ChangedBool = false;

        private List<string> _comboboxBindingItemsSource = new() { "A", "B", "C"};
        public List<string> ComboboxBindingItemsSource
        {
            get { return _comboboxBindingItemsSource; }
            set { SetProperty(ref _comboboxBindingItemsSource, value); }
        }

        private ICommand _clickReloadComboboxItemsSourceBtnCommand;
        public ICommand ClickReloadComboboxItemsSourceBtnCommand
        {
            get
            {
                if (_clickReloadComboboxItemsSourceBtnCommand == null)
                {
                    _clickReloadComboboxItemsSourceBtnCommand = new RelayCommand((x) =>
                    {
                        if (ChangedBool == false)
                        {
                            ChangedBool = true;
                            ComboboxBindingItemsSource = ComboboxItemsSource1;
                        }
                        else
                        {
                            ChangedBool = false;
                            ComboboxBindingItemsSource = ComboboxItemsSource2;
                        }
                    }
                    );
                }
                return _clickReloadComboboxItemsSourceBtnCommand;
            }
        }
    }
}
