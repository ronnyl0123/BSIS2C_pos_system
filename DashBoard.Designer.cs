namespace pos_system
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.buttonHardwareTools = new System.Windows.Forms.Label();
            this.buttonPaints = new System.Windows.Forms.Label();
            this.buttonPlumbing = new System.Windows.Forms.Label();
            this.buttonElectrical = new System.Windows.Forms.Label();
            this.buttonDeformedBar = new System.Windows.Forms.Label();
            this.buttonCement = new System.Windows.Forms.Label();
            this.buttonAggregates = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.voidItemButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.billDGV = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Changelbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Paymenttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.buttonHardwareTools);
            this.groupBox1.Controls.Add(this.buttonPaints);
            this.groupBox1.Controls.Add(this.buttonPlumbing);
            this.groupBox1.Controls.Add(this.buttonElectrical);
            this.groupBox1.Controls.Add(this.buttonDeformedBar);
            this.groupBox1.Controls.Add(this.buttonCement);
            this.groupBox1.Controls.Add(this.buttonAggregates);
            this.groupBox1.Location = new System.Drawing.Point(-8, -35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 743);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = global::pos_system.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(20, 693);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 30);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 72;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // buttonHardwareTools
            // 
            this.buttonHardwareTools.AutoSize = true;
            this.buttonHardwareTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHardwareTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHardwareTools.Location = new System.Drawing.Point(18, 586);
            this.buttonHardwareTools.Name = "buttonHardwareTools";
            this.buttonHardwareTools.Size = new System.Drawing.Size(238, 29);
            this.buttonHardwareTools.TabIndex = 55;
            this.buttonHardwareTools.Text = "HARDWARE TOOLS";
            this.buttonHardwareTools.Click += new System.EventHandler(this.txthtools_Click);
            // 
            // buttonPaints
            // 
            this.buttonPaints.AutoSize = true;
            this.buttonPaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaints.Location = new System.Drawing.Point(33, 481);
            this.buttonPaints.Name = "buttonPaints";
            this.buttonPaints.Size = new System.Drawing.Size(216, 58);
            this.buttonPaints.TabIndex = 54;
            this.buttonPaints.Text = "PAINTS AND \r\nPAINTS RELATED";
            this.buttonPaints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPaints.Click += new System.EventHandler(this.txtpaint_Click);
            // 
            // buttonPlumbing
            // 
            this.buttonPlumbing.AutoSize = true;
            this.buttonPlumbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlumbing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlumbing.Location = new System.Drawing.Point(72, 396);
            this.buttonPlumbing.Name = "buttonPlumbing";
            this.buttonPlumbing.Size = new System.Drawing.Size(137, 29);
            this.buttonPlumbing.TabIndex = 53;
            this.buttonPlumbing.Text = "PLUMBING";
            this.buttonPlumbing.Click += new System.EventHandler(this.txtplumbing_Click);
            // 
            // buttonElectrical
            // 
            this.buttonElectrical.AutoSize = true;
            this.buttonElectrical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonElectrical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElectrical.Location = new System.Drawing.Point(68, 323);
            this.buttonElectrical.Name = "buttonElectrical";
            this.buttonElectrical.Size = new System.Drawing.Size(159, 29);
            this.buttonElectrical.TabIndex = 52;
            this.buttonElectrical.Text = "ELECTRICAL";
            this.buttonElectrical.Click += new System.EventHandler(this.txtelectrical_Click);
            // 
            // buttonDeformedBar
            // 
            this.buttonDeformedBar.AutoSize = true;
            this.buttonDeformedBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeformedBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeformedBar.Location = new System.Drawing.Point(43, 248);
            this.buttonDeformedBar.Name = "buttonDeformedBar";
            this.buttonDeformedBar.Size = new System.Drawing.Size(204, 29);
            this.buttonDeformedBar.TabIndex = 51;
            this.buttonDeformedBar.Text = "DEFORMED BAR";
            this.buttonDeformedBar.Click += new System.EventHandler(this.txtdbar_Click);
            // 
            // buttonCement
            // 
            this.buttonCement.AutoSize = true;
            this.buttonCement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCement.Location = new System.Drawing.Point(81, 168);
            this.buttonCement.Name = "buttonCement";
            this.buttonCement.Size = new System.Drawing.Size(116, 29);
            this.buttonCement.TabIndex = 50;
            this.buttonCement.Text = "CEMENT";
            this.buttonCement.Click += new System.EventHandler(this.txtcement_Click);
            // 
            // buttonAggregates
            // 
            this.buttonAggregates.AutoSize = true;
            this.buttonAggregates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAggregates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggregates.Location = new System.Drawing.Point(56, 88);
            this.buttonAggregates.Name = "buttonAggregates";
            this.buttonAggregates.Size = new System.Drawing.Size(178, 29);
            this.buttonAggregates.TabIndex = 0;
            this.buttonAggregates.Text = "AGGREGATES";
            this.buttonAggregates.Click += new System.EventHandler(this.txtaggre_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.voidItemButton);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.billDGV);
            this.groupBox3.Controls.Add(this.btnPayment);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(963, -35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 743);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // voidItemButton
            // 
            this.voidItemButton.BackColor = System.Drawing.Color.DarkGray;
            this.voidItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voidItemButton.Location = new System.Drawing.Point(6, 459);
            this.voidItemButton.Name = "voidItemButton";
            this.voidItemButton.Size = new System.Drawing.Size(326, 34);
            this.voidItemButton.TabIndex = 78;
            this.voidItemButton.Text = "VOID";
            this.voidItemButton.UseVisualStyleBackColor = false;
            this.voidItemButton.Click += new System.EventHandler(this.voidItemButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::pos_system.Properties.Resources.add_to_cart;
            this.pictureBox5.Location = new System.Drawing.Point(13, 47);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 74;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "WALK IN",
            "PICK UP",
            "DELIVER"});
            this.comboBox1.Location = new System.Drawing.Point(225, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 77;
            // 
            // billDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.billDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.billDGV.GridColor = System.Drawing.Color.DarkGray;
            this.billDGV.Location = new System.Drawing.Point(6, 119);
            this.billDGV.Name = "billDGV";
            this.billDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.billDGV.RowHeadersVisible = false;
            this.billDGV.RowTemplate.Height = 28;
            this.billDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDGV.Size = new System.Drawing.Size(326, 334);
            this.billDGV.TabIndex = 76;
            this.billDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billDGV_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.DarkGray;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Location = new System.Drawing.Point(6, 675);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(326, 50);
            this.btnPayment.TabIndex = 75;
            this.btnPayment.Text = "PRINT RECEIPT";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Changelbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Paymenttxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Amtlbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 164);
            this.panel1.TabIndex = 2;
            // 
            // Changelbl
            // 
            this.Changelbl.AutoSize = true;
            this.Changelbl.Location = new System.Drawing.Point(214, 132);
            this.Changelbl.Name = "Changelbl";
            this.Changelbl.Size = new System.Drawing.Size(23, 20);
            this.Changelbl.TabIndex = 8;
            this.Changelbl.Text = "P.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Change Due:";
            // 
            // Paymenttxt
            // 
            this.Paymenttxt.Location = new System.Drawing.Point(218, 57);
            this.Paymenttxt.Name = "Paymenttxt";
            this.Paymenttxt.Size = new System.Drawing.Size(86, 26);
            this.Paymenttxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Payment:";
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Amtlbl.Location = new System.Drawing.Point(214, 19);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(23, 20);
            this.Amtlbl.TabIndex = 6;
            this.Amtlbl.Text = "P.";
            this.Amtlbl.Click += new System.EventHandler(this.Amtlbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 46);
            this.label8.TabIndex = 5;
            this.label8.Text = "-----------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDERS";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToOrderColumns = true;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewProducts.Location = new System.Drawing.Point(280, 9);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(677, 675);
            this.dataGridViewProducts.TabIndex = 71;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVprod_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label buttonHardwareTools;
        private System.Windows.Forms.Label buttonPaints;
        private System.Windows.Forms.Label buttonPlumbing;
        private System.Windows.Forms.Label buttonElectrical;
        private System.Windows.Forms.Label buttonDeformedBar;
        private System.Windows.Forms.Label buttonCement;
        private System.Windows.Forms.Label buttonAggregates;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView billDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label Amtlbl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox Paymenttxt;
        private System.Windows.Forms.Label Changelbl;
        private System.Windows.Forms.Button voidItemButton;
    }
}