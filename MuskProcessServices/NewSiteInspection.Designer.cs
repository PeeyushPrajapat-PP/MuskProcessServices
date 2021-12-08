
namespace MuskProcessServices
{
    partial class NewSiteInspection
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
            this.commentField = new System.Windows.Forms.TextBox();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.actionTakenField = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.workAreaField = new System.Windows.Forms.TextBox();
            this.jobDescriptionField = new System.Windows.Forms.TextBox();
            this.typeField = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sectionDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.inspectorDropdown = new System.Windows.Forms.ComboBox();
            this.supervisorDropdown = new System.Windows.Forms.ComboBox();
            this.siteDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.finishBtn = new System.Windows.Forms.Button();
            this.countField = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentField
            // 
            this.commentField.Location = new System.Drawing.Point(568, 306);
            this.commentField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentField.Multiline = true;
            this.commentField.Name = "commentField";
            this.commentField.Size = new System.Drawing.Size(130, 44);
            this.commentField.TabIndex = 7;
            this.commentField.Text = "Type here..";
            this.commentField.TextChanged += new System.EventHandler(this.commentField_TextChanged);
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.AutoSize = true;
            this.completedCheckBox.BackColor = System.Drawing.Color.White;
            this.completedCheckBox.Location = new System.Drawing.Point(568, 378);
            this.completedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(109, 24);
            this.completedCheckBox.TabIndex = 8;
            this.completedCheckBox.Text = "completed";
            this.completedCheckBox.UseVisualStyleBackColor = false;
            // 
            // actionTakenField
            // 
            this.actionTakenField.Location = new System.Drawing.Point(568, 432);
            this.actionTakenField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actionTakenField.Multiline = true;
            this.actionTakenField.Name = "actionTakenField";
            this.actionTakenField.Size = new System.Drawing.Size(130, 44);
            this.actionTakenField.TabIndex = 9;
            this.actionTakenField.Text = "Type here..";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(568, 515);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(447, 255);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 19);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Intervention";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(447, 432);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 19);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Action Taken";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(447, 306);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 19);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Site";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Work Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Supervisor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(64, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Job Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Inspector";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Type";
            // 
            // workAreaField
            // 
            this.workAreaField.Location = new System.Drawing.Point(210, 360);
            this.workAreaField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workAreaField.Name = "workAreaField";
            this.workAreaField.Size = new System.Drawing.Size(136, 26);
            this.workAreaField.TabIndex = 29;
            // 
            // jobDescriptionField
            // 
            this.jobDescriptionField.Location = new System.Drawing.Point(210, 511);
            this.jobDescriptionField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobDescriptionField.Name = "jobDescriptionField";
            this.jobDescriptionField.Size = new System.Drawing.Size(136, 26);
            this.jobDescriptionField.TabIndex = 31;
            // 
            // typeField
            // 
            this.typeField.Location = new System.Drawing.Point(187, 406);
            this.typeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(136, 26);
            this.typeField.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(447, 202);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 19);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Section";
            // 
            // sectionDropdown
            // 
            this.sectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionDropdown.FormattingEnabled = true;
            this.sectionDropdown.Items.AddRange(new object[] {
            "Working Standards",
            "Quality",
            "Site Rules",
            "Environmental",
            "Protection of Individuals",
            "Equipment",
            "Other"});
            this.sectionDropdown.Location = new System.Drawing.Point(568, 202);
            this.sectionDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sectionDropdown.Name = "sectionDropdown";
            this.sectionDropdown.Size = new System.Drawing.Size(136, 28);
            this.sectionDropdown.TabIndex = 17;
            this.sectionDropdown.SelectedIndexChanged += new System.EventHandler(this.sectionDropdown_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.inspectorDropdown);
            this.groupBox1.Controls.Add(this.supervisorDropdown);
            this.groupBox1.Controls.Add(this.siteDropdown);
            this.groupBox1.Controls.Add(this.typeField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(24, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(381, 586);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBtn.Location = new System.Drawing.Point(228, 471);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(94, 35);
            this.createBtn.TabIndex = 38;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // inspectorDropdown
            // 
            this.inspectorDropdown.FormattingEnabled = true;
            this.inspectorDropdown.Items.AddRange(new object[] {
            "Add New Site.."});
            this.inspectorDropdown.Location = new System.Drawing.Point(187, 299);
            this.inspectorDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inspectorDropdown.Name = "inspectorDropdown";
            this.inspectorDropdown.Size = new System.Drawing.Size(136, 28);
            this.inspectorDropdown.TabIndex = 27;
            // 
            // supervisorDropdown
            // 
            this.supervisorDropdown.FormattingEnabled = true;
            this.supervisorDropdown.Items.AddRange(new object[] {
            "Add New Site.."});
            this.supervisorDropdown.Location = new System.Drawing.Point(187, 251);
            this.supervisorDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supervisorDropdown.Name = "supervisorDropdown";
            this.supervisorDropdown.Size = new System.Drawing.Size(136, 28);
            this.supervisorDropdown.TabIndex = 26;
            // 
            // siteDropdown
            // 
            this.siteDropdown.FormattingEnabled = true;
            this.siteDropdown.Items.AddRange(new object[] {
            "Add New Site.."});
            this.siteDropdown.Location = new System.Drawing.Point(187, 149);
            this.siteDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siteDropdown.Name = "siteDropdown";
            this.siteDropdown.Size = new System.Drawing.Size(136, 28);
            this.siteDropdown.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.finishBtn);
            this.groupBox2.Controls.Add(this.countField);
            this.groupBox2.Location = new System.Drawing.Point(411, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(866, 586);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // finishBtn
            // 
            this.finishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finishBtn.Location = new System.Drawing.Point(554, 492);
            this.finishBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(94, 35);
            this.finishBtn.TabIndex = 36;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(158, 98);
            this.countField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countField.Name = "countField";
            this.countField.Size = new System.Drawing.Size(136, 26);
            this.countField.TabIndex = 38;
            this.countField.TextChanged += new System.EventHandler(this.countField_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backBtn.Location = new System.Drawing.Point(68, 62);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(84, 52);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Pink;
            this.logoutBtn.Location = new System.Drawing.Point(1154, 62);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(84, 52);
            this.logoutBtn.TabIndex = 36;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewSiteInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1290, 825);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.jobDescriptionField);
            this.Controls.Add(this.workAreaField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionDropdown);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.actionTakenField);
            this.Controls.Add(this.completedCheckBox);
            this.Controls.Add(this.commentField);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewSiteInspection";
            this.Text = "Add New Site Inspection";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox commentField;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.TextBox actionTakenField;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox workAreaField;
        private System.Windows.Forms.TextBox jobDescriptionField;
        private System.Windows.Forms.TextBox typeField;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox sectionDropdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox siteDropdown;
        private System.Windows.Forms.ComboBox inspectorDropdown;
        private System.Windows.Forms.ComboBox supervisorDropdown;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox countField;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
    

}