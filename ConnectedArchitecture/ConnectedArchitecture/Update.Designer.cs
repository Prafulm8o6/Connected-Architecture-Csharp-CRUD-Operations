namespace ConnectedArchitecture
{
    partial class Update
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
            this.lblCRUDOps = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSEmail = new System.Windows.Forms.Label();
            this.mtxtRollNo = new System.Windows.Forms.MaskedTextBox();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCRUDOps
            // 
            this.lblCRUDOps.AutoSize = true;
            this.lblCRUDOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCRUDOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblCRUDOps.Location = new System.Drawing.Point(371, 72);
            this.lblCRUDOps.Name = "lblCRUDOps";
            this.lblCRUDOps.Padding = new System.Windows.Forms.Padding(8);
            this.lblCRUDOps.Size = new System.Drawing.Size(298, 49);
            this.lblCRUDOps.TabIndex = 0;
            this.lblCRUDOps.Text = "CRUD OPERATIONS";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(258, 206);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(102, 26);
            this.lblRollNo.TabIndex = 0;
            this.lblRollNo.Text = "Roll No. :";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(277, 261);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(83, 26);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "Name :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(204, 379);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(156, 26);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date Of Birth  :";
            // 
            // lblSEmail
            // 
            this.lblSEmail.AutoSize = true;
            this.lblSEmail.Location = new System.Drawing.Point(277, 319);
            this.lblSEmail.Name = "lblSEmail";
            this.lblSEmail.Size = new System.Drawing.Size(80, 26);
            this.lblSEmail.TabIndex = 0;
            this.lblSEmail.Text = "Email :";
            // 
            // mtxtRollNo
            // 
            this.mtxtRollNo.Location = new System.Drawing.Point(371, 203);
            this.mtxtRollNo.Mask = "000";
            this.mtxtRollNo.Name = "mtxtRollNo";
            this.mtxtRollNo.Size = new System.Drawing.Size(142, 32);
            this.mtxtRollNo.TabIndex = 0;
            // 
            // dpDOB
            // 
            this.dpDOB.Location = new System.Drawing.Point(371, 374);
            this.dpDOB.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dpDOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(380, 32);
            this.dpDOB.TabIndex = 4;
            this.dpDOB.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(371, 258);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(380, 32);
            this.txtSName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(371, 316);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 32);
            this.txtEmail.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(371, 435);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 44);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 619);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dpDOB);
            this.Controls.Add(this.mtxtRollNo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblCRUDOps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update | Connected Architecture Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRUDOps;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSEmail;
        private System.Windows.Forms.MaskedTextBox mtxtRollNo;
        private System.Windows.Forms.DateTimePicker dpDOB;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdate;
    }
}

