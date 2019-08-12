namespace 宿舍管理系统
{
    partial class ManagerForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MbtnAdd = new System.Windows.Forms.Button();
            this.Mbtndelete = new System.Windows.Forms.Button();
            this.mbtnsearch = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnCutEt2 = new System.Windows.Forms.Button();
            this.btnCutEt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前时间";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 25);
            this.textBox1.TabIndex = 1;
            // 
            // MbtnAdd
            // 
            this.MbtnAdd.Location = new System.Drawing.Point(95, 146);
            this.MbtnAdd.Name = "MbtnAdd";
            this.MbtnAdd.Size = new System.Drawing.Size(75, 23);
            this.MbtnAdd.TabIndex = 2;
            this.MbtnAdd.Text = "添加";
            this.MbtnAdd.UseVisualStyleBackColor = true;
            // 
            // Mbtndelete
            // 
            this.Mbtndelete.Location = new System.Drawing.Point(250, 146);
            this.Mbtndelete.Name = "Mbtndelete";
            this.Mbtndelete.Size = new System.Drawing.Size(75, 23);
            this.Mbtndelete.TabIndex = 3;
            this.Mbtndelete.Text = "删除";
            this.Mbtndelete.UseVisualStyleBackColor = true;
            // 
            // mbtnsearch
            // 
            this.mbtnsearch.Location = new System.Drawing.Point(95, 218);
            this.mbtnsearch.Name = "mbtnsearch";
            this.mbtnsearch.Size = new System.Drawing.Size(75, 23);
            this.mbtnsearch.TabIndex = 4;
            this.mbtnsearch.Text = "查询";
            this.mbtnsearch.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(180, 98);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(250, 218);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 23);
            this.btnchange.TabIndex = 7;
            this.btnchange.Text = "修改信息";
            this.btnchange.UseVisualStyleBackColor = true;
            // 
            // btnCutEt2
            // 
            this.btnCutEt2.Location = new System.Drawing.Point(250, 287);
            this.btnCutEt2.Name = "btnCutEt2";
            this.btnCutEt2.Size = new System.Drawing.Size(75, 23);
            this.btnCutEt2.TabIndex = 8;
            this.btnCutEt2.Text = "一键断电";
            this.btnCutEt2.UseVisualStyleBackColor = true;
            // 
            // btnCutEt1
            // 
            this.btnCutEt1.Location = new System.Drawing.Point(95, 287);
            this.btnCutEt1.Name = "btnCutEt1";
            this.btnCutEt1.Size = new System.Drawing.Size(75, 23);
            this.btnCutEt1.TabIndex = 9;
            this.btnCutEt1.Text = "断电";
            this.btnCutEt1.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 338);
            this.Controls.Add(this.btnCutEt1);
            this.Controls.Add(this.btnCutEt2);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.mbtnsearch);
            this.Controls.Add(this.Mbtndelete);
            this.Controls.Add(this.MbtnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MbtnAdd;
        private System.Windows.Forms.Button Mbtndelete;
        private System.Windows.Forms.Button mbtnsearch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnCutEt2;
        private System.Windows.Forms.Button btnCutEt1;
    }
}