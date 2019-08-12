namespace 宿舍管理系统
{
    partial class mAlterEtmsg
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelshow = new System.Windows.Forms.Label();
            this.btnalter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 25);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入寝室号：";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(182, 51);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "查询状况";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前状况";
            // 
            // labelshow
            // 
            this.labelshow.AutoSize = true;
            this.labelshow.Location = new System.Drawing.Point(34, 139);
            this.labelshow.Name = "labelshow";
            this.labelshow.Size = new System.Drawing.Size(55, 15);
            this.labelshow.TabIndex = 4;
            this.labelshow.Text = "label3";
            // 
            // btnalter
            // 
            this.btnalter.Location = new System.Drawing.Point(95, 297);
            this.btnalter.Name = "btnalter";
            this.btnalter.Size = new System.Drawing.Size(113, 36);
            this.btnalter.TabIndex = 5;
            this.btnalter.Text = "确定修改";
            this.btnalter.UseVisualStyleBackColor = true;
            // 
            // AlterEtmsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 407);
            this.Controls.Add(this.btnalter);
            this.Controls.Add(this.labelshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AlterEtmsg";
            this.Text = "AlterEtmsg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelshow;
        private System.Windows.Forms.Button btnalter;
    }
}