using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FontAwesomeForms.Extensions
{
    public static class ListExtension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            return new ObservableCollection<T>(list);
        }
    }
}
