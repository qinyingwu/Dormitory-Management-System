namespace 宿舍管理系统
{
    partial class mAlterPsw
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
            this.tbxzhshow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxpsw1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxpsw2 = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前账号：";
            // 
            // tbxzhshow
            // 
            this.tbxzhshow.Location = new System.Drawing.Point(48, 55);
            this.tbxzhshow.Name = "tbxzhshow";
            this.tbxzhshow.ReadOnly = true;
            this.tbxzhshow.Size = new System.Drawing.Size(173, 25);
            this.tbxzhshow.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入新密码：";
            // 
            // tbxpsw1
            // 
            this.tbxpsw1.Location = new System.Drawing.Point(48, 158);
            this.tbxpsw1.Name = "tbxpsw1";
            this.tbxpsw1.Size = new System.Drawing.Size(173, 25);
            this.tbxpsw1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "请再次输入新密码：";
            // 
            // tbxpsw2
            // 
            this.tbxpsw2.Location = new System.Drawing.Point(48, 268);
            this.tbxpsw2.Name = "tbxpsw2";
            this.tbxpsw2.Size = new System.Drawing.Size(173, 25);
            this.tbxpsw2.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(97, 345);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(90, 32);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "确认修改";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // mAlterPsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 440);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbxpsw2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxpsw1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxzhshow);
            this.Controls.Add(this.label1);
            this.Name = "mAlterPsw";
            this.Text = "mAlterPsw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxzhshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxpsw1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxpsw2;
        private System.Windows.Forms.Button btnsubmit;
    }
}