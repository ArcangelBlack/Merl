using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MrelsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MrelsApp.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConnectSocialButtonControl : ContentView
	{
		public ConnectSocialButtonControl ()
		{
			InitializeComponent ();
		    BindingContext = new SocialServiceViewModel
		    {
		        Network = "Facebook",
		        DisconnectedImageUrl = "facebook_icon_grey.png",
		        ConnectedImageUrl = "facebook_icon_white.png",
		        CanConnect = false
		    };
        }
	}
}