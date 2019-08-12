namespace 宿舍管理系统
{
    partial class mAlterStd
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelmsgshow = new System.Windows.Forms.Label();
            this.btnsearchkc = new System.Windows.Forms.Button();
            this.listboxqsshow = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelmsgshow
            // 
            this.labelmsgshow.AutoSize = true;
            this.labelmsgshow.Location = new System.Drawing.Point(45, 104);
            this.labelmsgshow.Name = "labelmsgshow";
            this.labelmsgshow.Size = new System.Drawing.Size(55, 15);
            this.labelmsgshow.TabIndex = 2;
            this.labelmsgshow.Text = "label1";
            // 
            // btnsearchkc
            // 
            this.btnsearchkc.Location = new System.Drawing.Point(48, 186);
            this.btnsearchkc.Name = "btnsearchkc";
            this.btnsearchkc.Size = new System.Drawing.Size(186, 23);
            this.btnsearchkc.TabIndex = 3;
            this.btnsearchkc.Text = "显示当前有空床的寝室";
            this.btnsearchkc.UseVisualStyleBackColor = true;
            // 
            // listboxqsshow
            // 
            this.listboxqsshow.FormattingEnabled = true;
            this.listboxqsshow.ItemHeight = 15;
            this.listboxqsshow.Location = new System.Drawing.Point(48, 225);
            this.listboxqsshow.Name = "listboxqsshow";
            this.listboxqsshow.Size = new System.Drawing.Size(331, 184);
            this.listboxqsshow.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "确定修改";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "请输入学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "点击修改密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "点击修改寝室信息";
            // 
            // mAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listboxqsshow);
            this.Controls.Add(this.btnsearchkc);
            this.Controls.Add(this.labelmsgshow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "mAlter";
            this.Text = "mAlter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelmsgshow;
        private System.Windows.Forms.Button btnsearchkc;
        private System.Windows.Forms.ListBox listboxqsshow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}