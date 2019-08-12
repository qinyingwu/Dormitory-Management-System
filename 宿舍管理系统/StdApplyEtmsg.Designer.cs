namespace 宿舍管理系统
{
    partial class StdApplyEtmsg
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
            this.cbxdoor = new System.Windows.Forms.CheckBox();
            this.cbxfs = new System.Windows.Forms.CheckBox();
            this.cbxkt = new System.Windows.Forms.CheckBox();
            this.cbxnq = new System.Windows.Forms.CheckBox();
            this.cbxlight = new System.Windows.Forms.CheckBox();
            this.cbxwindow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxdoor
            // 
            this.cbxdoor.AutoSize = true;
            this.cbxdoor.Location = new System.Drawing.Point(39, 64);
            this.cbxdoor.Name = "cbxdoor";
            this.cbxdoor.Size = new System.Drawing.Size(44, 19);
            this.cbxdoor.TabIndex = 0;
            this.cbxdoor.Text = "门";
            this.cbxdoor.UseVisualStyleBackColor = true;
            // 
            // cbxfs
            // 
            this.cbxfs.AutoSize = true;
            this.cbxfs.Location = new System.Drawing.Point(39, 89);
            this.cbxfs.Name = "cbxfs";
            this.cbxfs.Size = new System.Drawing.Size(59, 19);
            this.cbxfs.TabIndex = 1;
            this.cbxfs.Text = "风扇";
            this.cbxfs.UseVisualStyleBackColor = true;
            // 
            // cbxkt
            // 
            this.cbxkt.AutoSize = true;
            this.cbxkt.Location = new System.Drawing.Point(39, 115);
            this.cbxkt.Name = "cbxkt";
            this.cbxkt.Size = new System.Drawing.Size(59, 19);
            this.cbxkt.TabIndex = 2;
            this.cbxkt.Text = "空调";
            this.cbxkt.UseVisualStyleBackColor = true;
            // 
            // cbxnq
            // 
            this.cbxnq.AutoSize = true;
            this.cbxnq.Location = new System.Drawing.Point(39, 140);
            this.cbxnq.Name = "cbxnq";
            this.cbxnq.Size = new System.Drawing.Size(59, 19);
            this.cbxnq.TabIndex = 3;
            this.cbxnq.Text = "暖气";
            this.cbxnq.UseVisualStyleBackColor = true;
            // 
            // cbxlight
            // 
            this.cbxlight.AutoSize = true;
            this.cbxlight.Location = new System.Drawing.Point(39, 165);
            this.cbxlight.Name = "cbxlight";
            this.cbxlight.Size = new System.Drawing.Size(59, 19);
            this.cbxlight.TabIndex = 4;
            this.cbxlight.Text = "电灯";
            this.cbxlight.UseVisualStyleBackColor = true;
            // 
            // cbxwindow
            // 
            this.cbxwindow.AutoSize = true;
            this.cbxwindow.Location = new System.Drawing.Point(39, 190);
            this.cbxwindow.Name = "cbxwindow";
            this.cbxwindow.Size = new System.Drawing.Size(59, 19);
            this.cbxwindow.TabIndex = 5;
            this.cbxwindow.Text = "窗户";
            this.cbxwindow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择损坏器物：";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(39, 233);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(85, 35);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "上报损坏";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // StdApplyEtmsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 311);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxwindow);
            this.Controls.Add(this.cbxlight);
            this.Controls.Add(this.cbxnq);
            this.Controls.Add(this.cbxkt);
            this.Controls.Add(this.cbxfs);
            this.Controls.Add(this.cbxdoor);
            this.Name = "StdApplyEtmsg";
            this.Text = "StdApplyEtmsg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxdoor;
        private System.Windows.Forms.CheckBox cbxfs;
        private System.Windows.Forms.CheckBox cbxkt;
        private System.Windows.Forms.CheckBox cbxnq;
        private System.Windows.Forms.CheckBox cbxlight;
        private System.Windows.Forms.CheckBox cbxwindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
    }
}