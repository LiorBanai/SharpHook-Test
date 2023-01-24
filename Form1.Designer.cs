namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TrackBarMaster = new System.Windows.Forms.TrackBar();
            this.btnStartHook = new System.Windows.Forms.Button();
            this.btnStopHook = new System.Windows.Forms.Button();
            this.btnStartExplorer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(594, 340);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // TrackBarMaster
            // 
            this.TrackBarMaster.LargeChange = 20;
            this.TrackBarMaster.Location = new System.Drawing.Point(628, 41);
            this.TrackBarMaster.Maximum = 100;
            this.TrackBarMaster.Name = "TrackBarMaster";
            this.TrackBarMaster.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrackBarMaster.Size = new System.Drawing.Size(45, 340);
            this.TrackBarMaster.SmallChange = 5;
            this.TrackBarMaster.TabIndex = 5;
            this.TrackBarMaster.TickFrequency = 10;
            this.TrackBarMaster.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // btnStartHook
            // 
            this.btnStartHook.Location = new System.Drawing.Point(8, 10);
            this.btnStartHook.Name = "btnStartHook";
            this.btnStartHook.Size = new System.Drawing.Size(87, 24);
            this.btnStartHook.TabIndex = 6;
            this.btnStartHook.Text = "Start hook";
            this.btnStartHook.UseVisualStyleBackColor = true;
            this.btnStartHook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopHook
            // 
            this.btnStopHook.Location = new System.Drawing.Point(99, 10);
            this.btnStopHook.Name = "btnStopHook";
            this.btnStopHook.Size = new System.Drawing.Size(87, 24);
            this.btnStopHook.TabIndex = 7;
            this.btnStopHook.Text = "stop hook";
            this.btnStopHook.UseVisualStyleBackColor = true;
            this.btnStopHook.Click += new System.EventHandler(this.btnStopHook_Click);
            // 
            // btnStartExplorer
            // 
            this.btnStartExplorer.Location = new System.Drawing.Point(210, 10);
            this.btnStartExplorer.Name = "btnStartExplorer";
            this.btnStartExplorer.Size = new System.Drawing.Size(87, 24);
            this.btnStartExplorer.TabIndex = 8;
            this.btnStartExplorer.Text = "Start Explorer";
            this.btnStartExplorer.UseVisualStyleBackColor = true;
            this.btnStartExplorer.Click += new System.EventHandler(this.btnStartExplorer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnStartExplorer);
            this.Controls.Add(this.btnStopHook);
            this.Controls.Add(this.btnStartHook);
            this.Controls.Add(this.TrackBarMaster);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private TrackBar TrackBarMaster;
        private Button btnStartHook;
        private Button btnStopHook;
        private Button btnStartExplorer;
    }
}