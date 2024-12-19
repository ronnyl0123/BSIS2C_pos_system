namespace pos_system
{
    partial class TotalSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back = new System.Windows.Forms.PictureBox();
            this.salesDGV = new System.Windows.Forms.DataGridView();
            this.Saleslbl = new System.Windows.Forms.Label();
            this.DailySaleslbl = new System.Windows.Forms.Label();
            this.MonthlySaleslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = global::pos_system.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(12, 648);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 40);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 73;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // salesDGV
            // 
            this.salesDGV.AccessibleName = "";
            this.salesDGV.AllowUserToAddRows = false;
            this.salesDGV.AllowUserToDeleteRows = false;
            this.salesDGV.AllowUserToOrderColumns = true;
            this.salesDGV.AllowUserToResizeColumns = false;
            this.salesDGV.AllowUserToResizeRows = false;
            this.salesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.salesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesDGV.EnableHeadersVisualStyles = false;
            this.salesDGV.GridColor = System.Drawing.Color.LightGray;
            this.salesDGV.Location = new System.Drawing.Point(12, 12);
            this.salesDGV.Name = "salesDGV";
            this.salesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salesDGV.RowHeadersVisible = false;
            this.salesDGV.RowTemplate.Height = 28;
            this.salesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDGV.Size = new System.Drawing.Size(1276, 564);
            this.salesDGV.TabIndex = 74;
            this.salesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDGV_CellContentClick);
            // 
            // Saleslbl
            // 
            this.Saleslbl.AutoSize = true;
            this.Saleslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saleslbl.Location = new System.Drawing.Point(934, 619);
            this.Saleslbl.Name = "Saleslbl";
            this.Saleslbl.Size = new System.Drawing.Size(92, 29);
            this.Saleslbl.TabIndex = 76;
            this.Saleslbl.Text = "TOTAL";
            // 
            // DailySaleslbl
            // 
            this.DailySaleslbl.AutoSize = true;
            this.DailySaleslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySaleslbl.Location = new System.Drawing.Point(136, 619);
            this.DailySaleslbl.Name = "DailySaleslbl";
            this.DailySaleslbl.Size = new System.Drawing.Size(80, 29);
            this.DailySaleslbl.TabIndex = 78;
            this.DailySaleslbl.Text = "DAILY";
            // 
            // MonthlySaleslbl
            // 
            this.MonthlySaleslbl.AutoSize = true;
            this.MonthlySaleslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlySaleslbl.Location = new System.Drawing.Point(483, 619);
            this.MonthlySaleslbl.Name = "MonthlySaleslbl";
            this.MonthlySaleslbl.Size = new System.Drawing.Size(132, 29);
            this.MonthlySaleslbl.TabIndex = 79;
            this.MonthlySaleslbl.Text = "MONTHLY";
            // 
            // TotalSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.MonthlySaleslbl);
            this.Controls.Add(this.DailySaleslbl);
            this.Controls.Add(this.Saleslbl);
            this.Controls.Add(this.salesDGV);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalSales";
            this.Load += new System.EventHandler(this.TotalSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.DataGridView salesDGV;
        private System.Windows.Forms.Label Saleslbl;
        private System.Windows.Forms.Label DailySaleslbl;
        private System.Windows.Forms.Label MonthlySaleslbl;
    }
}