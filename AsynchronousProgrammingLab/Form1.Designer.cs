namespace AsynchronousProgrammingLab
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
            lblFile1 = new Label();
            lblFile2 = new Label();
            lblResults1 = new Label();
            lblResults2 = new Label();
            btnBrowse1 = new Button();
            btnBrowse2 = new Button();
            txtFile2 = new TextBox();
            txtFile1 = new TextBox();
            lstBook1 = new ListBox();
            lstBook2 = new ListBox();
            btnSubmit = new Button();
            btnExit = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblFile1
            // 
            lblFile1.AutoSize = true;
            lblFile1.Location = new Point(26, 107);
            lblFile1.Name = "lblFile1";
            lblFile1.Size = new Size(46, 15);
            lblFile1.TabIndex = 0;
            lblFile1.Text = "Book 1:";
            // 
            // lblFile2
            // 
            lblFile2.AutoSize = true;
            lblFile2.Location = new Point(444, 106);
            lblFile2.Name = "lblFile2";
            lblFile2.Size = new Size(46, 15);
            lblFile2.TabIndex = 1;
            lblFile2.Text = "Book 2:";
            // 
            // lblResults1
            // 
            lblResults1.AutoSize = true;
            lblResults1.Location = new Point(99, 292);
            lblResults1.Name = "lblResults1";
            lblResults1.Size = new Size(0, 15);
            lblResults1.TabIndex = 2;
            // 
            // lblResults2
            // 
            lblResults2.AutoSize = true;
            lblResults2.Location = new Point(544, 292);
            lblResults2.Name = "lblResults2";
            lblResults2.Size = new Size(0, 15);
            lblResults2.TabIndex = 3;
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(251, 100);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(75, 23);
            btnBrowse1.TabIndex = 4;
            btnBrowse1.Text = "Browse...";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(669, 98);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(75, 23);
            btnBrowse2.TabIndex = 5;
            btnBrowse2.Text = "Browse...";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(496, 98);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(167, 23);
            txtFile2.TabIndex = 7;
            // 
            // txtFile1
            // 
            txtFile1.Location = new Point(78, 100);
            txtFile1.Name = "txtFile1";
            txtFile1.Size = new Size(167, 23);
            txtFile1.TabIndex = 8;
            // 
            // lstBook1
            // 
            lstBook1.FormattingEnabled = true;
            lstBook1.Location = new Point(26, 143);
            lstBook1.Name = "lstBook1";
            lstBook1.Size = new Size(321, 139);
            lstBook1.TabIndex = 9;
            // 
            // lstBook2
            // 
            lstBook2.FormattingEnabled = true;
            lstBook2.Location = new Point(423, 143);
            lstBook2.Name = "lstBook2";
            lstBook2.Size = new Size(321, 139);
            lstBook2.TabIndex = 10;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(272, 329);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(423, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(lstBook2);
            Controls.Add(lstBook1);
            Controls.Add(txtFile1);
            Controls.Add(txtFile2);
            Controls.Add(btnBrowse2);
            Controls.Add(btnBrowse1);
            Controls.Add(lblResults2);
            Controls.Add(lblResults1);
            Controls.Add(lblFile2);
            Controls.Add(lblFile1);
            Name = "Form1";
            Text = "Deshyah Anderson's Book Word Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile1;
        private Label lblFile2;
        private Label lblResults1;
        private Label lblResults2;
        private Button btnBrowse1;
        private Button btnBrowse2;
        private TextBox txtFile2;
        private TextBox txtFile1;
        private ListBox lstBook1;
        private ListBox lstBook2;
        private Button btnSubmit;
        private Button btnExit;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}
