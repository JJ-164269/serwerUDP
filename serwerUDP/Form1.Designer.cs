namespace serwerUDP
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
            this.My_port = new System.Windows.Forms.NumericUpDown();
            this.Messages = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.My_port)).BeginInit();
            this.SuspendLayout();
            // 
            // My_port
            // 
            this.My_port.Location = new System.Drawing.Point(208, 103);
            this.My_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.My_port.Name = "My_port";
            this.My_port.Size = new System.Drawing.Size(248, 20);
            this.My_port.TabIndex = 0;
            // 
            // Messages
            // 
            this.Messages.FormattingEnabled = true;
            this.Messages.Location = new System.Drawing.Point(12, 160);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(559, 173);
            this.Messages.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(208, 363);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(144, 45);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 444);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.My_port);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.My_port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown My_port;
        private System.Windows.Forms.ListBox Messages;
        private System.Windows.Forms.Button start;
    }
}

