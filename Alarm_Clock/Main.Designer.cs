
namespace Alarm_Clock
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_curret_time = new System.Windows.Forms.TextBox();
            this.cb_select_sound = new System.Windows.Forms.ComboBox();
            this.set = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.snooze = new System.Windows.Forms.Button();
            this.timer_alarm_time = new System.Windows.Forms.Timer(this.components);
            this.lb_curret_time = new System.Windows.Forms.Label();
            this.lb_alarm_time = new System.Windows.Forms.Label();
            this.tb_alarm_time = new System.Windows.Forms.TextBox();
            this.tb_snooze = new System.Windows.Forms.TextBox();
            this.lb_select_sound = new System.Windows.Forms.Label();
            this.timer_curret_time = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_curret_time
            // 
            this.tb_curret_time.Enabled = false;
            this.tb_curret_time.Location = new System.Drawing.Point(120, 43);
            this.tb_curret_time.Name = "tb_curret_time";
            this.tb_curret_time.ReadOnly = true;
            this.tb_curret_time.Size = new System.Drawing.Size(100, 20);
            this.tb_curret_time.TabIndex = 0;
            // 
            // cb_select_sound
            // 
            this.cb_select_sound.FormattingEnabled = true;
            this.cb_select_sound.Items.AddRange(new object[] {
            "Alarm",
            "Alarm1"});
            this.cb_select_sound.Location = new System.Drawing.Point(623, 289);
            this.cb_select_sound.Name = "cb_select_sound";
            this.cb_select_sound.Size = new System.Drawing.Size(121, 21);
            this.cb_select_sound.TabIndex = 2;
            // 
            // set
            // 
            this.set.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set.BackgroundImage")));
            this.set.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set.Location = new System.Drawing.Point(99, 238);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(93, 43);
            this.set.TabIndex = 3;
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // stop
            // 
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.stop.Location = new System.Drawing.Point(9, 238);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 43);
            this.stop.TabIndex = 4;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // snooze
            // 
            this.snooze.BackColor = System.Drawing.Color.Silver;
            this.snooze.Location = new System.Drawing.Point(9, 195);
            this.snooze.Name = "snooze";
            this.snooze.Size = new System.Drawing.Size(75, 23);
            this.snooze.TabIndex = 5;
            this.snooze.Text = "Snooze";
            this.snooze.UseVisualStyleBackColor = false;
            this.snooze.Click += new System.EventHandler(this.snooze_Click);
            // 
            // timer_alarm_time
            // 
            this.timer_alarm_time.Interval = 900;
            this.timer_alarm_time.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lb_curret_time
            // 
            this.lb_curret_time.AutoSize = true;
            this.lb_curret_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curret_time.Location = new System.Drawing.Point(-3, 38);
            this.lb_curret_time.Name = "lb_curret_time";
            this.lb_curret_time.Size = new System.Drawing.Size(130, 25);
            this.lb_curret_time.TabIndex = 6;
            this.lb_curret_time.Text = "Curret Time:";
            // 
            // lb_alarm_time
            // 
            this.lb_alarm_time.AutoSize = true;
            this.lb_alarm_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alarm_time.Location = new System.Drawing.Point(543, 43);
            this.lb_alarm_time.Name = "lb_alarm_time";
            this.lb_alarm_time.Size = new System.Drawing.Size(70, 24);
            this.lb_alarm_time.TabIndex = 7;
            this.lb_alarm_time.Text = "Alarm:";
            // 
            // tb_alarm_time
            // 
            this.tb_alarm_time.Location = new System.Drawing.Point(613, 45);
            this.tb_alarm_time.Name = "tb_alarm_time";
            this.tb_alarm_time.Size = new System.Drawing.Size(100, 20);
            this.tb_alarm_time.TabIndex = 8;
            // 
            // tb_snooze
            // 
            this.tb_snooze.Location = new System.Drawing.Point(90, 197);
            this.tb_snooze.Name = "tb_snooze";
            this.tb_snooze.Size = new System.Drawing.Size(64, 20);
            this.tb_snooze.TabIndex = 9;
            // 
            // lb_select_sound
            // 
            this.lb_select_sound.AutoSize = true;
            this.lb_select_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_select_sound.Location = new System.Drawing.Point(485, 284);
            this.lb_select_sound.Name = "lb_select_sound";
            this.lb_select_sound.Size = new System.Drawing.Size(141, 24);
            this.lb_select_sound.TabIndex = 10;
            this.lb_select_sound.Text = "Select Sound:";
            // 
            // timer_curret_time
            // 
            this.timer_curret_time.Interval = 900;
            this.timer_curret_time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(599, 132);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 131);
            this.textBox1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(743, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_select_sound);
            this.Controls.Add(this.tb_snooze);
            this.Controls.Add(this.tb_alarm_time);
            this.Controls.Add(this.lb_alarm_time);
            this.Controls.Add(this.lb_curret_time);
            this.Controls.Add(this.snooze);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.set);
            this.Controls.Add(this.cb_select_sound);
            this.Controls.Add(this.tb_curret_time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Alarm_Clock";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_curret_time;
        private System.Windows.Forms.ComboBox cb_select_sound;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button snooze;
        private System.Windows.Forms.Timer timer_alarm_time;
        private System.Windows.Forms.Label lb_curret_time;
        private System.Windows.Forms.Label lb_alarm_time;
        private System.Windows.Forms.TextBox tb_alarm_time;
        private System.Windows.Forms.TextBox tb_snooze;
        private System.Windows.Forms.Label lb_select_sound;
        private System.Windows.Forms.Timer timer_curret_time;
        private System.Windows.Forms.TextBox textBox1;
    }
}

