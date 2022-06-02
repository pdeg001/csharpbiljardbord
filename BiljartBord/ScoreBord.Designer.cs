namespace BiljartBord
{
    partial class ScoreBord
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBord));
            this.LblPlayer1Name = new System.Windows.Forms.Label();
            this.LblPlayer2Name = new System.Windows.Forms.Label();
            this.pnlPlayer1Carom = new System.Windows.Forms.Panel();
            this.LblplayerOne1Make = new System.Windows.Forms.Label();
            this.LblplayerOne10Make = new System.Windows.Forms.Label();
            this.LblplayerOne100Make = new System.Windows.Forms.Label();
            this.LblP1MakeHeader = new System.Windows.Forms.Label();
            this.pnlPlayerOneCarom = new System.Windows.Forms.Panel();
            this.LblplayerOne1Carom = new System.Windows.Forms.Label();
            this.LblplayerOne10Carom = new System.Windows.Forms.Label();
            this.LblplayerOne100Carom = new System.Windows.Forms.Label();
            this.LblP1CaromHeader = new System.Windows.Forms.Label();
            this.pnlPlayer2Carom = new System.Windows.Forms.Panel();
            this.LblplayerTwo1Make = new System.Windows.Forms.Label();
            this.LblplayerTwo10Make = new System.Windows.Forms.Label();
            this.LblplayerTwo100Make = new System.Windows.Forms.Label();
            this.LblP2MakeHeader = new System.Windows.Forms.Label();
            this.pnlPlayerTwoCarom = new System.Windows.Forms.Panel();
            this.LblplayerTwo1Carom = new System.Windows.Forms.Label();
            this.LblplayerTwo10Carom = new System.Windows.Forms.Label();
            this.LblplayerTwo100Carom = new System.Windows.Forms.Label();
            this.Lblp2CaromHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblInning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblP1Moyenne = new System.Windows.Forms.Label();
            this.LblP1Perc = new System.Windows.Forms.Label();
            this.LblP2Perc = new System.Windows.Forms.Label();
            this.LblP2Moyenne = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblFooterInfo = new System.Windows.Forms.Label();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.PgPlayerOne = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PgPlayerTwo = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PicReclame = new System.Windows.Forms.PictureBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.pnlPlayer1Carom.SuspendLayout();
            this.pnlPlayerOneCarom.SuspendLayout();
            this.pnlPlayer2Carom.SuspendLayout();
            this.pnlPlayerTwoCarom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReclame)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPlayer1Name
            // 
            this.LblPlayer1Name.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LblPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.LblPlayer1Name.Location = new System.Drawing.Point(15, 0);
            this.LblPlayer1Name.Name = "LblPlayer1Name";
            this.LblPlayer1Name.Size = new System.Drawing.Size(672, 152);
            this.LblPlayer1Name.TabIndex = 0;
            this.LblPlayer1Name.Text = "SJAAK\r\nVAN DUIJVENVOORDE";
            this.LblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPlayer1Name.Click += new System.EventHandler(this.PlayerName1Click);
            this.LblPlayer1Name.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_name_Paint);
            this.LblPlayer1Name.MouseEnter += new System.EventHandler(this.LblPlayerName_MouseEnter);
            this.LblPlayer1Name.MouseLeave += new System.EventHandler(this.LblPlayerName_MouseLeave);
            // 
            // LblPlayer2Name
            // 
            this.LblPlayer2Name.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LblPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.LblPlayer2Name.Location = new System.Drawing.Point(1245, -1);
            this.LblPlayer2Name.Name = "LblPlayer2Name";
            this.LblPlayer2Name.Size = new System.Drawing.Size(675, 145);
            this.LblPlayer2Name.TabIndex = 1;
            this.LblPlayer2Name.Text = "SJAAK";
            this.LblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPlayer2Name.Click += new System.EventHandler(this.PlayerName2Click);
            this.LblPlayer2Name.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_name_Paint);
            this.LblPlayer2Name.MouseEnter += new System.EventHandler(this.LblPlayerName_MouseEnter);
            this.LblPlayer2Name.MouseLeave += new System.EventHandler(this.LblPlayerName_MouseLeave);
            // 
            // pnlPlayer1Carom
            // 
            this.pnlPlayer1Carom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.pnlPlayer1Carom.Controls.Add(this.LblplayerOne1Make);
            this.pnlPlayer1Carom.Controls.Add(this.LblplayerOne10Make);
            this.pnlPlayer1Carom.Controls.Add(this.LblplayerOne100Make);
            this.pnlPlayer1Carom.Controls.Add(this.LblP1MakeHeader);
            this.pnlPlayer1Carom.Location = new System.Drawing.Point(15, 151);
            this.pnlPlayer1Carom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayer1Carom.Name = "pnlPlayer1Carom";
            this.pnlPlayer1Carom.Size = new System.Drawing.Size(672, 239);
            this.pnlPlayer1Carom.TabIndex = 3;
            // 
            // LblplayerOne1Make
            // 
            this.LblplayerOne1Make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerOne1Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerOne1Make.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblplayerOne1Make.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerOne1Make.Location = new System.Drawing.Point(449, 64);
            this.LblplayerOne1Make.Name = "LblplayerOne1Make";
            this.LblplayerOne1Make.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerOne1Make.Size = new System.Drawing.Size(213, 178);
            this.LblplayerOne1Make.TabIndex = 3;
            this.LblplayerOne1Make.Tag = "1";
            this.LblplayerOne1Make.Text = "0";
            this.LblplayerOne1Make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblplayerOne1Make.UseCompatibleTextRendering = true;
            this.LblplayerOne1Make.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerOne1Make.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerOne1Make.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerOne10Make
            // 
            this.LblplayerOne10Make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerOne10Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerOne10Make.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblplayerOne10Make.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerOne10Make.Location = new System.Drawing.Point(230, 64);
            this.LblplayerOne10Make.Name = "LblplayerOne10Make";
            this.LblplayerOne10Make.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerOne10Make.Size = new System.Drawing.Size(213, 178);
            this.LblplayerOne10Make.TabIndex = 2;
            this.LblplayerOne10Make.Tag = "10";
            this.LblplayerOne10Make.Text = "3";
            this.LblplayerOne10Make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblplayerOne10Make.UseCompatibleTextRendering = true;
            this.LblplayerOne10Make.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerOne10Make.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerOne10Make.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerOne100Make
            // 
            this.LblplayerOne100Make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerOne100Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerOne100Make.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblplayerOne100Make.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerOne100Make.Location = new System.Drawing.Point(11, 64);
            this.LblplayerOne100Make.Name = "LblplayerOne100Make";
            this.LblplayerOne100Make.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerOne100Make.Size = new System.Drawing.Size(213, 178);
            this.LblplayerOne100Make.TabIndex = 1;
            this.LblplayerOne100Make.Tag = "100";
            this.LblplayerOne100Make.Text = "0";
            this.LblplayerOne100Make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblplayerOne100Make.UseCompatibleTextRendering = true;
            this.LblplayerOne100Make.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerOne100Make.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerOne100Make.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblP1MakeHeader
            // 
            this.LblP1MakeHeader.Font = new System.Drawing.Font("Segoe UI", 30.25F);
            this.LblP1MakeHeader.ForeColor = System.Drawing.Color.White;
            this.LblP1MakeHeader.Location = new System.Drawing.Point(3, 1);
            this.LblP1MakeHeader.Name = "LblP1MakeHeader";
            this.LblP1MakeHeader.Size = new System.Drawing.Size(669, 52);
            this.LblP1MakeHeader.TabIndex = 0;
            this.LblP1MakeHeader.Text = "Te maken";
            this.LblP1MakeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayerOneCarom
            // 
            this.pnlPlayerOneCarom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.pnlPlayerOneCarom.Controls.Add(this.LblplayerOne1Carom);
            this.pnlPlayerOneCarom.Controls.Add(this.LblplayerOne10Carom);
            this.pnlPlayerOneCarom.Controls.Add(this.LblplayerOne100Carom);
            this.pnlPlayerOneCarom.Controls.Add(this.LblP1CaromHeader);
            this.pnlPlayerOneCarom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.pnlPlayerOneCarom.Location = new System.Drawing.Point(15, 391);
            this.pnlPlayerOneCarom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayerOneCarom.Name = "pnlPlayerOneCarom";
            this.pnlPlayerOneCarom.Size = new System.Drawing.Size(672, 308);
            this.pnlPlayerOneCarom.TabIndex = 4;
            // 
            // LblplayerOne1Carom
            // 
            this.LblplayerOne1Carom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerOne1Carom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerOne1Carom.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblplayerOne1Carom.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerOne1Carom.Location = new System.Drawing.Point(453, 53);
            this.LblplayerOne1Carom.Name = "LblplayerOne1Carom";
            this.LblplayerOne1Carom.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerOne1Carom.Size = new System.Drawing.Size(213, 243);
            this.LblplayerOne1Carom.TabIndex = 3;
            this.LblplayerOne1Carom.Tag = "1";
            this.LblplayerOne1Carom.Text = "3";
            this.LblplayerOne1Carom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblplayerOne1Carom.UseCompatibleTextRendering = true;
            this.LblplayerOne1Carom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerOne1Carom.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerOne1Carom.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerOne10Carom
            // 
            this.LblplayerOne10Carom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerOne10Carom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerOne10Carom.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblplayerOne10Carom.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerOne10Carom.Location = new System.Drawing.Point(232, 53);
            this.LblplayerOne10Carom.Name = "LblplayerOne10Carom";
            this.LblplayerOne10Carom.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerOne10Carom.Size = new System.Drawing.Size(213, 243);
            this.LblplayerOne10Carom.TabIndex = 2;
            this.LblplayerOne10Carom.Tag = "10";
            this.LblplayerOne10Carom.Text = "1";
            this.LblplayerOne10Carom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblplayerOne10Carom.UseCompatibleTextRendering = true;
            this.LblplayerOne10Carom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerOne10Carom.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerOne10Carom.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerOne100Carom
            // 
            this.LblplayerOne100Carom.BackColor = System.Drawing.Color.Transparent;
            this.LblplayerOne100Carom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerOne100Carom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerOne100Carom.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblplayerOne100Carom.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerOne100Carom.Location = new System.Drawing.Point(11, 53);
            this.LblplayerOne100Carom.Name = "LblplayerOne100Carom";
            this.LblplayerOne100Carom.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerOne100Carom.Size = new System.Drawing.Size(213, 243);
            this.LblplayerOne100Carom.TabIndex = 1;
            this.LblplayerOne100Carom.Tag = "100";
            this.LblplayerOne100Carom.Text = "0";
            this.LblplayerOne100Carom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblplayerOne100Carom.UseCompatibleTextRendering = true;
            this.LblplayerOne100Carom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerOne100Carom.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerOne100Carom.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblP1CaromHeader
            // 
            this.LblP1CaromHeader.Font = new System.Drawing.Font("Segoe UI", 30.25F);
            this.LblP1CaromHeader.ForeColor = System.Drawing.Color.White;
            this.LblP1CaromHeader.Location = new System.Drawing.Point(3, 1);
            this.LblP1CaromHeader.Name = "LblP1CaromHeader";
            this.LblP1CaromHeader.Size = new System.Drawing.Size(666, 52);
            this.LblP1CaromHeader.TabIndex = 0;
            this.LblP1CaromHeader.Text = "Caramboles";
            this.LblP1CaromHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayer2Carom
            // 
            this.pnlPlayer2Carom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.pnlPlayer2Carom.Controls.Add(this.LblplayerTwo1Make);
            this.pnlPlayer2Carom.Controls.Add(this.LblplayerTwo10Make);
            this.pnlPlayer2Carom.Controls.Add(this.LblplayerTwo100Make);
            this.pnlPlayer2Carom.Controls.Add(this.LblP2MakeHeader);
            this.pnlPlayer2Carom.Location = new System.Drawing.Point(1246, 146);
            this.pnlPlayer2Carom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayer2Carom.Name = "pnlPlayer2Carom";
            this.pnlPlayer2Carom.Size = new System.Drawing.Size(674, 242);
            this.pnlPlayer2Carom.TabIndex = 4;
            // 
            // LblplayerTwo1Make
            // 
            this.LblplayerTwo1Make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerTwo1Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerTwo1Make.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblplayerTwo1Make.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerTwo1Make.Location = new System.Drawing.Point(455, 64);
            this.LblplayerTwo1Make.Name = "LblplayerTwo1Make";
            this.LblplayerTwo1Make.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerTwo1Make.Size = new System.Drawing.Size(213, 178);
            this.LblplayerTwo1Make.TabIndex = 3;
            this.LblplayerTwo1Make.Tag = "1";
            this.LblplayerTwo1Make.Text = "0";
            this.LblplayerTwo1Make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblplayerTwo1Make.UseCompatibleTextRendering = true;
            this.LblplayerTwo1Make.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerTwo1Make.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerTwo1Make.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerTwo10Make
            // 
            this.LblplayerTwo10Make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerTwo10Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerTwo10Make.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblplayerTwo10Make.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerTwo10Make.Location = new System.Drawing.Point(235, 64);
            this.LblplayerTwo10Make.Name = "LblplayerTwo10Make";
            this.LblplayerTwo10Make.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerTwo10Make.Size = new System.Drawing.Size(213, 178);
            this.LblplayerTwo10Make.TabIndex = 2;
            this.LblplayerTwo10Make.Tag = "10";
            this.LblplayerTwo10Make.Text = "1";
            this.LblplayerTwo10Make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblplayerTwo10Make.UseCompatibleTextRendering = true;
            this.LblplayerTwo10Make.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerTwo10Make.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerTwo10Make.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerTwo100Make
            // 
            this.LblplayerTwo100Make.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerTwo100Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerTwo100Make.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblplayerTwo100Make.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerTwo100Make.Location = new System.Drawing.Point(15, 64);
            this.LblplayerTwo100Make.Name = "LblplayerTwo100Make";
            this.LblplayerTwo100Make.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerTwo100Make.Size = new System.Drawing.Size(213, 178);
            this.LblplayerTwo100Make.TabIndex = 1;
            this.LblplayerTwo100Make.Tag = "100";
            this.LblplayerTwo100Make.Text = "0";
            this.LblplayerTwo100Make.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblplayerTwo100Make.UseCompatibleTextRendering = true;
            this.LblplayerTwo100Make.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerTwo100Make.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerTwo100Make.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblP2MakeHeader
            // 
            this.LblP2MakeHeader.Font = new System.Drawing.Font("Segoe UI", 30.25F);
            this.LblP2MakeHeader.ForeColor = System.Drawing.Color.White;
            this.LblP2MakeHeader.Location = new System.Drawing.Point(3, 1);
            this.LblP2MakeHeader.Name = "LblP2MakeHeader";
            this.LblP2MakeHeader.Size = new System.Drawing.Size(668, 52);
            this.LblP2MakeHeader.TabIndex = 0;
            this.LblP2MakeHeader.Text = "Te maken";
            this.LblP2MakeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayerTwoCarom
            // 
            this.pnlPlayerTwoCarom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.pnlPlayerTwoCarom.Controls.Add(this.LblplayerTwo1Carom);
            this.pnlPlayerTwoCarom.Controls.Add(this.LblplayerTwo10Carom);
            this.pnlPlayerTwoCarom.Controls.Add(this.LblplayerTwo100Carom);
            this.pnlPlayerTwoCarom.Controls.Add(this.Lblp2CaromHeader);
            this.pnlPlayerTwoCarom.Location = new System.Drawing.Point(1245, 392);
            this.pnlPlayerTwoCarom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPlayerTwoCarom.Name = "pnlPlayerTwoCarom";
            this.pnlPlayerTwoCarom.Size = new System.Drawing.Size(672, 308);
            this.pnlPlayerTwoCarom.TabIndex = 5;
            // 
            // LblplayerTwo1Carom
            // 
            this.LblplayerTwo1Carom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerTwo1Carom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerTwo1Carom.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblplayerTwo1Carom.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerTwo1Carom.Location = new System.Drawing.Point(455, 53);
            this.LblplayerTwo1Carom.Name = "LblplayerTwo1Carom";
            this.LblplayerTwo1Carom.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerTwo1Carom.Size = new System.Drawing.Size(213, 251);
            this.LblplayerTwo1Carom.TabIndex = 3;
            this.LblplayerTwo1Carom.Tag = "1";
            this.LblplayerTwo1Carom.Text = "0";
            this.LblplayerTwo1Carom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblplayerTwo1Carom.UseCompatibleTextRendering = true;
            this.LblplayerTwo1Carom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerTwo1Carom.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerTwo1Carom.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerTwo10Carom
            // 
            this.LblplayerTwo10Carom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblplayerTwo10Carom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerTwo10Carom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerTwo10Carom.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblplayerTwo10Carom.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerTwo10Carom.Location = new System.Drawing.Point(235, 53);
            this.LblplayerTwo10Carom.Name = "LblplayerTwo10Carom";
            this.LblplayerTwo10Carom.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerTwo10Carom.Size = new System.Drawing.Size(213, 251);
            this.LblplayerTwo10Carom.TabIndex = 2;
            this.LblplayerTwo10Carom.Tag = "10";
            this.LblplayerTwo10Carom.Text = "0";
            this.LblplayerTwo10Carom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblplayerTwo10Carom.UseCompatibleTextRendering = true;
            this.LblplayerTwo10Carom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerTwo10Carom.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerTwo10Carom.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // LblplayerTwo100Carom
            // 
            this.LblplayerTwo100Carom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblplayerTwo100Carom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblplayerTwo100Carom.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblplayerTwo100Carom.ForeColor = System.Drawing.Color.Yellow;
            this.LblplayerTwo100Carom.Location = new System.Drawing.Point(15, 53);
            this.LblplayerTwo100Carom.Name = "LblplayerTwo100Carom";
            this.LblplayerTwo100Carom.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblplayerTwo100Carom.Size = new System.Drawing.Size(213, 251);
            this.LblplayerTwo100Carom.TabIndex = 1;
            this.LblplayerTwo100Carom.Tag = "100";
            this.LblplayerTwo100Carom.Text = "0";
            this.LblplayerTwo100Carom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblplayerTwo100Carom.UseCompatibleTextRendering = true;
            this.LblplayerTwo100Carom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblplayerNumber_MouseClick);
            this.LblplayerTwo100Carom.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblplayerTwo100Carom.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // Lblp2CaromHeader
            // 
            this.Lblp2CaromHeader.Font = new System.Drawing.Font("Segoe UI", 30.25F);
            this.Lblp2CaromHeader.ForeColor = System.Drawing.Color.White;
            this.Lblp2CaromHeader.Location = new System.Drawing.Point(3, 1);
            this.Lblp2CaromHeader.Name = "Lblp2CaromHeader";
            this.Lblp2CaromHeader.Size = new System.Drawing.Size(666, 52);
            this.Lblp2CaromHeader.TabIndex = 0;
            this.Lblp2CaromHeader.Text = "Caramboles";
            this.Lblp2CaromHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.LblInning);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(698, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 304);
            this.panel1.TabIndex = 5;
            // 
            // LblInning
            // 
            this.LblInning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblInning.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.LblInning.ForeColor = System.Drawing.Color.Yellow;
            this.LblInning.Location = new System.Drawing.Point(16, 60);
            this.LblInning.Name = "LblInning";
            this.LblInning.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.LblInning.Size = new System.Drawing.Size(496, 243);
            this.LblInning.TabIndex = 4;
            this.LblInning.Tag = "10";
            this.LblInning.Text = "0 1 3";
            this.LblInning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblInning.UseCompatibleTextRendering = true;
            this.LblInning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblInning_MouseDown);
            this.LblInning.MouseEnter += new System.EventHandler(this.LblNumberHover);
            this.LblInning.MouseLeave += new System.EventHandler(this.LblNumberLeave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 30.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(522, 52);
            this.label7.TabIndex = 0;
            this.label7.Text = "Beurten";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(699, 721);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 100);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moyenne";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(699, 829);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 100);
            this.label3.TabIndex = 7;
            this.label3.Text = "Percentage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblP1Moyenne
            // 
            this.LblP1Moyenne.BackColor = System.Drawing.Color.White;
            this.LblP1Moyenne.Font = new System.Drawing.Font("Verdana", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblP1Moyenne.ForeColor = System.Drawing.Color.Black;
            this.LblP1Moyenne.Location = new System.Drawing.Point(10, 721);
            this.LblP1Moyenne.Name = "LblP1Moyenne";
            this.LblP1Moyenne.Size = new System.Drawing.Size(659, 100);
            this.LblP1Moyenne.TabIndex = 8;
            this.LblP1Moyenne.Text = "10.000";
            this.LblP1Moyenne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblP1Perc
            // 
            this.LblP1Perc.BackColor = System.Drawing.Color.White;
            this.LblP1Perc.Font = new System.Drawing.Font("Verdana", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblP1Perc.ForeColor = System.Drawing.Color.Black;
            this.LblP1Perc.Location = new System.Drawing.Point(10, 829);
            this.LblP1Perc.Name = "LblP1Perc";
            this.LblP1Perc.Size = new System.Drawing.Size(659, 100);
            this.LblP1Perc.TabIndex = 9;
            this.LblP1Perc.Text = "33.33%";
            this.LblP1Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblP2Perc
            // 
            this.LblP2Perc.BackColor = System.Drawing.Color.White;
            this.LblP2Perc.Font = new System.Drawing.Font("Verdana", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblP2Perc.ForeColor = System.Drawing.Color.Black;
            this.LblP2Perc.Location = new System.Drawing.Point(1259, 827);
            this.LblP2Perc.Name = "LblP2Perc";
            this.LblP2Perc.Size = new System.Drawing.Size(658, 100);
            this.LblP2Perc.TabIndex = 11;
            this.LblP2Perc.Text = "0.00%";
            this.LblP2Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblP2Moyenne
            // 
            this.LblP2Moyenne.BackColor = System.Drawing.Color.White;
            this.LblP2Moyenne.Font = new System.Drawing.Font("Verdana", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblP2Moyenne.ForeColor = System.Drawing.Color.Black;
            this.LblP2Moyenne.Location = new System.Drawing.Point(1259, 721);
            this.LblP2Moyenne.Name = "LblP2Moyenne";
            this.LblP2Moyenne.Size = new System.Drawing.Size(658, 100);
            this.LblP2Moyenne.TabIndex = 10;
            this.LblP2Moyenne.Text = "0.000";
            this.LblP2Moyenne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(838, 933);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 42);
            this.label12.TabIndex = 12;
            this.label12.Text = "Partij Duur";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameTime
            // 
            this.lblGameTime.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTime.Font = new System.Drawing.Font("Verdana", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGameTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblGameTime.Location = new System.Drawing.Point(809, 990);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(309, 73);
            this.lblGameTime.TabIndex = 13;
            this.lblGameTime.Text = "01:26";
            this.lblGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblGameTime_MouseDown);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 990);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(253, 63);
            this.label14.TabIndex = 14;
            this.label14.Text = "Reset";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1499, 990);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(405, 63);
            this.label15.TabIndex = 15;
            this.label15.Text = "Partij Beëindigen";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFooterInfo
            // 
            this.LblFooterInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFooterInfo.ForeColor = System.Drawing.Color.LightGray;
            this.LblFooterInfo.Location = new System.Drawing.Point(1801, 1052);
            this.LblFooterInfo.Name = "LblFooterInfo";
            this.LblFooterInfo.Size = new System.Drawing.Size(103, 28);
            this.LblFooterInfo.TabIndex = 16;
            this.LblFooterInfo.Text = "192.168.1.31";
            this.LblFooterInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Enabled = true;
            this.tmrGameTime.Interval = 60000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // PgPlayerOne
            // 
            this.PgPlayerOne.ForeColor = System.Drawing.Color.Lime;
            this.PgPlayerOne.Location = new System.Drawing.Point(10, 705);
            this.PgPlayerOne.Name = "PgPlayerOne";
            this.PgPlayerOne.Size = new System.Drawing.Size(659, 15);
            this.PgPlayerOne.Step = 1;
            this.PgPlayerOne.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgPlayerOne.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PgPlayerTwo
            // 
            this.PgPlayerTwo.ForeColor = System.Drawing.Color.Lime;
            this.PgPlayerTwo.Location = new System.Drawing.Point(1258, 705);
            this.PgPlayerTwo.Name = "PgPlayerTwo";
            this.PgPlayerTwo.Size = new System.Drawing.Size(659, 15);
            this.PgPlayerTwo.Step = 1;
            this.PgPlayerTwo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgPlayerTwo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(0, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1920, 557);
            this.label1.TabIndex = 21;
            // 
            // PicReclame
            // 
            this.PicReclame.Image = ((System.Drawing.Image)(resources.GetObject("PicReclame.Image")));
            this.PicReclame.Location = new System.Drawing.Point(703, 2);
            this.PicReclame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicReclame.Name = "PicReclame";
            this.PicReclame.Size = new System.Drawing.Size(526, 316);
            this.PicReclame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicReclame.TabIndex = 2;
            this.PicReclame.TabStop = false;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(412, 990);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 22;
            this.BtnTest.Text = "Test Knopje";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // ScoreBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPlayer2Carom);
            this.Controls.Add(this.pnlPlayerOneCarom);
            this.Controls.Add(this.pnlPlayer1Carom);
            this.Controls.Add(this.pnlPlayerTwoCarom);
            this.Controls.Add(this.PicReclame);
            this.Controls.Add(this.PgPlayerTwo);
            this.Controls.Add(this.PgPlayerOne);
            this.Controls.Add(this.LblFooterInfo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblGameTime);
            this.Controls.Add(this.LblP2Perc);
            this.Controls.Add(this.LblP2Moyenne);
            this.Controls.Add(this.LblP1Perc);
            this.Controls.Add(this.LblP1Moyenne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPlayer2Name);
            this.Controls.Add(this.LblPlayer1Name);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ScoreBord";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.ScoreBord_Load);
            this.pnlPlayer1Carom.ResumeLayout(false);
            this.pnlPlayerOneCarom.ResumeLayout(false);
            this.pnlPlayer2Carom.ResumeLayout(false);
            this.pnlPlayerTwoCarom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReclame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblPlayer1Name;
        private System.Windows.Forms.Label LblPlayer2Name;
        private System.Windows.Forms.PictureBox PicReclame;
        private System.Windows.Forms.Panel pnlPlayer1Carom;
        private System.Windows.Forms.Label LblP1MakeHeader;
        private System.Windows.Forms.Label LblplayerOne1Make;
        private System.Windows.Forms.Label LblplayerOne10Make;
        private System.Windows.Forms.Label LblplayerOne100Make;
        private System.Windows.Forms.Panel pnlPlayerOneCarom;
        private System.Windows.Forms.Label LblplayerOne1Carom;
        private System.Windows.Forms.Label LblplayerOne10Carom;
        private System.Windows.Forms.Label LblplayerOne100Carom;
        private System.Windows.Forms.Label LblP1CaromHeader;
        private System.Windows.Forms.Panel pnlPlayer2Carom;
        private System.Windows.Forms.Label LblplayerTwo1Make;
        private System.Windows.Forms.Label LblplayerTwo10Make;
        private System.Windows.Forms.Label LblplayerTwo100Make;
        private System.Windows.Forms.Label LblP2MakeHeader;
        private System.Windows.Forms.Panel pnlPlayerTwoCarom;
        private System.Windows.Forms.Label LblplayerTwo1Carom;
        private System.Windows.Forms.Label LblplayerTwo10Carom;
        private System.Windows.Forms.Label LblplayerTwo100Carom;
        private System.Windows.Forms.Label Lblp2CaromHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblP1Moyenne;
        private System.Windows.Forms.Label LblP1Perc;
        private System.Windows.Forms.Label LblP2Perc;
        private System.Windows.Forms.Label LblP2Moyenne;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblFooterInfo;
        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.ProgressBar PgPlayerOne;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar PgPlayerTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblInning;
        private System.Windows.Forms.Button BtnTest;
    }
}
