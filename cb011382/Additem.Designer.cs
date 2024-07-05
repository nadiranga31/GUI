namespace cb011382
{
    partial class Additem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additem));
            txtcode = new System.Windows.Forms.TextBox();
            txtname = new System.Windows.Forms.TextBox();
            txtquantity = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btndelete = new System.Windows.Forms.Button();
            btnsave = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            btnback = new System.Windows.Forms.Button();
            lblerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtcode
            // 
            txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtcode.Location = new System.Drawing.Point(21, 92);
            txtcode.Name = "txtcode";
            txtcode.Size = new System.Drawing.Size(260, 24);
            txtcode.TabIndex = 0;
            // 
            // txtname
            // 
            txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtname.Location = new System.Drawing.Point(21, 170);
            txtname.Name = "txtname";
            txtname.Size = new System.Drawing.Size(260, 24);
            txtname.TabIndex = 1;
            // 
            // txtquantity
            // 
            txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtquantity.Location = new System.Drawing.Point(21, 242);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new System.Drawing.Size(260, 24);
            txtquantity.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(21, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 18);
            label4.TabIndex = 4;
            label4.Text = "Stock Code";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(21, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 18);
            label1.TabIndex = 5;
            label1.Text = "Stock Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(21, 219);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 18);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // btndelete
            // 
            btndelete.BackColor = System.Drawing.Color.Yellow;
            btndelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btndelete.Location = new System.Drawing.Point(702, 12);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(184, 54);
            btndelete.TabIndex = 9;
            btndelete.Text = "DELETE STOCK";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += button1_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnsave.Location = new System.Drawing.Point(88, 346);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(114, 43);
            btnsave.TabIndex = 10;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(360, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(498, 277);
            dataGridView1.TabIndex = 12;
            dataGridView1.AutoSizeColumnsModeChanged += fill;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePicker1.Location = new System.Drawing.Point(21, 294);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(299, 24);
            dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(544, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(157, 38);
            label3.TabIndex = 14;
            label3.Text = "Stock Item";
            // 
            // btnback
            // 
            btnback.BackColor = System.Drawing.Color.Red;
            btnback.Location = new System.Drawing.Point(6, 4);
            btnback.Name = "btnback";
            btnback.Size = new System.Drawing.Size(59, 29);
            btnback.TabIndex = 15;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += button1_Click_1;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new System.Drawing.Point(132, 417);
            lblerror.Name = "lblerror";
            lblerror.Size = new System.Drawing.Size(0, 20);
            lblerror.TabIndex = 16;
            // 
            // Additem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(898, 500);
            Controls.Add(lblerror);
            Controls.Add(btnback);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(btnsave);
            Controls.Add(btndelete);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtquantity);
            Controls.Add(txtname);
            Controls.Add(txtcode);
            Name = "Additem";
            Text = "Additem";
            Load += Additem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblerror;
    }
}