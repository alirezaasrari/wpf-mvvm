﻿using hotel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                onCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;
        private void onCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
