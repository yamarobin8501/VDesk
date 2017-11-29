namespace VirtualDesktopForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLeftDesktop = new System.Windows.Forms.Button();
            this.btnRightDesktop = new System.Windows.Forms.Button();
            this.btnDock = new System.Windows.Forms.Button();
            this.btnDesktop_1 = new System.Windows.Forms.Button();
            this.btnDesktop_2 = new System.Windows.Forms.Button();
            this.btnDesktop_3 = new System.Windows.Forms.Button();
            this.btnDesktop_4 = new System.Windows.Forms.Button();
            this.btnDesktop_5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeftDesktop
            // 
            this.btnLeftDesktop.BackColor = System.Drawing.Color.Transparent;
            this.btnLeftDesktop.FlatAppearance.BorderSize = 0;
            this.btnLeftDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftDesktop.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftDesktop.Image")));
            this.btnLeftDesktop.Location = new System.Drawing.Point(-5, -7);
            this.btnLeftDesktop.Name = "btnLeftDesktop";
            this.btnLeftDesktop.Size = new System.Drawing.Size(105, 36);
            this.btnLeftDesktop.TabIndex = 0;
            this.btnLeftDesktop.UseVisualStyleBackColor = false;
            this.btnLeftDesktop.Click += new System.EventHandler(this.btnLeftDesktop_Click);
            // 
            // btnRightDesktop
            // 
            this.btnRightDesktop.BackColor = System.Drawing.Color.Transparent;
            this.btnRightDesktop.FlatAppearance.BorderSize = 0;
            this.btnRightDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightDesktop.Image = ((System.Drawing.Image)(resources.GetObject("btnRightDesktop.Image")));
            this.btnRightDesktop.Location = new System.Drawing.Point(106, -7);
            this.btnRightDesktop.Name = "btnRightDesktop";
            this.btnRightDesktop.Size = new System.Drawing.Size(105, 36);
            this.btnRightDesktop.TabIndex = 1;
            this.btnRightDesktop.UseVisualStyleBackColor = false;
            this.btnRightDesktop.Click += new System.EventHandler(this.btnRightDesktop_Click);
            // 
            // btnDock
            // 
            this.btnDock.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDock.Location = new System.Drawing.Point(867, -3);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(105, 28);
            this.btnDock.TabIndex = 2;
            this.btnDock.Text = "Dock";
            this.btnDock.UseVisualStyleBackColor = false;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            // 
            // btnDesktop_1
            // 
            this.btnDesktop_1.BackColor = System.Drawing.Color.Orange;
            this.btnDesktop_1.Location = new System.Drawing.Point(264, -3);
            this.btnDesktop_1.Name = "btnDesktop_1";
            this.btnDesktop_1.Size = new System.Drawing.Size(42, 28);
            this.btnDesktop_1.TabIndex = 3;
            this.btnDesktop_1.Text = "1";
            this.btnDesktop_1.UseVisualStyleBackColor = false;
            this.btnDesktop_1.Click += new System.EventHandler(this.btnDesktop_1_Click);
            // 
            // btnDesktop_2
            // 
            this.btnDesktop_2.BackColor = System.Drawing.Color.Orange;
            this.btnDesktop_2.Location = new System.Drawing.Point(312, -3);
            this.btnDesktop_2.Name = "btnDesktop_2";
            this.btnDesktop_2.Size = new System.Drawing.Size(42, 28);
            this.btnDesktop_2.TabIndex = 3;
            this.btnDesktop_2.Text = "2";
            this.btnDesktop_2.UseVisualStyleBackColor = false;
            this.btnDesktop_2.Click += new System.EventHandler(this.btnDesktop_2_Click);
            // 
            // btnDesktop_3
            // 
            this.btnDesktop_3.BackColor = System.Drawing.Color.Orange;
            this.btnDesktop_3.Location = new System.Drawing.Point(360, -3);
            this.btnDesktop_3.Name = "btnDesktop_3";
            this.btnDesktop_3.Size = new System.Drawing.Size(42, 28);
            this.btnDesktop_3.TabIndex = 3;
            this.btnDesktop_3.Text = "3";
            this.btnDesktop_3.UseVisualStyleBackColor = false;
            this.btnDesktop_3.Click += new System.EventHandler(this.btnDesktop_3_Click);
            // 
            // btnDesktop_4
            // 
            this.btnDesktop_4.BackColor = System.Drawing.Color.Orange;
            this.btnDesktop_4.Location = new System.Drawing.Point(408, -3);
            this.btnDesktop_4.Name = "btnDesktop_4";
            this.btnDesktop_4.Size = new System.Drawing.Size(42, 28);
            this.btnDesktop_4.TabIndex = 3;
            this.btnDesktop_4.Text = "4";
            this.btnDesktop_4.UseVisualStyleBackColor = false;
            this.btnDesktop_4.Click += new System.EventHandler(this.btnDesktop_4_Click);
            // 
            // btnDesktop_5
            // 
            this.btnDesktop_5.BackColor = System.Drawing.Color.Orange;
            this.btnDesktop_5.Location = new System.Drawing.Point(456, -3);
            this.btnDesktop_5.Name = "btnDesktop_5";
            this.btnDesktop_5.Size = new System.Drawing.Size(42, 28);
            this.btnDesktop_5.TabIndex = 3;
            this.btnDesktop_5.Text = "5";
            this.btnDesktop_5.UseVisualStyleBackColor = false;
            this.btnDesktop_5.Click += new System.EventHandler(this.btnDesktop_5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(978, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(736, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Folder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.Location = new System.Drawing.Point(679, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Image";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(576, -3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 28);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Violet;
            this.button5.Location = new System.Drawing.Point(793, -3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 28);
            this.button5.TabIndex = 8;
            this.button5.Text = "REG";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(1060, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "60";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTimerReset.Location = new System.Drawing.Point(1120, -3);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(51, 28);
            this.btnTimerReset.TabIndex = 10;
            this.btnTimerReset.Text = "Reset";
            this.btnTimerReset.UseVisualStyleBackColor = false;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 23);
            this.Controls.Add(this.btnTimerReset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDesktop_5);
            this.Controls.Add(this.btnDesktop_4);
            this.Controls.Add(this.btnDesktop_3);
            this.Controls.Add(this.btnDesktop_2);
            this.Controls.Add(this.btnDesktop_1);
            this.Controls.Add(this.btnDock);
            this.Controls.Add(this.btnRightDesktop);
            this.Controls.Add(this.btnLeftDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "3DtoAll VDesk";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeftDesktop;
        private System.Windows.Forms.Button btnRightDesktop;
        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.Button btnDesktop_1;
        private System.Windows.Forms.Button btnDesktop_2;
        private System.Windows.Forms.Button btnDesktop_3;
        private System.Windows.Forms.Button btnDesktop_4;
        private System.Windows.Forms.Button btnDesktop_5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimerReset;
    }
}

