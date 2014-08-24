namespace WindowsFormsApplication1
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
            this.disableButton = new System.Windows.Forms.Button();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.enableButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // disableButton
            // 
            this.disableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disableButton.Location = new System.Drawing.Point(221, 14);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(75, 23);
            this.disableButton.TabIndex = 0;
            this.disableButton.Text = "Disable Chat";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // regionComboBox
            // 
            this.regionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "North America",
            "EU West",
            "EU Nordic & East",
            "Brazil",
            "Latin America North",
            "Latin America South",
            "Turkey",
            "Oceania",
            "Russia"});
            this.regionComboBox.Location = new System.Drawing.Point(93, 14);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionComboBox.TabIndex = 1;
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(12, 12);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(75, 23);
            this.enableButton.TabIndex = 2;
            this.enableButton.Text = "Enable Chat";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(13, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(283, 113);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 178);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.disableButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL Appear Offline";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

