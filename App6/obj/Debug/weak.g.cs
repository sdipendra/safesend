﻿

#pragma checksum "G:\code.fun.do\SafeSend\App6\App6\weak.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09DC9D9191641C4832A6980295E7434E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App6
{
    partial class weak : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 15 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.cipher_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 16 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.decipher_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 17 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.original_gotfocus;
                 #line default
                 #line hidden
                #line 17 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.original_TextChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 18 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.ciphered_gotfocus;
                 #line default
                 #line hidden
                #line 18 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.ciphered_TextChanged;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 19 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.key_gotfocus;
                 #line default
                 #line hidden
                #line 19 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.key_TextChanged;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 20 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.send_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 21 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Medium_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 22 "..\..\weak.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Strong_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

