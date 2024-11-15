using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp
{
    public partial class BrightnessForm : Form
    {
        public int BrightnessValue { get; private set; } = 0;
        public Bitmap OriginalImage { get; set; }
        public Bitmap AdjustedImage { get; private set; }
        private PictureBox pictureBox1;

        public BrightnessForm()
        {
            InitializeComponent();
        }

        private void BrightnessForm_Load(object sender, EventArgs e)
        {
            try
            {
                // OriginalImage가 null인지 확인
                if (OriginalImage == null)
                {
                    throw new InvalidOperationException("이미지가 설정되지 않았습니다.");
                }

                // pictureBox1이 null일 경우, 수동으로 초기화
                if (pictureBox1 == null)
                {
                    pictureBox1 = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                }

                // OriginalImage가 null이 아닌 경우 이미지를 설정
                pictureBox1.Image = new Bitmap(OriginalImage);
            }
            catch (InvalidOperationException ex)
            {
                // InvalidOperationException 발생 시 메시지 표시
                MessageBox.Show(ex.Message);
                Close();
            }
            catch (Exception ex)
            {
                // 그 외 예외 처리
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
                Close();
            }

        }

        private void BrightnessUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (OriginalImage != null && pictureBox1 != null)
            {
                BrightnessValue = (int)BrightnessUpDown.Value;
                AdjustedImage = AdjustBrightness(OriginalImage, BrightnessValue);
                pictureBox1.Image = AdjustedImage;
            }
        }

        private Bitmap AdjustBrightness(Bitmap image, int value)
        {
            if (image == null)
                return null;

            Bitmap temp = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int r = Clamp(pixel.R + value, 0, 255);
                    int g = Clamp(pixel.G + value, 0, 255);
                    int b = Clamp(pixel.B + value, 0, 255);
                    temp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return temp;

        }

        private int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            BrightnessUpDown.Value = 0;
            Close();
        }

        
    }
}
