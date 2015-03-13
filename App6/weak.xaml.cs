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
    public sealed partial class weak : Page
    {
        public weak()
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
        }
        string ktext="";
        private void cipher_Click(object sender, RoutedEventArgs e)
        {
            string o = original.Text;
            if (ktext.Length > 0)
            {
                int k = Convert.ToInt32(ktext);
                k = k % 10;
                int no = o.Length;
                Char[] oc = o.ToCharArray();
                char[] c = new char[no];
                for (int i = 0; i < no; i++)
                {
                    if (oc[i] == ' ') { c[i] = ' '; }
                    else
                    {
                        if ('a' <= oc[i] && oc[i] <= 'z')
                            c[i] = (char)((((int)oc[i] - k + 26 - (int)('a')) % 26) + 'a');
                        else if ('A' <= oc[i] && oc[i] <= 'Z')
                            c[i] = (char)((((int)oc[i] - k + 26 - (int)('A')) % 26) + 'A');
                        else c[i] = oc[i];
                    }
                }
                string cs = new string(c);
                ciphered.Text = cs;
            }
            else
            {
                key.Text = "Enter a key!!!!";
                ciphered.Text = "";
            }
        }

        private void decipher_Click(object sender, RoutedEventArgs e)
        {
            string o = ciphered.Text;
            if (ktext.Length > 0)
            {
                int k = Convert.ToInt32(ktext);
                int no = o.Length;
                Char[] oc = o.ToCharArray();
                char[] c = new char[no];
                for (int i = 0; i < no; i++)
                {
                    if (oc[i] == ' ') { c[i] = ' '; }
                    else
                    {
                        if ('a' <= oc[i] && oc[i] <= 'z')
                            c[i] = (char)((((int)oc[i] + k - (int)('a')) % 26) + 'a');
                        else if ('A' <= oc[i] && oc[i] <= 'Z')
                            c[i] = (char)((((int)oc[i] + k - (int)('A')) % 26) + 'A');
                        else c[i] = oc[i];
                    }
                    // s1 += ans.ToString();
                    //c[i] = (char)((((int)oc[i] + k  - (int)('a')) % 26) + 'a');

                }
                string cs = new string(c);
                original.Text = cs;
            }
            else
            {
                key.Text = "Enter a key!!!!";
                original.Text = "";
            }
        }

        private void original_gotfocus(object sender, RoutedEventArgs e)
        {
            original.Text = "";
        }

        private void ciphered_gotfocus(object sender, RoutedEventArgs e)
        {
            ciphered.Text = "";
        }

        private void key_gotfocus(object sender, RoutedEventArgs e)
        {
            key.Text = "";
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Strong_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(strong));
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(send), ciphered.Text);
        }

        private void original_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void key_TextChanged(object sender, TextChangedEventArgs e)
        {
            string check = key.Text;
            bool flag = true;
            int length = check.Length;
            for (int i = 0; i < length; i++)
            {
                if (!((check[i] >= '1') && (check[i] <= '9')))
                {
                    key.Text = "Wrong Input";
                    flag = false;
                }
            }
            if (flag) ktext = check;

        }

        private void ciphered_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
