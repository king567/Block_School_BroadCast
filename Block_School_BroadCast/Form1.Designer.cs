namespace Block_School_BroadCast
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Information_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Minn_To_Task_Bar = new System.Windows.Forms.Button();
            this.Mini_Size_Windows = new System.Windows.Forms.Button();
            this.Maxsize_Windows = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Task_Bar_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Information_Box
            // 
            this.Information_Box.BackColor = System.Drawing.SystemColors.MenuText;
            this.Information_Box.ForeColor = System.Drawing.Color.Lime;
            this.Information_Box.Location = new System.Drawing.Point(6, 82);
            this.Information_Box.Multiline = true;
            this.Information_Box.Name = "Information_Box";
            this.Information_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Information_Box.Size = new System.Drawing.Size(524, 145);
            this.Information_Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F);
            this.label1.Location = new System.Drawing.Point(75, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "阻擋廣播";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F);
            this.label2.Location = new System.Drawing.Point(355, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "顯示切換使用者";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Minn_To_Task_Bar);
            this.panel1.Controls.Add(this.Mini_Size_Windows);
            this.panel1.Controls.Add(this.Maxsize_Windows);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 76);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.Location = new System.Drawing.Point(68, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Block BroadCast";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Information_Box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.pictureBox1.Image = global::Block_School_BroadCast.Properties.Resources.switch_on;
            this.pictureBox1.Location = new System.Drawing.Point(10, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.pictureBox2.Image = global::Block_School_BroadCast.Properties.Resources.switch_on;
            this.pictureBox2.Location = new System.Drawing.Point(294, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Block_School_BroadCast.Properties.Resources.sword;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Minn_To_Task_Bar
            // 
            this.Minn_To_Task_Bar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minn_To_Task_Bar.FlatAppearance.BorderSize = 0;
            this.Minn_To_Task_Bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minn_To_Task_Bar.Image = global::Block_School_BroadCast.Properties.Resources.window_shade;
            this.Minn_To_Task_Bar.Location = new System.Drawing.Point(316, 0);
            this.Minn_To_Task_Bar.Name = "Minn_To_Task_Bar";
            this.Minn_To_Task_Bar.Size = new System.Drawing.Size(64, 76);
            this.Minn_To_Task_Bar.TabIndex = 4;
            this.Minn_To_Task_Bar.UseVisualStyleBackColor = true;
            this.Minn_To_Task_Bar.Click += new System.EventHandler(this.Minn_To_Task_Bar_Click);
            // 
            // Mini_Size_Windows
            // 
            this.Mini_Size_Windows.Dock = System.Windows.Forms.DockStyle.Right;
            this.Mini_Size_Windows.FlatAppearance.BorderSize = 0;
            this.Mini_Size_Windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mini_Size_Windows.Image = global::Block_School_BroadCast.Properties.Resources.minimize_window;
            this.Mini_Size_Windows.Location = new System.Drawing.Point(380, 0);
            this.Mini_Size_Windows.Name = "Mini_Size_Windows";
            this.Mini_Size_Windows.Size = new System.Drawing.Size(60, 76);
            this.Mini_Size_Windows.TabIndex = 3;
            this.Mini_Size_Windows.UseVisualStyleBackColor = true;
            this.Mini_Size_Windows.Click += new System.EventHandler(this.Mini_Size_Windows_Click);
            // 
            // Maxsize_Windows
            // 
            this.Maxsize_Windows.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maxsize_Windows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.Maxsize_Windows.FlatAppearance.BorderSize = 0;
            this.Maxsize_Windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maxsize_Windows.Image = global::Block_School_BroadCast.Properties.Resources.maximize_window;
            this.Maxsize_Windows.Location = new System.Drawing.Point(440, 0);
            this.Maxsize_Windows.Name = "Maxsize_Windows";
            this.Maxsize_Windows.Size = new System.Drawing.Size(60, 76);
            this.Maxsize_Windows.TabIndex = 2;
            this.Maxsize_Windows.UseVisualStyleBackColor = true;
            this.Maxsize_Windows.Click += new System.EventHandler(this.Maxsize_Windows_Click);
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = global::Block_School_BroadCast.Properties.Resources.close_window;
            this.Close.Location = new System.Drawing.Point(500, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(60, 76);
            this.Close.TabIndex = 1;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Task_Bar_Icon
            // 
            this.Task_Bar_Icon.Text = "notifyIcon1";
            this.Task_Bar_Icon.Visible = true;
            this.Task_Bar_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Task_Bar_Icon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(560, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Information_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Minn_To_Task_Bar;
        private System.Windows.Forms.Button Mini_Size_Windows;
        private System.Windows.Forms.Button Maxsize_Windows;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon Task_Bar_Icon;
    }
}

