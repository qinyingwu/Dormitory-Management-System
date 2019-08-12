namespace 宿舍管理系统
{
    partial class StdApplyAlterqs
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
            this.labelqsshow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.labelinfshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前寝室：";
            // 
            // labelqsshow
            // 
            this.labelqsshow.AutoSize = true;
            this.labelqsshow.Location = new System.Drawing.Point(113, 26);
            this.labelqsshow.Name = "labelqsshow";
            this.labelqsshow.Size = new System.Drawing.Size(55, 15);
            this.labelqsshow.TabIndex = 1;
            this.labelqsshow.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入你想要的寝室号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 25);
            this.textBox1.TabIndex = 3;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(217, 128);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "确定";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // labelinfshow
            // 
            this.labelinfshow.AutoSize = true;
            this.labelinfshow.Location = new System.Drawing.Point(40, 190);
            this.labelinfshow.Name = "labelinfshow";
            this.labelinfshow.Size = new System.Drawing.Size(55, 15);
            this.labelinfshow.TabIndex = 5;
            this.labelinfshow.Text = "label3";
            // 
            // StdApplyAlterqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 358);
            this.Controls.Add(this.labelinfshow);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelqsshow);
            this.Controls.Add(this.label1);
            this.Name = "StdApplyAlterqs";
            this.Text = "StdApplyAlterqs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelqsshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label labelinfshow;
    }
}