using oyun_ornk.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun_ornk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatroListesi=new List <Tiyatro>();

        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroListesi.Add(new Tiyatro(1, "Yüzyıllık Destan Ateş", "Akün Sahnesi", (183), 143, new DateTime(2023,12,24),false));
            tiyatroListesi.Add(new Tiyatro(2, "Korkuyu Beklerken", "Alanya Kültür Merkezi", (243), 190, new DateTime(2023, 12, 24), true));
            tiyatroListesi.Add(new Tiyatro(3, "Baba", "Dasdas Kültür Merkezi", (250), 160, new DateTime(2023, 12, 24), true));
            tiyatroListesi.Add(new Tiyatro(4, "Sır", "Kozyatağı Kültür Merkezi", (287), 180, new DateTime(2023, 12, 24), false));

            dgvListe.DataSource = tiyatroListesi.ToList();

        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtOyunİd.Text);
            string ad=cmbOyunAd.Text;
            string sahne=cmbSahne.Text;
            double fiyat =Convert.ToDouble(txtFiyat.Text);
            decimal sure =nmSüre.Value;
            DateTime tarih=dtpTarih.Value;
            bool muzikal=chkMuzikal.Checked;
            tiyatroListesi.Add(new Tiyatro(id,ad,sahne,fiyat,sure,tarih,muzikal));

            dgvListe.DataSource=tiyatroListesi.ToList();

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.Rows[0];
            Tiyatro secilenTiyatro=secilenSatir.DataBoundItem as Tiyatro;
            int id = Convert.ToInt32(txtOyunİd.Text);
            string ad = cmbOyunAd.Text;
            string sahne = cmbSahne.Text;
            double fiyat=Convert.ToDouble(txtFiyat.Text);
            decimal sure = nmSüre.Value;
            DateTime tarih=dtpTarih.Value;
            bool muzikal = chkMuzikal.Checked;


            secilenTiyatro.Id= id;
            secilenTiyatro.OyunAd = ad;
            secilenTiyatro.Sahne= sahne;
            secilenTiyatro.Fiyat = fiyat;
            secilenTiyatro.Sure= sure;
            secilenTiyatro.Tarih= tarih;
            secilenTiyatro.Muzikal= muzikal;

            dgvListe.DataSource=null;
            dgvListe.DataSource=tiyatroListesi.ToList();


        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOyunİd.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            cmbOyunAd.Text = dgvListe.CurrentRow.Cells["oyunAd"].Value.ToString();
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();
            nmSüre.Value = (decimal)dgvListe.CurrentRow.Cells["sure"].Value;
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            chkMuzikal.Checked = (bool)dgvListe.CurrentRow.Cells["muzikal"].Value;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilensatir = dgvListe.SelectedRows[0];
            Tiyatro secilenTiyatro=secilensatir.DataBoundItem as Tiyatro;
            DialogResult=MessageBox.Show("Seçilen Tiyatro Silinsin mi?","Tiyatro Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (DialogResult == DialogResult.Yes)
            {
                tiyatroListesi.Remove(secilenTiyatro);
            }
            dgvListe.DataSource = tiyatroListesi.ToList();

        }
    }
}
