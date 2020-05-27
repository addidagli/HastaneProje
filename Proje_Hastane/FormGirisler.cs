using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightSeaGreen;
        }

      

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FormHastaGiris frm = new FormHastaGiris();
            frm.Show();
            this.Hide();
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FormDoktorGiris frm = new FormDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FormSekreterGiris frm = new FormSekreterGiris();
            frm.Show();
            this.Hide();
        }
    }
}
