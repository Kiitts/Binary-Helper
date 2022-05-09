
namespace Binary_Helper
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
            this.fromConvertList = new System.Windows.Forms.ComboBox();
            this.fromConvertText = new System.Windows.Forms.TextBox();
            this.toConvertText = new System.Windows.Forms.TextBox();
            this.toConvertList = new System.Windows.Forms.ComboBox();
            this.fromClearButton = new System.Windows.Forms.Button();
            this.toClearButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.removeSpaceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fromConvertList
            // 
            this.fromConvertList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromConvertList.FormattingEnabled = true;
            this.fromConvertList.Items.AddRange(new object[] {
            "Text",
            "Binary",
            "Octal",
            "Hexadecimal"});
            this.fromConvertList.Location = new System.Drawing.Point(12, 12);
            this.fromConvertList.Name = "fromConvertList";
            this.fromConvertList.Size = new System.Drawing.Size(344, 21);
            this.fromConvertList.TabIndex = 0;
            this.fromConvertList.SelectedIndexChanged += new System.EventHandler(this.fromConvertList_SelectedIndexChanged);
            // 
            // fromConvertText
            // 
            this.fromConvertText.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromConvertText.Location = new System.Drawing.Point(13, 40);
            this.fromConvertText.Multiline = true;
            this.fromConvertText.Name = "fromConvertText";
            this.fromConvertText.Size = new System.Drawing.Size(424, 188);
            this.fromConvertText.TabIndex = 1;
            // 
            // toConvertText
            // 
            this.toConvertText.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toConvertText.Location = new System.Drawing.Point(13, 262);
            this.toConvertText.Multiline = true;
            this.toConvertText.Name = "toConvertText";
            this.toConvertText.ReadOnly = true;
            this.toConvertText.Size = new System.Drawing.Size(424, 188);
            this.toConvertText.TabIndex = 3;
            // 
            // toConvertList
            // 
            this.toConvertList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toConvertList.FormattingEnabled = true;
            this.toConvertList.Items.AddRange(new object[] {
            "Text",
            "Binary",
            "Octal",
            "Hexadecimal"});
            this.toConvertList.Location = new System.Drawing.Point(12, 234);
            this.toConvertList.Name = "toConvertList";
            this.toConvertList.Size = new System.Drawing.Size(344, 21);
            this.toConvertList.TabIndex = 2;
            this.toConvertList.SelectedIndexChanged += new System.EventHandler(this.toConvertList_SelectedIndexChanged);
            // 
            // fromClearButton
            // 
            this.fromClearButton.Location = new System.Drawing.Point(362, 12);
            this.fromClearButton.Name = "fromClearButton";
            this.fromClearButton.Size = new System.Drawing.Size(75, 23);
            this.fromClearButton.TabIndex = 4;
            this.fromClearButton.Text = "Clear";
            this.fromClearButton.UseVisualStyleBackColor = true;
            this.fromClearButton.Click += new System.EventHandler(this.fromClearButton_Click);
            // 
            // toClearButton
            // 
            this.toClearButton.Location = new System.Drawing.Point(362, 234);
            this.toClearButton.Name = "toClearButton";
            this.toClearButton.Size = new System.Drawing.Size(75, 23);
            this.toClearButton.TabIndex = 5;
            this.toClearButton.Text = "Clear";
            this.toClearButton.UseVisualStyleBackColor = true;
            this.toClearButton.Click += new System.EventHandler(this.toClearButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(12, 456);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 6;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(124, 456);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(345, 449);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(92, 23);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // removeSpaceCheckBox
            // 
            this.removeSpaceCheckBox.AutoSize = true;
            this.removeSpaceCheckBox.Location = new System.Drawing.Point(219, 460);
            this.removeSpaceCheckBox.Name = "removeSpaceCheckBox";
            this.removeSpaceCheckBox.Size = new System.Drawing.Size(100, 17);
            this.removeSpaceCheckBox.TabIndex = 9;
            this.removeSpaceCheckBox.Text = "Remove Space";
            this.removeSpaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 489);
            this.Controls.Add(this.removeSpaceCheckBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.toClearButton);
            this.Controls.Add(this.fromClearButton);
            this.Controls.Add(this.toConvertText);
            this.Controls.Add(this.toConvertList);
            this.Controls.Add(this.fromConvertText);
            this.Controls.Add(this.fromConvertList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 528);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 528);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromConvertList;
        private System.Windows.Forms.TextBox fromConvertText;
        private System.Windows.Forms.TextBox toConvertText;
        private System.Windows.Forms.ComboBox toConvertList;
        private System.Windows.Forms.Button fromClearButton;
        private System.Windows.Forms.Button toClearButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.CheckBox removeSpaceCheckBox;
    }
}

