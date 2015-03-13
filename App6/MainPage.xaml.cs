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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace App6
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
        }

        private void cipher_Click(object sender, RoutedEventArgs e)
        {
            string o = original.Text;
            string k = key.Text;
            bool flag = true;
            for (int i = 0; i < key.Text.Length; i++)
            {
                if (!(((key.Text[i] >= 'a') && (key.Text[i] <= 'z')) || ((key.Text[i] >= 'A') && (key.Text[i] <= 'Z'))))
                {
                    key.Text = "Wrong Input";
                    flag = false;
                }
            }
            if (flag)
            {
                int no = o.Length;
                int nk = k.Length;
                Char[] oc = o.ToCharArray();
                Char[] kc = k.ToCharArray();
                Char[] c = new char[no]; int j = 0;
                if (nk > 0)
                {
                    for (int i = 0; i < no; i++)
                    {
                        if ('A' <= oc[i] && 'Z' >= oc[i])
                        {
                            if ('A' <= kc[j % nk] && 'Z' >= kc[j % nk])
                            {
                                c[i] = (char)('A' + (oc[i] + kc[j % nk] - 'A' - 'A') % 26);
                                j++;
                            }
                            else if ('a' <= kc[j % nk] && 'z' >= kc[j % nk])
                            {
                                c[i] = (char)('A' + (oc[i] + kc[j % nk] - 'A' - 'a') % 26);
                                j++;
                            }
                        }

                        else if ('a' <= oc[i] && 'z' >= oc[i])
                        {
                            if ('A' <= kc[j % nk] && 'Z' >= kc[j % nk])
                            {
                                c[i] = (char)('a' + (oc[i] + kc[j % nk] - 'a' - 'A') % 26);
                                j++;
                            }
                            else if ('a' <= kc[j % nk] && 'z' >= kc[j % nk])
                            {
                                c[i] = (char)('a' + (oc[i] + kc[j % nk] - 'a' - 'a') % 26);
                                j++;
                            }
                        }

                        else
                            c[i] = oc[i];
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
            else ciphered.Text = "";
        }

        private void decipher_Click(object sender, RoutedEventArgs e)
        {
            string c = ciphered.Text;
            string k = key.Text;
            bool flag = true;
            for (int i = 0; i < key.Text.Length; i++)
            {
                if (!(((key.Text[i] >= 'a') && (key.Text[i] <= 'z')) || ((key.Text[i] >= 'A') && (key.Text[i] <= 'Z'))))
                {
                    key.Text = "Wrong Input";
                    flag = false;
                }
            }
            if (flag)
            {
            int nc = c.Length;
            int nk = k.Length;
            Char[] cc = c.ToCharArray();
            Char[] kc = k.ToCharArray();
            Char[] o = new char[nc]; int j = 0;
            if (nk > 0)
            {
                for (int i = 0; i < nc; i++)
                {
                    if (cc[i] >= 'a' && cc[i] <= 'z')
                    {
                        if (kc[j % nk] >= 'a' && kc[j % nk] <= 'z')
                        {
                            o[i] = (char)('a' + (cc[i] - kc[j % nk] + 26) % 26);
                            j++;
                        }
                        else if (kc[j % nk] >= 'A' && kc[j % nk] <= 'Z')
                        {
                            o[i] = (char)('a' + (cc[i] - 'a' - kc[j % nk] + 'A' + 26) % 26);
                            j++;
                        }
                    }

                    else if (cc[i] >= 'A' && cc[i] <= 'Z')
                    {
                        if (kc[j % nk] >= 'a' && kc[j % nk] <= 'z')
                        {
                            o[i] = (char)('A' + (cc[i] - 'A' - kc[j % nk] + 'a' + 26) % 26);
                            j++;
                        }
                        else if (kc[j % nk] >= 'A' && kc[j % nk] <= 'Z')
                        {
                            o[i] = (char)('A' + (cc[i] - 'A' - kc[j % nk] + 'A' + 26) % 26);
                            j++;
                        }
                    }

                    else
                        o[i] = cc[i];
                }
                string cs = new string(o);
                original.Text = cs;
            }
            else
            {
                key.Text = "Enter a key!!!!";
                original.Text = "";
            }
            }
            else ciphered.Text = "";


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

        private void original_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(send),ciphered.Text);
        }

        private void ciphered_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void key_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Weak_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(weak));
        }

        private void Strong_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(strong));
        }
       
    }
}
