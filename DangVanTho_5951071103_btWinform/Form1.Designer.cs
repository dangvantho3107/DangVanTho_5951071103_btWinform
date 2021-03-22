namespace DangVanTho_5951071103_btWinform
{
    partial class Form1
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
            this.StudentRecordData = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtHName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtNName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentRecordData
            // 
            this.StudentRecordData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordData.Location = new System.Drawing.Point(97, 274);
            this.StudentRecordData.Name = "StudentRecordData";
            this.StudentRecordData.Size = new System.Drawing.Size(587, 150);
            this.StudentRecordData.TabIndex = 31;
            this.StudentRecordData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordData_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(371, 245);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 28;
            this.btnApply.Text = "Xác lập";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(241, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Cập nhập";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên sinh viên";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(94, 197);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(40, 13);
            this.lb.TabIndex = 23;
            this.lb.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số báo danh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ sinh viên";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(609, 103);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 20;
            // 
            // txtHName
            // 
            this.txtHName.Location = new System.Drawing.Point(609, 26);
            this.txtHName.Name = "txtHName";
            this.txtHName.Size = new System.Drawing.Size(100, 20);
            this.txtHName.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(241, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 18;
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(241, 104);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 20);
            this.txtRoll.TabIndex = 17;
            // 
            // txtNName
            // 
            this.txtNName.Location = new System.Drawing.Point(241, 27);
            this.txtNName.Name = "txtNName";
            this.txtNName.Size = new System.Drawing.Size(100, 20);
            this.txtNName.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentRecordData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtHName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.txtNName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentRecordData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtHName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.TextBox txtNName;
    }
}

