﻿namespace WindowsFormsApp1
{
    partial class Form1
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

        //region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.allUser_lst = new System.Windows.Forms.ListBox();
            this.allUser_lst = new System.Windows.Forms.ListBox();
            this.arcUser_lst = new System.Windows.Forms.ListBox();
            this.remArc_btn = new System.Windows.Forms.Button();
            this.addArc_btn = new System.Windows.Forms.Button();
            this.arcSel_btn = new System.Windows.Forms.Button();
            this.toggleAttr_btn = new System.Windows.Forms.Button();
            this.sam_txtbx = new System.Windows.Forms.TextBox();
            this.mail_txtbx = new System.Windows.Forms.TextBox();
            this.lastLogin_txtbx = new System.Windows.Forms.TextBox();
            this.cp_txtbx = new System.Windows.Forms.TextBox();
            this.enabled_txtbx = new System.Windows.Forms.TextBox();
            this.hw_txtbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.desc_txtbx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UserDataPath_txtbx = new System.Windows.Forms.TextBox();
            this.RedirPath_txtbx = new System.Windows.Forms.TextBox();
            this.CPPPath_txtbx = new System.Windows.Forms.TextBox();
            this.desktopPath_txtbx = new System.Windows.Forms.TextBox();
            this.DocsPath_txtbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();

            this.SuspendLayout();
            //
            // form
            //
            this.Location = new System.Drawing.Point(14, 12);
            this.Size = new System.Drawing.Size(436, 339);
            this.Name = "Form1";
            this.ResumeLayout(false);

            //
            //allUser_lst
            //
            this.allUser_lst.FormattingEnabled = true;
            this.allUser_lst.Location = new System.Drawing.Point(13, 39);
            this.allUser_lst.Name = "allUser_lst";
            this.allUser_lst.Size = new System.Drawing.Size(213, 316);
            this.allUser_lst.TabIndex = 0;
            //
            //arcUser_lst
            //
            this.arcUser_lst.FormattingEnabled = true;
            this.arcUser_lst.Location = new System.Drawing.Point(313, 39);
            this.arcUser_lst.Name = "arcUser_lst";
            this.arcUser_lst.Size = new System.Drawing.Size(213, 316);
            this.arcUser_lst.TabIndex = 1;
            //this.arcUser_lst.add_SelectedIndexChanged(this.arcUser_lst_SelectedIndexChanged);
            //;
            //remArc_btn;
            //;
            this.remArc_btn.Location = new System.Drawing.Point(232, 195);
            this.remArc_btn.Name = "remArc_btn";
            this.remArc_btn.Size = new System.Drawing.Size(75, 23);
            this.remArc_btn.TabIndex = 2;
            this.remArc_btn.Text = "< Remove";
            this.remArc_btn.UseVisualStyleBackColor = true;
            //this.remArc_btn.add_Click(this.remArc_btn_Click);
            //;
            //addArc_btn;
            //;
            this.addArc_btn.Location = new System.Drawing.Point(232, 166);
            this.addArc_btn.Name = "addArc_btn";
            this.addArc_btn.Size = new System.Drawing.Size(75, 23);
            this.addArc_btn.TabIndex = 3;
            this.addArc_btn.Text = "Add >";
            this.addArc_btn.UseVisualStyleBackColor = true;
            //this.addArc_btn.add_Click(this.addArc_btn_Click);
            //;
            //label1;
            //;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-8, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1920, 3);
            this.label1.TabIndex = 4;
            this.label1.Text = " ";
            //;
            //arcSel_btn;
            //;
            this.arcSel_btn.Location = new System.Drawing.Point(426, 372);
            this.arcSel_btn.Name = "arcSel_btn";
            this.arcSel_btn.Size = new System.Drawing.Size(100, 23);
            this.arcSel_btn.TabIndex = 5;
            this.arcSel_btn.Text = "Archive Selected";
            this.arcSel_btn.UseVisualStyleBackColor = true;
            //this.arcSel_btn.add_Click(this.arcSel_btn_Click);
            //;
            //toggleAttr_btn;
            //;
            this.toggleAttr_btn.Location = new System.Drawing.Point(13, 372);
            this.toggleAttr_btn.Name = "toggleAttr_btn";
            this.toggleAttr_btn.Size = new System.Drawing.Size(100, 23);
            this.toggleAttr_btn.TabIndex = 6;
            this.toggleAttr_btn.Text = "Toggle Attributes";
            this.toggleAttr_btn.UseVisualStyleBackColor = true;
            //this.toggleAttr_btn.add_Click(this.toggleAttr_btn_Click);
            //;
            //label2;
            //;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(542, -25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 500);
            this.label2.TabIndex = 7;
            this.label2.Text = " ";
            //;
            //label3;
            //;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SAMaccountName";
            //;
            //sam_txtbx;
            //;
            this.sam_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sam_txtbx.Location = new System.Drawing.Point(563, 30);
            this.sam_txtbx.Name = "sam_txtbx";
            this.sam_txtbx.ReadOnly = true;
            this.sam_txtbx.Size = new System.Drawing.Size(171, 20);
            this.sam_txtbx.TabIndex = 10;
            //;
            //mail_txtbx;
            //;
            this.mail_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mail_txtbx.Location = new System.Drawing.Point(750, 30);
            this.mail_txtbx.Name = "mail_txtbx";
            this.mail_txtbx.ReadOnly = true;
            this.mail_txtbx.Size = new System.Drawing.Size(171, 20);
            this.mail_txtbx.TabIndex = 12;
            //;
            //label5;
            //;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            //;
            //lastLogin_txtbx;
            //;
            this.lastLogin_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastLogin_txtbx.Location = new System.Drawing.Point(750, 74);
            this.lastLogin_txtbx.Name = "lastLogin_txtbx";
            this.lastLogin_txtbx.ReadOnly = true;
            this.lastLogin_txtbx.Size = new System.Drawing.Size(171, 20);
            this.lastLogin_txtbx.TabIndex = 16;
            //;
            //label4;
            //;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last Logon";
            //;
            //cp_txtbx;
            //;
            this.cp_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cp_txtbx.Location = new System.Drawing.Point(563, 74);
            this.cp_txtbx.Name = "cp_txtbx";
            this.cp_txtbx.ReadOnly = true;
            this.cp_txtbx.Size = new System.Drawing.Size(171, 20);
            this.cp_txtbx.TabIndex = 14;
            //;
            //label6;
            //;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CP Server";
            //;
            //UserDataPath_txtbx;
            //;
            this.UserDataPath_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserDataPath_txtbx.ForeColor = System.Drawing.Color.Blue;
            this.UserDataPath_txtbx.Location = new System.Drawing.Point(750, 162);
            this.UserDataPath_txtbx.Name = "UserDataPath_txtbx";
            this.UserDataPath_txtbx.ReadOnly = true;
            this.UserDataPath_txtbx.Size = new System.Drawing.Size(171, 20);
            this.UserDataPath_txtbx.TabIndex = 24;
            //;
            //label7;
            //;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "UserData Path";
            //;
            //RedirPath_txtbx;
            //;
            this.RedirPath_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RedirPath_txtbx.ForeColor = System.Drawing.Color.Blue;
            this.RedirPath_txtbx.Location = new System.Drawing.Point(563, 162);
            this.RedirPath_txtbx.Name = "RedirPath_txtbx";
            this.RedirPath_txtbx.ReadOnly = true;
            this.RedirPath_txtbx.Size = new System.Drawing.Size(171, 20);
            this.RedirPath_txtbx.TabIndex = 22;
            //;
            //label8;
            //;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Redirected Profile Path";
            //;
            //CPPPath_txtbx;
            //;
            this.CPPPath_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CPPPath_txtbx.ForeColor = System.Drawing.Color.Blue;
            this.CPPPath_txtbx.Location = new System.Drawing.Point(750, 118);
            this.CPPPath_txtbx.Name = "CPPPath_txtbx";
            this.CPPPath_txtbx.ReadOnly = true;
            this.CPPPath_txtbx.Size = new System.Drawing.Size(171, 20);
            this.CPPPath_txtbx.TabIndex = 20;
            //;
            //label9;
            //;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Citrix Profile Path";
            //;
            //enabled_txtbx;
            //;
            this.enabled_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enabled_txtbx.Location = new System.Drawing.Point(563, 118);
            this.enabled_txtbx.Name = "enabled_txtbx";
            this.enabled_txtbx.ReadOnly = true;
            this.enabled_txtbx.Size = new System.Drawing.Size(171, 20);
            this.enabled_txtbx.TabIndex = 18;
            //;
            //label10;
            //;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Account Enabled";
            //;
            //hw_txtbx;
            //;
            this.hw_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hw_txtbx.Location = new System.Drawing.Point(563, 294);
            this.hw_txtbx.Name = "hw_txtbx";
            this.hw_txtbx.ReadOnly = true;
            this.hw_txtbx.Size = new System.Drawing.Size(358, 20);
            this.hw_txtbx.TabIndex = 30;
            //;
            //label14;
            //;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(560, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Hardware (Based on AD Description)";
            //;
            //desc_txtbx;
            //;
            this.desc_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.desc_txtbx.Location = new System.Drawing.Point(563, 250);
            this.desc_txtbx.Name = "desc_txtbx";
            this.desc_txtbx.ReadOnly = true;
            this.desc_txtbx.Size = new System.Drawing.Size(358, 20);
            this.desc_txtbx.TabIndex = 26;
            //;
            //label16;
            //;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(560, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Description";
            //;
            //label11;
            //;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Users to be Archived";
            //;
            //label12;
            //;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Users";
            //;
            //button2;
            //;
            this.button2.Location = new System.Drawing.Point(232, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            //this.button2.add_Click(this.button2_Click);
            this.button2.Visible = false;
            //;
            //desktopPath_txtbx;
            //;
            this.desktopPath_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.desktopPath_txtbx.ForeColor = System.Drawing.Color.Blue;
            this.desktopPath_txtbx.Location = new System.Drawing.Point(750, 206);
            this.desktopPath_txtbx.Name = "desktopPath_txtbx";
            this.desktopPath_txtbx.ReadOnly = true;
            this.desktopPath_txtbx.Size = new System.Drawing.Size(171, 20);
            this.desktopPath_txtbx.TabIndex = 37;
            //;
            //label13;
            //;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(747, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Desktop Path";
            //;
            //DocsPath_txtbx;
            //;
            this.DocsPath_txtbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DocsPath_txtbx.ForeColor = System.Drawing.Color.Blue;
            this.DocsPath_txtbx.Location = new System.Drawing.Point(563, 206);
            this.DocsPath_txtbx.Name = "DocsPath_txtbx";
            this.DocsPath_txtbx.ReadOnly = true;
            this.DocsPath_txtbx.Size = new System.Drawing.Size(171, 20);
            this.DocsPath_txtbx.TabIndex = 35;
            //;
            //label15;
            //;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(560, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Docs Path";
            //;
            //MainForm;
            //;
            this.ClientSize = new System.Drawing.Size(938, 400);
            this.Controls.Add(this.desktopPath_txtbx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DocsPath_txtbx);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hw_txtbx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.desc_txtbx);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.UserDataPath_txtbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RedirPath_txtbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CPPPath_txtbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.enabled_txtbx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lastLogin_txtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cp_txtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mail_txtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sam_txtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toggleAttr_btn);
            this.Controls.Add(this.arcSel_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addArc_btn);
            this.Controls.Add(this.remArc_btn);
            this.Controls.Add(this.arcUser_lst);
            this.Controls.Add(this.allUser_lst);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "AD Archive Tool";
            //this.add_Load(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox allUser_lst;
        private System.Windows.Forms.ListBox arcUser_lst;
        private System.Windows.Forms.Button remArc_btn;
        private System.Windows.Forms.Button addArc_btn;
        private System.Windows.Forms.Button arcSel_btn;
        private System.Windows.Forms.Button toggleAttr_btn;
        private System.Windows.Forms.TextBox sam_txtbx;
        private System.Windows.Forms.TextBox mail_txtbx;
        private System.Windows.Forms.TextBox lastLogin_txtbx;
        private System.Windows.Forms.TextBox cp_txtbx;
        private System.Windows.Forms.TextBox enabled_txtbx ;
        private System.Windows.Forms.TextBox hw_txtbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox desc_txtbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UserDataPath_txtbx;
        private System.Windows.Forms.TextBox RedirPath_txtbx;
        private System.Windows.Forms.TextBox CPPPath_txtbx;
        private System.Windows.Forms.TextBox desktopPath_txtbx;
        private System.Windows.Forms.TextBox DocsPath_txtbx;
        private System.Windows.Forms.Button button1;


    }
}

