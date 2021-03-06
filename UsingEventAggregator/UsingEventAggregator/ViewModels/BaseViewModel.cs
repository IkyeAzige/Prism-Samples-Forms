﻿using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace UsingEventAggregator
{
    public class BaseViewModel : BindableBase, INavigationAware, IDisposable
    {
        #region Properties

        private string _title;
        public string Title {
        	get { return _title; }
        	set { SetProperty (ref _title, value); }
        }

        #endregion

        #region INavigationAware

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void OnNavigatingTo(INavigationParameters parameters) { }

        #endregion

        #region IDisposable

        public virtual void Dispose() { }
        
        #endregion

    }
}
