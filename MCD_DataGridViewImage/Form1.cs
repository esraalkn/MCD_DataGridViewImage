using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_DataGridViewImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<urun> urunlerim = new List<urun>();
            urunlerim.Add(new urun()
            {
                id = 1,
                UrunTanim = "Tablet 1",
                ResimYol = @"C:\Users\ECR_EXCALIBUR_G770\Desktop\KitapResim\Tablet1.jpg"
            });

            urunlerim.Add(new urun()
            {
                id = 2,
                UrunTanim = "Tablet 2",
                ResimYol = @"C:\Users\ECR_EXCALIBUR_G770\Desktop\KitapResim\Tablet2.jpg"
            });

            urunlerim.Add(new urun()
            {
                id = 3,
                UrunTanim = "Tablet 3",
                ResimYol = @"C:\Users\ECR_EXCALIBUR_G770\Desktop\KitapResim\Tablet3.jpg"
            });

            urunlerim.Add(new urun()
            {
                id = 4,
                UrunTanim = "Tablet 4",
                ResimYol = string.Empty
            });

            grdUrunler.DataSource = urunlerim;
        }
    }
}
