
namespace FernandezBatoBatoPick
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBBP1 = new System.Windows.Forms.Label();
            this.lblBBP2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rdbBato = new System.Windows.Forms.RadioButton();
            this.rdbPapel = new System.Windows.Forms.RadioButton();
            this.rdbGunting = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblBBP1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdbBato);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.lblScoreBoard);
            this.panel2.Controls.Add(this.txtComp);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.lblComputer);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Location = new System.Drawing.Point(0, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 149);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.lblResult);
            this.panel3.Controls.Add(this.txtResult);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(199, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 149);
            this.panel3.TabIndex = 2;
            // 
            // lblBBP1
            // 
            this.lblBBP1.AutoSize = true;
            this.lblBBP1.BackColor = System.Drawing.Color.Transparent;
            this.lblBBP1.Font = new System.Drawing.Font("Terminator Two", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.lblBBP1.Location = new System.Drawing.Point(58, 61);
            this.lblBBP1.Name = "lblBBP1";
            this.lblBBP1.Size = new System.Drawing.Size(159, 48);
            this.lblBBP1.TabIndex = 3;
            this.lblBBP1.Text = "BATC";
            // 
            // lblBBP2
            // 
            this.lblBBP2.AutoSize = true;
            this.lblBBP2.BackColor = System.Drawing.Color.Transparent;
            this.lblBBP2.Font = new System.Drawing.Font("Terminator Two", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.lblBBP2.Location = new System.Drawing.Point(167, 57);
            this.lblBBP2.Name = "lblBBP2";
            this.lblBBP2.Size = new System.Drawing.Size(381, 48);
            this.lblBBP2.TabIndex = 4;
            this.lblBBP2.Text = "O BATO PICK";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Terminator Two", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(164, 126);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(261, 44);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY NOW";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rdbBato
            // 
            this.rdbBato.AutoSize = true;
            this.rdbBato.Font = new System.Drawing.Font("Terminator Two", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.rdbBato.Location = new System.Drawing.Point(66, 213);
            this.rdbBato.Name = "rdbBato";
            this.rdbBato.Size = new System.Drawing.Size(101, 28);
            this.rdbBato.TabIndex = 7;
            this.rdbBato.TabStop = true;
            this.rdbBato.Text = "BATO";
            this.rdbBato.UseVisualStyleBackColor = true;
            // 
            // rdbPapel
            // 
            this.rdbPapel.AutoSize = true;
            this.rdbPapel.Font = new System.Drawing.Font("Terminator Two", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPapel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.rdbPapel.Location = new System.Drawing.Point(241, 209);
            this.rdbPapel.Name = "rdbPapel";
            this.rdbPapel.Size = new System.Drawing.Size(115, 28);
            this.rdbPapel.TabIndex = 8;
            this.rdbPapel.TabStop = true;
            this.rdbPapel.Text = "PAPEL";
            this.rdbPapel.UseVisualStyleBackColor = true;
            // 
            // rdbGunting
            // 
            this.rdbGunting.AutoSize = true;
            this.rdbGunting.Font = new System.Drawing.Font("Terminator Two", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGunting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.rdbGunting.Location = new System.Drawing.Point(406, 209);
            this.rdbGunting.Name = "rdbGunting";
            this.rdbGunting.Size = new System.Drawing.Size(142, 28);
            this.rdbGunting.TabIndex = 9;
            this.rdbGunting.TabStop = true;
            this.rdbGunting.Text = "GUNTING";
            this.rdbGunting.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 151);
            this.panel4.TabIndex = 10;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Terminator Two", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(19, 55);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(359, 65);
            this.txtResult.TabIndex = 12;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComp
            // 
            this.txtComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.txtComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComp.Font = new System.Drawing.Font("Terminator Two", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp.ForeColor = System.Drawing.Color.White;
            this.txtComp.Location = new System.Drawing.Point(134, 42);
            this.txtComp.Name = "txtComp";
            this.txtComp.ReadOnly = true;
            this.txtComp.Size = new System.Drawing.Size(46, 29);
            this.txtComp.TabIndex = 13;
            this.txtComp.Text = "0";
            this.txtComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Terminator Two", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(134, 91);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(46, 29);
            this.txtUser.TabIndex = 14;
            this.txtUser.Text = "0";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.Color.White;
            this.lblComputer.Location = new System.Drawing.Point(11, 48);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(126, 16);
            this.lblComputer.TabIndex = 17;
            this.lblComputer.Text = "Computer : ";
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBoard.ForeColor = System.Drawing.Color.White;
            this.lblScoreBoard.Location = new System.Drawing.Point(37, 12);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(130, 16);
            this.lblScoreBoard.TabIndex = 18;
            this.lblScoreBoard.Text = "Scoreboard";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(11, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(113, 16);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "User     :";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(159, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(87, 16);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "RESULT ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.rdbGunting);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rdbPapel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBBP2);
            this.Name = "Form1";
            this.Text = "Bato Bato Pick";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBBP1;
        private System.Windows.Forms.Label lblBBP2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rdbBato;
        private System.Windows.Forms.RadioButton rdbPapel;
        private System.Windows.Forms.RadioButton rdbGunting;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblScoreBoard;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblResult;
    }
}

