﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace NavigationSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.

            messageTextBox.Text = string.Format("BackStack count is {0}, BackStackDepth is {1}.", Frame.BackStack.Count, Frame.BackStackDepth);
        }


        private void goForward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Frame.GoForward();
            }
            catch (Exception ex)
            {

                messageTextBox.Text = ex.Message;
            }
            
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Frame.GoBack();
            }
            catch (Exception ex)
            {

                messageTextBox.Text = ex.Message;
            }
          
        }

        private void goToPage3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page3));
        }

        private void goToPage2_Click(object sender, RoutedEventArgs e)
        {
            // Simple navigation, no parameters
            //Frame.Navigate(typeof(Page2));

            // Passing a simple type, like a string
            //Frame.Navigate(typeof(Page2), "String from MainPage");

            // Passing an instance of a 'NavigationContext' object
            NavigationContext nav = new NavigationContext()
            {
                ID = 7,
                Name = "Test",
                Description = "This is a test"
            };

            Frame.Navigate(typeof(Page2), nav);
        }
    }
}
