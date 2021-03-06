﻿using System;
using Xamarin.Forms;

namespace Todo
{
	public class TodoItemCell : ViewCell
	{
		public TodoItemCell ()
		{
			var label = new Label {
				YAlign = TextAlignment.Center
			};
			label.SetBinding (Label.TextProperty, "Name");

			var tick = new Image {
				Source = ImageSource.FromFile ("check.png"),
			};
			tick.SetBinding (Image.IsVisibleProperty, "Done");

			var layout = new StackLayout {
				Padding = new Thickness(20, 0, 0, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Children = {label, tick}
			};
			View = layout;
		}
	}
}

