﻿using Xamarin.Forms;

namespace FitRest.ViewModels.Abstract
{
    public class AViewModel<T> where T : class
    {
        public T DataStore => DependencyService.Get<T>();
    }
}
