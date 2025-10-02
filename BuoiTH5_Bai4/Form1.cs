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
                    double p=Convert.ToDouble((a+b+c)/2);
                    txtDTTG.Text = (Math.Sqrt(p * (p - a) * (p - b) * (p - c))).ToString();

                }

            }
            else
            {
                int dai = int.Parse(txtDai.Text);
                int rong = int.Parse(txtRong.Text);
                if ((dai <= 0) || (rong <= 0))
                {
                    MessageBox.Show("Chiều dài và chiều rộng phải lớn hơn 0!", "Thông báo");
                }
                else
                {
                    txtCVHCN.Text = (2 * (dai + rong)).ToString();
                    txtDTHCN.Text = (dai * rong).ToString();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grbHT.Visible = false;
            grbHV.Visible = false;
            grbHTG.Visible = false;
            grbHCN.Visible = false;
            rdoHT.Checked = false;
            rdoHV.Checked = false;
            rdoHTG.Checked = false;
            rdoHCN.Checked = false;
            txtR.Clear();
            txtCV.Clear();
            txtDT.Clear();
            txtCanh.Clear();
            txtCVHV.Clear();
            txtDTHV.Clear();
            txtCVTG.Clear();
            txtDTTG.Clear();
            txtCanhA.Clear();
            txtCanhB.Clear();
            txtCanhC.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtCVHCN.Clear();
            txtDTHCN.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes) this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grbHT.Visible = false;
            grbHV.Visible = false;
            grbHTG.Visible = false;
            grbHCN.Visible = false;
            rdoHT.Checked = false;
            rdoHV.Checked = false;
            rdoHTG.Checked = false;
            rdoHCN.Checked = false;

        }


        private void rdoHT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHT.Checked == true)
            {
                grbHT.Visible = true;
                grbHV.Visible = false;
                grbHTG.Visible = false;
                grbHCN.Visible = false;
            }

        }

        private void rdoHV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHV.Checked == true)
            {
                grbHV.Visible = true;
                grbHT.Visible = false;
               
                grbHTG.Visible = false;
                grbHCN.Visible = false;
            }

        }

        private void rdoHTG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHTG.Checked == true)
            {
                grbHTG.Visible = true;
                grbHT.Visible = false;
                grbHV.Visible = false;
                
                grbHCN.Visible = false;
            }
        }

        private void rdoHCN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHCN.Checked == true)
            {
                grbHCN.Visible = true;
                grbHT.Visible = false;
                grbHV.Visible = false;
                grbHTG.Visible = false;
               
            }

        }
    }
}
