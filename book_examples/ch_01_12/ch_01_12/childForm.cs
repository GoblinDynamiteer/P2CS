using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ch_01_12
{
    public partial class childForm : Form
    {
        public childForm(string title, string fileName)
        {
            InitializeComponent();
            Text = title;
            pictureBox1.Image = Image.FromFile(
                Directory.GetCurrentDirectory() + fileName);
        }
    }
}
