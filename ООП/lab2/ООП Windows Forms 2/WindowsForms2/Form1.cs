using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
        public Form1()
        {
            student = new Student();
            InitializeComponent();
        }
        Student student;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void resetWrittenData()
        {
            FIO_label.Text = student.fullName;
            age_numeric.Value = student.age;
            speciality_label.Text = student.speciality;
            birthDate_DatePicker.Value = student.birthDate;
            course_trackBar.Value = student.course;
            group_label.Text = student.group.ToString();
            averageMark_label.Text = student.averageMark.ToString();
            if (student.gender == Gender.Male)
                GenderRadio_M.Checked = true;
            else
                GenderRadio_F.Checked = true;
            city_comboBox.Text = student.address.city;
            index_label.Text = student.address.index.ToString();
            street_label.Text = student.address.street;
            house_label.Text = student.address.house;
            flat_label.Text = student.address.flat;
        }
        public bool checkData()
        {
            student.fullName = FIO_label.Text;
            student.age = Convert.ToInt16(age_numeric.Value);
            student.speciality = speciality_label.Text;
            student.birthDate = birthDate_DatePicker.Value;
            student.course = Convert.ToInt16(course_trackBar.Value);
            student.group = Convert.ToInt16(group_label.Text);
            double.TryParse(averageMark_label.Text, out student.averageMark);
            if (GenderRadio_M.Checked)
            {
                student.gender = Gender.Male;
            }
            else
            {
                student.gender = Gender.Female;
            }

            student.address.city = city_comboBox.Text;
            student.address.street = street_label.Text;
            long.TryParse(index_label.Text, out student.address.index);
            student.address.house = house_label.Text;
            student.address.flat = flat_label.Text;

            return true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void GenderRadio_M_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                student = xmlSerializer.Deserialize(fs) as Student;
            }
            resetWrittenData();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!checkData()) return;
            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, student);
            }
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            if (checkData())
                DEBUG_TEXT.Text = "Верно";
            else
                DEBUG_TEXT.Text = "Ошибка";
        }
    }
    public class Student
    {
        public Student()
        {
            this.address = new Address();
        }
        public string fullName;
        public short age;
        public string speciality;
        public DateTime birthDate;
        public short course;
        public short group;
        public double averageMark;
        public Gender gender;
        public Address address;
    }
    public enum Gender
    {
        Male,
        Female
    }
    public class Address
    {
        public string city;
        public long index;
        public string street;
        public string house;
        public string flat;
    }
}
