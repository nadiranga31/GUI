namespace cb011382
{
    partial class Deleteitem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deleteitem));
            button2 = new System.Windows.Forms.Button();
            btnback = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            lbldisplay = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtquantity = new System.Windows.Forms.TextBox();
            txtname = new System.Windows.Forms.TextBox();
            txtcode = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(209, 409);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(131, 54);
            button2.TabIndex = 19;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnback
            // 
            btnback.BackColor = System.Drawing.Color.Red;
            btnback.Location = new System.Drawing.Point(2, 2);
            btnback.Name = "btnback";
            btnback.Size = new System.Drawing.Size(59, 29);
            btnback.TabIndex = 20;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(80, 275);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(137, 54);
            button1.TabIndex = 27;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbldisplay
            // 
            lbldisplay.AutoSize = true;
            lbldisplay.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            lbldisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbldisplay.Location = new System.Drawing.Point(270, 356);
            lbldisplay.Name = "lbldisplay";
            lbldisplay.Size = new System.Drawing.Size(0, 38);
            lbldisplay.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Location = new System.Drawing.Point(80, 186);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 18);
            label5.TabIndex = 34;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label6.Location = new System.Drawing.Point(80, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(101, 18);
            label6.TabIndex = 33;
            label6.Text = "Stock Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label7.Location = new System.Drawing.Point(80, 36);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 18);
            label7.TabIndex = 32;
            label7.Text = "Stock Code";
            // 
            // txtquantity
            // 
            txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtquantity.Location = new System.Drawing.Point(80, 209);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new System.Drawing.Size(260, 24);
            txtquantity.TabIndex = 31;
            // 
            // txtname
            // 
            txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtname.Location = new System.Drawing.Point(80, 137);
            txtname.Name = "txtname";
            txtname.Size = new System.Drawing.Size(260, 24);
            txtname.TabIndex = 30;
            // 
            // txtcode
            // 
            txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtcode.Location = new System.Drawing.Point(80, 59);
            txtcode.Name = "txtcode";
            txtcode.Size = new System.Drawing.Size(260, 24);
            txtcode.TabIndex = 29;
            // 
            // Deleteitem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(947, 505);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtquantity);
            Controls.Add(txtname);
            Controls.Add(txtcode);
            Controls.Add(lbldisplay);
            Controls.Add(button1);
            Controls.Add(btnback);
            Controls.Add(button2);
            Name = "Deleteitem";
            Text = "Deleteitem";
            Load += Deleteitem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcode;
    }
}