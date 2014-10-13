using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace NavigationSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //myTextBlock.Text = e.Parameter.ToString();

            var nav = (NavigationContext)e.Parameter;
            myTextBlock.Text = nav.Description;

            messageTextBox.Text = string.Format("BackStack count is {0}, BackStackDepth is {1}.", Frame.BackStack.Count, Frame.BackStackDepth);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page3));
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
    }
}
