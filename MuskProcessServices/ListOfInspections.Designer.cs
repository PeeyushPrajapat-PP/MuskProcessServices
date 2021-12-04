
namespace MuskProcessServices
{
    partial class ListOfInspections
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
            this.headingText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.siteDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enteredByDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthDropdown = new System.Windows.Forms.ComboBox();
            this.yearDropdown = new System.Windows.Forms.ComboBox();
            this.yeardropdownLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dgvListOfInspections = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInspections)).BeginInit();
            this.SuspendLayout();
            // 
            // headingText
            // 
            this.headingText.AutoSize = true;
            this.headingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.headingText.Location = new System.Drawing.Point(610, 178);
            this.headingText.Name = "headingText";
            this.headingText.Size = new System.Drawing.Size(316, 42);
            this.headingText.TabIndex = 0;
            this.headingText.Text = "List of Inspections";
            this.headingText.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MuskProcessServices.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(617, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.backBtn.Location = new System.Drawing.Point(31, 57);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(125, 38);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.logoutBtn.Location = new System.Drawing.Point(1321, 57);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(125, 38);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(28, 325);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(135, 17);
            this.welcomeText.TabIndex = 5;
            this.welcomeText.Text = "Welcome, John Doe";
            this.welcomeText.UseMnemonic = false;
            this.welcomeText.Click += new System.EventHandler(this.label2_Click);
            // 
            // siteDropdown
            // 
            this.siteDropdown.FormattingEnabled = true;
            this.siteDropdown.Location = new System.Drawing.Point(31, 410);
            this.siteDropdown.Name = "siteDropdown";
            this.siteDropdown.Size = new System.Drawing.Size(193, 24);
            this.siteDropdown.TabIndex = 6;
            this.siteDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(33, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Site:";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(292, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entered by:";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // enteredByDropdown
            // 
            this.enteredByDropdown.FormattingEnabled = true;
            this.enteredByDropdown.Location = new System.Drawing.Point(290, 410);
            this.enteredByDropdown.Name = "enteredByDropdown";
            this.enteredByDropdown.Size = new System.Drawing.Size(193, 24);
            this.enteredByDropdown.TabIndex = 8;
            this.enteredByDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(548, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Month:";
            this.label3.UseMnemonic = false;
            // 
            // monthDropdown
            // 
            this.monthDropdown.FormattingEnabled = true;
            this.monthDropdown.Location = new System.Drawing.Point(546, 410);
            this.monthDropdown.Name = "monthDropdown";
            this.monthDropdown.Size = new System.Drawing.Size(112, 24);
            this.monthDropdown.TabIndex = 10;
            this.monthDropdown.SelectedIndexChanged += new System.EventHandler(this.monthDropdown_SelectedIndexChanged);
            // 
            // yearDropdown
            // 
            this.yearDropdown.FormattingEnabled = true;
            this.yearDropdown.Location = new System.Drawing.Point(688, 410);
            this.yearDropdown.Name = "yearDropdown";
            this.yearDropdown.Size = new System.Drawing.Size(72, 24);
            this.yearDropdown.TabIndex = 12;
            this.yearDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // yeardropdownLabel
            // 
            this.yeardropdownLabel.AutoSize = true;
            this.yeardropdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.yeardropdownLabel.Location = new System.Drawing.Point(685, 389);
            this.yeardropdownLabel.Name = "yeardropdownLabel";
            this.yeardropdownLabel.Size = new System.Drawing.Size(47, 17);
            this.yeardropdownLabel.TabIndex = 13;
            this.yeardropdownLabel.Text = "Year:";
            this.yeardropdownLabel.UseMnemonic = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.searchBtn.Location = new System.Drawing.Point(1273, 396);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 38);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dgvListOfInspections
            // 
            this.dgvListOfInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfInspections.Location = new System.Drawing.Point(31, 523);
            this.dgvListOfInspections.Name = "dgvListOfInspections";
            this.dgvListOfInspections.RowHeadersWidth = 51;
            this.dgvListOfInspections.RowTemplate.Height = 24;
            this.dgvListOfInspections.Size = new System.Drawing.Size(1169, 150);
            this.dgvListOfInspections.TabIndex = 15;
            // 
            // ListOfInspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 809);
            this.Controls.Add(this.dgvListOfInspections);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.yeardropdownLabel);
            this.Controls.Add(this.yearDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enteredByDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siteDropdown);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headingText);
            this.Name = "ListOfInspections";
            this.Text = "ListOfInspections";
            this.Load += new System.EventHandler(this.ListOfInspections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfInspections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.ComboBox siteDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox enteredByDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthDropdown;
        private System.Windows.Forms.ComboBox yearDropdown;
        private System.Windows.Forms.Label yeardropdownLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dgvListOfInspections;
    }
}