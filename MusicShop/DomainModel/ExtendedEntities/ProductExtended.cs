using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace MusicShop.DomainModel
{
    partial class Product
    {
        public string ManufacturerName 
        { 
            get
            {
                if (Manufacturer != null)
                {
                    return Manufacturer.Name;
                }
                return "-";
            }
        }

        public string Country 
        {
            get
            {
                if (Manufacturer != null)
                {
                    return Manufacturer.Country;
                }
                return "-";
            }
        }

        public decimal AvgRating  
        { 
            get
            {
                if (Comments.Count == 0)
                {
                    return 0;
                }
                return Math.Round(Comments.Average(c => c.Rating), 1);
            }
        }

        private Image GetImage(byte[] image)
        {
            Image pic;
            using (MemoryStream memoryStream = new MemoryStream(image))
            {
                pic = Image.FromStream(memoryStream);
            }
            return pic;
        }

        public Image LastPicture 
        {
            get
            {
                if (ProductImages.Count == 0)
                {
                    return Properties.Resources.image;
                }
                return GetImage(ProductImages.Last().Image);
            }
        }

        public List<Image> Pictures
        {
            get
            {
                if (ProductImages.Count == 0)
                {
                    return null;
                }
                List<Image> imgs = new List<Image>();
                foreach (var img in ProductImages)
                {
                    imgs.Add(GetImage(img.Image));
                }
                return imgs;
            }
        }
    }
}
