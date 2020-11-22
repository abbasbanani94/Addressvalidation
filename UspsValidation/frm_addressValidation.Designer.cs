namespace UspsValidation
{
    partial class frm_addressValidation
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name : ";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFileName.Location = new System.Drawing.Point(158, 27);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(506, 32);
            this.txtFileName.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(670, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtUserId.Location = new System.Drawing.Point(158, 82);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(273, 32);
            this.txtUserId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID : ";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAdd1.Location = new System.Drawing.Point(158, 137);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(215, 32);
            this.txtAdd1.TabIndex = 3;
            this.txtAdd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address 1 Index : ";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAdd2.Location = new System.Drawing.Point(539, 136);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(215, 32);
            this.txtAdd2.TabIndex = 4;
            this.txtAdd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address 2 Index : ";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCity.Location = new System.Drawing.Point(158, 192);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(215, 32);
            this.txtCity.TabIndex = 5;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "City Index : ";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtState.Location = new System.Drawing.Point(539, 195);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(215, 32);
            this.txtState.TabIndex = 6;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "State Index : ";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtZip.Location = new System.Drawing.Point(158, 247);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(215, 32);
            this.txtZip.TabIndex = 7;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Zip Code Index : ";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(158, 312);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(84, 32);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 80);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes : \r\n- Make sure that the data in the file doesn\'t contain\r\n   any commas, s" +
    "ingle or double qoutations.\r\n- Make sure that there is no wrapped cells in the f" +
    "ile.";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 354);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1303, 364);
            this.listBox1.TabIndex = 19;
            // 
            // frm_addressValidation
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 718);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "frm_addressValidation";
            this.Text = "USPS Address Validation";
            this.Load += new System.EventHandler(this.frm_addressValidation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}

