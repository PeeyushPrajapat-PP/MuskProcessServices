namespace MuskProcessServices
{
    partial class Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewSiteInspectionBtn = new System.Windows.Forms.Button();
            this.listOfInspectionsBtn = new System.Windows.Forms.Button();
            this.monthlyReportBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(523, 197);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(48, 17);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MuskProcessServices.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(396, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addNewSiteInspectionBtn
            // 
            this.addNewSiteInspectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSiteInspectionBtn.Location = new System.Drawing.Point(332, 233);
            this.addNewSiteInspectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewSiteInspectionBtn.Name = "addNewSiteInspectionBtn";
            this.addNewSiteInspectionBtn.Size = new System.Drawing.Size(425, 59);
            this.addNewSiteInspectionBtn.TabIndex = 2;
            this.addNewSiteInspectionBtn.Text = "Add a New Site Inspection Report";
            this.addNewSiteInspectionBtn.UseVisualStyleBackColor = true;
            this.addNewSiteInspectionBtn.Click += new System.EventHandler(this.addNewSiteInspectionBtn_Click);
            // 
            // listOfInspectionsBtn
            // 
            this.listOfInspectionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfInspectionsBtn.Location = new System.Drawing.Point(332, 314);
            this.listOfInspectionsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.listOfInspectionsBtn.Name = "listOfInspectionsBtn";
            this.listOfInspectionsBtn.Size = new System.Drawing.Size(425, 59);
            this.listOfInspectionsBtn.TabIndex = 3;
            this.listOfInspectionsBtn.Text = "View Site Inspection Reports";
            this.listOfInspectionsBtn.UseVisualStyleBackColor = true;
            this.listOfInspectionsBtn.Click += new System.EventHandler(this.listOfInspectionsBtn_Click);
            // 
            // monthlyReportBtn
            // 
            this.monthlyReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyReportBtn.Location = new System.Drawing.Point(332, 395);
            this.monthlyReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.monthlyReportBtn.Name = "monthlyReportBtn";
            this.monthlyReportBtn.Size = new System.Drawing.Size(425, 59);
            this.monthlyReportBtn.TabIndex = 4;
            this.monthlyReportBtn.Text = "View Monthly Report";
            this.monthlyReportBtn.UseVisualStyleBackColor = true;
            this.monthlyReportBtn.Click += new System.EventHandler(this.monthlyReportBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(514, 489);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 34);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.monthlyReportBtn);
            this.Controls.Add(this.listOfInspectionsBtn);
            this.Controls.Add(this.addNewSiteInspectionBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addNewSiteInspectionBtn;
        private System.Windows.Forms.Button listOfInspectionsBtn;
        private System.Windows.Forms.Button monthlyReportBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}