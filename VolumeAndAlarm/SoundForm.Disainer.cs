using System;
using System.Collections.Generic;
using System.Text;

namespace VolumeAndAlarm
{
    public partial class SoundForm : System.Windows.Forms.Form
    {

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericHour = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numericMinute = new NumericMinutes();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(12, 94);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(253, 45);
            this.trackBarVolume.TabIndex = 0;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVolume.Location = new System.Drawing.Point(279, 99);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(29, 31);
            this.labelVolume.TabIndex = 1;
            this.labelVolume.Text = "0";
            // 
            // buttonMute
            // 
            this.buttonMute.BackColor = System.Drawing.Color.White;
            this.buttonMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMute.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMute.Location = new System.Drawing.Point(12, 65);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(105, 23);
            this.buttonMute.TabIndex = 2;
            this.buttonMute.Text = "mute";
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.White;
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest.ForeColor = System.Drawing.Color.Maroon;
            this.buttonTest.Location = new System.Drawing.Point(223, 65);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(116, 23);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "Воспроизвести ";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Остановить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выбрать музыку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericHour
            // 
            this.numericHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericHour.Location = new System.Drawing.Point(13, 12);
            this.numericHour.Margin = new System.Windows.Forms.Padding(0);
            this.numericHour.Name = "numericHour";
            this.numericHour.Size = new System.Drawing.Size(74, 34);
            this.numericHour.TabIndex = 6;
            this.numericHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericHour.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numericMinute
            // 
            this.numericMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericMinute.Location = new System.Drawing.Point(87, 12);
            this.numericMinute.Margin = new System.Windows.Forms.Padding(0);
            this.numericMinute.Name = "numericMinute";
            this.numericMinute.Size = new System.Drawing.Size(74, 34);
            this.numericMinute.TabIndex = 7;
            this.numericMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SoundForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(351, 152);
            this.Controls.Add(this.numericMinute);
            this.Controls.Add(this.numericHour);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoundForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Громкость";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.NumericUpDown numericHour;
        private System.Windows.Forms.Timer timer;
        private NumericMinutes numericMinute;
    }
}
