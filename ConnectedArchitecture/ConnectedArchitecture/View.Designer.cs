namespace ConnectedArchitecture
{
    partial class View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCRUDOps
            // 
            this.lblCRUDOps.AutoSize = true;
            this.lblCRUDOps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCRUDOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblCRUDOps.Location = new System.Drawing.Point(469, 101);
            this.lblCRUDOps.Name = "lblCRUDOps";
            this.lblCRUDOps.Padding = new System.Windows.Forms.Padding(8);
            this.lblCRUDOps.Size = new System.Drawing.Size(91, 49);
            this.lblCRUDOps.TabIndex = 0;
            this.lblCRUDOps.Text = "View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(821, 454);
            this.dataGridView1.TabIndex = 1;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 751);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCRUDOps);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View | Connected Architecture Example";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRUDOps;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

