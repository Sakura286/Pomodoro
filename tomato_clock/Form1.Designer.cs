namespace tomato_clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.workTime_TextBox = new System.Windows.Forms.TextBox();
            this.restTime_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.lb_set = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(71, 241);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 37);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(199, 241);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 37);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "暂停";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(324, 241);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 37);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "工作时间";
            // 
            // workTime_TextBox
            // 
            this.workTime_TextBox.Location = new System.Drawing.Point(137, 155);
            this.workTime_TextBox.Name = "workTime_TextBox";
            this.workTime_TextBox.Size = new System.Drawing.Size(100, 23);
            this.workTime_TextBox.TabIndex = 4;
            this.workTime_TextBox.TextChanged += new System.EventHandler(this.workTime_TextChanged);
            // 
            // restTime_TextBox
            // 
            this.restTime_TextBox.Location = new System.Drawing.Point(137, 193);
            this.restTime_TextBox.Name = "restTime_TextBox";
            this.restTime_TextBox.Size = new System.Drawing.Size(100, 23);
            this.restTime_TextBox.TabIndex = 5;
            this.restTime_TextBox.TextChanged += new System.EventHandler(this.restTime_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "休息时间";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft YaHei UI", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_time.Location = new System.Drawing.Point(71, 40);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(353, 81);
            this.lb_time.TabIndex = 7;
            this.lb_time.Text = "00 : 00 : 00";
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(278, 155);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(100, 37);
            this.btn_set.TabIndex = 8;
            this.btn_set.Text = "设置";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.button6_Click);
            // 
            // lb_set
            // 
            this.lb_set.AutoSize = true;
            this.lb_set.Location = new System.Drawing.Point(278, 199);
            this.lb_set.Name = "lb_set";
            this.lb_set.Size = new System.Drawing.Size(70, 17);
            this.lb_set.TabIndex = 9;
            this.lb_set.Text = "W: 30, R: 8";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 332);
            this.Controls.Add(this.lb_set);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restTime_TextBox);
            this.Controls.Add(this.workTime_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_start;
        private Button btn_stop;
        private Button btn_reset;
        private Label label1;
        private TextBox workTime_TextBox;
        private TextBox restTime_TextBox;
        private Label label2;
        private Label lb_time;
        private Button btn_set;
        private Label lb_set;
        private System.Windows.Forms.Timer timer1;
    }
}