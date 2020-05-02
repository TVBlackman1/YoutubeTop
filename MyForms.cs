using System;
using System.Drawing;
using System.Windows.Forms;

namespace YoutubeTop
{
    class MyForms:Form
    {
        private Color baseColor;

        public MyForms(string txt):base()
        {
            Text = txt;
            Height = 200;
            Width = 300;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            baseColor = BackColor;
            MouseEnter += (a, b) =>
            {
                BackColor = Color.Red;
            };

            MouseLeave += (a, b) =>
            {
                BackColor = baseColor;
            };
        }

        public static void Show(string txt)
        {
            Application.Run(new MyForms(txt));
        }
    }
}
