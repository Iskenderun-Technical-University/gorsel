using System.Data.SqlClient;

namespace eczane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("data source=DESKTOP-P44PA8U\\SQLEXPRESS;Initial Catalog=eczaneilacstok;Integrated Security=true");
        private void verilerigoruntule()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ilac", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem(); 
                ekle.Text= oku["id"].ToString();
                ekle.SubItems.Add(oku["ilacad"].ToString());
                ekle.SubItems.Add(oku["ilacsirketi"].ToString());
                ekle.SubItems.Add(oku["ilacturu"].ToString());
                ekle.SubItems.Add(oku["ilackutuadedi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }
    }
}