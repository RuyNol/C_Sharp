using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 标准分幅工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        参数 canshu=new 参数();
        public double zxjd, zxjf, zxjm, zxjs, zxwd, zxwf, zxwm, zxws, ysjd, ysjf, ysjm, ysjs, yswd, yswf, yswm, ysws;
        public bool dfm=false;
        public bool sjz=false;
        private void 左下经度_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下经度.Text, out zxjd))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 左下经分_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下经分.Text, out zxjf))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 左下经秒_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下经秒.Text, out zxjm))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 左下经十_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下经十.Text, out zxjs))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void 左下纬度_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下纬度.Text, out zxwd))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 左下纬分_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下纬分.Text, out zxwf))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 左下纬秒_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下纬秒.Text, out zxwm))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 左下纬十_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(左下纬十.Text, out zxws))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上经度_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上经度.Text, out ysjd))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上经分_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上经分.Text, out ysjf))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上经秒_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上经秒.Text, out ysjm))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上经十_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上经十.Text, out ysjs))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上纬度_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上纬度.Text, out yswd))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上纬分_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上纬分.Text, out yswf))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上纬秒_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上纬秒.Text, out yswm))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 右上纬十_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(右上纬十.Text, out ysws))
            {
                // 转换成功，执行其他操作
            }
            else
            {
                // 转换失败，可以在这里处理转换失败的情况
            }
        }

        private void 计算_Click(object sender, EventArgs e)
        {
            if (zxjd + zxjf + zxjm + zxwd + zxwf + zxwm + ysjd + ysjf + ysjm + yswd + yswf + yswm == 0) dfm = false; else dfm = true;
            if (zxjs + zxws + ysjs + ysws == 0) sjz = false; else sjz = true;
           
            if (dfm && !sjz)
            {
            dfm_z_s();
            }
            else if(!dfm && sjz)
            {
                s_z_dfm();
            }
            //if (dfm && sjz)
            else
            {
                MessageBox.Show("请不要在“度分秒”和“十进制”中同时键入！");
            }
        }

        public void dfm_z_s()
        {
           double[] zy1 = new double[4];
            zy1 = canshu.转换1(zxjd, zxjf, zxjm, zxwd, zxwf, zxwm, ysjd, ysjf, ysjm, yswd, yswf, yswm);
            左下经十.Text = Convert.ToString(zy1[0]);
            左下纬十.Text = Convert.ToString(zy1[1]);
            右上经十.Text = Convert.ToString(zy1[2]);
            右上纬十.Text = Convert.ToString(zy1[3]);
        }
        public void s_z_dfm()
        {
           double[] zy2 = new double[12];
            zy2 = canshu.转换2(zxjs,zxws,ysjs, ysws);
            左下经度.Text = Convert.ToString(zy2[0]);
            左下经分.Text = Convert.ToString(zy2[1]);
            左下经秒.Text = Convert.ToString(zy2[2]);

            左下纬度.Text = Convert.ToString(zy2[3]);
            左下纬分.Text = Convert.ToString(zy2[4]);
            左下纬秒.Text = Convert.ToString(zy2[5]);

            右上经度.Text = Convert.ToString(zy2[6]);
            右上经分.Text = Convert.ToString(zy2[7]);
            右上经秒.Text = Convert.ToString(zy2[8]);

            右上纬度.Text = Convert.ToString(zy2[9]);
            右上纬分.Text = Convert.ToString(zy2[10]);
            右上纬秒.Text = Convert.ToString(zy2[11]);
        }
    }
}
