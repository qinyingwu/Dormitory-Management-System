namespace 宿舍管理系统
{
    partial class Searchadd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxqsh = new System.Windows.Forms.TextBox();
            this.tbxch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxzhuanye = new System.Windows.Forms.TextBox();
            this.tbxclass = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "寝室号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "床号：";
            // 
            // tbxqsh
            // 
            this.tbxqsh.Location = new System.Drawing.Point(141, 44);
            this.tbxqsh.Name = "tbxqsh";
            this.tbxqsh.ReadOnly = true;
            this.tbxqsh.Size = new System.Drawing.Size(102, 25);
            this.tbxqsh.TabIndex = 2;
            // 
            // tbxch
            // 
            this.tbxch.Location = new System.Drawing.Point(141, 75);
            this.tbxch.Name = "tbxch";
            this.tbxch.ReadOnly = true;
            this.tbxch.Size = new System.Drawing.Size(102, 25);
            this.tbxch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "确定添加如下信息吗？";
            // 
            // tbxzhuanye
            // 
            this.tbxzhuanye.Location = new System.Drawing.Point(141, 178);
            this.tbxzhuanye.Name = "tbxzhuanye";
            this.tbxzhuanye.Size = new System.Drawing.Size(141, 25);
            this.tbxzhuanye.TabIndex = 41;
            // 
            // tbxclass
            // 
            this.tbxclass.Location = new System.Drawing.Point(141, 143);
            this.tbxclass.Name = "tbxclass";
            this.tbxclass.Size = new System.Drawing.Size(141, 25);
            this.tbxclass.TabIndex = 40;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(141, 106);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(141, 25);
            this.tbxname.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "专业 ：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "班级：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "姓名：";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(86, 236);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(176, 23);
            this.btnsubmit.TabIndex = 42;
            this.btnsubmit.Text = "确定";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // Searchadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 313);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbxzhuanye);
            this.Controls.Add(this.tbxclass);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxch);
            this.Controls.Add(this.tbxqsh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Searchadd";
            this.Text = "Searchadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxqsh;
        private System.Windows.Forms.TextBox tbxch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxzhuanye;
        private System.Windows.Forms.TextBox tbxclass;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsubmit;
    }
}