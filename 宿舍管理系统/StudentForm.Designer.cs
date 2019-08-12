namespace 宿舍管理系统
{
    partial class StudentForm
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
            this.btngetmsg = new System.Windows.Forms.Button();
            this.btnAlterqs = new System.Windows.Forms.Button();
            this.btnEtmsg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimeshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎，";
            // 
            // btngetmsg
            // 
            this.btngetmsg.Location = new System.Drawing.Point(41, 158);
            this.btngetmsg.Name = "btngetmsg";
            this.btngetmsg.Size = new System.Drawing.Size(130, 41);
            this.btngetmsg.TabIndex = 1;
            this.btngetmsg.Text = "查询寝室情况";
            this.btngetmsg.UseVisualStyleBackColor = true;
            // 
            // btnAlterqs
            // 
            this.btnAlterqs.Location = new System.Drawing.Point(41, 232);
            this.btnAlterqs.Name = "btnAlterqs";
            this.btnAlterqs.Size = new System.Drawing.Size(130, 41);
            this.btnAlterqs.TabIndex = 2;
            this.btnAlterqs.Text = "申请更换宿舍";
            this.btnAlterqs.UseVisualStyleBackColor = true;
            // 
            // btnEtmsg
            // 
            this.btnEtmsg.Location = new System.Drawing.Point(41, 306);
            this.btnEtmsg.Name = "btnEtmsg";
            this.btnEtmsg.Size = new System.Drawing.Size(130, 41);
            this.btnEtmsg.TabIndex = 3;
            this.btnEtmsg.Text = "上报电气损伤";
            this.btnEtmsg.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前时间为：";
            // 
            // labelTimeshow
            // 
            this.labelTimeshow.AutoSize = true;
            this.labelTimeshow.Location = new System.Drawing.Point(38, 97);
            this.labelTimeshow.Name = "labelTimeshow";
            this.labelTimeshow.Size = new System.Drawing.Size(55, 15);
            this.labelTimeshow.TabIndex = 5;
            this.labelTimeshow.Text = "label3";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 426);
            this.Controls.Add(this.labelTimeshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEtmsg);
            this.Controls.Add(this.btnAlterqs);
            this.Controls.Add(this.btngetmsg);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngetmsg;
        private System.Windows.Forms.Button btnAlterqs;
        private System.Windows.Forms.Button btnEtmsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTimeshow;
    }
}