using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Lists
{
    class Product
    {
        public string Symbol { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public Size? Size { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

        public Manufacture Manufacture { get; set; }


        public string FullName
        {
            get
            {
                // Tworzenie zaawansowanych tekstów
                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"Name: {Name}");

                if (Size.HasValue)
                    builder.AppendLine($"Size: {Size}");

                builder.AppendLine($"Gender: {Gender}");
                builder.AppendLine($"Price: {Price:C2}");
                builder.AppendLine($"Color: {Color}");
                builder.AppendLine($"Manufacture: {Manufacture.Name}");

                string result = builder.ToString();

                return result;


                //if (Size.HasValue)
                //{
                //    return $"Name: {Name} \n Size: {Size} \n Gender: {Gender} \n Price: {Price:C2} \n Manufacture: {Manufacture.Name}";
                //}
                //else
                //{
                //    return $"Name: {Name} \n Gender: {Gender} \n Price: {Price:C2} \n Manufacture: {Manufacture.Name}";
                //}
            }
        }


    }

    enum Gender
    {
        Woman,

        Man,

        Unisex
    }


    enum Size
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
    }
}
