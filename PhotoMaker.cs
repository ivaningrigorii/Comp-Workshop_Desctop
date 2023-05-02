using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace course_project
{
    static class PhotoMaker
    {
        const int sizePhoto = 141;
        private static string photoFromFile()
        {
            string path = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            return path;
        }

        public static byte[] getPhoto()
        {
            byte[] res = null;
            Image image;
           

            try
            {
                string path = photoFromFile();

                image = new Bitmap(Image.FromFile(path), sizePhoto, sizePhoto);
                
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                res = memoryStream.ToArray();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            return res;
        }

        public static Image toImageFromByte(byte[] photo)
        {
            Image image;
            MemoryStream memoryStream = new MemoryStream();

            foreach (byte byte_ in photo)
            {
                memoryStream.WriteByte(byte_);
            }

            image = Image.FromStream(memoryStream);

            return image;
        }

    }
}
