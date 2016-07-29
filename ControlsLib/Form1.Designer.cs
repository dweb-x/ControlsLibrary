namespace ControlsLib
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.led1 = new ControlsLib.LED();
            this.barGraphH1 = new ControlsLib.BarGraphH();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 16);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // led1
            // 
            this.led1.Clickable = true;
            this.led1.LedColor = ControlsLib.LedColor.BLUE;
            this.led1.Location = new System.Drawing.Point(42, 29);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(16, 16);
            this.led1.State = false;
            this.led1.TabIndex = 0;
            // 
            // barGraphH1
            // 
            this.barGraphH1.BackColor = System.Drawing.Color.Black;
            this.barGraphH1.Location = new System.Drawing.Point(27, 91);
            this.barGraphH1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.barGraphH1.MaximumSize = new System.Drawing.Size(16, 96);
            this.barGraphH1.MinimumSize = new System.Drawing.Size(16, 96);
            this.barGraphH1.Name = "barGraphH1";
            this.barGraphH1.Size = new System.Drawing.Size(16, 96);
            this.barGraphH1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 457);
            this.Controls.Add(this.barGraphH1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.led1);
            this.Name = "Form1";
            this.Text = "LED Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LED led1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BarGraphH barGraphH1;
    }
}

