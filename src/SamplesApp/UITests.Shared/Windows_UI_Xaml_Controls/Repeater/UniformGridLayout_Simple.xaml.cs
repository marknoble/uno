﻿using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Uno.UI.Samples.Controls;

namespace UITests.Windows_UI_Xaml_Controls.Repeater
{
	[Sample("ItemsRepeater")]
	public sealed partial class UniformGridLayout_Simple : Page
	{
		public UniformGridLayout_Simple()
		{
			this.InitializeComponent();
		}

		public int[] Items { get; } = Enumerable.Range(1, 50000).ToArray();

		private void Scroll(object server, RoutedEventArgs routedEventArgs)
		{
			if (server is Button btn)
			{
				if (double.TryParse(btn.Tag as string, out var pct))
				{
					if (layout.Orientation == Orientation.Horizontal)
					{
						var offset = RepeaterScrollViewer.ScrollableHeight * pct;
						RepeaterScrollViewer.ChangeView(null, offset, null, true);
					}
					else
					{
						var offset = RepeaterScrollViewer.ScrollableWidth * pct;
						RepeaterScrollViewer.ChangeView(offset, null, null, true);
					}
				}
			}
		}

		private void Tree(object server, RoutedEventArgs routedEventArgs)
		{
#if HAS_UNO || HAS_UNO_WINUI
			var txt = this.ShowLocalVisualTree();
			Console.WriteLine(txt);
#endif
		}
	}
}
