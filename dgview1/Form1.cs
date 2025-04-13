using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public static ArrayList no = new ArrayList() { 11, 12, 13, 14, 17, 18, 19, 20 };
        public static ArrayList ad = new ArrayList() { "ali", "osman", "mehmet", "yunus", "fatma", "nurcan", "eslem", "sude" };
        public static ArrayList soyad = new ArrayList() { "AK", "KAYA", "MOR", "TOR", "KAR", "AS", "KOR", "KEL" };
        public static ArrayList ort = new ArrayList() { 85, 50, 58, 55, 68, 65, 46, 48 };

        int i, j, s;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvolustur();
            yukle();
            lbyaz();

        }
        private void dgvolustur()
        {
            DGV1.ColumnCount = 4;
            DGV1.Columns[0].Name = "No";
            DGV1.Columns[1].Name = "Ad";
            DGV1.Columns[2].Name = "Soyad";
            DGV1.Columns[3].Name = "Ort";

            DGV1.Columns[0].Width = 50;
            DGV1.Columns[1].Width = 125;
            DGV1.Columns[2].Width = 125;
            DGV1.Columns[3].Width = 80;

            DGV1.ReadOnly = true;
            DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV1.MultiSelect = false;
        }
        private void yukle()
        {
            for (s = 0; s < ad.Count; s++)
            {
                DGV1.Rows.Add(no[s], ad[s], soyad[s], ort[s]);
            }

            i = ad.Count - 1;
            j = i;
            lbyaz();
        }
        private void button1_Click(object sender, EventArgs e)//ekle
        {
            if (hataA() == 1)
            {
                i++;
                j = i;
                ekle();
                lbyaz();
                TB1.Focus();
            }
        }
        private void ekle()
        {
            DGV1.Rows.Add(TB1.Text, TB2.Text, TB3.Text, TB4.Text);
        }
        private void degistir()
        {
            DGV1.Rows[j].Cells[0].Value = TB1.Text;
            DGV1.Rows[j].Cells[1].Value = TB2.Text;
            DGV1.Rows[j].Cells[2].Value = TB3.Text;
            DGV1.Rows[j].Cells[3].Value = TB4.Text;
        }
        private void button3_Click(object sender, EventArgs e)//degistir
        {
            if (hataA() == 1)
            {
                degistir();
                lbyaz();
                TB1.Focus();
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            j = DGV1.CurrentRow.Index;
            lbyaz();
            if (DGV1.CurrentRow != null && j <= i)
            {                        
                TB1.Text = DGV1.Rows[j].Cells[0].Value.ToString();
                TB2.Text = DGV1.Rows[j].Cells[1].Value.ToString();
                TB3.Text = DGV1.Rows[j].Cells[2].Value.ToString();
                TB4.Text = DGV1.Rows[j].Cells[3].Value.ToString();             
            }
        }
        private void button2_Click(object sender, EventArgs e)//sil
        {
            if (DGV1.SelectedRows.Count > 0 && j >= 0 && j <= i)
            {              
                DGV1.Rows.RemoveAt(j);
                i--;
                temizle();
                lbyaz();
            }
            else
            {
                MessageBox.Show("Eleman seçiniz.");
            }
            TB1.Focus();
        }
        private void lbyaz()
        {
            DGV1.CurrentCell = DGV1.Rows[j].Cells[0];
            label1.Text = (j + 1) + " / " + (i + 1);
        }
        private void temizle()
        {

            TB1.Text = ""; TB2.Text = "";
            TB3.Text = ""; TB4.Text = "";      
        }
        private int hataA()
        {
            if (TB1.Text == "" || TB2.Text == "" || TB3.Text == "" || TB4.Text == "")
            {
                MessageBox.Show("Hata: Alanları boş bırakmayınız!");
                return 0;
            }
            return 1;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
