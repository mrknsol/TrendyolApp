using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TrendyolApp.Services.Classes
{
    public class ContextMenuBinding : Freezable
    {
        protected override Freezable CreateInstanceCore()
        {
            return new ContextMenuBinding();
        }

        public object Data
        {
            get { return (object)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data", typeof(object), typeof(ContextMenuBinding), new UIPropertyMetadata(null));
    }

}
