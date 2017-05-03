using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Karteiapp
{
    class Karte : DependencyObject
    {

        public static readonly DependencyProperty FrageProperty;

        static Karte()
        {
            FrageProperty = DependencyProperty.Register("Frage", typeof(string), typeof(Karte));

        }

        public string Frage
        {
            set { SetValue(FrageProperty, value); }
            get { return (string)GetValue(FrageProperty); }
        }
    }
}
