using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using System.Windows.Media;
//using static System.Net.Mime.MediaTypeNames;
//using System.Net;


namespace BiljartBord
{
    public partial class ScoreBord : UserControl
    {   public bool changeBorder;
        int playerAtTable = 1;
        BordHelper bordHelper = new BordHelper();
        GeneralFunctions GenFunc = new GeneralFunctions();
        private PrivateFontCollection pfc = new PrivateFontCollection();
     //   public static PrivateFontCollection bordFonts = new PrivateFontCollection();
        

        public ScoreBord()
        {
            InitializeComponent();
            // BordHelper.SetNumberFontType();
            SetNumberLabelFont();
            CalculateMoyenne();
        }

        private void LblPlayerName_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            changeBorder = true;
            lbl.Refresh();

        }

        private void LblPlayerName_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            changeBorder = false;
            lbl.Refresh();

        }

        private void lbl_name_Paint(object sender, PaintEventArgs e)
        {
            int width = 8;

            if (changeBorder)
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                              Color.Red, width, ButtonBorderStyle.Solid, //left
                              Color.Red, width, ButtonBorderStyle.Solid, //top
                              Color.Red, width, ButtonBorderStyle.Solid, //right 
                              Color.Red, width, ButtonBorderStyle.Solid); //bottomwidth
            }
            else
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, this.BackColor, ButtonBorderStyle.None);
        }

        private void LblNumberHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = ColorTranslator.FromHtml("#FF00FF");

        }

        private void LblNumberLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.Transparent;
        }

        private void SetNumberLabelFont()
        {
            int fontSmall=150, fontLarge=210;
            pfc = (PrivateFontCollection)GenFunc.GetBordFont();

            LblplayerOne100Make.Font = new Font(pfc.Families[0], fontSmall);
            LblplayerOne10Make.Font = new Font(pfc.Families[0], fontSmall);
            LblplayerOne1Make.Font = new Font(pfc.Families[0], fontSmall);
            LblplayerOne1Carom.Font = new Font(pfc.Families[0], fontLarge);
            LblplayerOne10Carom.Font = new Font(pfc.Families[0], fontLarge);
            LblplayerOne100Carom.Font = new Font(pfc.Families[0], fontLarge);

            LblplayerTwo100Make.Font = new Font(pfc.Families[0], fontSmall);
            LblplayerTwo10Make.Font = new Font(pfc.Families[0], fontSmall);
            LblplayerTwo1Make.Font = new Font(pfc.Families[0], fontSmall);
            LblplayerTwo1Carom.Font = new Font(pfc.Families[0], fontLarge);
            LblplayerTwo10Carom.Font = new Font(pfc.Families[0], fontLarge);
            LblplayerTwo100Carom.Font = new Font(pfc.Families[0], fontLarge);
            //LblBeurten1.Font = new Font(pfc.Families[0], fontSmall);
            //LblBeurten10.Font = new Font(pfc.Families[0], fontSmall);
            //LblBeurten100.Font = new Font(pfc.Families[0], fontSmall);

            LblFooterInfo.Text = GenFunc.GetLocalIp();
            LblInning.Font = new Font(pfc.Families[0], 180);
        }



        private void SetBordNumber(string mouseClicked, Label lbl, string lTag)
        {
            var bValue = Int32.Parse(lTag);
            var labelName = Regex.Replace(lbl.Name, "[0-9]", "$");
            var count = labelName.Count(x => x == '$');
           
            var rStr = "";
            for (int i = 0; i < count; i++)
            {
                rStr += "$";
            }
            
            var lbl100 = this.Controls.Find($"{labelName.Replace(rStr, "100")}", true).FirstOrDefault() as Label;
            var lbl10 = this.Controls.Find($"{labelName.Replace(rStr, "10")}", true).FirstOrDefault() as Label;
            var lbl1 = this.Controls.Find($"{labelName.Replace(rStr, "1")}", true).FirstOrDefault() as Label;
            var hValue = Int32.Parse(lbl100.Text + lbl10.Text + lbl1.Text);

            if (mouseClicked == "Right")
            {
                bValue = bValue * -1;
            }
            
            int makeValue = hValue+bValue;
            if (makeValue < 0) return;
            string newValue = makeValue.ToString().PadLeft(3, '0');
          
            lbl100.Text = newValue.Substring(0, 1);
            lbl10.Text = newValue.Substring(1, 1);
            lbl1.Text = newValue.Substring(2, 1);

        }

        private void InningClicked(string mouseClicked, Label lbl)
        {
            int addValue = 1;
            string[] inningText = lbl.Text.Split(' ');
            string strInningValue = $"{inningText[0]}{inningText[1]}{inningText[2]}";
            int iValue = int.Parse(strInningValue);

            if(iValue == 0) return;

            if (mouseClicked == "Right")
            {
                addValue = addValue * -1;
            }
            iValue += addValue;
            string newInning = iValue.ToString().PadLeft(3, '0');
            LblInning.Text = GenFunc.SetInningsText(newInning);
            CalculateMoyenne();
        }

        private void PlayerName1Click(object sender, EventArgs e)
        {
            bordHelper.PlayerAtTable = 1;
            SetPlayerNameAtTable();
            Label lbl = sender as Label;
            changeBorder = false;
            lbl.Refresh();
        }

        private void PlayerName2Click(object sender, EventArgs e)
        {
            bordHelper.PlayerAtTable = 2;
            SetPlayerNameAtTable();
            Label lbl = sender as Label;
            changeBorder = false;
            lbl.Refresh();
        }

        private void SetPlayerNameAtTable()
        {
            if (bordHelper.PlayerAtTable == 1)
            {
                LblPlayer1Name.BackColor = Color.White;
                LblPlayer1Name.ForeColor = Color.Black;

                LblPlayer2Name.BackColor = Color.Transparent;
                LblPlayer2Name.ForeColor = Color.White;
            } else
            {
                LblPlayer1Name.BackColor = Color.Transparent;
                LblPlayer1Name.ForeColor = Color.White;

                LblPlayer2Name.BackColor = Color.White;
                LblPlayer2Name.ForeColor = Color.Black;
            }
        }

        private void LblInning_MouseDown(object sender, MouseEventArgs e)
        {
            InningClicked(e.Button.ToString(), sender as Label);
        }

        private void LblplayerNumber_MouseClick(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            var lTag = lbl.Tag.ToString();
            SetBordNumber(e.Button.ToString(), lbl, lTag);
            CalculateMoyenne();

            if (lbl.Name.IndexOf("playerTwo")> 0)
            {

            } else if (lbl.Name.IndexOf("playerTwo") > 0)
            {

            }

        }

        

        private void CalculateMoyenne()
        {
            var p1Carom = float.Parse(LblplayerOne100Carom.Text + LblplayerOne10Carom.Text + LblplayerOne1Carom.Text);
            var p1Make = float.Parse(LblplayerOne100Make.Text + LblplayerOne10Make.Text + LblplayerOne1Make.Text);
            var p2Carom = float.Parse(LblplayerTwo100Carom.Text + LblplayerTwo10Carom.Text + LblplayerTwo1Carom.Text);
            var p2Make = float.Parse(LblplayerTwo100Make.Text + LblplayerTwo10Make.Text + LblplayerTwo1Make.Text);
            //var inning = float.Parse(LblBeurten100.Text + LblBeurten10.Text + LblBeurten1.Text);
            var inning = float.Parse(LblInning.Text.Replace(" ", ""));

            float p1Moyenne = p1Carom/inning;
            float p1Perc = (p1Carom / p1Make) * 100;
            float p2Moyenne = p2Carom/inning;
            float p2Perc = (p2Carom / p2Make) * 100;
          
            LblP1Moyenne.Text = p1Moyenne.ToString("F3").Replace(",", ".");
            LblP2Moyenne.Text = p2Moyenne.ToString("F3").Replace(",", ".");
          
            if ((int)p1Perc <= 100)
            {
                PgPlayerOne.Value = (int)p1Perc;
            }
            if ((int)p2Perc <= 100)
            {
                PgPlayerTwo.Value = (int)p2Perc;
            }
            LblP1Perc.Text = p1Perc.ToString("F2").Replace(",", ".")+"%";
            LblP2Perc.Text = p2Perc.ToString("F2").Replace(",", ".")+"%";

           
        }

        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            int GameTimeHrs, GameTimeMin;
            string[] currGameTime = lblGameTime.Text.Split(':');
            GameTimeHrs = int.Parse(currGameTime[0]);
            GameTimeMin = int.Parse(currGameTime[1]);

            if (GameTimeMin == 59)
            {
                GameTimeMin = 0;
                GameTimeHrs++;
            } else
            {
                GameTimeMin++;
            }

            lblGameTime.Text = $"{GameTimeHrs.ToString().PadLeft(2, '0')}:{GameTimeMin.ToString().PadLeft(2, '0')}";

        }

        private void lblGameTime_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LblplayerTwo10Carom_Click(object sender, EventArgs e)
        {

        }

        private void LblplayerTwo10Make_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBord_Load(object sender, EventArgs e)
        {

        }

        private void LblBeurten10_Click(object sender, EventArgs e)
        {

        }

       
    }
}
