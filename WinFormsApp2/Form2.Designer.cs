namespace WinFormsApp2
{
    partial class Form2
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
            pb_qr = new PictureBox();
            lb_qr = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_qr).BeginInit();
            SuspendLayout();
            // 
            // pb_qr
            // 
            pb_qr.Location = new Point(46, 26);
            pb_qr.Name = "pb_qr";
            pb_qr.Size = new Size(278, 246);
            pb_qr.TabIndex = 0;
            pb_qr.TabStop = false;
            // 
            // lb_qr
            // 
            lb_qr.AutoSize = true;
            lb_qr.Location = new Point(46, 290);
            lb_qr.Name = "lb_qr";
            lb_qr.Size = new Size(38, 15);
            lb_qr.TabIndex = 1;
            lb_qr.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(lb_qr);
            Controls.Add(pb_qr);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pb_qr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_qr;
        private Label lb_qr;
    }
}