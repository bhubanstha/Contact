using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using AnimatorNS;

namespace Win.Carousel
{
    public class Carousel
    {
        Animator animator = new Animator();
        Random rand = new Random();
        ctrlCarousel ctrl = new ctrlCarousel();
        Timer t = new Timer();
        int i = 2;
        Image image;

        public Carousel()
        {
            animator.AnimationType = AnimationType.Mosaic;
            animator.Interval = 1;
            animator.MaxAnimationTime = 2500;
            ctrl.BringToFront();
            ctrl.Dock = DockStyle.Fill;
            t.Interval = 5000;
            t.Tick += T_Tick;
            ctrl.pic.Image = Properties.Resources._1;
            ctrl.pic.Hide();
            animator.Show(ctrl.pic);

        }


        public void Add(Control container)
        {
            foreach (UserControl uctrl in container.Controls.OfType<UserControl>())
            {
                container.Controls.Remove(uctrl);
                uctrl.Dispose();
            }
            t.Enabled = true;
            container.Padding = new Padding(0);
            container.Controls.Add(ctrl);
        }
        public void Add(Control container, int intervalInSecond)
        {
            foreach (UserControl uctrl in container.Controls.OfType<UserControl>())
            {
                container.Controls.Remove(uctrl);
                uctrl.Dispose();
            }

            t.Interval = intervalInSecond * 1000;
            t.Enabled = true;
            container.Padding = new Padding(0);
            container.Controls.Add(ctrl);
        }
        private void T_Tick(object sender, EventArgs e)
        {
            ctrl.pic.Hide();
            animator.AnimationType = (AnimationType) GetRandomAnimation();
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
            if (i > 6)
            {
                i = 0;
            }
            ctrl.pic.Image = image;
            animator.Show(ctrl.pic);
        }

        private int GetRandomAnimation()
        {
            return rand.Next(1, 13);
        }
    }
}
