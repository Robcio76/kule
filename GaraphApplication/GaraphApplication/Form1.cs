using System.Security.Cryptography.X509Certificates;

namespace GaraphApplication
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(10, 10);
        Bitmap new_bmp = new Bitmap(10, 10);


        List<Sphere> spheres = new List<Sphere>();
        List<Light> lights = new List<Light>();


        public Form1()
        {
            InitializeComponent();

            spheres.Add(new Sphere(100, 100, 400, 10, Color.Red));
            spheres.Add(new Sphere(80, 200, 100, 10, Color.Blue));
            spheres.Add(new Sphere(50, 300, 300, 10, Color.Green));
            spheres.Add(new Sphere(120, 400, 100, 10, Color.Pink));

            lights.Add(new Light(10, 200, 400, Color.White));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.DrawImage(bmp, 10, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(500, 500);
            for (int x = 0; x < bmp.Height; x++)
            {
                for (int y = 0; y < bmp.Width; y++)
                {
                    bmp.SetPixel(x, y, Color.Black);

                    foreach (Sphere sphere in spheres)
                    {

                        double d = Math.Sqrt((x - sphere.xs) * (x - sphere.xs) + (y - sphere.ys) * (y - sphere.ys));
                        if (d < sphere.R)
                        {
                            double f = sphere.getlightcoefficient(x, y, lights[0]);
                            bmp.SetPixel(x, y, sphere.color);
                        }

                    }
                }
            }


            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f01 = -1;
            int f02 = 0;
            int f03 = 1;
            int f04 = -1;
            int f05 = 1;
            int f06 = 1;
            int f07 = -1;
            int f08 = 0;
            int f09 = 1;

            new_bmp = new Bitmap(500, 500);
            for (int x = 0; x < new_bmp.Height; x++)
            {
                for (int y = 0; y < new_bmp.Width; y++)
                { 

                   int R = bmp.GetPixel(x - 1, y).R * f04 + bmp.GetPixel(x + 1, y).R * f06 + bmp.GetPixel(x, y - 1).R * f08 + bmp.GetPixel(x, y + 1).R * f02 + bmp.GetPixel(x - 1, y - 1).R * f07 + bmp.GetPixel(x - 1, y + 1).R * f01 + bmp.GetPixel(x + 1, y - 1).R * f09 + bmp.GetPixel(x + 1, y + 1).R * f03 + bmp.GetPixel(x, y).R * f05;  
                   int G = bmp.GetPixel(x - 1, y).G * f04 + bmp.GetPixel(x + 1, y).G * f06 + bmp.GetPixel(x, y - 1).G * f08 + bmp.GetPixel(x, y + 1).G * f02 + bmp.GetPixel(x - 1, y - 1).G * f07 + bmp.GetPixel(x - 1, y + 1).G * f01 + bmp.GetPixel(x + 1, y - 1).G * f09 + bmp.GetPixel(x + 1, y + 1).G * f03 + bmp.GetPixel(x, y).G * f05;
                   int B = bmp.GetPixel(x - 1, y).B * f04 + bmp.GetPixel(x + 1, y).B * f06 + bmp.GetPixel(x, y - 1).B * f08 + bmp.GetPixel(x, y + 1).B * f02 + bmp.GetPixel(x - 1, y - 1).B * f07 + bmp.GetPixel(x - 1, y + 1).B * f01 + bmp.GetPixel(x + 1, y - 1).B * f09 + bmp.GetPixel(x + 1, y + 1).B * f03 + bmp.GetPixel(x, y).B * f05;
                    new_bmp.SetPixel(x, y, Color.FromArgb(R,G,B));


                }
            }
        }
    }
}