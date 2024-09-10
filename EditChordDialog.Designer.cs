namespace ChordBook
{
    partial class EditChordDialog
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
            this.endingBox = new System.Windows.Forms.TextBox();
            this.endingLabel = new System.Windows.Forms.Label();
            this.changeKeyButton = new System.Windows.Forms.Button();
            this.changeKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endingBox
            // 
            this.endingBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingBox.Location = new System.Drawing.Point(100, 24);
            this.endingBox.Name = "endingBox";
            this.endingBox.Size = new System.Drawing.Size(70, 25);
            this.endingBox.TabIndex = 0;
            // 
            // endingLabel
            // 
            this.endingLabel.AutoSize = true;
            this.endingLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingLabel.ForeColor = System.Drawing.Color.Gray;
            this.endingLabel.Location = new System.Drawing.Point(97, 9);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(44, 13);
            this.endingLabel.TabIndex = 1;
            this.endingLabel.Text = "Ending";
            // 
            // changeKeyButton
            // 
            this.changeKeyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.changeKeyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.changeKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeKeyButton.Location = new System.Drawing.Point(12, 24);
            this.changeKeyButton.Name = "changeKeyButton";
            this.changeKeyButton.Size = new System.Drawing.Size(81, 25);
            this.changeKeyButton.TabIndex = 2;
            this.changeKeyButton.Text = "Change Key";
            this.changeKeyButton.UseVisualStyleBackColor = false;
            this.changeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // changeKeyLabel
            // 
            this.changeKeyLabel.AutoSize = true;
            this.changeKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeKeyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeKeyLabel.ForeColor = System.Drawing.Color.Black;
            this.changeKeyLabel.Location = new System.Drawing.Point(12, 6);
            this.changeKeyLabel.Name = "changeKeyLabel";
            this.changeKeyLabel.Size = new System.Drawing.Size(40, 15);
            this.changeKeyLabel.TabIndex = 3;
            this.changeKeyLabel.Text = "Key: C";
            // 
            // EditChordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 61);
            this.Controls.Add(this.changeKeyLabel);
            this.Controls.Add(this.changeKeyButton);
            this.Controls.Add(this.endingLabel);
            this.Controls.Add(this.endingBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditChordDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Chord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditChordDialog_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endingBox;
        private System.Windows.Forms.Label endingLabel;
        private System.Windows.Forms.Button changeKeyButton;
        private System.Windows.Forms.Label changeKeyLabel;
    }
}