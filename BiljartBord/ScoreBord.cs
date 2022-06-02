using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace BiljartBord
{
    public partial class ScoreBord : UserControl
    {   public bool changeBorder;
        private PrivateFontCollection pfc = new PrivateFontCollection();
        public int gameStarted;
        private bool isUnix;
        
        BordHelper bordHelper = new BordHelper();
        GeneralFunctions GenFunc = new GeneralFunctions();

        public ScoreBord()
        {
            isUnix = GenFunc.GetOs();
            InitializeComponent();
        }

        private void ScoreBord_Load(object sender, EventArgs e)
        {
            PicReclame.Image = GenFunc.ShowReclameImg();
            SetNumberLabelFont();
            ProcessCurrScore();
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
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, this.BackColor, ButtonBorderStyle.None);
            }
        }

        private void LblNumberHoverP1(object sender, EventArgs e)
        {
            if (bordHelper.PlayerAtTable == 1)
            {
                Label lbl = sender as Label;
                lbl.BackColor = ColorTranslator.FromHtml("#FF00FF");
            }
        }

        private void LblNumberHoverP2(object sender, EventArgs e)
        {
            if (bordHelper.PlayerAtTable == 2)
            {
                Label lbl = sender as Label;
                lbl.BackColor = ColorTranslator.FromHtml("#FF00FF");
            }
        }

        private void LblInningHover(object sender, EventArgs e)
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
            
            LblInning.Font = new Font(pfc.Families[0], 180);
            LblFooterInfo.Text = GenFunc.GetLocalIp();
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
                bValue *= -1;
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
            LblInning.Text = GenFunc.SetInningsText(lbl.Text, mouseClicked == "Right");
            CalculateMoyenne();
        }

        private void PlayerName1Click(object sender, EventArgs e)
        {
            bordHelper.PlayerAtTable = 1;
            SetPlayerNameAtTable();
            changeBorder = false;
            LblInning.Text = GenFunc.SetInningsText(LblInning.Text, false);
            CalculateMoyenne();
           
        }

        private void PlayerName2Click(object sender, EventArgs e)
        {
            bordHelper.PlayerAtTable = 2;
            SetPlayerNameAtTable();
            changeBorder = false;
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

        private void LblplayerNumber(object sender, MouseEventArgs e)
        {
            if (bordHelper.PlayerAtTable == 1)
            {
                Label lbl = sender as Label;
                var lTag = lbl.Tag.ToString();
                SetBordNumber(e.Button.ToString(), lbl, lTag);
                CalculateMoyenne();
                SetCurrScore();
            }
        }

        private void LblplayerNumberP2(object sender, MouseEventArgs e)
        {
            if (bordHelper.PlayerAtTable == 2)
            {
                Label lbl = sender as Label;
                var lTag = lbl.Tag.ToString();
                SetBordNumber(e.Button.ToString(), lbl, lTag);
                CalculateMoyenne();
                SetCurrScore();
            }
        }

        private bool HandleClick(Label lbl)
        {
            if (lbl.Name.IndexOf("LblplayerOne") > -1 && bordHelper.PlayerAtTable == 1)
            {
                return true;
            }
            if (lbl.Name.IndexOf("LblplayerTwo") > -1 && bordHelper.PlayerAtTable == 2)
            {
                return true;
            }
            return false;
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

            if (inning > 0)
            {
                LblP1Moyenne.Text = p1Moyenne.ToString("F3").Replace(",", ".");
                LblP2Moyenne.Text = p2Moyenne.ToString("F3").Replace(",", ".");
            } else
            {
                LblP1Moyenne.Text = "0.000";
                LblP2Moyenne.Text = "0.000";
            }

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

            SetCurrScore();
            lblGameTime.Text = $"{GameTimeHrs.ToString().PadLeft(2, '0')}:{GameTimeMin.ToString().PadLeft(2, '0')}";

        }

        private void lblGameTime_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

       
              
        /**Get and set last played data*/
        private void ProcessCurrScore()
        {
            ProcessJson.CurrScore.Root score = GenFunc.GetCurrScore();

            if (score == null)
            {
                Console.WriteLine("GEEN JSON");
                return;
            }
            var uIninng = score.Beurten.Aantal.Substring(0, 1) + " " + score.Beurten.Aantal.Substring(1, 1) + " " + score.Beurten.Aantal.Substring(2, 1);

            LblInning.Text = uIninng;
            LblPlayer1Name.Text = score.P1.Naam;
            LblplayerOne100Carom.Text = score.P1.Caram.Substring(0, 1);
            LblplayerOne10Carom.Text = score.P1.Caram.Substring(1, 1);
            LblplayerOne1Carom.Text = score.P1.Caram.Substring(2, 1);
            LblplayerOne100Make.Text = score.P1.Maken.Substring(0,1);
            LblplayerOne10Make.Text = score.P1.Maken.Substring(1,1);
            LblplayerOne1Make.Text = score.P1.Maken.Substring(2,1);

            LblPlayer2Name.Text = score.P2.Naam;
            LblplayerTwo100Carom.Text = score.P2.Caram.Substring(0, 1);
            LblplayerTwo10Carom.Text = score.P2.Caram.Substring(1, 1);
            LblplayerTwo1Carom.Text = score.P2.Caram.Substring(2, 1);
            LblplayerTwo100Make.Text = score.P2.Maken.Substring(0, 1);
            LblplayerTwo10Make.Text = score.P2.Maken.Substring(1, 1);
            LblplayerTwo1Make.Text = score.P2.Maken.Substring(2, 1);

            lblGameTime.Text = score.Spelduur.Tijd;
            bordHelper.SetPlayerAtTable(int.Parse(score.AanStoot.Speler));

            CalculateMoyenne();
           // DisablePlayerClickNumber();
            SetPlayerNameAtTable();
        }

        private void SetCurrScore()
        {
            ProcessJson.CurrScore.Root score = GenFunc.GetCurrScore();

            if (score == null) return;

            var filePath = GenFunc.bordDataFolder + @"currscore.json";
           
            score.Spelduur.Tijd = lblGameTime.Text;
            score.AanStoot.Speler = bordHelper.PlayerAtTable.ToString();
            score.Spelduur.Tijd = lblGameTime.Text;
            score.Beurten.Aantal = LblInning.Text.Replace(" ", "");
            score.P1.Caram = $"{LblplayerOne100Carom.Text}{LblplayerOne10Carom.Text}{LblplayerOne1Carom.Text}";
            score.P1.Naam = LblPlayer1Name.Text;
            score.P1.Maken = $"{LblplayerOne100Make.Text}{LblplayerOne10Make.Text}{LblplayerOne1Make.Text}";

            score.P2.Caram = $"{LblplayerTwo100Carom.Text}{LblplayerTwo10Carom.Text}{LblplayerTwo1Carom.Text}";
            score.P2.Naam = LblPlayer2Name.Text;
            score.P2.Maken = $"{LblplayerTwo100Make.Text}{LblplayerTwo10Make.Text}{LblplayerTwo1Make.Text}";


            string json = JsonConvert.SerializeObject(score, Formatting.Indented);
            File.WriteAllText(filePath, json);

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            SetCurrScore();
        }

    }
}
