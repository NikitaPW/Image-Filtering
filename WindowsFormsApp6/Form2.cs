using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        private List<Custom> filters = new List<Custom>();
        private List<Point> points = new List<Point>();
        private List<Point> pointsss = new List<Point>();
        Point rec = new Point();

        private Form1 mainForm = null;

        private Bitmap sourceBitmap;

        public Form2()
        {
            InitializeComponent();             
        }

        public Form2(Form callingForm, Bitmap resource, Custom tmp)
        {
            InitializeComponent();
            mainForm = callingForm as Form1;
            pictureBox1.Height = 256;
            pictureBox1.Width = 256;
            sourceBitmap = resource;
            points = tmp.points;
            GetPolylineFilters();
            //points.Add(new Point(0, pictureBox1.Height));
            //points.Add(new Point(pictureBox1.Width, 0));          
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Point dp in points)
                if (dp.X - e.X < 8 && dp.X - e.X > -8 && dp.Y - e.Y < 8 && dp.Y - e.Y > -8)
                {
                    rec = dp;
                    break;
                }
            if (rec.X == 0 && rec.Y == 0)
            {
                foreach (Point dp in points)
                    if (dp.X - e.X < 8 && dp.X - e.X > -8 && dp.Y - e.Y < 8 && dp.Y - e.Y > -8)
                    {
                        rec = dp;
                        break;
                    }
                for (int i = 0; i < points.Count - 1; i++)
                {
                    if (!(points[i].X - e.X < 5 && points[i].X - e.X > -5 && points[i].Y - e.Y < 5 && points[i].Y - e.Y > -5))
                    {
                        if (e.X < points[i + 1].X)
                        {
                            points.Insert(i + 1, new Point(e.X, e.Y));
                            break;
                        }
                    }
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            List<Point> points2 = new List<Point>();
            points2.Add(new Point(0, pictureBox1.Height));
            points2.Add(new Point(pictureBox1.Width, 0));
            float s, ln, lp, x1, x2, y, y1, y2;
            ControlPaint.DrawBorder(e.Graphics, pictureBox1.ClientRectangle, Color.CornflowerBlue, ButtonBorderStyle.Solid);
            Graphics g = e.Graphics;
            for (int i = 0; i < points.Count - 1; i++)
            {
                if (i == 0)
                {
                    g.DrawEllipse(Pens.Black, points[i].X - 4.0f, points[i].Y - 4.0f, 8.0f, 8.0f);
                    g.FillEllipse(Brushes.Black, points[i].X - 4.0f, points[i].Y - 4.0f, 8.0f, 8.0f);
                }

                else
                {
                    g.DrawEllipse(Pens.Black, points[i].X - 4.0f, points[i].Y - 4.0f, 8.0f, 8.0f);
                    g.FillEllipse(Brushes.Black, points[i].X - 4.0f, points[i].Y - 4.0f, 8.0f, 8.0f);
                }
                            
                g.DrawLine(Pens.Black, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
                x1 = points[i].X;
                x2 = points[i + 1].X;
                y1 = points[i].Y;
                y2 = points[i + 1].Y;
                int ind = 0;
                s = points[i + 1].X - points[i].X;
                for (int k = 1; k <= s; k++)
                {
                    ind++;
                    ln = points[i + 1].X - points[i].X;
                    lp = points[i].Y - points[i + 1].Y;
                    y = y1 - (k) / ln * lp;
                    points2.Insert((int)(x1 + k), new Point((int)(k + x1), (int)(256 - y)));                      
                }
                
            }
            g.DrawEllipse(Pens.Black, points[points.Count - 1].X - 4.0f, points[points.Count-1].Y - 4.0f, 8.0f, 8.0f);
            g.FillEllipse(Brushes.Black, points[points.Count - 1].X - 4.0f, points[points.Count - 1].Y - 4.0f, 8.0f, 8.0f);
            if (points2.Count > 2)
            {
                points2.RemoveAt(points2.Count - 1);
                points2.RemoveAt(points2.Count - 1);
            }
            pointsss = points2;

            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                        sourceBitmap.Width, sourceBitmap.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            int blue = 0;
            int green = 0;
            int red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                if (pixelBuffer[k] >= 0 && pixelBuffer[k] <= 255)
                {
                    blue = points2.ElementAt(pixelBuffer[k]).Y;

                    green = points2.ElementAt(pixelBuffer[k + 1]).Y;

                    red = points2.ElementAt(pixelBuffer[k + 2]).Y;

                    pixelBuffer[k] = (byte)blue;
                    pixelBuffer[k + 1] = (byte)green;
                    pixelBuffer[k + 2] = (byte)red;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);
            mainForm.Image2.Image = resultBitmap;           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && rec != null)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    if (points[i].X == rec.X && points[i].Y == rec.Y)
                    {
                        if (i == 0)
                        {
                            points.RemoveAt(i);
                            points.Insert(i, new Point(rec.X, e.Y));
                            if (rec.Y <= pictureBox1.Height && e.Y > 0)
                                rec.Y = e.Y;
                            else
                            {
                                if (rec.Y < 0) rec.Y = pictureBox1.Height;
                                if (points[i].Y <= 0) { points.RemoveAt(i); points.Insert(i, new Point(0, 0)); }
                                if (points[i].Y > pictureBox1.Height) { points.RemoveAt(i); points.Insert(i, new Point(0, pictureBox1.Height)); }
                            }
                        }
                        else if (i == points.Count-1)
                        {
                            points.RemoveAt(i);
                            points.Insert(i, new Point(rec.X, e.Y));
                            if (rec.Y < pictureBox1.Height && e.Y > 0)
                                rec.Y = e.Y;
                            if (points[i].Y < 0) { points.RemoveAt(i); points.Insert(i, new Point(pictureBox1.Width, 1)); }
                            if (points[i].Y > pictureBox1.Height) { points.RemoveAt(i); points.Insert(i, new Point(pictureBox1.Width, pictureBox1.Height)); }
                        }
                        else if (points[i - 1].X < rec.X && points[i + 1].X > rec.X)
                        {
                            points.RemoveAt(i);
                            points.Insert(i, new Point(e.X, e.Y));
                            rec.X = e.X; rec.Y = e.Y;
                        }  
                        else if (points[i - 1].X >= rec.X)
                        {
                            int r = points[i - 1].X;
                            points.RemoveAt(i);
                            points.Insert(i, new Point(r + 1, e.Y));
                            rec.Y = e.Y;
                            rec.X = e.X;
                        }
                        else if (points[i + 1].X <= rec.X)
                        {
                            int r = points[i + 1].X;
                            points.RemoveAt(i);
                            points.Insert(i, new Point(r - 1, e.Y));
                            rec.Y = e.Y;
                            rec.X = e.X;
                        }
                    }
                }                 
                pictureBox1.Refresh();
            }         
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button.HasFlag(MouseButtons.Right) && rec != null)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    if ((points[i].X - rec.X < 4 || points[i].X - rec.X > -4) && (points[i].Y - rec.Y < 4 || points[i].Y - rec.Y > -4))
                    {
                        if (i == 0)
                        {

                        }
                        else if (i == points.Count - 1)
                        {

                        }
                        else if (rec.X==points[i].X)
                        {
                            points.RemoveAt(i);
                        }
                    }
                }
            }         
            Refresh();
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            rec = new Point(0,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Custom cast = new Custom(points);
            cast.FileName = textBox1.Text;
            XmlSerializer xs = new XmlSerializer(typeof(Custom));
            TextWriter tw = new StreamWriter(@".\" + cast.FileName + ".xml");
            xs.Serialize(tw, cast);
            tw.Close();
            
            GetPolylineFilters();
            
        }

        private void GetPolylineFilters()
        {
            filters.Clear();
            listBox1.Items.Clear();
            var files = Directory.GetFiles(@".", "*.xml", SearchOption.TopDirectoryOnly);
            XmlSerializer xs = new XmlSerializer(typeof(Custom));

            foreach (var file in files)
            {
                Custom CAF;
                using (var sr = new StreamReader(file))
                {
                    CAF = (Custom)xs.Deserialize(sr);
                }
                filters.Add(CAF);
                listBox1.Items.Add(CAF.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                foreach(var file in filters)
                {
                    if (file.FileName == name)
                        points = file.points;
                }
                Refresh();
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points = new List<Point>();
            points.Add(new Point(0, 256));
            points.Add(new Point(256, 0));
            Refresh();
        }
    }
}
