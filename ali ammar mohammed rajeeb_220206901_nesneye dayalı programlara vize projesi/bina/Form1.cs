using System.Windows.Forms;


namespace bina
{
    public partial class Form1 : Form
    {

        private List<Building> buildings = new List<Building>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AddBuilding(ListViewItem newItem)
        {
            // ListViewItem'ý ListView'e ekle
            Building newBuilding = new Building
            {
                BuildingName = newItem.Text,
                NumberOfApartments = int.Parse(newItem.SubItems[1].Text),
                MonthlyDues = decimal.Parse(newItem.SubItems[2].Text)
            };

            // Building'i listeye ekle
            buildings.Add(newBuilding);

            // ListViewItem'ý ListView'e ekle
            listView1.Items.Add(newItem);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili öðenin bina ismini al
                string selectedBuilding = listView1.SelectedItems[0].Text;

                // Yeni bir form oluþtur ve seçili binanýn adýný ileterek aç
                Form3 form3 = new Form3(selectedBuilding,buildings);
                form3.Show();
                this.Hide();
            }
        }
    }
}