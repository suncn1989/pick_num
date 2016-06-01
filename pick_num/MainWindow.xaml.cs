using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mshtml;


namespace pick_num
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://518ek.com");
            webBrowser1.LoadCompleted += new LoadCompletedEventHandler(webBrowser1_LoadCompleted);

            /*
            IHTMLDocument2 doc2 = (IHTMLDocument2)webBrowser1.Document;
            if (doc2.body.innerHTML != null)
            {
                Console.Write(doc2.body.innerHTML);
            }
            IHTMLDocument2 tbUserid = webBrowser1.Document;
            IHTMLDocument2 tbPasswd = webBrowser1.Document.All["password"]; 
             */
        }

        private void webBrowser1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            //throw new NotImplementedException();
            IHTMLDocument2 dom = (IHTMLDocument2)webBrowser1.Document;
            mshtml.IHTMLElementCollection inputs;
            inputs = dom.all.tags("INPUT");

            mshtml.IHTMLElement element_usrname = (mshtml.IHTMLElement)inputs.item("username", 0);
            mshtml.IHTMLInputElement inputElement_username = (mshtml.IHTMLInputElement)element_usrname;
            inputElement_username.value = "301aaa";

            mshtml.IHTMLElement element_pwd = (mshtml.IHTMLElement)inputs.item("pwd", 0);
            mshtml.IHTMLInputElement inputElement_pwd = (mshtml.IHTMLInputElement)element_pwd;
            inputElement_pwd.value = "qwe123123";

            //dom.all.item("password", 222);
            //IHTMLDocument2 tbUserid = (IHTMLDocument2)webBrowser1.Document.;
            //IHTMLDocument2 tbPasswd = (IHTMLDocument2)webBrowser1.Document.All["password"]; 

        }
    }
}
