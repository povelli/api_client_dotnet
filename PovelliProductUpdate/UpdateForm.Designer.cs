namespace PovelliProductUpdate
{
    partial class UpdateForm
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.storeID = new System.Windows.Forms.TextBox();
            this.UPC = new System.Windows.Forms.TextBox();
            this.productTitle = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apiResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(15, 243);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(114, 33);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(280, 20);
            this.privateKey.TabIndex = 1;
            this.privateKey.TabStop = false;
            this.privateKey.Text = "e37dee6f43e1fb43c728bf7794fcc08f8c34463c";
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(114, 59);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(280, 20);
            this.publicKey.TabIndex = 2;
            this.publicKey.TabStop = false;
            this.publicKey.Text = "b21305e7a8354f989fed1bf25d719264";
            // 
            // storeID
            // 
            this.storeID.Location = new System.Drawing.Point(114, 86);
            this.storeID.Name = "storeID";
            this.storeID.Size = new System.Drawing.Size(100, 20);
            this.storeID.TabIndex = 3;
            this.storeID.TabStop = false;
            this.storeID.Text = "8";
            // 
            // UPC
            // 
            this.UPC.Location = new System.Drawing.Point(114, 151);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(145, 20);
            this.UPC.TabIndex = 0;
            // 
            // productTitle
            // 
            this.productTitle.Location = new System.Drawing.Point(114, 178);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(280, 20);
            this.productTitle.TabIndex = 1;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(114, 205);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(55, 20);
            this.productPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Public Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Store ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product UPC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // apiResponse
            // 
            this.apiResponse.AutoSize = true;
            this.apiResponse.Location = new System.Drawing.Point(111, 248);
            this.apiResponse.Name = "apiResponse";
            this.apiResponse.Size = new System.Drawing.Size(0, 13);
            this.apiResponse.TabIndex = 13;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 292);
            this.Controls.Add(this.apiResponse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productTitle);
            this.Controls.Add(this.UPC);
            this.Controls.Add(this.storeID);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.sendBtn);
            this.Name = "UpdateForm";
            this.Text = "Povelli Product Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox storeID;
        private System.Windows.Forms.TextBox UPC;
        private System.Windows.Forms.TextBox productTitle;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label apiResponse;
    }
}

