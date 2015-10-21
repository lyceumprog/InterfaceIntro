using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace InterfaceIntro
{
	[Activity (Label = "InterfaceIntro", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.button1);
			int width = Resources.DisplayMetrics.WidthPixels; // Получение данных о ширине экрана
			button.SetWidth (width/3); // Установка ширины кнопки

			button.Click += delegate {
				button.SetWidth(button.Width + 10); // Увеличение ширины кнопки при нажатии на нее
			};
		}
	}
}


