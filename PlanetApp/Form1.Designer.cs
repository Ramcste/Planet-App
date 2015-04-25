namespace PlanetApp
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
            this.planetListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planetListComboBox
            // 
            this.planetListComboBox.FormattingEnabled = true;
            this.planetListComboBox.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"});
            this.planetListComboBox.Location = new System.Drawing.Point(151, 61);
            this.planetListComboBox.Name = "planetListComboBox";
            this.planetListComboBox.Size = new System.Drawing.Size(121, 21);
            this.planetListComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet Name";
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(159, 140);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(113, 23);
            this.showDetailsButton.TabIndex = 2;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 283);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planetListComboBox);
            this.Name = "Form1";
            this.Text = "Planet UI App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox planetListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showDetailsButton;
    }
}

