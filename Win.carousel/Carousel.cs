using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Win.Carousel
{
    public  class Carousel
    {
         ctrlCarousel ctrl = new ctrlCarousel();
         Timer t = new Timer();
         Timer progress = new Timer();
         int i = 2;
         Image image;

        public Carousel()
        {
            ctrl.BringToFront();
            ctrl.Dock = DockStyle.Fill;
            t.Interval = 3000;
            t.Tick += T_Tick;
            ctrl.pic.Image = Properties.Resources._1;

            progress.Tick += Progress_Tick;
        }

        private  void Progress_Tick(object sender, EventArgs e)
        {
            ctrl.prog.Value ++;
            if (ctrl.prog.Value == 100)
            {
                progress.Enabled = false;               
            }
        }

        public  void Add(Control container)
        {
            foreach (UserControl uctrl in container.Controls.OfType<UserControl>())
            {
                container.Controls.Remove(uctrl);
                uctrl.Dispose();
            }
            progress.Interval = 3000 / 100;           
            progress.Enabled = true;
            t.Enabled = true;
            container.Padding = new Padding(0);         
            container.Controls.Add(ctrl);
        }
        public  void Add(Control container, int intervalInSecond)
        {
            foreach (UserControl uctrl in container.Controls.OfType<UserControl>())
            {
                container.Controls.Remove(uctrl);
                uctrl.Dispose();
            }

            t.Interval = intervalInSecond * 1000;           
            progress.Interval = t.Interval / 100;
            progress.Enabled = true;
            t.Enabled = true;
            container.Padding = new Padding(0);
            container.Controls.Add(ctrl);
        }
        private  void T_Tick(object sender, EventArgs e)
        {
            ctrl.prog.Value = 0;
            progress.Enabled = true;
            switch (i)
            {
                case 1:
                    image = Properties.Resources._1;                               
                    break;
                case 2:
                    image = Properties.Resources._2;
                    break;
                case 3:
                    image = Properties.Resources._3;
                    break;
                case 4:
                    image = Properties.Resources._4;
                    break;
                case 5:
                    image = Properties.Resources._5;
                    break;
                case 6:
                    image = Properties.Resources._6;
                    break;
                default:
                    image = Properties.Resources._1;
                    break;
            }
            i++;
            if (i>6)
            {
                i = 0;
            }
            ctrl.pic.Image = image;
        }
    }
}
