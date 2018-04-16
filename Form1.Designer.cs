namespace memoryAllocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.holeStartingAdressText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.holeSizeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.processIDText = new System.Windows.Forms.TextBox();
            this.processSizeText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonFirstFit = new System.Windows.Forms.RadioButton();
            this.radioButtonBestFit = new System.Windows.Forms.RadioButton();
            this.radioButtonWorstFit = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(118, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "insert new hole:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(440, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "insert new hole";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // holeStartingAdressText
            // 
            this.holeStartingAdressText.Location = new System.Drawing.Point(306, 146);
            this.holeStartingAdressText.Margin = new System.Windows.Forms.Padding(4);
            this.holeStartingAdressText.Name = "holeStartingAdressText";
            this.holeStartingAdressText.Size = new System.Drawing.Size(124, 26);
            this.holeStartingAdressText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(118, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "hole starting address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "hole size:";
            // 
            // holeSizeText
            // 
            this.holeSizeText.Location = new System.Drawing.Point(306, 194);
            this.holeSizeText.Margin = new System.Windows.Forms.Padding(4);
            this.holeSizeText.Name = "holeSizeText";
            this.holeSizeText.Size = new System.Drawing.Size(124, 26);
            this.holeSizeText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(118, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "insert new process:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "process ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 506);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "process size:";
            // 
            // processIDText
            // 
            this.processIDText.Location = new System.Drawing.Point(306, 450);
            this.processIDText.Margin = new System.Windows.Forms.Padding(4);
            this.processIDText.Name = "processIDText";
            this.processIDText.Size = new System.Drawing.Size(124, 26);
            this.processIDText.TabIndex = 9;
            // 
            // processSizeText
            // 
            this.processSizeText.Location = new System.Drawing.Point(306, 506);
            this.processSizeText.Margin = new System.Windows.Forms.Padding(4);
            this.processSizeText.Name = "processSizeText";
            this.processSizeText.Size = new System.Drawing.Size(124, 26);
            this.processSizeText.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(440, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 69);
            this.button2.TabIndex = 11;
            this.button2.Text = "insert new process";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 565);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "choose methodology:";
            // 
            // radioButtonFirstFit
            // 
            this.radioButtonFirstFit.AutoSize = true;
            this.radioButtonFirstFit.Location = new System.Drawing.Point(306, 565);
            this.radioButtonFirstFit.Name = "radioButtonFirstFit";
            this.radioButtonFirstFit.Size = new System.Drawing.Size(89, 24);
            this.radioButtonFirstFit.TabIndex = 18;
            this.radioButtonFirstFit.TabStop = true;
            this.radioButtonFirstFit.Text = "First-Fit";
            this.radioButtonFirstFit.UseVisualStyleBackColor = true;
            // 
            // radioButtonBestFit
            // 
            this.radioButtonBestFit.AutoSize = true;
            this.radioButtonBestFit.Location = new System.Drawing.Point(306, 600);
            this.radioButtonBestFit.Name = "radioButtonBestFit";
            this.radioButtonBestFit.Size = new System.Drawing.Size(90, 24);
            this.radioButtonBestFit.TabIndex = 18;
            this.radioButtonBestFit.TabStop = true;
            this.radioButtonBestFit.Text = "Best-Fit";
            this.radioButtonBestFit.UseVisualStyleBackColor = true;
            // 
            // radioButtonWorstFit
            // 
            this.radioButtonWorstFit.AutoSize = true;
            this.radioButtonWorstFit.Location = new System.Drawing.Point(306, 635);
            this.radioButtonWorstFit.Name = "radioButtonWorstFit";
            this.radioButtonWorstFit.Size = new System.Drawing.Size(100, 24);
            this.radioButtonWorstFit.TabIndex = 18;
            this.radioButtonWorstFit.TabStop = true;
            this.radioButtonWorstFit.Text = "Worst-Fit";
            this.radioButtonWorstFit.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(1000, 23);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 636);
            this.panel.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(790, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 62);
            this.button3.TabIndex = 20;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1408, 692);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.radioButtonWorstFit);
            this.Controls.Add(this.radioButtonBestFit);
            this.Controls.Add(this.radioButtonFirstFit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.processSizeText);
            this.Controls.Add(this.processIDText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.holeSizeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.holeStartingAdressText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox holeStartingAdressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox holeSizeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox processIDText;
        private System.Windows.Forms.TextBox processSizeText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonFirstFit;
        private System.Windows.Forms.RadioButton radioButtonBestFit;
        private System.Windows.Forms.RadioButton radioButtonWorstFit;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

