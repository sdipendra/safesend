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

namespace App6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class send : Page
    {
        public send()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>

        string cipher;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            cipher = e.Parameter.ToString();
        }

        private async void send_Click(object sender, RoutedEventArgs e)
        {
            var chatMessage = new
            Windows.ApplicationModel.Chat.ChatMessage();
            chatMessage.Body = cipher;
            chatMessage.Recipients.Add(number.Text);
            await Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(chatMessage);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }      

        
    }
}
