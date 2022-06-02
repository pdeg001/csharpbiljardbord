using System;
using System.Windows.Forms;

namespace BiljartBord
{
    public partial class MainForm : Form
    {
        GeneralFunctions GenFunc = new GeneralFunctions();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GenFunc.GetOs())
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            LoadBiljartPanel();
        }

        private void LoadBiljartPanel()
        {
            var bord = new ScoreBord();
            pnlMain.Controls.Add(bord);
        }
    }
}
