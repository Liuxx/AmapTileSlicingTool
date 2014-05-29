using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace AmapTileSlicing
{
    public partial class Main : Form
    {
        private string fileExt = string.Empty;
        private string savePath = string.Empty;
        private Dictionary<int, List<Image>> images = new Dictionary<int, List<Image>>();
        int slicingHeight = 256, slicingWidth = 256;
        
        public Main()
        {
            InitializeComponent();
        }

        private List<Image> Slicing(Image image, int level)
        {
            var pow = Math.Pow(2, 18 - level);
            int zoomPower = (int)Math.Pow(2, 18 - level);

            var leftTile = this.GetX() / pow;
            var topTile = this.GetY() / pow;

            int tileX = (int)Math.Floor(leftTile);
            int destX = (int)((tileX - leftTile) * 256);
          
            List<Image> imgs = new List<Image>();
            int pixelSkip = 256;
            do
            {
                int tileY = (int)Math.Floor(topTile);
                int destY = (int)((Math.Floor(topTile) - topTile) * 256);
                do {
                    imgs.Add(CreateTile(image, pixelSkip, level, destX, destY, tileX, tileY));
                    tileY++;
                    destY += pixelSkip;
                }
                while (image.Height > destY);
                destX += pixelSkip;
                tileX++;
            }
            while (image.Width > destX);

            return imgs;
        }
        /// <summary>
        /// 创建瓦片图
        /// </summary>
        /// <param name="fimage">源图</param>
        /// <param name="pixelSkip">从源图获取图像的范围</param>
        /// <param name="x">源图横向(x)起始坐标</param>
        /// <param name="y">源图纵向(y)起始坐标</param> 
        /// <param name="tileX">瓦片图的x坐标</param>
        /// <param name="tileY">瓦片图的y坐标</param>
        private  Image CreateTile(Image fimage, int pixelSkip,int level ,int x, int y, int tileX, int tileY)
        {
            // 目标区域
            Rectangle destRect = new Rectangle(0, 0, 256, 256);
            // 源图区域
            Rectangle srcRect = new Rectangle(x, y, pixelSkip, pixelSkip);
            // 新建Graphics对象
            Bitmap newImage = new Bitmap(256, 256);
            Graphics g = Graphics.FromImage(newImage);
            // 绘图平滑程序
            g.SmoothingMode = SmoothingMode.HighQuality;
            // 图片输出质量
            g.CompositingQuality = CompositingQuality.HighQuality;

            // 输出到newImage对象

            g.DrawImage(fimage, destRect, srcRect, GraphicsUnit.Pixel);
            // 释放绘图对象
            g.Dispose();

          
            string path = Path.Combine(this.savePath, level.ToString());
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            
            path = Path.Combine(path, string.Format("x{0}y{1}{2}", tileX, tileY, ".png"));
            
            newImage.Save(path, ImageFormat.Png);
            FileInfo fi = new FileInfo(path);
            if (fi.Length <= 1276)
                fi.Delete();
            return newImage;
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Title = "选择图片";
            open.Filter = "所有文件|*.*|图片文件|*.bmp;*.jpg;*.png;*.jpeg;*.gif|JPEG文件|*.jpg;*.jpeg|PNG文件|*.png|BMP文件|*.bmp|GIF文件|*.gif";
            if (open.ShowDialog() == DialogResult.Cancel) return;
            FileInfo file = new FileInfo(open.FileName);
            this.savePath = Path.Combine(file.DirectoryName, file.Extension.Length == 0 ? "dir" + file.Name : file.Name.Replace(file.Extension, ""));
            this.fileExt = file.Extension;
            Image img = Image.FromFile(open.FileName, true);
            this.pb1.Image = img;
            this.tsslPicPath.Text = open.FileName;
            if (!Directory.Exists(this.savePath)) Directory.CreateDirectory(this.savePath);
        }

        private void btnSlicingPic_Click(object sender, EventArgs e)
        {
            //var save = new FolderBrowserDialog();
            //if (save.ShowDialog() == DialogResult.Cancel) this.Close();
            //this.savePath = save.SelectedPath;
            if (Directory.Exists(this.savePath)) Directory.Delete(this.savePath, true);
            Directory.CreateDirectory(this.savePath);
            images.Clear();

            var minLevel = this.GetMinLevel();
            var maxLevel = this.GetMaxLevel();

            Bitmap image = new Bitmap(this.pb1.Image);

            for (int level = maxLevel; minLevel <= level; level--)
            {
                var v = Math.Pow(2, 18 - level);
                var height = image.Height / v;
                var width = image.Width / v;
                if (height < 1 || width < 1)
                {
                    MessageBox.Show(string.Format("缩放等级{0}计算失败\n切割终止", level));
                    return;
                }
                Bitmap newImage = new Bitmap(image, (int)width, (int)height);
                images.Add(level, Slicing(newImage, level));
            }
            MessageBox.Show("切割完成");
        }

        private void btnJoinPic_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.savePath)) MessageBox.Show("目录不存在");
            var x = this.GetX();
            var y = this.GetY();
            var minLevel = this.GetMinLevel();
            var maxLevel = this.GetMaxLevel();

            var width = this.pb1.Image.Width;
            var height = this.pb1.Image.Height;
            Bitmap bit = new Bitmap(width, height);
            using (Graphics graph = Graphics.FromImage(bit))
            {
                graph.DrawImage(bit, 0, 0);
                graph.Clear(Color.Empty);

                int iLeft = 0, iTop = 0, hCount = 0, wCount = 0;
                hCount = height % slicingHeight == 0 ? height / slicingHeight : height / slicingHeight + 1;
                wCount = width % slicingWidth == 0 ? width / slicingWidth : width / slicingWidth + 1;
                for (int i = 0; i < hCount; i++)
                {
                    iTop = i * slicingHeight;
                    for (int j = 0; j < wCount; j++)
                    {
                        iLeft = j * slicingWidth;
                        //string path = Path.Combine(this.savePath, "18", string.Format("x{0}y{1}{2}", iLeft + x, iTop + y, this.fileExt));
                        string path = Path.Combine(this.savePath, "18", string.Format("x{0}y{1}{2}", j + x, i + y, this.fileExt));
                        if (!File.Exists(path)) break;
                        using (Image image = Image.FromFile(path))
                        {
                            graph.DrawImage(image, iLeft, iTop);
                        }
                    }
                }
                bit.Save(Path.Combine(this.savePath, string.Format("{0}{1}", Guid.NewGuid().ToString("N"), this.fileExt)));

            }
            this.pb2.Image = bit;
        }

        private string PicType(Image image)
        {
            if (image.RawFormat == ImageFormat.Bmp) return "Bmp";
            if (image.RawFormat == ImageFormat.Emf) return "Emf";
            if (image.RawFormat == ImageFormat.Exif) return "Exif";
            if (image.RawFormat == ImageFormat.Gif) return "Gif";
            if (image.RawFormat == ImageFormat.Icon) return "Icon";
            if (image.RawFormat == ImageFormat.Jpeg) return "Jpeg";
            if (image.RawFormat == ImageFormat.Png) return "Png";
            return "jpg";
        }

        private int GetX()
        {
            int v = 0;
            int.TryParse(this.txtX.Text, out v);
            return v;
        }

        private int GetY()
        {
            int v = 0;
            int.TryParse(this.txtY.Text, out v);
            return v;
        }

        private int GetMinLevel()
        {
            int v = 1;
            int.TryParse(this.txtMinLevel.Text, out v);
            return v;
        }

        private int GetMaxLevel()
        {
            int v = 18;
            int.TryParse(this.txtMaxLevel.Text, out v);
            return v;
        }
    }
}
