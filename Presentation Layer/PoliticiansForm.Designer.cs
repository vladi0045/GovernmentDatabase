namespace PresentationLayer
{
    partial class PoliticiansForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.middleNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.partyComboBox = new System.Windows.Forms.ComboBox();
            this.partyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.positionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.politicianBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.politicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.positionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.politiciansDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.politicianBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.politicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.politiciansDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(110, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "Politician";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(322, 300);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(261, 47);
            this.firstNameTxtBox.TabIndex = 4;
            // 
            // middleNameTxtBox
            // 
            this.middleNameTxtBox.Location = new System.Drawing.Point(363, 389);
            this.middleNameTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.middleNameTxtBox.Name = "middleNameTxtBox";
            this.middleNameTxtBox.Size = new System.Drawing.Size(261, 47);
            this.middleNameTxtBox.TabIndex = 5;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(322, 490);
            this.lastNameTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(261, 47);
            this.lastNameTxtBox.TabIndex = 6;
            // 
            // partyComboBox
            // 
            this.partyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.partyBindingSource3, "Id", true));
            this.partyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partyBindingSource3, "Id", true));
            this.partyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partyComboBox.FormattingEnabled = true;
            this.partyComboBox.Location = new System.Drawing.Point(246, 687);
            this.partyComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.partyComboBox.Name = "partyComboBox";
            this.partyComboBox.Size = new System.Drawing.Size(316, 49);
            this.partyComboBox.TabIndex = 7;
            // 
            // partyBindingSource3
            // 
            this.partyBindingSource3.DataSource = typeof(BusinessLayer.Party);
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataSource = typeof(BusinessLayer.Party);
            // 
            // positionComboBox
            // 
            this.positionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.positionBindingSource2, "Id", true));
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(283, 779);
            this.positionComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(316, 49);
            this.positionComboBox.TabIndex = 8;
            // 
            // positionBindingSource2
            // 
            this.positionBindingSource2.DataSource = typeof(BusinessLayer.Position);
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(BusinessLayer.Position);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(132, 950);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(249, 47);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2022, 6, 22, 3, 9, 28, 0);
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(243, 590);
            this.ageNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(108, 47);
            this.ageNumericUpDown.TabIndex = 10;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // politicianBindingSource1
            // 
            this.politicianBindingSource1.DataSource = typeof(BusinessLayer.Politician);
            // 
            // politicianBindingSource
            // 
            this.politicianBindingSource.DataSource = typeof(BusinessLayer.Politician);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(123, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(123, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(123, 490);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 46);
            this.label4.TabIndex = 17;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(123, 589);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 46);
            this.label5.TabIndex = 18;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(123, 687);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 46);
            this.label6.TabIndex = 19;
            this.label6.Text = "Party";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(123, 779);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 46);
            this.label7.TabIndex = 20;
            this.label7.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(123, 873);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 46);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date of Appointment";
            // 
            // partyBindingSource1
            // 
            this.partyBindingSource1.DataSource = typeof(BusinessLayer.Party);
            // 
            // partyBindingSource2
            // 
            this.partyBindingSource2.DataSource = typeof(BusinessLayer.Party);
            // 
            // createBtn
            // 
            this.createBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createBtn.Location = new System.Drawing.Point(1116, 895);
            this.createBtn.Margin = new System.Windows.Forms.Padding(6);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(200, 59);
            this.createBtn.TabIndex = 22;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.updateBtn.Location = new System.Drawing.Point(1537, 895);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(6);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(200, 59);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.deleteBtn.Location = new System.Drawing.Point(1116, 1024);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(200, 59);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.exitBtn.Location = new System.Drawing.Point(1537, 1024);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 59);
            this.exitBtn.TabIndex = 25;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // positionBindingSource1
            // 
            this.positionBindingSource1.DataSource = typeof(BusinessLayer.Position);
            // 
            // politiciansDataGridView
            // 
            this.politiciansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.politiciansDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.politiciansDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.politiciansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.politiciansDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.politiciansDataGridView.Location = new System.Drawing.Point(684, 107);
            this.politiciansDataGridView.Name = "politiciansDataGridView";
            this.politiciansDataGridView.ReadOnly = true;
            this.politiciansDataGridView.RowHeadersWidth = 102;
            this.politiciansDataGridView.RowTemplate.Height = 49;
            this.politiciansDataGridView.Size = new System.Drawing.Size(1523, 721);
            this.politiciansDataGridView.TabIndex = 26;
            this.politiciansDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.politiciansDataGridView_CellClick);
            // 
            // PoliticiansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(2263, 1228);
            this.Controls.Add(this.politiciansDataGridView);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.partyComboBox);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.middleNameTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PoliticiansForm";
            this.Text = "Politicians Form";
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.politicianBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.politicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.politiciansDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.TextBox middleNameTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.ComboBox partyComboBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.DataGridView politiciansDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.BindingSource partyBindingSource1;
        private System.Windows.Forms.BindingSource partyBindingSource2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.BindingSource politicianBindingSource;
        private System.Windows.Forms.BindingSource politicianBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAppointment;
        private System.Windows.Forms.BindingSource positionBindingSource1;
        private System.Windows.Forms.BindingSource partyBindingSource3;
        private System.Windows.Forms.BindingSource positionBindingSource2;
        private System.Windows.Forms.DataGridView productsDataGridView;
    }
}