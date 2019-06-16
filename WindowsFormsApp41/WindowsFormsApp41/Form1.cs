using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter = null;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            groupBox3.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nepokretnostDataSet.Namena' table. You can move, or remove it, as needed.
            this.namenaTableAdapter.Fill(this.nepokretnostDataSet.Namena);
            // TODO: This line of code loads data into the 'nepokretnostDataSet.Objekat' table. You can move, or remove it, as needed.
            this.objekatTableAdapter.Fill(this.nepokretnostDataSet.Objekat);

        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }
    
        
        public string vratiRadio()
        {
            string promenljiva = "";
            foreach(RadioButton rb in groupBox3.Controls)
            {
                if (rb.Checked)
                {
                    promenljiva = rb.Text;
                }
            }
            return promenljiva;
        }
        public DataTable puniObjekte()
        {
            adapter = new SqlDataAdapter("select distinct Vlasnik from Objekat", Konekcija.konString);
            adapter.Fill(ds, "Objekat");
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataTable dt = ds.Tables["Objekat"];
            return dt;
        }
        public void puniCombo()
        {
            DataTable dt = puniObjekte();
            cbVlasnik.DataSource = dt;
            cbVlasnik.ValueMember = "Vlasnik";
            
        }
            
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            SqlConnection konekcija = new SqlConnection(Konekcija.konString);
            SqlCommand komanda = new SqlCommand("select count(*) from Objekat o join Namena n on n.IDNamena=o.Namena where n.Naziv=@id", konekcija);
            komanda.Parameters.AddWithValue("@id",Convert.ToString( vratiRadio()));
            try
            {
                konekcija.Open();
                tbBrojObjekta.Text =Convert.ToString(komanda.ExecuteScalar());


            }
            catch(Exception ex)
            {
                MessageBox.Show("Doslo je do greske " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }

        private void racuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            puniCombo();

        }

        private void cbVlasnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection konekcija = new SqlConnection(Konekcija.konString);
            SqlCommand komanda = new SqlCommand("select IDObjekat,Povrsina from Objekat o join Namena n on n.IDNamena=o.Namena where n.Naziv=@id", konekcija);
            komanda.Parameters.AddWithValue("@id", Convert.ToString(vratiRadio()));
            SqlDataReader reader = null;

            try
            {
                konekcija.Open();
                reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString() + "   " + reader[1].ToString() + "\n");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske " + ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}
