namespace PresentationLayer
{
    partial class MainForm
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
            this.positionsBtn = new System.Windows.Forms.Button();
            this.politiciansBtn = new System.Windows.Forms.Button();
            this.partiesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionsBtn
            // 
            this.positionsBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.positionsBtn.Location = new System.Drawing.Point(686, 800);
            this.positionsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.positionsBtn.Name = "positionsBtn";
            this.positionsBtn.Size = new System.Drawing.Size(283, 125);
            this.positionsBtn.TabIndex = 2;
            this.positionsBtn.Text = "Positions";
            this.positionsBtn.UseVisualStyleBackColor = true;
            this.positionsBtn.Click += new System.EventHandler(this.positionsBtn_Click);
            // 
            // politiciansBtn
            // 
            this.politiciansBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.politiciansBtn.Location = new System.Drawing.Point(686, 541);
            this.politiciansBtn.Margin = new System.Windows.Forms.Padding(2);
            this.politiciansBtn.Name = "politiciansBtn";
            this.politiciansBtn.Size = new System.Drawing.Size(283, 125);
            this.politiciansBtn.TabIndex = 3;
            this.politiciansBtn.Text = "Politicians";
            this.politiciansBtn.UseVisualStyleBackColor = true;
            this.politiciansBtn.Click += new System.EventHandler(this.politiciansBtn_Click);
            // 
            // partiesBtn
            // 
            this.partiesBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.partiesBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.partiesBtn.Location = new System.Drawing.Point(1269, 541);
            this.partiesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.partiesBtn.Name = "partiesBtn";
            this.partiesBtn.Size = new System.Drawing.Size(283, 125);
            this.partiesBtn.TabIndex = 4;
            this.partiesBtn.Text = "Parties";
            this.partiesBtn.UseVisualStyleBackColor = true;
            this.partiesBtn.Click += new System.EventHandler(this.partiesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitBtn.Location = new System.Drawing.Point(1269, 800);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(283, 125);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(594, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1037, 125);
            this.label1.TabIndex = 6;
            this.label1.Text = "Government Database";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(2263, 1228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.partiesBtn);
            this.Controls.Add(this.politiciansBtn);
            this.Controls.Add(this.positionsBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Menu Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button positionsBtn;
        private System.Windows.Forms.Button politiciansBtn;
        private System.Windows.Forms.Button partiesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
    }
}
