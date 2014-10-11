using HelloWorld.Common;
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

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CommonXAMLControls : Page
    {
        private readonly NavigationHelper navigationHelper;

        public CommonXAMLControls()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>.
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Create an appropriate data model for your problem domain to replace the sample data.
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/>.</param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            // TODO: Save the unique state of the page here.
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }


        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            //TextBox
            //myTextBlock.Text = myTextBox.Text;

            //ComboBox
            //myTextBlock.Text = ((ComboBoxItem)myComboBox.SelectedItem).Content.ToString();

            //CheckBox
            //myTextBlock.Text = (bool)myCheckBox.IsChecked ? "Is Checked" : "Not Checked";

            //RadioButton
            //if(myFirstRadioButton.IsChecked == true)
            //{
            //    myTextBlock.Text = "First Radio";
            //}
            //else if(mySecondRadioButton.IsChecked == true)
            //{
            //    myTextBlock.Text = "Second Radio";
            //}
            //else
            //{
            //    myTextBlock.Text = "Unknown";
            //}

            //DatePicker
            //myTextBlock.Text = myDatePicker.Date.ToString();

            //TimePicker
            myTextBlock.Text = myTimePicker.Time.ToString();
        }

        private void myToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (myToggleButton.IsChecked == true)
            {
                myProgressRing.IsActive = true;
            }
            else
            {
                myProgressRing.IsActive = false;
            }
        }
    }
}
