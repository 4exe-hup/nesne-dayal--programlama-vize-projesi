using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bina
{



    public partial class Form3 : Form
    {
        private List<Building> buildings;

        private string selectedBuilding;
        public Form3(string selectedBuilding, List<Building> buildings)
        {
            InitializeComponent();
            comboBox1.Items.Add("Ödendi");
            comboBox1.Items.Add("Ödenmedi");
            InitializeComponent();
            this.selectedBuilding = selectedBuilding;
            this.buildings = buildings;

            // İlgili bina bilgilerini al
            Building selectedBuildingInfo = buildings.Find(b => b.BuildingName == selectedBuilding);

            // Building bilgilerini Form3'teki kontrolere yerleştir
            // Örnek olarak, eğer TextBox kullanıyorsanız:



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni bir ListViewItem oluştur
            ListViewItem newItem = new ListViewItem();

            // ListViewItem'a sırasıyla kapı numarası, son ödeme tarihi ve durum ekleniyor
            newItem.Text = numericUpDown1.Value.ToString(); // Kapı Numarası
            newItem.SubItems.Add(dateTimePicker1.Value.ToShortDateString()); // Son Ödeme Tarihi
            newItem.SubItems.Add(comboBox1.SelectedItem.ToString()); // Durum

            // ListViewItem'ı ListView'e ekle
            listView1.Items.Add(newItem);

            // Giriş alanlarını temizle
            numericUpDown1.Value = 1;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Seçili item'ı kontrol et
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili item'ı kaldır
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
