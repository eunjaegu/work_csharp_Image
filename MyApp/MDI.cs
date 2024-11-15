using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyApp
{
    public partial class MDI : Form
    {

        private Form brightnessForm;
        private Bitmap loadedImage;
        public MDI()
        {
            InitializeComponent();
        }

        // 파일 열기 메뉴 클릭 시
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "이미지 파일 (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|모든 파일 (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    // PictureBox에 이미지 표시
                    loadedImage = new Bitmap(fileName); // loadedImage에 이미지 할당
                    pictureBox1.Image = loadedImage;

                    // 이미지 크기 자동조절
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지를 열 수 없습니다: {ex.Message}");
                }

            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveFileDialog.Filter = "이미지 파일 (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|모든 파일 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    // PictureBox에서 이미지를 가져와 저장
                    if (pictureBox1.Image != null)
                    {
                        // 파일 확장자에 맞게 이미지 저장
                        string extension = Path.GetExtension(fileName).ToLower();
                        if (extension == ".jpg" || extension == ".jpeg")
                        {
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else if (extension == ".png")
                        {
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else if (extension == ".bmp")
                        {
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                        else if (extension == ".gif")
                        {
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        }
                        else
                        {
                            // 다른 파일 형식 지원 (기본적으로 PNG로 저장)
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                    else
                    {
                        MessageBox.Show("저장할 이미지가 없습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지 저장 오류: {ex.Message}");
                }
            }
        }

        // 밝기조정 메뉴 클릭 후 폼 생성
        private void BrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //brightnessForm = new BrightnessForm();

            //brightnessForm.Show();

            if (loadedImage == null)
            {
                MessageBox.Show("먼저 이미지를 불러와 주세요.");
                return;
            }

            // 밝기 조정 폼 열기
            using (BrightnessForm brightnessForm = new BrightnessForm())
            {
                brightnessForm.OriginalImage = new Bitmap(loadedImage); // 불러온 이미지 전달

                // 폼이 제대로 표시되도록 ShowDialog 호출
                if (brightnessForm.ShowDialog(this) == DialogResult.OK)
                {
                    // 조정된 이미지가 반환되면 PictureBox와 loadedImage에 반영
                    if (brightnessForm.AdjustedImage != null)
                    {
                        loadedImage = brightnessForm.AdjustedImage;
                        pictureBox1.Image = loadedImage;
                    }
                }
            }

        }

        //흑백전환 (기능구현안됨)
        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null)
            {
                MessageBox.Show("먼저 이미지를 불러와 주세요.");
                return;
            }

            // 이미지를 그레이스케일로 변환하고 pictureBox에 표시
            Bitmap grayscaleImage = ConvertToGrayscale(loadedImage);

            // 이미지를 pictureBox에 설정
            pictureBox1.Image = grayscaleImage;

            // 화면을 강제로 갱신
            pictureBox1.Refresh();

            // 변환된 이미지를 loadedImage에 반영
            loadedImage = grayscaleImage;
        }

        // 흑백전환 기능
        private Bitmap ConvertToGrayscale(Bitmap originalImage)
        {
            // 그레이스케일 이미지를 담을 새로운 Bitmap 생성
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    // 원본 이미지에서 픽셀의 색상 가져오기
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // 그레이스케일 값 계산 (0.3 * R + 0.59 * G + 0.11 * B)
                    int grayValue = (int)(0.3 * pixelColor.R + 0.59 * pixelColor.G + 0.11 * pixelColor.B);

                    // 그레이스케일 값으로 새로운 색상 생성
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    // 변환된 색상으로 새로운 이미지에 픽셀 설정
                    grayscaleImage.SetPixel(x, y, grayColor);
                }
            }

            return grayscaleImage;
        }

        // 반전이미지
        private void invertColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null)
            {
                MessageBox.Show("먼저 이미지를 불러와 주세요.");
                return;
            }

            // 이미지를 반전시키고 pictureBox에 표시
            Bitmap invertedImage = InvertColors(loadedImage);

            // 이미지를 pictureBox에 설정
            pictureBox1.Image = invertedImage;

            // 화면을 강제로 갱신
            pictureBox1.Refresh();

            // 변환된 이미지를 loadedImage에 반영
            loadedImage = invertedImage;
        }

        // 반전이미지 기능
        private Bitmap InvertColors(Bitmap originalImage)
        {
            // 반전된 이미지를 담을 새로운 Bitmap 생성
            Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    // 원본 이미지에서 픽셀의 색상 가져오기
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // 색상 반전 (255 - 각 색상 값)
                    int invertedR = 255 - pixelColor.R;
                    int invertedG = 255 - pixelColor.G;
                    int invertedB = 255 - pixelColor.B;

                    // 반전된 색상으로 새로운 색상 생성
                    Color invertedColor = Color.FromArgb(invertedR, invertedG, invertedB);

                    // 반전된 색상으로 새로운 이미지에 픽셀 설정
                    invertedImage.SetPixel(x, y, invertedColor);
                }
            }

            return invertedImage;

        }

        // 부분 반전 이미지 범위 설정 (기능구현안됨)
        private Rectangle specifiedArea = new Rectangle(50, 50, 407, 800);

        // 부분 반전 이미지 기능(기능구현안됨)
        private void invertSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedImage == null)
            {
                MessageBox.Show("먼저 이미지를 불러와 주세요.");
                return;
            }

            // 지정된 영역을 반전
            int startX = Math.Max(specifiedArea.X, 0);
            int startY = Math.Max(specifiedArea.Y, 0);
            int endX = Math.Min(specifiedArea.X + specifiedArea.Width, loadedImage.Width);
            int endY = Math.Min(specifiedArea.Y + specifiedArea.Height, loadedImage.Height);

            // 영역 내 픽셀 반전
            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    Color pixelColor = loadedImage.GetPixel(x, y);

                    // 반전된 색상 계산
                    int invertedR = 255 - pixelColor.R;
                    int invertedG = 255 - pixelColor.G;
                    int invertedB = 255 - pixelColor.B;

                    // 반전된 색상으로 픽셀 설정
                    loadedImage.SetPixel(x, y, Color.FromArgb(invertedR, invertedG, invertedB));
                }
            }

            // 변경된 이미지를 pictureBox에 설정
            pictureBox1.Image = loadedImage;
        }


    }



 }

    

