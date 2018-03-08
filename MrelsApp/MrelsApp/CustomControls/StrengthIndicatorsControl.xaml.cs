using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrelsApp.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StrengthIndicatorsControl : ContentView
	{
		public StrengthIndicatorsControl ()
		{
			InitializeComponent ();
		}

	    public static readonly BindableProperty StrengthProperty = BindableProperty.Create(nameof(StrengthProperty), typeof(object), typeof(StrengthIndicatorsControl), default(Object));

	    public Object Strength
	    {
	        get
	        {
	            return GetValue(StrengthProperty);
	        }
	        set
	        {
	            SetValue(StrengthProperty, value);
	        }
	    }
    }
}