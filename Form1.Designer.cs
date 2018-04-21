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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonFirstFit = new System.Windows.Forms.RadioButton();
            this.radioButtonBestFit = new System.Windows.Forms.RadioButton();
            this.radioButtonWorstFit = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.holeStartingAdressText = new System.Windows.Forms.NumericUpDown();
            this.holeSizeText = new System.Windows.Forms.NumericUpDown();
            this.processIDText = new System.Windows.Forms.NumericUpDown();
            this.processSizeText = new System.Windows.Forms.NumericUpDown();
            this.compact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.holeStartingAdressText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holeSizeText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processIDText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processSizeText)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "insert new hole:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(440, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert new hole";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(118, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hole starting address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hole size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(118, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "insert new process:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Process ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 506);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Process size:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(440, 371);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Insert new process";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 565);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Choose methodology:";
            // 
            // radioButtonFirstFit
            // 
            this.radioButtonFirstFit.AutoSize = true;
            this.radioButtonFirstFit.Location = new System.Drawing.Point(306, 565);
            this.radioButtonFirstFit.Name = "radioButtonFirstFit";
            this.radioButtonFirstFit.Size = new System.Drawing.Size(73, 21);
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
            this.radioButtonBestFit.Size = new System.Drawing.Size(74, 21);
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
            this.radioButtonWorstFit.Size = new System.Drawing.Size(83, 21);
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
            this.panel.Size = new System.Drawing.Size(202, 636);
            this.panel.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(790, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 62);
            this.button3.TabIndex = 20;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // holeStartingAdressText
            // 
            this.holeStartingAdressText.Location = new System.Drawing.Point(285, 146);
            this.holeStartingAdressText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.holeStartingAdressText.Name = "holeStartingAdressText";
            this.holeStartingAdressText.Size = new System.Drawing.Size(124, 23);
            this.holeStartingAdressText.TabIndex = 21;
            // 
            // holeSizeText
            // 
            this.holeSizeText.Location = new System.Drawing.Point(285, 201);
            this.holeSizeText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.holeSizeText.Name = "holeSizeText";
            this.holeSizeText.Size = new System.Drawing.Size(124, 23);
            this.holeSizeText.TabIndex = 21;
            // 
            // processIDText
            // 
            this.processIDText.Location = new System.Drawing.Point(306, 450);
            this.processIDText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.processIDText.Name = "processIDText";
            this.processIDText.Size = new System.Drawing.Size(120, 23);
            this.processIDText.TabIndex = 22;
            // 
            // processSizeText
            // 
            this.processSizeText.Location = new System.Drawing.Point(306, 506);
            this.processSizeText.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.processSizeText.Name = "processSizeText";
            this.processSizeText.Size = new System.Drawing.Size(120, 23);
            this.processSizeText.TabIndex = 22;
            // 
            // compact
            // 
            this.compact.BackColor = System.Drawing.SystemColors.HotTrack;
            this.compact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.compact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compact.Location = new System.Drawing.Point(790, 329);
            this.compact.Name = "compact";
            this.compact.Size = new System.Drawing.Size(88, 62);
            this.compact.TabIndex = 23;
            this.compact.Text = "Compact";
            this.compact.UseVisualStyleBackColor = false;
            this.compact.Click += new System.EventHandler(this.compact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.compact);
            this.Controls.Add(this.processSizeText);
            this.Controls.Add(this.processIDText);
            this.Controls.Add(this.holeSizeText);
            this.Controls.Add(this.holeStartingAdressText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.radioButtonWorstFit);
            this.Controls.Add(this.radioButtonBestFit);
            this.Controls.Add(this.radioButtonFirstFit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Manager";
            ((System.ComponentModel.ISupportInitialize)(this.holeStartingAdressText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holeSizeText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processIDText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processSizeText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonFirstFit;
        private System.Windows.Forms.RadioButton radioButtonBestFit;
        private System.Windows.Forms.RadioButton radioButtonWorstFit;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown holeStartingAdressText;
        private System.Windows.Forms.NumericUpDown holeSizeText;
        private System.Windows.Forms.NumericUpDown processIDText;
        private System.Windows.Forms.NumericUpDown processSizeText;
        private System.Windows.Forms.Button compact;
    }
}

