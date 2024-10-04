
namespace WindowsForms2
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
            label1 = new System.Windows.Forms.Label();
            FIO_label = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            date = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            averageMark_label = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            group_label = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            index_label = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            house_label = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            street_label = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            flat_label = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            save_button = new System.Windows.Forms.Button();
            load_button = new System.Windows.Forms.Button();
            check_button = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            GenderRadio_M = new System.Windows.Forms.RadioButton();
            GenderRadio_F = new System.Windows.Forms.RadioButton();
            DEBUG_TEXT = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label12 = new System.Windows.Forms.Label();
            birthDate_DatePicker = new System.Windows.Forms.DateTimePicker();
            city_comboBox = new System.Windows.Forms.ComboBox();
            age_numeric = new System.Windows.Forms.NumericUpDown();
            speciality_label = new System.Windows.Forms.RichTextBox();
            course_trackBar = new System.Windows.Forms.TrackBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)age_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)course_trackBar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // FIO_label
            // 
            FIO_label.Location = new System.Drawing.Point(13, 32);
            FIO_label.Name = "FIO_label";
            FIO_label.Size = new System.Drawing.Size(172, 23);
            FIO_label.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Возраст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Специальность";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new System.Drawing.Point(15, 174);
            date.Name = "date";
            date.Size = new System.Drawing.Size(90, 15);
            date.TabIndex = 6;
            date.Text = "Дата рождения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 219);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 15);
            label5.TabIndex = 8;
            label5.Text = "Курс";
            // 
            // averageMark_label
            // 
            averageMark_label.Location = new System.Drawing.Point(12, 305);
            averageMark_label.Name = "averageMark_label";
            averageMark_label.Size = new System.Drawing.Size(172, 23);
            averageMark_label.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 286);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 15);
            label6.TabIndex = 10;
            label6.Text = "Средний балл";
            // 
            // group_label
            // 
            group_label.Location = new System.Drawing.Point(221, 32);
            group_label.Name = "group_label";
            group_label.Size = new System.Drawing.Size(172, 23);
            group_label.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(221, 58);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 15);
            label7.TabIndex = 12;
            label7.Text = "Город";
            // 
            // index_label
            // 
            index_label.Location = new System.Drawing.Point(221, 122);
            index_label.Name = "index_label";
            index_label.Size = new System.Drawing.Size(172, 23);
            index_label.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(221, 103);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 15);
            label8.TabIndex = 14;
            label8.Text = "Иднекс";
            // 
            // house_label
            // 
            house_label.Location = new System.Drawing.Point(221, 211);
            house_label.Name = "house_label";
            house_label.Size = new System.Drawing.Size(172, 23);
            house_label.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(221, 192);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 15);
            label9.TabIndex = 18;
            label9.Text = "Дом";
            // 
            // street_label
            // 
            street_label.Location = new System.Drawing.Point(221, 166);
            street_label.Name = "street_label";
            street_label.Size = new System.Drawing.Size(172, 23);
            street_label.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(221, 147);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(41, 15);
            label10.TabIndex = 16;
            label10.Text = "Улица";
            // 
            // flat_label
            // 
            flat_label.Location = new System.Drawing.Point(221, 257);
            flat_label.Name = "flat_label";
            flat_label.Size = new System.Drawing.Size(172, 23);
            flat_label.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(221, 238);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 15);
            label11.TabIndex = 20;
            label11.Text = "Квартира";
            // 
            // save_button
            // 
            save_button.Location = new System.Drawing.Point(12, 427);
            save_button.Name = "save_button";
            save_button.Size = new System.Drawing.Size(75, 23);
            save_button.TabIndex = 22;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // load_button
            // 
            load_button.Location = new System.Drawing.Point(127, 427);
            load_button.Name = "load_button";
            load_button.Size = new System.Drawing.Size(75, 23);
            load_button.TabIndex = 23;
            load_button.Text = "Загрузить";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += load_button_Click;
            // 
            // check_button
            // 
            check_button.Location = new System.Drawing.Point(280, 394);
            check_button.Name = "check_button";
            check_button.Size = new System.Drawing.Size(75, 23);
            check_button.TabIndex = 25;
            check_button.Text = "Проверить";
            check_button.UseVisualStyleBackColor = true;
            check_button.Click += check_button_Click;
            // 
            // label4
            // 
            label4.AccessibleName = "";
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(141, 351);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 15);
            label4.TabIndex = 26;
            // 
            // GenderRadio_M
            // 
            GenderRadio_M.AutoSize = true;
            GenderRadio_M.Checked = true;
            GenderRadio_M.Location = new System.Drawing.Point(6, 21);
            GenderRadio_M.Name = "GenderRadio_M";
            GenderRadio_M.Size = new System.Drawing.Size(77, 19);
            GenderRadio_M.TabIndex = 29;
            GenderRadio_M.TabStop = true;
            GenderRadio_M.Text = "Мужской";
            GenderRadio_M.UseVisualStyleBackColor = true;
            // 
            // GenderRadio_F
            // 
            GenderRadio_F.AutoSize = true;
            GenderRadio_F.Location = new System.Drawing.Point(97, 21);
            GenderRadio_F.Name = "GenderRadio_F";
            GenderRadio_F.Size = new System.Drawing.Size(75, 19);
            GenderRadio_F.TabIndex = 30;
            GenderRadio_F.Text = "Женский";
            GenderRadio_F.UseVisualStyleBackColor = true;
            // 
            // DEBUG_TEXT
            // 
            DEBUG_TEXT.AutoSize = true;
            DEBUG_TEXT.Location = new System.Drawing.Point(280, 427);
            DEBUG_TEXT.Name = "DEBUG_TEXT";
            DEBUG_TEXT.Size = new System.Drawing.Size(101, 15);
            DEBUG_TEXT.TabIndex = 31;
            DEBUG_TEXT.Text = "Результат Дэбага";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GenderRadio_M);
            groupBox1.Controls.Add(GenderRadio_F);
            groupBox1.Location = new System.Drawing.Point(13, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(189, 44);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(221, 13);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(46, 15);
            label12.TabIndex = 33;
            label12.Text = "Группа";
            // 
            // birthDate_DatePicker
            // 
            birthDate_DatePicker.Location = new System.Drawing.Point(12, 193);
            birthDate_DatePicker.Name = "birthDate_DatePicker";
            birthDate_DatePicker.Size = new System.Drawing.Size(173, 23);
            birthDate_DatePicker.TabIndex = 35;
            // 
            // city_comboBox
            // 
            city_comboBox.FormattingEnabled = true;
            city_comboBox.Items.AddRange(new object[] { "Минск", "Брест", "Гродно" });
            city_comboBox.Location = new System.Drawing.Point(221, 78);
            city_comboBox.Name = "city_comboBox";
            city_comboBox.Size = new System.Drawing.Size(172, 23);
            city_comboBox.TabIndex = 36;
            // 
            // age_numeric
            // 
            age_numeric.Location = new System.Drawing.Point(12, 78);
            age_numeric.Name = "age_numeric";
            age_numeric.Size = new System.Drawing.Size(173, 23);
            age_numeric.TabIndex = 37;
            age_numeric.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // speciality_label
            // 
            speciality_label.Location = new System.Drawing.Point(13, 118);
            speciality_label.Name = "speciality_label";
            speciality_label.Size = new System.Drawing.Size(172, 53);
            speciality_label.TabIndex = 40;
            speciality_label.Text = "";
            // 
            // course_trackBar
            // 
            course_trackBar.LargeChange = 1;
            course_trackBar.Location = new System.Drawing.Point(12, 238);
            course_trackBar.Maximum = 4;
            course_trackBar.Minimum = 1;
            course_trackBar.Name = "course_trackBar";
            course_trackBar.Size = new System.Drawing.Size(165, 45);
            course_trackBar.TabIndex = 41;
            course_trackBar.Value = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(409, 462);
            Controls.Add(course_trackBar);
            Controls.Add(speciality_label);
            Controls.Add(age_numeric);
            Controls.Add(city_comboBox);
            Controls.Add(birthDate_DatePicker);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(DEBUG_TEXT);
            Controls.Add(label4);
            Controls.Add(check_button);
            Controls.Add(load_button);
            Controls.Add(save_button);
            Controls.Add(flat_label);
            Controls.Add(label11);
            Controls.Add(house_label);
            Controls.Add(label9);
            Controls.Add(street_label);
            Controls.Add(label10);
            Controls.Add(index_label);
            Controls.Add(label8);
            Controls.Add(group_label);
            Controls.Add(label7);
            Controls.Add(averageMark_label);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FIO_label);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "University";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)age_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)course_trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIO_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox averageMark_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox group_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox index_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox house_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox street_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox flat_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton GenderRadio_M;
        private System.Windows.Forms.RadioButton GenderRadio_F;
        private System.Windows.Forms.Label DEBUG_TEXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker birthDate_DatePicker;
        private System.Windows.Forms.ComboBox city_comboBox;
        private System.Windows.Forms.NumericUpDown age_numeric;
        private System.Windows.Forms.RichTextBox speciality_label;
        private System.Windows.Forms.TrackBar course_trackBar;
    }
}

