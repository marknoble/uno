// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Windows.UI.Xaml.Controls
{
	public partial class SwipeItem
	{
		class SwipeItem : 

		public ReferenceTracker<SwipeItem, winrt.implementation.SwipeItemT>,

		public SwipeItemProperties
		{

		public:

		SwipeItem();

		// Property changed handler.
		void OnPropertyChanged(winrt.DependencyPropertyChangedEventArgs& args);

		void GenerateControl(winrt.AppBarButton& appBarButton, winrt.Style& swipeItemStyle);

		void InvokeSwipe(winrt.SwipeControl& content);

		private:

		void OnItemTapped(
			winrt.DependencyObject& sender,

		winrt.TappedRoutedEventArgs& args);

		void OnPointerPressed(
			winrt.DependencyObject& sender,

		winrt.PointerRoutedEventArgs& args);

		void OnCommandChanged(winrt.ICommand& oldCommand, winrt.ICommand& newCommand);

		void AttachEventHandlers(winrt.AppBarButton& appBarButton);
	}
}
