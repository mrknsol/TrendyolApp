using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrendyolApp.Models;

namespace TrendyolApp.Services.Classes
{
    public class AddGoodsService
    {
        public Goods AddProductOrder(string name, string description, string type, int price, byte[] _image)
        {
            Goods products = new Goods()
            {
                Name = name,
                Description = description,
                Price = price,
                ImageData = _image,
                ProductType = type,
            };
            return products;
        }


        public bool ValidateFields(string name, string description, string type, int price, int count)
        {
            string nameRegex = @"^[a-zA-Z0-9\s]+$";
            string descriptionRegex = @"^[a-zA-Z0-9\s\.,!?]+$";
            string typeRegex = @"^[a-zA-Z\s]+$";


            if (!Regex.IsMatch(name, nameRegex))
                return false;

            if (!Regex.IsMatch(description, descriptionRegex))
                return false;

            if (!Regex.IsMatch(type, typeRegex))
                return false;

            if (price <= 0)
                return false;

            if (count <= 0)
                return false;

            return true;
        }
    }
}



