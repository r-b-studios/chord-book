namespace ChordBook
{
    partial class Line
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
            this.components = new System.ComponentModel.Container();
            this.textLabel = new System.Windows.Forms.TextBox();
            this.addChordButton = new System.Windows.Forms.Button();
            this.chord1 = new ChordBook.Chord(this.components);
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.SystemColors.Control;
            this.textLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(50, 27);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(440, 18);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Servus du Masthuhn";
            // 
            // addChordButton
            // 
            this.addChordButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addChordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.addChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChordButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addChordButton.Location = new System.Drawing.Point(10, 10);
            this.addChordButton.Name = "addChordButton";
            this.addChordButton.Size = new System.Drawing.Size(30, 30);
            this.addChordButton.TabIndex = 1;
            this.addChordButton.Text = "C";
            this.addChordButton.UseVisualStyleBackColor = false;
            // 
            // chord1
            // 
            this.chord1.AutoSize = true;
            this.chord1.Font = new System.Drawing.Font("Consolas", 12F);
            this.chord1.Location = new System.Drawing.Point(320, 10);
            this.chord1.Name = "chord1";
            this.chord1.Size = new System.Drawing.Size(63, 19);
            this.chord1.TabIndex = 2;
            this.chord1.Text = "chord1";
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.chord1);
            this.Controls.Add(this.addChordButton);
            this.Controls.Add(this.textLabel);
            this.Name = "Line";
            this.Size = new System.Drawing.Size(500, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.Button addChordButton;
        private Chord chord1;
    }
}
