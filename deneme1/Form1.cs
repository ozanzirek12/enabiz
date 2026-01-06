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

namespace deneme1
{
    
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=OZAN\\SQLEXPRESS;Initial Catalog=Hastane;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        // BU METOT: TC kutusuna ne yazarsan ona göre filtreleyip tabloyu doldurur
        void RandevulariGetir(string tcFiltresi)
        {
            try
            {
                baglanti.Open();

                // SQL SORGUSU: HastaTC sütununda, yazılan numara ile başlayanları getir (LIKE komutu)
                // Eğer kutu boşsa hepsini getirir.
                string sql = "SELECT * FROM Randevu WHERE HastaTC LIKE @tc + '%' ORDER BY Tarih DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@tc", tcFiltresi);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Verileri DataGridView'e bas
                dataGridView1.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                baglanti.Close();
                // Hata olursa (örn: tablo yoksa) mesaj verme, formu kilitlemesin.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandevulariGetir("");
            // TODO: Bu kod satırı 'hastaneDataSet.hastane' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaneTableAdapter.Fill(this.hastaneDataSet.hastane);
            // TODO: Bu kod satırı 'hastaneDataSet.Poliklinik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.poliklinikTableAdapter.Fill(this.hastaneDataSet.Poliklinik);
            // TODO: Bu kod satırı 'hastaneDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.hastaneDataSet.iller);
           

            // --- SENİN EKLEYECEĞİN KISIM ---

            // 1. Şehir seçimi yapılmamış olsun
            cmbIller.SelectedIndex = -1;

            // 2. Hastane seçimi yapılmamış olsun
            cmbHastaneler.SelectedIndex = -1;

            cmbPoliklinik.SelectedIndex = -1;
            RandevulariGetir("-1");

            // 3. (İsteğe Bağlı) Hiçbir il seçili değilken Hastane listesi de boş görünsün istiyorsan:
            // Bu satırı eklemezsen tüm hastaneler listelenir ama seçili olmaz.
            // Ekler isen liste bomboş gelir.
            hastaneBindingSource.Filter = "sehirid = -1";

        }

       

        private void cmbIller_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Hata almamak için dolu mu kontrolü
            if (cmbIller.SelectedValue != null)
            {
                try
                {
                    // Kontrol: Bakalım program 1 rakamını yakalayabiliyor mu?
                    // (Bu satır sadece test için, çalışınca sileceğiz)
                    // MessageBox.Show("Seçilen ID Değeri: " + cmbIller.SelectedValue.ToString());

                    // 1. İlin ID'sini al (Örn: 1)
                    int id = Convert.ToInt32(cmbIller.SelectedValue);

                    // 2. Hastanelere Filtre Uygula: "sehirid sütunu bu ID'ye eşit olanları göster"
                    // 'hastaneBindingSource' isminin senin projendekiyle AYNI olduğundan emin ol!
                    // Tablo resminde sütun adı 'sehirid' olduğu için 'sehirid=' yazdık.
                    hastaneBindingSource.Filter = string.Format("sehirid = {0}", id);
                }
                catch
                {
                    // Açılışta bazen sayı yerine "System.Data..." gibi bir yazı gelebilir, onu görmezden geliyoruz.
                }
            }
            cmbPoliklinik.SelectedIndex = -1;
            

        }

        private void cmbHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbPoliklinik.SelectedIndex = -1;


        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            RandevulariGetir(txtTC.Text);

            // MANTIK: Sadece karakter sayısı tam 11 olduğunda veritabanına git.
            if (txtTC.Text.Length == 11)
            {
                // 11 hane tamamlandı, şimdi aramayı yap
                RandevulariGetir(txtTC.Text);
            }
            else
            {
                // Eğer 11 hane değilse (yani yazmaya devam ediyorsa veya siliyorsa)
                // Tabloyu BOŞ TUT (Gizle)
                RandevulariGetir("-1");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Basit bir boş alan kontrolü
            if (txtTC.Text.Length < 11 || cmbPoliklinik.Text == "")
            {
                MessageBox.Show("Lütfen TC'yi tam girin ve tüm seçimleri yapın.");
                return;
            }

            try
            {
                baglanti.Open();

                // Veritabanına kaydetme komutu
                SqlCommand komut = new SqlCommand("INSERT INTO Randevu (HastaTC, Sehir, Hastane, Poliklinik) VALUES (@p1, @p2, @p3, @p4)", baglanti);

                komut.Parameters.AddWithValue("@p1", txtTC.Text);
                komut.Parameters.AddWithValue("@p2", cmbIller.Text);      // Seçili İL ADI
                komut.Parameters.AddWithValue("@p3", cmbHastaneler.Text); // Seçili HASTANE ADI
                komut.Parameters.AddWithValue("@p4", cmbPoliklinik.Text); // Seçili POLİKLİNİK ADI

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Randevu Kaydedildi!");

                // Kaydettikten sonra listeyi yenile ki yeni kaydı görelim
                RandevulariGetir(txtTC.Text);
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer basılan tuş RAKAM değilse VE Silme Tuşu (Backspace) değilse engelle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // "Bu tuşu görmezden gel" demektir.
            }
        }
    }
}
