namespace BattleShipGUIVersion
{
    partial class BattleShip
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numLbl = new System.Windows.Forms.Label();
            this.letterLbl = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.turnPB = new System.Windows.Forms.ProgressBar();
            this.turnLbl = new System.Windows.Forms.Label();
            this.fireBtn = new System.Windows.Forms.Button();
            this.targetTB = new System.Windows.Forms.TextBox();
            this.cordLbl = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.userBtn = new System.Windows.Forms.Button();
            this.promptLbl = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
            this.statLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statLbl);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(415, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 365);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numLbl.Location = new System.Drawing.Point(425, 35);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(335, 18);
            this.numLbl.TabIndex = 1;
            this.numLbl.Text = "1       2       3       4       5       6       7       8       9       10\r\n";
            // 
            // letterLbl
            // 
            this.letterLbl.AutoSize = true;
            this.letterLbl.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.letterLbl.Location = new System.Drawing.Point(393, 67);
            this.letterLbl.Name = "letterLbl";
            this.letterLbl.Size = new System.Drawing.Size(16, 342);
            this.letterLbl.TabIndex = 0;
            this.letterLbl.Text = "A\r\n\r\nB\r\n\r\nC\r\n\r\nD\r\n\r\nE\r\n\r\nF\r\n\r\nG\r\n\r\nH\r\n\r\nI\r\n\r\nJ";
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(116, 379);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(54, 41);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(34, 379);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(56, 41);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // turnPB
            // 
            this.turnPB.Location = new System.Drawing.Point(34, 235);
            this.turnPB.Name = "turnPB";
            this.turnPB.Size = new System.Drawing.Size(276, 23);
            this.turnPB.TabIndex = 1;
            // 
            // turnLbl
            // 
            this.turnLbl.AutoSize = true;
            this.turnLbl.Location = new System.Drawing.Point(140, 215);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(71, 17);
            this.turnLbl.TabIndex = 2;
            this.turnLbl.Text = "Turn Limit";
            // 
            // fireBtn
            // 
            this.fireBtn.Location = new System.Drawing.Point(216, 130);
            this.fireBtn.Name = "fireBtn";
            this.fireBtn.Size = new System.Drawing.Size(93, 49);
            this.fireBtn.TabIndex = 5;
            this.fireBtn.Text = "Fire!";
            this.fireBtn.UseVisualStyleBackColor = true;
            this.fireBtn.Click += new System.EventHandler(this.fireBtn_Click);
            // 
            // targetTB
            // 
            this.targetTB.Location = new System.Drawing.Point(34, 157);
            this.targetTB.Name = "targetTB";
            this.targetTB.Size = new System.Drawing.Size(139, 22);
            this.targetTB.TabIndex = 6;
            // 
            // cordLbl
            // 
            this.cordLbl.AutoSize = true;
            this.cordLbl.Location = new System.Drawing.Point(63, 130);
            this.cordLbl.Name = "cordLbl";
            this.cordLbl.Size = new System.Drawing.Size(76, 17);
            this.cordLbl.TabIndex = 7;
            this.cordLbl.Text = "Cordinates";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(31, 327);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(139, 22);
            this.userTB.TabIndex = 8;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(28, 305);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(145, 17);
            this.userLbl.TabIndex = 9;
            this.userLbl.Text = "Enter your username:";
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(212, 327);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(93, 23);
            this.userBtn.TabIndex = 10;
            this.userBtn.Text = "Enter";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLbl.Location = new System.Drawing.Point(31, 20);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(274, 50);
            this.promptLbl.TabIndex = 11;
            this.promptLbl.Text = "Welcome to BattleShip! \r\nEnter your username below\r\n";
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(214, 379);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(143, 40);
            this.displayBtn.TabIndex = 12;
            this.displayBtn.Text = "Stats";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // statLbl
            // 
            this.statLbl.AutoSize = true;
            this.statLbl.BackColor = System.Drawing.SystemColors.Control;
            this.statLbl.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLbl.ForeColor = System.Drawing.Color.Black;
            this.statLbl.Location = new System.Drawing.Point(27, 38);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(50, 24);
            this.statLbl.TabIndex = 0;
            this.statLbl.Text = "Stats:";
            // 
            // BattleShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numLbl);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.letterLbl);
            this.Controls.Add(this.promptLbl);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.cordLbl);
            this.Controls.Add(this.targetTB);
            this.Controls.Add(this.fireBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.turnLbl);
            this.Controls.Add(this.turnPB);
            this.Controls.Add(this.panel1);
            this.Name = "BattleShip";
            this.Text = "BattleShip";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ProgressBar turnPB;
        private System.Windows.Forms.Label turnLbl;
        private System.Windows.Forms.Button fireBtn;
        private System.Windows.Forms.TextBox targetTB;
        private System.Windows.Forms.Label cordLbl;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.Label letterLbl;
        private System.Windows.Forms.Label statLbl;
    }
}

