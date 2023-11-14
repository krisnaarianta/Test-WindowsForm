namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAlamat = new TextBox();
            txtNo_handphone = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoaddata = new Button();
            dgvData = new DataGridView();
            btn_qr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 38);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "DATA USERS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 106);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 140);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 171);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "No Handphone";
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(140, 23);
            txtName.TabIndex = 4;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(167, 137);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(140, 23);
            txtAlamat.TabIndex = 5;
            // 
            // txtNo_handphone
            // 
            txtNo_handphone.Location = new Point(167, 168);
            txtNo_handphone.Name = "txtNo_handphone";
            txtNo_handphone.Size = new Size(140, 23);
            txtNo_handphone.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(326, 103);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(88, 88);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(420, 103);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 88);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(514, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 88);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoaddata
            // 
            btnLoaddata.Location = new Point(608, 379);
            btnLoaddata.Name = "btnLoaddata";
            btnLoaddata.Size = new Size(88, 37);
            btnLoaddata.TabIndex = 11;
            btnLoaddata.Text = "Load Data";
            btnLoaddata.UseVisualStyleBackColor = true;
            btnLoaddata.Click += btnLoaddata_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(61, 208);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(635, 150);
            dgvData.TabIndex = 12;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellContentClick += dgvData_CellClick;
            dgvData.CellContentDoubleClick += dgvData_CellClick;
            dgvData.CellDoubleClick += dgvData_CellClick;
            // 
            // btn_qr
            // 
            btn_qr.Location = new Point(608, 103);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(88, 88);
            btn_qr.TabIndex = 13;
            btn_qr.Text = "Generate QR";
            btn_qr.UseVisualStyleBackColor = true;
            btn_qr.Click += btn_qr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(btn_qr);
            Controls.Add(dgvData);
            Controls.Add(btnLoaddata);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtNo_handphone);
            Controls.Add(txtAlamat);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAlamat;
        private TextBox txtNo_handphone;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoaddata;
        private DataGridView dgvData;
        private Button btn_qr;
    }
}