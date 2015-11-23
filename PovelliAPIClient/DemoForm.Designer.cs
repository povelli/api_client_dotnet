namespace PovelliProductUpdate
{
    partial class DemoForm
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
            this.storeUID = new System.Windows.Forms.TextBox();
            this.UPC = new System.Windows.Forms.TextBox();
            this.productTitle = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAssign = new System.Windows.Forms.Panel();
            this.assignBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.templates = new System.Windows.Forms.ComboBox();
            this.labelCheck = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.labelBarcode = new System.Windows.Forms.TextBox();
            this.assignPanelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
            this.sizeFilter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UPCFilter = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.apiResponse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.labelAssign.SuspendLayout();
            this.labelCheck.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(9, 141);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
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
            this.privateKey.Text = "977bb7f0524343a3202fb6c6806d9ea4934d1b00";
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(114, 59);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(280, 20);
            this.publicKey.TabIndex = 2;
            this.publicKey.TabStop = false;
            this.publicKey.Text = "f76534228489449d904e8d0c1b8cff90";
            // 
            // storeUID
            // 
            this.storeUID.Location = new System.Drawing.Point(114, 86);
            this.storeUID.Name = "storeUID";
            this.storeUID.Size = new System.Drawing.Size(264, 20);
            this.storeUID.TabIndex = 3;
            this.storeUID.TabStop = false;
            this.storeUID.Text = "45bd16aa782d4db9a09f6ee1f52726a9";
            // 
            // UPC
            // 
            this.UPC.Location = new System.Drawing.Point(120, 147);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(145, 20);
            this.UPC.TabIndex = 0;
            this.UPC.Text = "123123";
            // 
            // productTitle
            // 
            this.productTitle.Location = new System.Drawing.Point(120, 204);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(280, 20);
            this.productTitle.TabIndex = 2;
            this.productTitle.Text = "test";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(120, 231);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(55, 20);
            this.productPrice.TabIndex = 3;
            this.productPrice.Text = "10";
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
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Store UID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product UPC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Size/Packaging";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(120, 176);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(73, 20);
            this.size.TabIndex = 1;
            this.size.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 194);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Add / Update";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAssign);
            this.groupBox2.Controls.Add(this.labelCheck);
            this.groupBox2.Controls.Add(this.assignPanelBtn);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.statusBtn);
            this.groupBox2.Controls.Add(this.sizeFilter);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UPCFilter);
            this.groupBox2.Location = new System.Drawing.Point(447, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 194);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Status";
            // 
            // labelAssign
            // 
            this.labelAssign.Controls.Add(this.assignBtn);
            this.labelAssign.Controls.Add(this.label11);
            this.labelAssign.Controls.Add(this.templates);
            this.labelAssign.Location = new System.Drawing.Point(29, 146);
            this.labelAssign.Name = "labelAssign";
            this.labelAssign.Size = new System.Drawing.Size(328, 30);
            this.labelAssign.TabIndex = 20;
            this.labelAssign.Visible = false;
            // 
            // assignBtn
            // 
            this.assignBtn.Location = new System.Drawing.Point(222, 3);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(75, 23);
            this.assignBtn.TabIndex = 31;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Template";
            // 
            // templates
            // 
            this.templates.FormattingEnabled = true;
            this.templates.Location = new System.Drawing.Point(85, 3);
            this.templates.Name = "templates";
            this.templates.Size = new System.Drawing.Size(121, 21);
            this.templates.TabIndex = 19;
            // 
            // labelCheck
            // 
            this.labelCheck.Controls.Add(this.label8);
            this.labelCheck.Controls.Add(this.checkBtn);
            this.labelCheck.Controls.Add(this.labelBarcode);
            this.labelCheck.Location = new System.Drawing.Point(29, 117);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(328, 30);
            this.labelCheck.TabIndex = 19;
            this.labelCheck.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Label Barcode";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(222, -1);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 30;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // labelBarcode
            // 
            this.labelBarcode.Location = new System.Drawing.Point(85, 3);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(100, 20);
            this.labelBarcode.TabIndex = 26;
            this.labelBarcode.Text = "33554474";
            // 
            // assignPanelBtn
            // 
            this.assignPanelBtn.Location = new System.Drawing.Point(236, 80);
            this.assignPanelBtn.Name = "assignPanelBtn";
            this.assignPanelBtn.Size = new System.Drawing.Size(109, 23);
            this.assignPanelBtn.TabIndex = 25;
            this.assignPanelBtn.Text = "Assign Label";
            this.assignPanelBtn.UseVisualStyleBackColor = true;
            this.assignPanelBtn.Click += new System.EventHandler(this.assignPanelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(90, 80);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // statusBtn
            // 
            this.statusBtn.Location = new System.Drawing.Point(9, 80);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(75, 23);
            this.statusBtn.TabIndex = 23;
            this.statusBtn.Text = "Status";
            this.statusBtn.UseVisualStyleBackColor = true;
            this.statusBtn.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // sizeFilter
            // 
            this.sizeFilter.Location = new System.Drawing.Point(108, 46);
            this.sizeFilter.Name = "sizeFilter";
            this.sizeFilter.Size = new System.Drawing.Size(73, 20);
            this.sizeFilter.TabIndex = 20;
            this.sizeFilter.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Product UPC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Size/Packaging";
            // 
            // UPCFilter
            // 
            this.UPCFilter.Location = new System.Drawing.Point(108, 17);
            this.UPCFilter.Name = "UPCFilter";
            this.UPCFilter.Size = new System.Drawing.Size(145, 20);
            this.UPCFilter.TabIndex = 19;
            this.UPCFilter.Text = "123123";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.apiResponse);
            this.groupBox3.Location = new System.Drawing.Point(15, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(847, 158);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "API Response";
            // 
            // apiResponse
            // 
            this.apiResponse.Location = new System.Drawing.Point(7, 20);
            this.apiResponse.Multiline = true;
            this.apiResponse.Name = "apiResponse";
            this.apiResponse.Size = new System.Drawing.Size(834, 132);
            this.apiResponse.TabIndex = 0;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 521);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productTitle);
            this.Controls.Add(this.UPC);
            this.Controls.Add(this.storeUID);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.groupBox1);
            this.Name = "DemoForm";
            this.Text = "Povelli API Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.labelAssign.ResumeLayout(false);
            this.labelAssign.PerformLayout();
            this.labelCheck.ResumeLayout(false);
            this.labelCheck.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox storeUID;
        private System.Windows.Forms.TextBox UPC;
        private System.Windows.Forms.TextBox productTitle;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel labelAssign;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox templates;
        private System.Windows.Forms.Panel labelCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox labelBarcode;
        private System.Windows.Forms.Button assignPanelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.TextBox sizeFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UPCFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox apiResponse;
    }
}

