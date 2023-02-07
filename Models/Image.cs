using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Models
{
    public class Image
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ImageFormat { get; set; }
        public byte[] ImageData { get; set; }

        public Image(int width, int height, string imageFormat, byte[] imageData)
        {
            Width = width;
            Height = height;
            ImageFormat = imageFormat;
            ImageData = imageData;
        }

        public void SaveImage(string filePath)
        {
            // Code pour enregistrer l'image sur le disque
        }

        public void ResizeImage(int newWidth, int newHeight)
        {
            // Code pour redimensionner l'image
        }
    }
    
}
