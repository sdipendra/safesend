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
    public sealed partial class strong : Page
    {
        public strong()
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

        private void Weak_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(weak));
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void cipher_Click(object sender, RoutedEventArgs e)
        {
            string o = original.Text;
            if (o.Length > 0)
            {
                string k = "Public Key: 9129";
                int no = o.Length;
                int nk = k.Length;
                Char[] oc = o.ToCharArray();
                Char[] kc = k.ToCharArray();
                int ans = 0; char[] c2 = new char[1];
                int n1 = 91, e1 = 29; string s1 = "";
                int pp;
                for (int i = 0; i < no; i++)
                {
                    if (oc[i] == ' ') s1 += " ";
                    else
                    {
                        if ('a' <= oc[i] && oc[i] <= 'z')
                        {
                            pp = (int)(oc[i] - 'a' + 2);
                            ans = 1;
                            for (int qq = 0; qq < e1; qq++)
                            {
                                ans *= pp;
                                ans = ans % n1;
                            }
                            if (ans / 10 == 0) s1 += "0";
                            s1 += ans.ToString();
                        }
                        else if ('A' <= oc[i] && oc[i] <= 'Z')
                        {
                            pp = (int)(oc[i] - 'A' + 2 + 30);
                            ans = 1;
                            for (int qq = 0; qq < e1; qq++)
                            {
                                ans *= pp;
                                ans = ans % n1;
                            }
                            if (ans / 10 == 0) s1 += "0";
                            s1 += ans.ToString();
                        }
                        else if ('0' <= oc[i] && oc[i] <= '9')
                        {
                            pp = (int)(oc[i] - '0' + 2 + 60);
                            ans = 1;
                            for (int qq = 0; qq < e1; qq++)
                            {
                                ans *= pp;
                                ans = ans % n1;
                            }
                            if (ans / 10 == 0) s1 += "0";
                            s1 += ans.ToString();
                        }
                        else s1 += oc[i];
                    }
                    ciphered.Text = s1;
                }
            }
            else ciphered.Text = "";
        }
        private void decipher_Click(object sender, RoutedEventArgs e)
        {
            string o = ciphered.Text;
            if (o.Length > 0)
            {
                string k = "Public Key: 9129"; int pp;
                int no = o.Length;
                int d = 5; int n1 = 91;
                Char[] oc = o.ToCharArray();
                Char[] kc = k.ToCharArray();
                int num = 0;
                string s1 = "";
                for (int i = 0; i < no; i += 1)
                {
                    if (oc[i] == ' ') s1 += " ";
                    else
                    {
                        if (oc[i] < '0' || (oc[i] > '9' && oc[i] < 'A') || (('Z' < oc[i]) && (oc[i] < 'a')) || (oc[i]) > 'Z') s1 += oc[i];
                        else
                        {
                            num = (int)(oc[i]) - '1' + 1;
                            num *= 10;
                            num += ((int)(oc[i + 1]) - '1' + 1);
                            pp = num;
                            num = 1;
                            for (int qq = 0; qq < d; qq++)
                            {
                                num *= pp;
                                num = num % n1;
                            }
                            if (num >= 60)
                            {
                                char tert = (char)(num + '0' - 60 - 2);
                                s1 += (char)tert; i += 1;
                            }
                            else
                            {
                                char tert = (char)(num + 'a' - 2 - (num / 32) * 30 + ('A' - 'a') * (num / 32));
                                s1 += (char)tert; i += 1;
                            }
                        }
                    }
                }// string cs = new string(oc);
                original.Text = s1;
            }
            else original.Text = "";
        } 


        private void original_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ciphered_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(send), ciphered.Text);
        }

        private void original_gotfocus(object sender, RoutedEventArgs e)
        {
            original.Text = "";
        }

        private void ciphered_gotfocus(object sender, RoutedEventArgs e)
        {
            ciphered.Text = "";
        }
    }
}
