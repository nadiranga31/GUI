namespace cb011382
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            add_item = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            delete_item = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Red;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(210, 448);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(36, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(125, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(22, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 31);
            label2.TabIndex = 1;
            label2.Text = "ENTERPRICES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(22, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 31);
            label1.TabIndex = 0;
            label1.Text = "SAHAN";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Gold;
            panel2.Controls.Add(label3);
            panel2.Location = new System.Drawing.Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(589, 63);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(84, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(431, 38);
            label3.TabIndex = 3;
            label3.Text = "STOCK MANAGEMENT SYSTEM";
            // 
            // add_item
            // 
            add_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            add_item.Location = new System.Drawing.Point(353, 83);
            add_item.Name = "add_item";
            add_item.Size = new System.Drawing.Size(308, 54);
            add_item.TabIndex = 8;
            add_item.Text = "Add a new item of Stock";
            add_item.UseVisualStyleBackColor = true;
            add_item.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(353, 143);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(308, 54);
            button2.TabIndex = 9;
            button2.Text = "Add quantity to a Stock";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(353, 203);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(308, 54);
            button3.TabIndex = 10;
            button3.Text = "Remove quantity from a Stock Item";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(353, 384);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(308, 54);
            button4.TabIndex = 13;
            button4.Text = "View stock levels";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(353, 324);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(308, 54);
            button5.TabIndex = 12;
            button5.Text = "View transaction log ";
            button5.UseVisualStyleBackColor = true;
            // 
            // delete_item
            // 
            delete_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            delete_item.Location = new System.Drawing.Point(353, 264);
            delete_item.Name = "delete_item";
            delete_item.Size = new System.Drawing.Size(308, 54);
            delete_item.TabIndex = 11;
            delete_item.Text = "Delete a stock item ";
            delete_item.UseVisualStyleBackColor = true;
            delete_item.Click += delete_item_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(delete_item);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(add_item);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button delete_item;
    }
}