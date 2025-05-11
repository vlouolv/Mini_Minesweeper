namespace SapperMini
{
    partial class FormGeneral
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            this.groupBoxControlers = new System.Windows.Forms.GroupBox();
            this.buttonScores = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.panelField = new System.Windows.Forms.Panel();
            this.labelFlagsInfo = new System.Windows.Forms.Label();
            this.labelTimerInfo = new System.Windows.Forms.Label();
            this.labelFlagsCount = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.timerForTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightmareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxControlers.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControlers
            // 
            this.groupBoxControlers.Controls.Add(this.buttonScores);
            this.groupBoxControlers.Controls.Add(this.buttonRestart);
            this.groupBoxControlers.Location = new System.Drawing.Point(12, 27);
            this.groupBoxControlers.Name = "groupBoxControlers";
            this.groupBoxControlers.Size = new System.Drawing.Size(200, 64);
            this.groupBoxControlers.TabIndex = 7;
            this.groupBoxControlers.TabStop = false;
            this.groupBoxControlers.Text = "Control buttons";
            // 
            // buttonScores
            // 
            this.buttonScores.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScores.Location = new System.Drawing.Point(52, 18);
            this.buttonScores.Name = "buttonScores";
            this.buttonScores.Size = new System.Drawing.Size(142, 40);
            this.buttonScores.TabIndex = 6;
            this.buttonScores.Text = "Scores";
            this.buttonScores.UseVisualStyleBackColor = true;
            this.buttonScores.Click += new System.EventHandler(this.buttonScores_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(6, 18);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(40, 40);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "R";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // panelField
            // 
            this.panelField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelField.Location = new System.Drawing.Point(12, 97);
            this.panelField.Name = "panelField";
            this.panelField.Size = new System.Drawing.Size(200, 200);
            this.panelField.TabIndex = 0;
            // 
            // labelFlagsInfo
            // 
            this.labelFlagsInfo.AutoSize = true;
            this.labelFlagsInfo.Location = new System.Drawing.Point(3, 9);
            this.labelFlagsInfo.Name = "labelFlagsInfo";
            this.labelFlagsInfo.Size = new System.Drawing.Size(35, 13);
            this.labelFlagsInfo.TabIndex = 1;
            this.labelFlagsInfo.Text = "Flags:";
            // 
            // labelTimerInfo
            // 
            this.labelTimerInfo.AutoSize = true;
            this.labelTimerInfo.Location = new System.Drawing.Point(107, 9);
            this.labelTimerInfo.Name = "labelTimerInfo";
            this.labelTimerInfo.Size = new System.Drawing.Size(33, 13);
            this.labelTimerInfo.TabIndex = 2;
            this.labelTimerInfo.Text = "Time:";
            // 
            // labelFlagsCount
            // 
            this.labelFlagsCount.AutoSize = true;
            this.labelFlagsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFlagsCount.Location = new System.Drawing.Point(44, 9);
            this.labelFlagsCount.Name = "labelFlagsCount";
            this.labelFlagsCount.Size = new System.Drawing.Size(27, 15);
            this.labelFlagsCount.TabIndex = 3;
            this.labelFlagsCount.Text = "000";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTimer.Location = new System.Drawing.Point(146, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(51, 15);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "00:00:00";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelFlagsInfo);
            this.panelInfo.Controls.Add(this.labelFlagsCount);
            this.panelInfo.Controls.Add(this.labelTimer);
            this.panelInfo.Controls.Add(this.labelTimerInfo);
            this.panelInfo.Location = new System.Drawing.Point(12, 303);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(200, 31);
            this.panelInfo.TabIndex = 6;
            // 
            // timerForTimer
            // 
            this.timerForTimer.Interval = 1000;
            this.timerForTimer.Tick += new System.EventHandler(this.timerForTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(224, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.hugeToolStripMenuItem,
            this.nightmareToolStripMenuItem,
            this.toolStripSeparator1,
            this.customToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.smallToolStripMenuItem.Tag = "1";
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.mediumToolStripMenuItem.Tag = "2";
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.largeToolStripMenuItem.Tag = "3";
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // hugeToolStripMenuItem
            // 
            this.hugeToolStripMenuItem.Name = "hugeToolStripMenuItem";
            this.hugeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.hugeToolStripMenuItem.Tag = "4";
            this.hugeToolStripMenuItem.Text = "Huge";
            this.hugeToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // nightmareToolStripMenuItem
            // 
            this.nightmareToolStripMenuItem.Name = "nightmareToolStripMenuItem";
            this.nightmareToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.nightmareToolStripMenuItem.Tag = "5";
            this.nightmareToolStripMenuItem.Text = "Nightmare";
            this.nightmareToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchThemeToolStripMenuItem,
            this.howPlayToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutProgrammToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // switchThemeToolStripMenuItem
            // 
            this.switchThemeToolStripMenuItem.Name = "switchThemeToolStripMenuItem";
            this.switchThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchThemeToolStripMenuItem.Text = "Switch Theme";
            this.switchThemeToolStripMenuItem.Click += new System.EventHandler(this.switchThemeToolStripMenuItem_Click);
            // 
            // howPlayToolStripMenuItem
            // 
            this.howPlayToolStripMenuItem.Name = "howPlayToolStripMenuItem";
            this.howPlayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howPlayToolStripMenuItem.Text = "How Play";
            this.howPlayToolStripMenuItem.Click += new System.EventHandler(this.howPlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutProgrammToolStripMenuItem
            // 
            this.aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            this.aboutProgrammToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutProgrammToolStripMenuItem.Text = "About Programm";
            this.aboutProgrammToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammToolStripMenuItem_Click);
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 345);
            this.Controls.Add(this.groupBoxControlers);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelField);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SapperMini";
            this.Load += new System.EventHandler(this.FormGeneral_Load);
            this.groupBoxControlers.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelField;
        private System.Windows.Forms.Label labelFlagsInfo;
        private System.Windows.Forms.Label labelTimerInfo;
        private System.Windows.Forms.Label labelFlagsCount;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Timer timerForTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightmareToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxControlers;
        private System.Windows.Forms.Button buttonScores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammToolStripMenuItem;
    }
}

