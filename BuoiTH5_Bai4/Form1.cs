using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH5_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoHT_CheckedChanged(object sender, EventArgs e)
        {
            grbHT.Visible = true;

        }

        private void rdoHV_CheckedChanged(object sender, EventArgs e)
        {
            grbHV.Visible = true;
        }

        private void rdoHTG_CheckedChanged(object sender, EventArgs e)
        {
            grbHTG.Visible = true;
        }

        private void rdoHCN_CheckedChanged(object sender, EventArgs e)
        {
            grbHCN.Visible = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdoHT.Checked)
            {
                float r = float.Parse(txtR.Text);
                if (r <= 0)
                {
                    MessageBox.Show("Bán kính phải lớn hơn 0!", "Thông báo");

                } 
                else
                {
                    txtCV.Text = (2 * r * 3.14).ToString();
                    txtDT.Text = (r * r * 3.14).ToString();
                }      
            }
            else if (rdoHV.Checked)
            {
                int canh=int.Parse(txtCanh.Text);
                if (canh <= 0)
                {
                    MessageBox.Show("Cạnh hình vuông phải lớn hơn 0!", "Thông báo");

                }
                else
                {
                    txtCVHV.Text = (4 * canh).ToString();
                    txtDTHV.Text = (canh * canh).ToString();
                }
               
            }
            else if(rdoHTG.Checked)
            {
                int a=int.Parse(txtCanhA.Text);
                int b=int.Parse(txtCanhB.Text);
                int c=int.Parse(txtCanhC.Text);
                if((a+b<c) || (b+c<a)||(a+c<b)||(a<=0)||(b<=0)||(c<=0))
                {
                    MessageBox.Show("Ba cạnh vừa nhập không tạo thành hình tam giác!", "Thông báo");

                }
                else
                {
                    txtCVTG.Text=(a+b+c).ToString();
                    double p=Convert.ToDouble(txtCVTG.Text);
                    txtDTTG.Text=(Math.Sqrt(a*).ToString();
                }

            }    
        }
    }
}
