using System;
using System.Windows.Forms;

namespace YTPGenDeluxe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnGenerateClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "YTPGen Deluxe preview shell is ready. Wire up processing pipelines here.",
                "Preview",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
