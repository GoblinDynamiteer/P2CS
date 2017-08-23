using System.Windows.Forms;

namespace trf
{
    public partial class frmWebBrowser : Form
    {
        /* Webaddress för Tiger på Wikipedia */
        string webpageUrlWikiTigers =
            "http://sv.wikipedia.org/wiki/Tiger";

        /* Konstruktor */
        public frmWebBrowser()
        {
            InitializeComponent();

            /* Navigera till webaddress */
            webBrowser.Navigate(webpageUrlWikiTigers);

            /* Titel på formen / fönstret */
            this.Text = "TRF WebBrowser - " + webpageUrlWikiTigers;
        }
    }
}
