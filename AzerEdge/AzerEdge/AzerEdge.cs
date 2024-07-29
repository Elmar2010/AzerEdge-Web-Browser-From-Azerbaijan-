using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Diagnostics;
using Microsoft.Web.WebView2.Wpf;



namespace AzerEdge
{
    public partial class AzerEdge : Telerik.WinControls.UI.RadTabbedForm
    {
        public AzerEdge()
        {
            InitializeComponent();

            this.AllowAero = false;
        }

        private void radTabbedFormControl1_SelectedTabChanged(object sender, EventArgs e)
        {

        }

        private void radTabbedFormControlTab2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radTabbedFormControlTab1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gotoHomeMainBtn_Click(object sender, EventArgs e)
        {
            InitBrowser();
            

        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://google.az");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fwww.google.com%2F&ec=GAZAmgQ&hl=tr&ifkv=AdF4I76v65lhrdggpwKKYT7RHRUvcjC3cVMMepvV_6Gif_DnECQTC9ozsWpoyHiFAguCxb0BEW3Fpw&passive=true&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S-1593663531%3A1722250180895110&ddm=0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AzerEdgeInformation azerEdgeInformation = new AzerEdgeInformation();
            azerEdgeInformation.Show();
        }

        private void getDeviceInfoBtn_Click(object sender, EventArgs e)
        {
            AzerEdgeInformation azerEdgeInformation = new AzerEdgeInformation();
            azerEdgeInformation.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && textBox1.Text.Trim().Length > 0)
            {
                if (textBox1.Text.Contains("."))
                {
                    
                }
                else
                {
                    webView21.Source = new Uri("https://www.google.com/search?q=" + textBox1.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Axtarış google.com Üzərindən Axtarır.", "Axtarış Bildirişi");
        }

        private void WebviewOnCoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            this.webView21.CoreWebView2.PermissionRequested += this.CoreWebView2OnPermissionRequested;
        }

        private void CoreWebView2OnPermissionRequested(object sender, CoreWebView2PermissionRequestedEventArgs e)
        {
            Debug.WriteLine($"+++> Requested {e.PermissionKind} for uri {e.Uri}");
            var def = e.GetDeferral();
            e.State = CoreWebView2PermissionState.Default;
            e.Handled = true;
            def.Complete();
        }

        private void WebView2_PermissionRequested(object obj, CoreWebView2PermissionRequestedEventArgs args)
        {
            if (args.PermissionKind == CoreWebView2PermissionKind.Microphone || args.PermissionKind == CoreWebView2PermissionKind.Camera)
            {
                args.State = CoreWebView2PermissionState.Allow;
                args.Handled = true;
            }
        }
    }
}
