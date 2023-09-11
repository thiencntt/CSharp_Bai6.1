using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            Double hk1, hk2, dtb;
            hk1 = Convert.ToDouble(txtHK1.Text);
            hk2 = Convert.ToDouble(txtHK2.Text);
            dtb = (hk1 + hk2) / 2;
            txtDTB.Text = Convert.ToString(dtb);
            if (dtb >= 5)
            {
                txtKQ.Text = "Được lên lớp";
            } else
            {
                txtKQ.Text = "Ở lại lớp";
            }

            if (dtb < 5) {
                txtXepLoai.Text = "Yếu";
            } else if(dtb <= 6) {
                txtXepLoai.Text = "Trung Bình";
            } else if (dtb <8) {
                txtXepLoai.Text = "Khá";
            } else {
                txtXepLoai.Text = "Giỏi";
            }

        }
    }
}
