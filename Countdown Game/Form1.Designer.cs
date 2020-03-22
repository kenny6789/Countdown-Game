namespace Countdown_Game
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
            this.btnConsonant = new System.Windows.Forms.Button();
            this.btnVowel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnagram = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotalScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.txbRound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCurrentScore = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFindResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsonant
            // 
            this.btnConsonant.Location = new System.Drawing.Point(8, 96);
            this.btnConsonant.Name = "btnConsonant";
            this.btnConsonant.Size = new System.Drawing.Size(111, 23);
            this.btnConsonant.TabIndex = 0;
            this.btnConsonant.Text = "Consonant";
            this.btnConsonant.UseVisualStyleBackColor = true;
            this.btnConsonant.Click += new System.EventHandler(this.btnConsonant_Click);
            // 
            // btnVowel
            // 
            this.btnVowel.Location = new System.Drawing.Point(133, 96);
            this.btnVowel.Name = "btnVowel";
            this.btnVowel.Size = new System.Drawing.Size(75, 23);
            this.btnVowel.TabIndex = 1;
            this.btnVowel.Text = "Vowel";
            this.btnVowel.UseVisualStyleBackColor = true;
            this.btnVowel.Click += new System.EventHandler(this.btnVowel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is this word?";
            // 
            // txtAnagram
            // 
            this.txtAnagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnagram.Location = new System.Drawing.Point(8, 64);
            this.txtAnagram.Name = "txtAnagram";
            this.txtAnagram.ReadOnly = true;
            this.txtAnagram.Size = new System.Drawing.Size(112, 26);
            this.txtAnagram.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Score";
            // 
            // txbTotalScore
            // 
            this.txbTotalScore.Location = new System.Drawing.Point(78, 12);
            this.txbTotalScore.Name = "txbTotalScore";
            this.txbTotalScore.ReadOnly = true;
            this.txbTotalScore.Size = new System.Drawing.Size(36, 20);
            this.txbTotalScore.TabIndex = 5;
            this.txbTotalScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(125, 16);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(39, 13);
            this.lblRound.TabIndex = 15;
            this.lblRound.Text = "Round";
            // 
            // txbRound
            // 
            this.txbRound.Location = new System.Drawing.Point(170, 12);
            this.txbRound.Name = "txbRound";
            this.txbRound.ReadOnly = true;
            this.txbRound.Size = new System.Drawing.Size(36, 20);
            this.txbRound.TabIndex = 16;
            this.txbRound.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Current Score";
            // 
            // txbCurrentScore
            // 
            this.txbCurrentScore.Location = new System.Drawing.Point(291, 13);
            this.txbCurrentScore.Name = "txbCurrentScore";
            this.txbCurrentScore.ReadOnly = true;
            this.txbCurrentScore.Size = new System.Drawing.Size(36, 20);
            this.txbCurrentScore.TabIndex = 18;
            this.txbCurrentScore.Text = "0";
            // 
            // txbResult
            // 
            this.txbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.Location = new System.Drawing.Point(133, 64);
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(112, 26);
            this.txbResult.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Answer";
            // 
            // btnFindResult
            // 
            this.btnFindResult.Location = new System.Drawing.Point(216, 95);
            this.btnFindResult.Name = "btnFindResult";
            this.btnFindResult.Size = new System.Drawing.Size(75, 23);
            this.btnFindResult.TabIndex = 21;
            this.btnFindResult.Text = "Find Result";
            this.btnFindResult.UseVisualStyleBackColor = true;
            this.btnFindResult.Click += new System.EventHandler(this.btnFindResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 141);
            this.Controls.Add(this.btnFindResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbCurrentScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTotalScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnagram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVowel);
            this.Controls.Add(this.btnConsonant);
            this.Name = "Form1";
            this.Text = "Countdown Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsonant;
        private System.Windows.Forms.Button btnVowel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnagram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTotalScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TextBox txbRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCurrentScore;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFindResult;
    }
}

