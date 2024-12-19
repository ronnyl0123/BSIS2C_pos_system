namespace pos_system
{
    partial class AdminSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVprod = new System.Windows.Forms.DataGridView();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVprod)).BeginInit();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVprod
            // 
            this.DGVprod.AllowUserToAddRows = false;
            this.DGVprod.AllowUserToDeleteRows = false;
            this.DGVprod.AllowUserToOrderColumns = true;
            this.DGVprod.AllowUserToResizeColumns = false;
            this.DGVprod.AllowUserToResizeRows = false;
            this.DGVprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVprod.BackgroundColor = System.Drawing.Color.White;
            this.DGVprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVprod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVprod.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVprod.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVprod.EnableHeadersVisualStyles = false;
            this.DGVprod.GridColor = System.Drawing.Color.LightGray;
            this.DGVprod.Location = new System.Drawing.Point(319, 0);
            this.DGVprod.Name = "DGVprod";
            this.DGVprod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVprod.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVprod.RowHeadersVisible = false;
            this.DGVprod.RowTemplate.Height = 28;
            this.DGVprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVprod.Size = new System.Drawing.Size(978, 666);
            this.DGVprod.TabIndex = 2;
            this.DGVprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVprod_CellContentClick);
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.SystemColors.Info;
            this.gbox.Controls.Add(this.btndelete);
            this.gbox.Controls.Add(this.btnupdate);
            this.gbox.Controls.Add(this.back);
            this.gbox.Controls.Add(this.logo);
            this.gbox.Controls.Add(this.label4);
            this.gbox.Controls.Add(this.label3);
            this.gbox.Controls.Add(this.label2);
            this.gbox.Controls.Add(this.label1);
            this.gbox.Controls.Add(this.txtprice);
            this.gbox.Controls.Add(this.cbcategory);
            this.gbox.Controls.Add(this.txtproduct);
            this.gbox.Controls.Add(this.txtquantity);
            this.gbox.Location = new System.Drawing.Point(3, -9);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(319, 695);
            this.gbox.TabIndex = 68;
            this.gbox.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(161, 316);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 40);
            this.btndelete.TabIndex = 72;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(30, 316);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 40);
            this.btnupdate.TabIndex = 71;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // back
            // 
            this.back.Image = global::pos_system.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(15, 756);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 40);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 62;
            this.back.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::pos_system.Properties.Resources.unione;
            this.logo.Location = new System.Drawing.Point(15, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(0, 0);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 50;
            this.logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Product Name";
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Location = new System.Drawing.Point(30, 262);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(126, 26);
            this.txtprice.TabIndex = 65;
            // 
            // cbcategory
            // 
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(30, 196);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(251, 28);
            this.cbcategory.TabIndex = 66;
            // 
            // txtproduct
            // 
            this.txtproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproduct.Location = new System.Drawing.Point(30, 65);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(251, 26);
            this.txtproduct.TabIndex = 63;
            // 
            // txtquantity
            // 
            this.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantity.Location = new System.Drawing.Point(30, 128);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(251, 26);
            this.txtquantity.TabIndex = 64;
            // 
            // AdminSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.DGVprod);
            this.Name = "AdminSales";
            this.Size = new System.Drawing.Size(1300, 669);
            this.Load += new System.EventHandler(this.AdminSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVprod)).EndInit();
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVprod;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.TextBox txtquantity;
    }
}
