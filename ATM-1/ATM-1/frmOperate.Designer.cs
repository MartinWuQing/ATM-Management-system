namespace ATM_1
{
    partial class frmOperate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperate));
            this.btnBalance = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChangePassWord = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSaveMoney = new System.Windows.Forms.Button();
            this.btnGetMoney = new System.Windows.Forms.Button();
            this.btnChageMony = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalance
            // 
            this.btnBalance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBalance.Location = new System.Drawing.Point(50, 36);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(117, 44);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.Text = "查询余额";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(50, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "查询明细";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangePassWord.Location = new System.Drawing.Point(50, 249);
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(117, 47);
            this.btnChangePassWord.TabIndex = 2;
            this.btnChangePassWord.Text = "修改密码";
            this.btnChangePassWord.UseVisualStyleBackColor = true;
            this.btnChangePassWord.Click += new System.EventHandler(this.btnChangePassWord_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.ForeColor = System.Drawing.Color.Red;
            this.btnUp.Location = new System.Drawing.Point(50, 353);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(117, 46);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "返回上一步";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSaveMoney
            // 
            this.btnSaveMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveMoney.Location = new System.Drawing.Point(344, 36);
            this.btnSaveMoney.Name = "btnSaveMoney";
            this.btnSaveMoney.Size = new System.Drawing.Size(125, 44);
            this.btnSaveMoney.TabIndex = 4;
            this.btnSaveMoney.Text = "存款";
            this.btnSaveMoney.UseVisualStyleBackColor = true;
            this.btnSaveMoney.Click += new System.EventHandler(this.btnSaveMoney_Click);
            // 
            // btnGetMoney
            // 
            this.btnGetMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetMoney.Location = new System.Drawing.Point(344, 143);
            this.btnGetMoney.Name = "btnGetMoney";
            this.btnGetMoney.Size = new System.Drawing.Size(125, 43);
            this.btnGetMoney.TabIndex = 5;
            this.btnGetMoney.Text = "取款";
            this.btnGetMoney.UseVisualStyleBackColor = true;
            this.btnGetMoney.Click += new System.EventHandler(this.btnGetMoney_Click);
            // 
            // btnChageMony
            // 
            this.btnChageMony.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChageMony.Location = new System.Drawing.Point(344, 249);
            this.btnChageMony.Name = "btnChageMony";
            this.btnChageMony.Size = new System.Drawing.Size(125, 47);
            this.btnChageMony.TabIndex = 6;
            this.btnChageMony.Text = "转账";
            this.btnChageMony.UseVisualStyleBackColor = true;
            this.btnChageMony.Click += new System.EventHandler(this.btnChageMony_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(344, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 459);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChageMony);
            this.Controls.Add(this.btnGetMoney);
            this.Controls.Add(this.btnSaveMoney);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnChangePassWord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBalance);
            this.Name = "frmOperate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM操作平台";
            this.Load += new System.EventHandler(this.frmOperate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChangePassWord;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSaveMoney;
        private System.Windows.Forms.Button btnGetMoney;
        private System.Windows.Forms.Button btnChageMony;
        private System.Windows.Forms.Button btnCancel;
    }
}