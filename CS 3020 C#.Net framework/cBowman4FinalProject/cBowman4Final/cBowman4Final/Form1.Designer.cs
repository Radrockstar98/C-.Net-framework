namespace cBowman4Final
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameLog = new System.Windows.Forms.TextBox();
            this.attackBtn = new System.Windows.Forms.Button();
            this.defendBtn = new System.Windows.Forms.Button();
            this.specialBtn = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_Item_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Item_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Item_About_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Item_About_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerPictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerPictureBox3 = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox3 = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox2 = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox1 = new System.Windows.Forms.PictureBox();
            this.enemyHealthBar2 = new System.Windows.Forms.ProgressBar();
            this.startBtn = new System.Windows.Forms.Button();
            this.enemyHealthBar3 = new System.Windows.Forms.ProgressBar();
            this.enemyHealthBar1 = new System.Windows.Forms.ProgressBar();
            this.warriorLbl = new System.Windows.Forms.Label();
            this.mageLbl = new System.Windows.Forms.Label();
            this.clericLbl = new System.Windows.Forms.Label();
            this.enemyImageList = new System.Windows.Forms.ImageList(this.components);
            this.mageHealthBar = new System.Windows.Forms.ProgressBar();
            this.mageHealthLbl = new System.Windows.Forms.Label();
            this.warriorHealthLbl = new System.Windows.Forms.Label();
            this.warriorHealthBar = new System.Windows.Forms.ProgressBar();
            this.clericHealthLbl = new System.Windows.Forms.Label();
            this.clericHealthBar = new System.Windows.Forms.ProgressBar();
            this.restartBtn = new System.Windows.Forms.Button();
            this.highestScoreLbl = new System.Windows.Forms.Label();
            this.highestLevelPassedLbl = new System.Windows.Forms.Label();
            this.scoreTxt = new System.Windows.Forms.TextBox();
            this.highestLevelTxt = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLog
            // 
            this.gameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLog.Location = new System.Drawing.Point(486, 403);
            this.gameLog.Multiline = true;
            this.gameLog.Name = "gameLog";
            this.gameLog.ReadOnly = true;
            this.gameLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameLog.Size = new System.Drawing.Size(395, 186);
            this.gameLog.TabIndex = 0;
            // 
            // attackBtn
            // 
            this.attackBtn.BackColor = System.Drawing.Color.Yellow;
            this.attackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.attackBtn.Location = new System.Drawing.Point(311, 395);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(96, 47);
            this.attackBtn.TabIndex = 1;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = false;
            // 
            // defendBtn
            // 
            this.defendBtn.BackColor = System.Drawing.Color.Yellow;
            this.defendBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defendBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.defendBtn.Location = new System.Drawing.Point(311, 471);
            this.defendBtn.Name = "defendBtn";
            this.defendBtn.Size = new System.Drawing.Size(96, 47);
            this.defendBtn.TabIndex = 2;
            this.defendBtn.Text = "Defend";
            this.defendBtn.UseVisualStyleBackColor = false;
            // 
            // specialBtn
            // 
            this.specialBtn.BackColor = System.Drawing.Color.Yellow;
            this.specialBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.specialBtn.Location = new System.Drawing.Point(311, 538);
            this.specialBtn.Name = "specialBtn";
            this.specialBtn.Size = new System.Drawing.Size(96, 47);
            this.specialBtn.TabIndex = 3;
            this.specialBtn.Text = "Special";
            this.specialBtn.UseVisualStyleBackColor = false;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Yellow;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(481, 375);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(153, 25);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Adventure Log";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Item_Quit,
            this.menu_Item_About});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(885, 28);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menu_Item_Quit
            // 
            this.menu_Item_Quit.Name = "menu_Item_Quit";
            this.menu_Item_Quit.Size = new System.Drawing.Size(51, 24);
            this.menu_Item_Quit.Text = "Quit";
            // 
            // menu_Item_About
            // 
            this.menu_Item_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Item_About_Info,
            this.menu_Item_About_Profile});
            this.menu_Item_About.Name = "menu_Item_About";
            this.menu_Item_About.Size = new System.Drawing.Size(64, 24);
            this.menu_Item_About.Text = "About";
            // 
            // menu_Item_About_Info
            // 
            this.menu_Item_About_Info.Name = "menu_Item_About_Info";
            this.menu_Item_About_Info.Size = new System.Drawing.Size(165, 26);
            this.menu_Item_About_Info.Text = "Info";
            // 
            // menu_Item_About_Profile
            // 
            this.menu_Item_About_Profile.Name = "menu_Item_About_Profile";
            this.menu_Item_About_Profile.Size = new System.Drawing.Size(165, 26);
            this.menu_Item_About_Profile.Text = "Dev Profile";
            // 
            // playerPictureBox1
            // 
            this.playerPictureBox1.BackColor = System.Drawing.Color.Green;
            this.playerPictureBox1.Location = new System.Drawing.Point(181, 188);
            this.playerPictureBox1.Name = "playerPictureBox1";
            this.playerPictureBox1.Size = new System.Drawing.Size(67, 69);
            this.playerPictureBox1.TabIndex = 9;
            this.playerPictureBox1.TabStop = false;
            // 
            // playerPictureBox2
            // 
            this.playerPictureBox2.BackColor = System.Drawing.Color.Green;
            this.playerPictureBox2.Location = new System.Drawing.Point(101, 90);
            this.playerPictureBox2.Name = "playerPictureBox2";
            this.playerPictureBox2.Size = new System.Drawing.Size(67, 70);
            this.playerPictureBox2.TabIndex = 10;
            this.playerPictureBox2.TabStop = false;
            // 
            // playerPictureBox3
            // 
            this.playerPictureBox3.BackColor = System.Drawing.Color.Green;
            this.playerPictureBox3.Location = new System.Drawing.Point(101, 284);
            this.playerPictureBox3.Name = "playerPictureBox3";
            this.playerPictureBox3.Size = new System.Drawing.Size(67, 68);
            this.playerPictureBox3.TabIndex = 11;
            this.playerPictureBox3.TabStop = false;
            // 
            // enemyPictureBox3
            // 
            this.enemyPictureBox3.Location = new System.Drawing.Point(683, 284);
            this.enemyPictureBox3.Name = "enemyPictureBox3";
            this.enemyPictureBox3.Size = new System.Drawing.Size(66, 68);
            this.enemyPictureBox3.TabIndex = 14;
            this.enemyPictureBox3.TabStop = false;
            // 
            // enemyPictureBox2
            // 
            this.enemyPictureBox2.Location = new System.Drawing.Point(683, 90);
            this.enemyPictureBox2.Name = "enemyPictureBox2";
            this.enemyPictureBox2.Size = new System.Drawing.Size(66, 70);
            this.enemyPictureBox2.TabIndex = 13;
            this.enemyPictureBox2.TabStop = false;
            // 
            // enemyPictureBox1
            // 
            this.enemyPictureBox1.Location = new System.Drawing.Point(598, 188);
            this.enemyPictureBox1.Name = "enemyPictureBox1";
            this.enemyPictureBox1.Size = new System.Drawing.Size(66, 69);
            this.enemyPictureBox1.TabIndex = 12;
            this.enemyPictureBox1.TabStop = false;
            // 
            // enemyHealthBar2
            // 
            this.enemyHealthBar2.Location = new System.Drawing.Point(598, 215);
            this.enemyHealthBar2.Name = "enemyHealthBar2";
            this.enemyHealthBar2.Size = new System.Drawing.Size(66, 23);
            this.enemyHealthBar2.TabIndex = 16;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Yellow;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(342, 189);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(130, 80);
            this.startBtn.TabIndex = 21;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // enemyHealthBar3
            // 
            this.enemyHealthBar3.Location = new System.Drawing.Point(683, 312);
            this.enemyHealthBar3.Name = "enemyHealthBar3";
            this.enemyHealthBar3.Size = new System.Drawing.Size(66, 23);
            this.enemyHealthBar3.TabIndex = 17;
            // 
            // enemyHealthBar1
            // 
            this.enemyHealthBar1.Location = new System.Drawing.Point(683, 111);
            this.enemyHealthBar1.Name = "enemyHealthBar1";
            this.enemyHealthBar1.Size = new System.Drawing.Size(66, 23);
            this.enemyHealthBar1.TabIndex = 15;
            // 
            // warriorLbl
            // 
            this.warriorLbl.AutoSize = true;
            this.warriorLbl.BackColor = System.Drawing.Color.Black;
            this.warriorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warriorLbl.ForeColor = System.Drawing.Color.Yellow;
            this.warriorLbl.Location = new System.Drawing.Point(165, 471);
            this.warriorLbl.Name = "warriorLbl";
            this.warriorLbl.Size = new System.Drawing.Size(83, 25);
            this.warriorLbl.TabIndex = 25;
            this.warriorLbl.Text = "Warrior";
            // 
            // mageLbl
            // 
            this.mageLbl.AutoSize = true;
            this.mageLbl.BackColor = System.Drawing.Color.Black;
            this.mageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mageLbl.ForeColor = System.Drawing.Color.Yellow;
            this.mageLbl.Location = new System.Drawing.Point(165, 395);
            this.mageLbl.Name = "mageLbl";
            this.mageLbl.Size = new System.Drawing.Size(66, 25);
            this.mageLbl.TabIndex = 26;
            this.mageLbl.Text = "Mage";
            // 
            // clericLbl
            // 
            this.clericLbl.AutoSize = true;
            this.clericLbl.BackColor = System.Drawing.Color.Black;
            this.clericLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clericLbl.ForeColor = System.Drawing.Color.Yellow;
            this.clericLbl.Location = new System.Drawing.Point(165, 547);
            this.clericLbl.Name = "clericLbl";
            this.clericLbl.Size = new System.Drawing.Size(68, 25);
            this.clericLbl.TabIndex = 27;
            this.clericLbl.Text = "Cleric";
            // 
            // enemyImageList
            // 
            this.enemyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("enemyImageList.ImageStream")));
            this.enemyImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.enemyImageList.Images.SetKeyName(0, "Bandit.png");
            this.enemyImageList.Images.SetKeyName(1, "Ogre.png");
            this.enemyImageList.Images.SetKeyName(2, "Dragon.png");
            // 
            // mageHealthBar
            // 
            this.mageHealthBar.Location = new System.Drawing.Point(28, 395);
            this.mageHealthBar.Name = "mageHealthBar";
            this.mageHealthBar.Size = new System.Drawing.Size(100, 23);
            this.mageHealthBar.TabIndex = 29;
            // 
            // mageHealthLbl
            // 
            this.mageHealthLbl.AutoSize = true;
            this.mageHealthLbl.Location = new System.Drawing.Point(25, 375);
            this.mageHealthLbl.Name = "mageHealthLbl";
            this.mageHealthLbl.Size = new System.Drawing.Size(46, 17);
            this.mageHealthLbl.TabIndex = 30;
            this.mageHealthLbl.Text = "label1";
            // 
            // warriorHealthLbl
            // 
            this.warriorHealthLbl.AutoSize = true;
            this.warriorHealthLbl.Location = new System.Drawing.Point(25, 451);
            this.warriorHealthLbl.Name = "warriorHealthLbl";
            this.warriorHealthLbl.Size = new System.Drawing.Size(46, 17);
            this.warriorHealthLbl.TabIndex = 32;
            this.warriorHealthLbl.Text = "label1";
            // 
            // warriorHealthBar
            // 
            this.warriorHealthBar.Location = new System.Drawing.Point(28, 471);
            this.warriorHealthBar.Name = "warriorHealthBar";
            this.warriorHealthBar.Size = new System.Drawing.Size(100, 23);
            this.warriorHealthBar.TabIndex = 31;
            // 
            // clericHealthLbl
            // 
            this.clericHealthLbl.AutoSize = true;
            this.clericHealthLbl.Location = new System.Drawing.Point(25, 522);
            this.clericHealthLbl.Name = "clericHealthLbl";
            this.clericHealthLbl.Size = new System.Drawing.Size(46, 17);
            this.clericHealthLbl.TabIndex = 34;
            this.clericHealthLbl.Text = "label1";
            // 
            // clericHealthBar
            // 
            this.clericHealthBar.Location = new System.Drawing.Point(28, 542);
            this.clericHealthBar.Name = "clericHealthBar";
            this.clericHealthBar.Size = new System.Drawing.Size(100, 23);
            this.clericHealthBar.TabIndex = 33;
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.Yellow;
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(342, 189);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(130, 80);
            this.restartBtn.TabIndex = 35;
            this.restartBtn.Text = "Restart Game";
            this.restartBtn.UseVisualStyleBackColor = false;
            // 
            // highestScoreLbl
            // 
            this.highestScoreLbl.AutoSize = true;
            this.highestScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScoreLbl.Location = new System.Drawing.Point(205, 41);
            this.highestScoreLbl.Name = "highestScoreLbl";
            this.highestScoreLbl.Size = new System.Drawing.Size(135, 20);
            this.highestScoreLbl.TabIndex = 37;
            this.highestScoreLbl.Text = "Highest Score:";
            // 
            // highestLevelPassedLbl
            // 
            this.highestLevelPassedLbl.AutoSize = true;
            this.highestLevelPassedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestLevelPassedLbl.Location = new System.Drawing.Point(502, 41);
            this.highestLevelPassedLbl.Name = "highestLevelPassedLbl";
            this.highestLevelPassedLbl.Size = new System.Drawing.Size(199, 20);
            this.highestLevelPassedLbl.TabIndex = 38;
            this.highestLevelPassedLbl.Text = "Highest Level Passed:";
            // 
            // scoreTxt
            // 
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(209, 65);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.ReadOnly = true;
            this.scoreTxt.Size = new System.Drawing.Size(100, 22);
            this.scoreTxt.TabIndex = 39;
            // 
            // highestLevelTxt
            // 
            this.highestLevelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestLevelTxt.Location = new System.Drawing.Point(501, 65);
            this.highestLevelTxt.Name = "highestLevelTxt";
            this.highestLevelTxt.ReadOnly = true;
            this.highestLevelTxt.Size = new System.Drawing.Size(100, 22);
            this.highestLevelTxt.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::cBowman4Final.Properties.Resources.back_cave;
            this.ClientSize = new System.Drawing.Size(885, 610);
            this.Controls.Add(this.highestLevelTxt);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.highestLevelPassedLbl);
            this.Controls.Add(this.highestScoreLbl);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.clericHealthLbl);
            this.Controls.Add(this.clericHealthBar);
            this.Controls.Add(this.warriorHealthLbl);
            this.Controls.Add(this.warriorHealthBar);
            this.Controls.Add(this.mageHealthLbl);
            this.Controls.Add(this.mageHealthBar);
            this.Controls.Add(this.clericLbl);
            this.Controls.Add(this.mageLbl);
            this.Controls.Add(this.warriorLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.enemyHealthBar3);
            this.Controls.Add(this.enemyHealthBar2);
            this.Controls.Add(this.enemyHealthBar1);
            this.Controls.Add(this.enemyPictureBox3);
            this.Controls.Add(this.enemyPictureBox2);
            this.Controls.Add(this.enemyPictureBox1);
            this.Controls.Add(this.playerPictureBox3);
            this.Controls.Add(this.playerPictureBox2);
            this.Controls.Add(this.playerPictureBox1);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.specialBtn);
            this.Controls.Add(this.defendBtn);
            this.Controls.Add(this.attackBtn);
            this.Controls.Add(this.gameLog);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "RPG Adventure";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameLog;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button defendBtn;
        private System.Windows.Forms.Button specialBtn;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_Quit;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_About_Info;
        private System.Windows.Forms.PictureBox playerPictureBox1;
        private System.Windows.Forms.PictureBox playerPictureBox2;
        private System.Windows.Forms.PictureBox playerPictureBox3;
        private System.Windows.Forms.PictureBox enemyPictureBox3;
        private System.Windows.Forms.PictureBox enemyPictureBox2;
        private System.Windows.Forms.PictureBox enemyPictureBox1;
        private System.Windows.Forms.ProgressBar enemyHealthBar2;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_About_Profile;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar enemyHealthBar3;
        private System.Windows.Forms.ProgressBar enemyHealthBar1;
        private System.Windows.Forms.Label warriorLbl;
        private System.Windows.Forms.Label mageLbl;
        private System.Windows.Forms.Label clericLbl;
        private System.Windows.Forms.ImageList enemyImageList;
        private System.Windows.Forms.ProgressBar mageHealthBar;
        private System.Windows.Forms.Label mageHealthLbl;
        private System.Windows.Forms.Label warriorHealthLbl;
        private System.Windows.Forms.ProgressBar warriorHealthBar;
        private System.Windows.Forms.Label clericHealthLbl;
        private System.Windows.Forms.ProgressBar clericHealthBar;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label highestScoreLbl;
        private System.Windows.Forms.Label highestLevelPassedLbl;
        private System.Windows.Forms.TextBox scoreTxt;
        private System.Windows.Forms.TextBox highestLevelTxt;
    }
}

