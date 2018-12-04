using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.Other
{
    public partial class ViewPhoto : Form
    {
        Image Myimage=null;
        public ViewPhoto(Image image)
        {
            InitializeComponent();
            //Image image = Image.FromFile(Application.StartupPath + "\\image.jpg");
            pictureBox1.Image = image;
            Myimage = image.Clone() as Image;
            panel1.AutoScroll = true;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {

            if(pictureBox1.Image==null)
                return;

            int height = pictureBox1.Image.Size.Height;
            int width = pictureBox1.Image.Size.Width;
            Bitmap bit = new Bitmap(Myimage, new Size(height, width));

            int newheight=width;
            int newwidth=height;
            if (e.Delta > 0)
            {
                //鼠标滑轮向上！
                newheight = (int)(height*1.1);
                newwidth = (int)(width*1.1);
                bit = new Bitmap(Myimage, new Size(newwidth, newheight));
            }
            else if (e.Delta < 0)
            {
                //鼠标滑轮向下！

                //宽度太小的时候将不再进行
                if (height < 100 || width<100)
                    return;

                newheight = (int)(height * 0.9);
                newwidth = (int)(width * 0.9);
                bit = new Bitmap(Myimage, new Size(newwidth, newheight));
            }
            if (newheight > this.Height)
            {
                panel1.Dock = DockStyle.None;
                panel1.Size = new Size(newwidth, newheight);
                //panel1.Location = new Point(0, 0);
            }
            if (newwidth > this.Width)
            {
                panel1.Dock = DockStyle.None;
                panel1.Size = new Size(newwidth, newheight);
                //panel1.Location = new Point(0, 0);
            }
            if (newheight <= this.Height && newwidth <= this.Width)
            {
                panel1.Dock = DockStyle.Fill;
            }
            this.pictureBox1.Image = bit;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
