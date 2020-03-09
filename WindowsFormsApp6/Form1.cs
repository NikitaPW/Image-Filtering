using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {        
            String img = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    img = dialog.FileName;
                    Image1.ImageLocation = img;
                    Image2.ImageLocation = img;
                }
                uploadImageToolStripMenuItem.CheckState = CheckState.Checked;

            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while uploading pircture", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }
        
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Bitmap pic = new Bitmap(Image2.Image);
            BitmapData sourceData = pic.LockBits(new Rectangle(0, 0,
                                 pic.Width, pic.Height),
                                 ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            pic.UnlockBits(sourceData);

        
            double blue = 0;
            double green = 0;
            double red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = 255 - pixelBuffer[k];

                green = 255 - pixelBuffer[k + 1];

                red = 255 - pixelBuffer[k + 2];

                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }

                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }

                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }
            Bitmap resultBitmap = new Bitmap(pic.Width, pic.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);
            Image2.Image = resultBitmap;        
            
        }

        private void brightnessCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float brightness = 45;
            if (brightnessCorrectionToolStripMenuItem.Checked)
            {
                Bitmap TempBitmap = new Bitmap(Image2.Image);
                float FinalValue = -brightness / 255.0f;
                Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
                Graphics NewGraphics = Graphics.FromImage(NewBitmap);
                float[][] FloatColorMatrix ={
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                };

                ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
                ImageAttributes Attributes = new ImageAttributes();
                Attributes.SetColorMatrix(NewColorMatrix);
                NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
                Attributes.Dispose();
                NewGraphics.Dispose();
                Image2.Image = NewBitmap;
                
            }
            else {
                Bitmap TempBitmap = new Bitmap(Image2.Image);
                float FinalValue = brightness / 255.0f;
                Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
                Graphics NewGraphics = Graphics.FromImage(NewBitmap);
                float[][] FloatColorMatrix ={
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                };

                ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
                ImageAttributes Attributes = new ImageAttributes();
                Attributes.SetColorMatrix(NewColorMatrix);
                NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
                Attributes.Dispose();
                NewGraphics.Dispose();
                Image2.Image = NewBitmap;
            }                   
        }      

        private void Image1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Image1.ClientRectangle, Color.CornflowerBlue, ButtonBorderStyle.Solid);
        }

        private void Image2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Image2.ClientRectangle, Color.CornflowerBlue, ButtonBorderStyle.Solid);
        }

        private void contrastEnhancementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int threshold = 12;
            Bitmap bmp = new Bitmap(Image2.Image);
            BitmapData sourceData = bmp.LockBits(new Rectangle(0, 0,
                                 bmp.Width, bmp.Height),
                                 ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            bmp.UnlockBits(sourceData);

            double contrastLevel;

            double blue = 0;
            double green = 0;
            double red = 0;

            if (contrastEnhancementToolStripMenuItem.Checked)
            {
                contrastLevel = (100.0 + threshold)/ 100.0;
                for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
                {
                    blue = ((((pixelBuffer[k] / 255.0) - 0.5) /
                                contrastLevel) + 0.5) * 255.0;

                    green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) /
                                contrastLevel) + 0.5) * 255.0;

                    red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) /
                                contrastLevel) + 0.5) * 255.0;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    pixelBuffer[k] = (byte)blue;
                    pixelBuffer[k + 1] = (byte)green;
                    pixelBuffer[k + 2] = (byte)red;
                }
                
            }
            else
            {
                
                contrastLevel =(100.0 + threshold) / 100.0;
                for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
                {
                    blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                                contrastLevel) + 0.5) * 255.0;

                    green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                                contrastLevel) + 0.5) * 255.0;

                    red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                                contrastLevel) + 0.5) * 255.0;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    pixelBuffer[k] = (byte)blue;
                    pixelBuffer[k + 1] = (byte)green;
                    pixelBuffer[k + 2] = (byte)red;
                }
                
            }       

            Bitmap resultBitmap = new Bitmap(bmp.Width, bmp.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);
            Image2.Image = resultBitmap;
        }
       
        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gammaCorrectionToolStripMenuItem.Checked)
            {
                float gamma = 0.5f;
                Image image = Image2.Image;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetGamma(gamma);
               
                Point[] points =
                {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
                };
                Rectangle rect =
                    new Rectangle(0, 0, image.Width, image.Height);
              
                Bitmap bm = new Bitmap(image.Width, image.Height);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
                }

                Image2.Image = bm;
                
            }
            else {
                    float gamma = 2.0f;
                    Image image = Image2.Image;
               
                    ImageAttributes attributes = new ImageAttributes();
                    attributes.SetGamma(gamma);

                    Point[] points =
                    {
                    new Point(0, 0),
                    new Point(image.Width, 0),
                    new Point(0, image.Height),
                    };
                    Rectangle rect =
                        new Rectangle(0, 0, image.Width, image.Height);

                    Bitmap bm = new Bitmap(image.Width, image.Height);
                    using (Graphics gr = Graphics.FromImage(bm))
                    {
                        gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
                    }

                    Image2.Image = bm;
                    
            }
        } 

        public static Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor)
        {                                  
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                     ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   filterMatrix[filterY + filterOffset,
                                                      filterX + filterOffset];
                        }
                    }            
                    
                    blue = factor * blue ;
                    green = factor * green ;
                    red = factor * red ;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                     ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {          
                Bitmap blurred = new Bitmap(Image2.Image);
                double factor, sum = 0;
                double[,] filterMatrix =
                //new double[,] { { 1.0, 1.0, 1.0,},
                //                { 1.0, 1.0, 1.0,},
                //                { 1.0, 1.0, 1.0,}, };
                new double[,] { { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,},
                            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,  1.0, 1.0, 1.0,}, };

                for (int i = 0; i < filterMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < filterMatrix.GetLength(0); j++)
                    {
                        sum += filterMatrix[i, j];
                    }
                }
                factor = 1 / sum;
                blurred = ConvolutionFilter(blurred, filterMatrix, factor);
                Image2.Image = blurred;
            

        }

        private void gausssianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {         
                embossToolStripMenuItem.CheckState = CheckState.Unchecked;
                Bitmap blurred = new Bitmap(Image2.Image);
                double factor, sum = 0;
                double[,] filterMatrix =
                //new double[,] { { 0.0, 1.0, 0.0,},
                //                { 1.0, 4.0, 1.0,},
                //                { 0.0, 1.0, 0.0,}, };
                new double[,] { { 1.0, 4.0, 6.0, 4.0, 1.0,},
                            { 4.0, 16.0, 24.0, 16.0, 4.0,},
                            { 6.0, 24.0, 36.0, 24.0, 6.0,},
                            { 4.0, 16.0, 24.0, 16.0, 4.0,},
                            { 1.0, 4.0, 6.0, 4.0, 1.0,} };

                for (int i = 0; i < filterMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < filterMatrix.GetLength(0); j++)
                    {
                        sum += filterMatrix[i, j];
                    }
                }
                factor = 1 / sum;
                blurred = ConvolutionFilter(blurred, filterMatrix, factor);
                Image2.Image = blurred;
            
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {         
                Bitmap sharpened = new Bitmap(Image2.Image);
                double factor, sum = 0;
                double[,] filterMatrix =
                new double[,] { { -1, -1, -1, },
                            { -1,  9, -1, },
                            { -1, -1, -1, }, };

                for (int i = 0; i < filterMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < filterMatrix.GetLength(0); j++)
                    {
                        sum += filterMatrix[i, j];
                    }
                }
                factor = 1 / sum;
                sharpened = ConvolutionFilter(sharpened, filterMatrix, factor);
                Image2.Image = sharpened;
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {                         
                Bitmap edged = new Bitmap(Image2.Image);
                double factor, sum = 0;
                double[,] filterMatrix =
                    new double[,] { { -1, -1, -1},
                                { -1, 8, -1},
                                { -1, -1, -1} };

                for (int i = 0; i < filterMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < filterMatrix.GetLength(0); j++)
                    {
                        sum += filterMatrix[i, j];
                    }
                }
                if (sum == 0) sum = 1;
                factor = 1 / sum;
                edged = ConvolutionFilter(edged, filterMatrix, factor);
                Image2.Image = edged;
            
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {   
                Bitmap edged = new Bitmap(Image2.Image);
                double factor, sum = 0;
                double[,] filterMatrix =
                    new double[,] { { -1, -1, -1},
                                { 0, 1, 0},
                                { 1, 1, 1} };// South Emboss


                //double[,] filterMatrix =
                //    new double[,] { { -1, -1, 0},
                //                    { -1, 1, 1},
                //                    {  0, 1, 1} }; // South-east Emboss

                for (int i = 0; i < filterMatrix.GetLength(1); i++)
                {
                    for (int j = 0; j < filterMatrix.GetLength(0); j++)
                    {
                        sum += filterMatrix[i, j];
                    }
                }
                factor = 1 / sum;
                edged = ConvolutionFilter(edged, filterMatrix, factor);
                Image2.Image = edged;
            
        }

        private void undoAllChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image2.Image = Image1.Image;
        }

        private void undoAllChangesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Image1.Image = Properties.Resources.image_placeholder;
            Image2.Image = Properties.Resources.image_placeholder;
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            dialog.Title = "Save an Image File";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                System.IO.FileStream fs =
                        (System.IO.FileStream)dialog.OpenFile();
                Bitmap save = new Bitmap(Image2.Image);
                switch (dialog.FilterIndex)
                {
                    case 1:
                        Image2.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        Image2.Image.Save(fs, ImageFormat.Bmp);
                        break;

                    case 3:
                        Image2.Image.Save(fs, ImageFormat.Gif);
                        break;
                }         
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void polylineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Image2.Image);
            List<Point> list = new List<Point>();
            list.Add(new Point(0, 256));
            list.Add(new Point(256, 0));
            Custom cust = new Custom(list);
            List<Custom> custList = new List<Custom>();
            custList.Add(cust);

            Form2 f3 = new Form2(this, bmp, custList[0]); 
            f3.Show(); 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float gamma = float.Parse(textBox1.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat);
            if (gamma < 0)
                MessageBox.Show("TextBox cannot be Empty and it shoud be greater then 0");
            else
            {
                Image image = Image2.Image;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetGamma(gamma);

                Point[] points =
                {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
                };
                Rectangle rect =
                    new Rectangle(0, 0, image.Width, image.Height);

                Bitmap bm = new Bitmap(image.Width, image.Height);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
                }

                Image2.Image = bm;
            }

            
        }
    }
}
