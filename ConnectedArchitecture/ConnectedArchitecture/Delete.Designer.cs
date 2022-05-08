namespace ConnectedArchitecture
{
    partial class Delete
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
            this.mtxtRollNo = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCRUDOps
            // 
            this.lblCRUDOps.AutoSize = true;
            this.lblCRUDOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCRUDOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblCRUDOps.Location = new System.Drawing.Point(162, 86);
            this.lblCRUDOps.Name = "lblCRUDOps";
            this.lblCRUDOps.Padding = new System.Windows.Forms.Padding(8);
            this.lblCRUDOps.Size = new System.Drawing.Size(298, 49);
            this.lblCRUDOps.TabIndex = 0;
            this.lblCRUDOps.Text = "CRUD OPERATIONS";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Location = new System.Drawing.Point(157, 181);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(102, 26);
            this.lblRollNo.TabIndex = 0;
            this.lblRollNo.Text = "Roll No. :";
            // 
            // mtxtRollNo
            // 
            this.mtxtRollNo.Location = new System.Drawing.Point(265, 178);
            this.mtxtRollNo.Mask = "000";
            this.mtxtRollNo.Name = "mtxtRollNo";
            this.mtxtRollNo.Size = new System.Drawing.Size(195, 32);
            this.mtxtRollNo.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(249, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 475);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mtxtRollNo);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.lblCRUDOps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELETE | Connected Architecture Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRUDOps;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.MaskedTextBox mtxtRollNo;
        private System.Windows.Forms.Button btnDelete;
    }
}

