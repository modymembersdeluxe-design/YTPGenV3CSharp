namespace YTPGenDeluxe
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label summaryLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.generateButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // generateButton
            //
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(508, 303);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(140, 32);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Preview";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.OnGenerateClick);
            //
            // summaryLabel
            //
            this.summaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLabel.Location = new System.Drawing.Point(24, 24);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(624, 256);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "YTPGen Deluxe (Windows 8.1)\r\n\r\n- Import MP4, WMV, AVI, PNG, JPG, WEBP\r\n- Flexible stream duration and clip count\r\n- Toggleable audio/video effects and style presets\r\n\r\nWire up processing and rendering pipelines here.";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 360);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.generateButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YTPGen Deluxe Preview";
            this.ResumeLayout(false);
        }
    }
}
