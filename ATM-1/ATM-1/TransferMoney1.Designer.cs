namespace ATM_1
{
    partial class TransferMoney1
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
            this.txtzhanghao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjine = new System.Windows.Forms.TextBox();
            this.btnzhuanzhang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入账号：";
            // 
            // txtzhanghao
            // 
            this.txtzhanghao.Location = new System.Drawing.Point(153, 22);
            this.txtzhanghao.Name = "txtzhanghao";
            this.txtzhanghao.Size = new System.Drawing.Size(172, 21);
            this.txtzhanghao.TabIndex = 1;
            this.txtzhanghao.TextChanged += new System.EventHandler(this.txtzhanghao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入金额：";
            // 
            // txtjine
            // 
            this.txtjine.Location = new System.Drawing.Point(153, 66);
            this.txtjine.Name = "txtjine";
            this.txtjine.Size = new System.Drawing.Size(172, 21);
            this.txtjine.TabIndex = 3;
            this.txtjine.TextChanged += new System.EventHandler(this.txtjine_TextChanged);
            // 
            // btnzhuanzhang
            // 
            this.btnzhuanzhang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnzhuanzhang.Location = new System.Drawing.Point(164, 131);
            this.btnzhuanzhang.Name = "btnzhuanzhang";
            this.btnzhuanzhang.Size = new System.Drawing.Size(75, 23);
            this.btnzhuanzhang.TabIndex = 4;
            this.btnzhuanzhang.Text = "确定转账";
            this.btnzhuanzhang.UseVisualStyleBackColor = true;
            this.btnzhuanzhang.Click += new System.EventHandler(this.btnzhuanzhang_Click);
            // 
            // TransferMoney1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 166);
            this.Controls.Add(this.btnzhuanzhang);
            this.Controls.Add(this.txtjine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtzhanghao);
            this.Controls.Add(this.label1);
            this.Name = "TransferMoney1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转账";
            this.Load += new System.EventHandler(this.TransferMoney1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtzhanghao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjine;
        private System.Windows.Forms.Button btnzhuanzhang;
    }
}