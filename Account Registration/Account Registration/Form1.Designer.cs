namespace Account_Registration
{
    partial class FrmRegistration
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
            this.studentnotb = new System.Windows.Forms.TextBox();
            this.stdntno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lntb = new System.Windows.Forms.TextBox();
            this.programcb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fntb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mntb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.agetb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactnotb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nextbtn = new System.Windows.Forms.Button();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentnotb
            // 
            this.studentnotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnotb.Location = new System.Drawing.Point(12, 32);
            this.studentnotb.Name = "studentnotb";
            this.studentnotb.Size = new System.Drawing.Size(239, 26);
            this.studentnotb.TabIndex = 0;
            this.studentnotb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentnotb_KeyPress);
            // 
            // stdntno
            // 
            this.stdntno.AutoSize = true;
            this.stdntno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdntno.Location = new System.Drawing.Point(13, 9);
            this.stdntno.Name = "stdntno";
            this.stdntno.Size = new System.Drawing.Size(115, 20);
            this.stdntno.TabIndex = 1;
            this.stdntno.Text = "Student No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Program :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name :";
            // 
            // lntb
            // 
            this.lntb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lntb.Location = new System.Drawing.Point(16, 112);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(235, 26);
            this.lntb.TabIndex = 4;
            this.lntb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lntb_KeyPress);
            // 
            // programcb
            // 
            this.programcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programcb.FormattingEnabled = true;
            this.programcb.Items.AddRange(new object[] {
            "Bachelor Of Science In Information Technology",
            "Bachelor Of Science In Computer Science",
            "Bachelor Of Science In Computer Engineering"});
            this.programcb.Location = new System.Drawing.Point(270, 30);
            this.programcb.Name = "programcb";
            this.programcb.Size = new System.Drawing.Size(485, 28);
            this.programcb.TabIndex = 6;
            this.programcb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.programcb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name :";
            // 
            // fntb
            // 
            this.fntb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fntb.Location = new System.Drawing.Point(266, 112);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(235, 26);
            this.fntb.TabIndex = 7;
            this.fntb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fntb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Middle Name :";
            // 
            // mntb
            // 
            this.mntb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mntb.Location = new System.Drawing.Point(520, 112);
            this.mntb.Name = "mntb";
            this.mntb.Size = new System.Drawing.Size(235, 26);
            this.mntb.TabIndex = 9;
            this.mntb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mntb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Age :";
            // 
            // agetb
            // 
            this.agetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetb.Location = new System.Drawing.Point(16, 194);
            this.agetb.Name = "agetb";
            this.agetb.Size = new System.Drawing.Size(235, 26);
            this.agetb.TabIndex = 11;
            this.agetb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agetb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact No. :";
            // 
            // contactnotb
            // 
            this.contactnotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnotb.Location = new System.Drawing.Point(270, 194);
            this.contactnotb.Name = "contactnotb";
            this.contactnotb.Size = new System.Drawing.Size(235, 26);
            this.contactnotb.TabIndex = 13;
            this.contactnotb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactnotb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address :";
            // 
            // nextbtn
            // 
            this.nextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.Location = new System.Drawing.Point(312, 403);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(162, 37);
            this.nextbtn.TabIndex = 18;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // addresstb
            // 
            this.addresstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstb.Location = new System.Drawing.Point(12, 275);
            this.addresstb.Multiline = true;
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(742, 122);
            this.addresstb.TabIndex = 19;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactnotb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agetb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mntb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fntb);
            this.Controls.Add(this.programcb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lntb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stdntno);
            this.Controls.Add(this.studentnotb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentnotb;
        private System.Windows.Forms.Label stdntno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lntb;
        private System.Windows.Forms.ComboBox programcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fntb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mntb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agetb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactnotb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.TextBox addresstb;
    }
}

