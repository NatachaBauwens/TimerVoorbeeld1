namespace TimerVoorbeeld1
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
            this.lbltijdTeller = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltijdNU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltijdTeller
            // 
            this.lbltijdTeller.AutoSize = true;
            this.lbltijdTeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltijdTeller.ForeColor = System.Drawing.Color.Honeydew;
            this.lbltijdTeller.Location = new System.Drawing.Point(21, 185);
            this.lbltijdTeller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltijdTeller.Name = "lbltijdTeller";
            this.lbltijdTeller.Size = new System.Drawing.Size(73, 31);
            this.lbltijdTeller.TabIndex = 0;
            this.lbltijdTeller.Text = "(tijd)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start de timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop de timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.tijdweergeven);
            // 
            // lbltijdNU
            // 
            this.lbltijdNU.AutoSize = true;
            this.lbltijdNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltijdNU.ForeColor = System.Drawing.Color.Honeydew;
            this.lbltijdNU.Location = new System.Drawing.Point(21, 122);
            this.lbltijdNU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltijdNU.Name = "lbltijdNU";
            this.lbltijdNU.Size = new System.Drawing.Size(56, 25);
            this.lbltijdNU.TabIndex = 3;
            this.lbltijdNU.Text = "(tijd)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(545, 321);
            this.Controls.Add(this.lbltijdNU);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltijdTeller);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "KLOK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltijdTeller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltijdNU;
    }
}

