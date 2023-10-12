using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 标准分幅工具
{
    public class 参数
    {
        public double zxjd, zxjf, zxjm, zxjs, zxwd, zxwf, zxwm, zxws, ysjd, ysjf, ysjm, ysjs, yswd, yswf, yswm, ysws;
        public double[] zy1;
        public double[] zy2;
        public string[] tfh;
        public double[] 转换1(double zxjd, double zxjf, double zxjm, double zxwd, double zxwf, double zxwm, double ysjd, double ysjf, double ysjm, double yswd, double yswf, double yswm)
        {
            double[] zy1 = new double[4];
            zxjs = zxjd + zxjf / 60 + zxjm / 3600;
            zy1[0] = zxjs;
            zxws = zxwd + zxwf / 60 + zxwm / 3600;
            zy1[1] = zxws;
            ysjs = ysjd + ysjf / 60 + ysjm / 3600;
            zy1[2] = ysjs;
            ysws = yswd + yswf / 60 + yswm / 3600;
            zy1[3] = ysws;
            return zy1;
        }
        public double[] 转换2(double zxjs, double zxws, double ysjs,double ysws)
        {

            double[] zy2 = new double[12];
            zxjd = Math.Truncate(zxjs);
            zxjf = Math.Truncate((zxjs - zxjd) * 60);
            zxjm = (zxjs - zxjd - zxjf / 60) * 3600;
            zy2[0] = zxjd;
            zy2[1] = zxjf;
            zy2[2] = zxjm;

            zxwd = Math.Truncate(zxws);
            zxwf = Math.Truncate((zxws - zxwd) * 60);
            zxwm = (zxws - zxwd - zxwf / 60) * 3600;
            zy2[3] = zxwd;
            zy2[4] = zxwf;
            zy2[5] = zxwm;

            ysjd = Math.Truncate(ysjs);
            ysjf = Math.Truncate((ysjs - ysjd) * 60);
            ysjm = (ysjs - ysjd - ysjf / 60) * 3600;
            zy2[6] = ysjd;
            zy2[7] = ysjf;
            zy2[8] = ysjm;

            yswd = Math.Truncate(ysws);
            yswf = Math.Truncate((ysws - yswd) * 60);
            yswm = (ysws - yswd - yswf / 60) * 3600;
            zy2[9] = yswd;
            zy2[10] = yswf;
            zy2[11] = yswm;

            return zy2;
        }
        public string[] tufu(double zxjs, double zxws, double ysjs, double ysws)
        {


            return tfh;
        }
    }
}
