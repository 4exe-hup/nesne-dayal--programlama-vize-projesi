using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bina
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        public Form2(Form1 parentForm)
        {
            InitializeComponent();

            // Form1 referansını al
            this.parentForm = parentForm;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'ların değerlerini al
            string binaIsmi = textBox1.Text;
            int daireSayisi = int.Parse(textBox2.Text); // Eğer sayısal bir değer bekleniyorsa uygun dönüşümü yapın
            decimal aidatMiktari = decimal.Parse(textBox3.Text); // Eğer sayısal bir değer bekleniyorsa uygun dönüşümü yapın

            // Form1'deki ListView'e yeni bir öğe ekle
            ListViewItem newItem = new ListViewItem();
            newItem.Text = binaIsmi;
            newItem.SubItems.Add(daireSayisi.ToString());
            newItem.SubItems.Add(aidatMiktari.ToString());

            parentForm.AddBuilding(newItem);

            // Giriş alanlarını temizle
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
