namespace ControlsLib
{
    partial class BarGraphH
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
            this.led1 = new ControlsLib.LED();
            this.led2 = new ControlsLib.LED();
            this.led3 = new ControlsLib.LED();
            this.led4 = new ControlsLib.LED();
            this.led5 = new ControlsLib.LED();
            this.led6 = new ControlsLib.LED();
            this.SuspendLayout();
            // 
            // led1
            // 
            this.led1.Clickable = true;
            this.led1.LedColor = ControlsLib.LedColor.GREEN;
            this.led1.Location = new System.Drawing.Point(0, 81);
            this.led1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(16, 16);
            this.led1.State = false;
            this.led1.TabIndex = 0;
            // 
            // led2
            // 
            this.led2.Clickable = true;
            this.led2.LedColor = ControlsLib.LedColor.GREEN;
            this.led2.Location = new System.Drawing.Point(0, 65);
            this.led2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(16, 16);
            this.led2.State = false;
            this.led2.TabIndex = 1;
            // 
            // led3
            // 
            this.led3.Clickable = true;
            this.led3.LedColor = ControlsLib.LedColor.GREEN;
            this.led3.Location = new System.Drawing.Point(0, 49);
            this.led3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(16, 16);
            this.led3.State = false;
            this.led3.TabIndex = 2;
            // 
            // led4
            // 
            this.led4.Clickable = true;
            this.led4.LedColor = ControlsLib.LedColor.GREEN;
            this.led4.Location = new System.Drawing.Point(0, 33);
            this.led4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(16, 16);
            this.led4.State = false;
            this.led4.TabIndex = 3;
            // 
            // led5
            // 
            this.led5.Clickable = true;
            this.led5.LedColor = ControlsLib.LedColor.AMBER;
            this.led5.Location = new System.Drawing.Point(0, 17);
            this.led5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(16, 16);
            this.led5.State = false;
            this.led5.TabIndex = 4;
            // 
            // led6
            // 
            this.led6.Clickable = true;
            this.led6.LedColor = ControlsLib.LedColor.RED;
            this.led6.Location = new System.Drawing.Point(0, 0);
            this.led6.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(16, 16);
            this.led6.State = false;
            this.led6.TabIndex = 5;
            // 
            // BarGraphH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.led6);
            this.Controls.Add(this.led5);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MaximumSize = new System.Drawing.Size(16, 96);
            this.MinimumSize = new System.Drawing.Size(16, 96);
            this.Name = "BarGraphH";
            this.Size = new System.Drawing.Size(16, 96);
            this.ResumeLayout(false);

        }

        #endregion

        private LED led1;
        private LED led2;
        private LED led3;
        private LED led4;
        private LED led5;
        private LED led6;
    }
}
