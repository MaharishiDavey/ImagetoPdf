using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Web.UI.WebControls;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace ImagetoPdf
{
    public partial class Form1 : Form
    {
        float opacityVal = 0.3f;
        List<string> files = new List<string>();
        private string watermarkImagePath = null; 
        bool logoNeeded = false;
        bool opacityVal_message_shown = false;

        public Form1()
        {
            InitializeComponent();
            //watermarkImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "TempleLogo.png");
        }

        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                   files.Add(file);
                   
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            using (PdfSharp.Pdf.PdfDocument pdfDocument = new PdfSharp.Pdf.PdfDocument())
            {
                if (!files.Any())
                {
                    MessageBox.Show("Images not found. Please Select Images to convert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (string imageFile in files)
                    {
                        PdfPage page = pdfDocument.AddPage();
                        using (XGraphics gfx = XGraphics.FromPdfPage(page))
                        {
                            using (XImage img = XImage.FromFile(imageFile))
                            {
                                page.Width = img.PixelWidth * 72 / img.HorizontalResolution;
                                page.Height = img.PixelHeight * 72 / img.VerticalResolution;
                                gfx.DrawImage(img, 0, 0, page.Width, page.Height);

                                if (string.IsNullOrEmpty(watermarkImagePath))
                                {
                                    if (logoNeeded)
                                    {
                                    MessageBox.Show("Watermark image not found. Please check the path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                    }
                                }
                                else
                                {
                                    // Add watermark
                                    DrawWatermark(gfx, page);
                                }
                            }
                        }
                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pdfDocument.Save(saveFileDialog.FileName);
                        MessageBox.Show("PDF created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void DrawWatermark(XGraphics gfx, PdfPage page)
        {
            
            if (opacityVal <= 0f || opacityVal >100)
            {
                MessageBox.Show("Opacity Value not found. Please provide value for Opacity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (Bitmap bitmap = new Bitmap(watermarkImagePath))
                {
                    using (Bitmap semiTransparentBitmap = ApplyOpacity(bitmap, opacityVal)) // 30% opacity
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            semiTransparentBitmap.Save(ms, ImageFormat.Png);
                            ms.Position = 0;
                            using (XImage watermarkImage = XImage.FromStream(ms))
                            {
                                double width = page.Width * 0.1; // Watermark width (30% of page width)
                                double height = watermarkImage.PixelHeight * width / watermarkImage.PixelWidth; // Maintain aspect ratio
                                double x = page.Width - width - 10; // 10 points margin from the right
                                double y = page.Height - height - 10; // 10 points margin from the bottom

                                gfx.DrawImage(watermarkImage, x, y, width, height);
                            }
                        }
                    }

                }
            }
        }

        private Bitmap ApplyOpacity(Bitmap bitmap, float opacity)
        {
            
            Bitmap transparentBitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(transparentBitmap))
            {
                ColorMatrix colorMatrix = new ColorMatrix
                {
                    Matrix33 = opacity // Set the opacity level
                };
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return transparentBitmap;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                ManuallyPanel.Visible = true;
            }
            else
            {
                ManuallyPanel.Visible = false;
            }
        }

        private void logoImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                watermarkImagePath = openFileDialog1.FileName;
            }
        }

        private void opacityValue_TextChanged(object sender, EventArgs e)
        {
            if(opacityValue.Text!="")
                opacityVal = float.Parse(opacityValue.Text)/100;
            else
            {
                opacityVal = 0;
            }
        }

        private void AddLogoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddLogoBox.Checked)
            {
                logoImage.Visible = true;
                OpacityValueLable.Visible = true;
                opacityValue.Visible = true;
                logoNeeded = true;
            }
            else
            {
                logoImage.Visible = false;
                OpacityValueLable.Visible = false;
                opacityValue.Visible = false;
                logoNeeded = false;
            }
        }
    }


}
