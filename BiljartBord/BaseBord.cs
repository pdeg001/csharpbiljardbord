using System;
using System.Windows.Forms;

namespace BiljartBord
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBiljartPanel();
        }

        private void LoadBiljartPanel()
        {
            var bord = new ScoreBord();
            pnlMain.Controls.Add(bord);
        }
    }
}
