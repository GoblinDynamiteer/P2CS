using System.Windows.Forms;

namespace trf
{
    public partial class frmWebBrowser : Form
    {
        /* Webaddress för Tiger på Wikipedia */
        string webpageUrlWikiTigers =
            "http://sv.wikipedia.org/wiki/Tiger";

        public frmWebBrowser()
        {
            InitializeComponent();
            webBrowser.Navigate(webpageUrlWikiTigers);

            this.Text = "TRF: " + webpageUrlWikiTigers;
        }
    }
}
