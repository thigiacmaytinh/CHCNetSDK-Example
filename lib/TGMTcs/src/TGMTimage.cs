//CÔNG TY TNHH GIẢI PHÁP THỊ GIÁC MÁY TÍNH
//support@viscomsolution.com
//0939.825.125

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace TGMTcs
{
    public class TGMTimage
    {

        public static Bitmap CorrectOrientation(Bitmap bmp)
        {
            if (bmp == null)
                return null;

            if (Array.IndexOf(bmp.PropertyIdList, 274) > -1)
            {
                var orientation = (int)bmp.GetPropertyItem(274).Value[0];
                switch (orientation)
                {
                    case 1:
                        // No rotation required.
                        break;
                    case 2:
                        bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        break;
                    case 3:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 4:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                        break;
                    case 5:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
                        break;
                    case 6:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 7:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipX);
                        break;
                    case 8:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
                // This EXIF data is now invalid and should be removed.
                bmp.RemovePropertyItem(274);
            }
            return bmp;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string ImageToBase64(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] filebytes = new byte[fs.Length];
            fs.Read(filebytes, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return "data:image/png;base64," + Convert.ToBase64String(filebytes, Base64FormattingOptions.None);

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image Base64ToImage(string base64String)
        {
            // Preprocess base 64 string
            base64String = base64String.Replace("%2F", "/");
            base64String = base64String.Replace("%2B", "+");
            base64String = base64String.Replace("%3D", "=");
            base64String = base64String.TrimEnd('\r', '\n');
            base64String = base64String.Replace("\r", "").Replace("\n", "");
            base64String = base64String.PadRight(base64String.Length + (4 - base64String.Length % 4) % 4, '='); 

            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                using (Image img = Image.FromStream(ms, true))
                {
                    Bitmap bmp = new Bitmap(img.Width, img.Height, PixelFormat.Format24bppRgb);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(img, 0, 0, img.Width, img.Height);
                    }

                    return bmp;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static ImageCodecInfo GetJpegCodec()
        {
            foreach (ImageCodecInfo c in ImageCodecInfo.GetImageEncoders())
            {
                if (c.CodecName.ToLower().Contains("jpeg")
                    || c.FilenameExtension.ToLower().Contains("*.jpg")
                    || c.FormatDescription.ToLower().Contains("jpeg")
                    || c.MimeType.ToLower().Contains("image/jpeg"))
                    return c;
            }

            return null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsImage(string fileName)
        {
            string ext = Path.GetExtension(fileName).ToLower();
            return (ext == ".jpg" || ext == ".png" || ext == ".bmp");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsBase64(string base64String)
        {
            // Credit: oybek https://stackoverflow.com/users/794764/oybek
            if (base64String == null || base64String.Length == 0 || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            return true;
        }

        //public static Bitmap ResizeBitmap(Image image, int width, int height)
        //{
        //    var destRect = new Rectangle(0, 0, width, height);
        //    var destImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);

        //    destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        //    using (var graphics = Graphics.FromImage(destImage))
        //    {
        //        graphics.CompositingMode = CompositingMode.SourceCopy;
        //        graphics.CompositingQuality = CompositingQuality.HighQuality;
        //        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphics.SmoothingMode = SmoothingMode.HighQuality;
        //        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        //        using (var wrapMode = new ImageAttributes())
        //        {
        //            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
        //            graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
        //        }
        //    }

        //    return destImage;
        //}

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ResizeBitmap(Image image, int width, int height)
        {
            if(width == 0 || height == 0)
                return null;
            var dest = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            using (var g = Graphics.FromImage(dest))
            {
                g.InterpolationMode = InterpolationMode.Low;
                g.DrawImage(image, 0, 0, width, height);
            }

            return dest;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ResizeBitmapByWidth(Image image, int width)
        {
            float ratio = (float)image.Width / (float)image.Height;
            int height = (int)((float)width / ratio);

            return ResizeBitmap(image, width, height);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ResizeBitmapByHeight(Image image, int height)
        {
            float ratio = (float)image.Width / (float)image.Height;
            int width = (int)((float)height * ratio);

            return ResizeBitmap(image, width, height);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image ResizeImageByWidth(Image image, int width)
        {
            float ratio = (float)image.Width / (float)image.Height;
            int height = (int)((float)width / ratio);

            return ResizeBitmap(image, width, height);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image ResizeImageByHeight(Image image, int height)
        {
            float ratio = (float)image.Width / (float)image.Height;
            int width = (int)((float)height * ratio);

            return ResizeBitmap(image, width, height);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ExpandBitmap(Bitmap original, int padding, Color fillColor)
        {
            return ExpandBitmap(original, padding, padding, padding, padding, fillColor);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ExpandBitmap(Bitmap original, int paddingLeft, int paddingTop, int paddingRight, int paddingBottom, Color fillColor)
        {
            int newWidth = original.Width + paddingLeft + paddingRight;
            int newHeight = original.Height + paddingTop + paddingBottom;

            // Create new bitmap with expanded size
            Bitmap expanded = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(expanded))
            {
                // Fill entire new image with fill color
                using (Brush brush = new SolidBrush(fillColor))
                {
                    g.FillRectangle(brush, 0, 0, newWidth, newHeight);
                }

                // Draw original image onto the new one at the correct offset
                g.DrawImage(original, paddingLeft, paddingTop);
            }

            return expanded;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap EnlargeSharpenBitmap(Bitmap image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            using(Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                g.DrawImage(image, 0, 0, width, height);
            }

            return result;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap CropBitmap(Bitmap bmp, Rectangle rect)
        {
            if (bmp == null)
                return null;

            if (rect.Width <= 0 || rect.Height <= 0)
                return bmp;

            if (rect.X + rect.Width > bmp.Width || rect.Y + rect.Height > bmp.Height)
                return bmp;

            Bitmap target = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(bmp, new Rectangle(0, 0, target.Width, target.Height),
                                 rect,
                                 GraphicsUnit.Pixel);                
            }

            return target;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static Image CaptureScreen(Rectangle roi)
        {
            if (roi.Width == 0 || roi.Height == 0)
                return null;

            Bitmap target = new Bitmap(roi.Width, roi.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.CopyFromScreen(roi.X, roi.Y, 0, 0, new Size(roi.Width, roi.Height));
            }
            return target;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap LoadBitmapWithoutLock(string imagePath)
        {
            if (!File.Exists(imagePath))
                return null;
            string ext = Path.GetExtension(imagePath).ToLower();
            if(ext == ".jpg" || ext == ".png" || ext == ".bmp")
            {
                var bytes = File.ReadAllBytes(imagePath);
                if(bytes == null || bytes.Length == 0)
                    return null;
                var ms = new MemoryStream(bytes);
                var img = Image.FromStream(ms, true);
                return (Bitmap)img;
            }
            return null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static byte[] ImageToBytes(Image image, ImageFormat imageFormat)
        {
            byte[] imageBytes;
            try
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    image.Save(ms, imageFormat);
                    imageBytes = ms.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return imageBytes;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image BytesToImage(byte[] imageBytes)
        {
            Image image;
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                throw;
            }
            return image;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int GetNumChannels(Bitmap bitmap)
        {
            int numChannels = 0;

            switch (bitmap.PixelFormat)
            {
                case PixelFormat.Format24bppRgb:
                    numChannels = 3; // RGB
                    break;
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppPArgb:
                    numChannels = 4; // RGBA
                    break;
                case PixelFormat.Format8bppIndexed:
                    numChannels = 1; // Grayscale or indexed
                    break;
                // Add other cases if needed
                default:
                    numChannels = 0; // Unknown or unsupported format
                    break;
            }

            return numChannels;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ConvertRGBA2RGB(Bitmap bitmap)
        {
            // Create a new Bitmap with 24bppRgb format (3 channels)
            Bitmap rgbBitmap = new Bitmap(bitmap.Width, bitmap.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Iterate through each pixel
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    // Get the pixel from the original bitmap
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Create a new color without the alpha channel (RGB only)
                    Color rgbColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);

                    // Set the pixel in the new bitmap
                    rgbBitmap.SetPixel(x, y, rgbColor);
                }
            }

            return rgbBitmap;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap CropToPolygon(Bitmap source, List<Point> polygon)
        {
            Rectangle boundingRect = GetPolygonBoundingBox(polygon);
            if(boundingRect.Width == 0 || boundingRect.Height == 0)
            {
                return source;
            }
            if(boundingRect.X < 0 || boundingRect.Y < 0 || boundingRect.X + boundingRect.Width > source.Width || boundingRect.Y + boundingRect.Height > source.Height)
            {
                return source;
            }

            // Create a new empty bitmap with the same size as the source
            Bitmap croppedBitmap = new Bitmap(source.Width, source.Height);

            // Create a GraphicsPath from the polygon points
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(polygon.ToArray());

                // Create a Region from the path
                using (Region region = new Region(path))
                {
                    // Create the Graphics object for the new bitmap
                    using (Graphics g = Graphics.FromImage(croppedBitmap))
                    {
                        // Clear the new bitmap with transparent background
                        g.Clear(Color.Transparent);

                        // Set the clipping region to the polygon
                        g.SetClip(region, CombineMode.Replace);

                        // Draw the source image onto the new bitmap using the clipping region
                        g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height));
                    }
                }
            }

            // Crop the resulting bitmap to the bounding rectangle of the polygon
            
            Bitmap finalCroppedBitmap = croppedBitmap.Clone(boundingRect, PixelFormat.Format24bppRgb);

            return finalCroppedBitmap;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static Rectangle GetPolygonBoundingBox(List<Point> polygon)
        {
            int minX = int.MaxValue;
            int minY = int.MaxValue;
            int maxX = int.MinValue;
            int maxY = int.MinValue;

            foreach (var point in polygon)
            {
                if (point.X < minX) minX = point.X;
                if (point.Y < minY) minY = point.Y;
                if (point.X > maxX) maxX = point.X;
                if (point.Y > maxY) maxY = point.Y;
            }

            return new Rectangle(minX, minY, maxX - minX, maxY - minY);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// Require call this function to clone bitmap

        public static Bitmap CloneBitmap(Bitmap source)
        {
            if (source == null)
                return null;

            // Create a deep copy of the bitmap
            Bitmap bmp24 = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(bmp24))
            {
                g.DrawImage(source, new Rectangle(0, 0, bmp24.Width, bmp24.Height));
            }

            return bmp24;
        }

        public static Bitmap FastClone(Bitmap src)
        {
            if(src == null)            
                return null;
            
            // 1. Đảm bảo source là 24bpp và KHÔNG thay đổi src gốc
            Bitmap src24 = src;

            if (src.PixelFormat != PixelFormat.Format24bppRgb)
            {
                src24 = new Bitmap(src.Width, src.Height, PixelFormat.Format24bppRgb);
                using (Graphics g = Graphics.FromImage(src24))
                {
                    g.DrawImage(src, 0, 0, src.Width, src.Height);
                }
            }

            // 2. Tạo bitmap clone hoàn toàn mới
            Bitmap clone = new Bitmap(src24.Width, src24.Height, PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, src24.Width, src24.Height);

            BitmapData srcData = null;
            BitmapData dstData = null;

            try
            {
                srcData = src24.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                dstData = clone.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

                int bytesPerRow = src24.Width * 3;

                unsafe
                {
                    byte* srcPtr = (byte*)srcData.Scan0;
                    byte* dstPtr = (byte*)dstData.Scan0;

                    for (int y = 0; y < src24.Height; y++)
                    {
                        Buffer.MemoryCopy(
                            srcPtr + y * srcData.Stride,
                            dstPtr + y * dstData.Stride,
                            bytesPerRow,
                            bytesPerRow
                        );
                    }
                }
            }
            finally
            {
                if (srcData != null) src24.UnlockBits(srcData);
                if (dstData != null) clone.UnlockBits(dstData);

                // 3. Dispose bitmap trung gian nếu có
                if (!ReferenceEquals(src24, src))
                    src24.Dispose();
            }

            return clone;
        }
    }
}
