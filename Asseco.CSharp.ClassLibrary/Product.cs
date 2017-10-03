using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.CSharp.Models
{
    class Shirt : Product
    {
        public byte? Collar { get; set; }
    }

    class Dress : Product
    {
        
    }

    class WeddingDress : Dress
    {
        public int Length { get; set; }
    }
    

    abstract class Product
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public Size? Size { get; set; }     //pole nie jest obowiązkowe 
        public string Color { get; set; }
        public Gender Gender { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } 
        public Manufacture Manufacture { get; set; }

        public string FullName
        {
            get
            {
                //string fullName = $"Produkt: {Symbol}, {Name}";

                //if (Size.HasValue) fullName += $", {Size}";

                //fullName += $", { Color}, { Gender}, { Price:C2}, { Manufacture.FullName}";

                //if (!IsDeleted)
                //    fullName += " jest w sprzedaży";
                //else
                //    fullName += " jest wycofany ze sprzedaży";

                //return fullName;

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"Symbol: {Symbol}");
                stringBuilder.AppendLine($"   Nazwa: {Name}");
                if (Size.HasValue) stringBuilder.AppendLine($"   Rozmiar: {Size}");
                stringBuilder.AppendLine($"   Kolor: {Color}");
                stringBuilder.AppendLine($"   Płeć: {Gender}");
                stringBuilder.AppendLine($"   Cena: {Price:C2}");
                stringBuilder.AppendLine($"   Producent: {Manufacture.FullName}");

                if (!IsDeleted)
                    stringBuilder.AppendLine("  Dostępny");
                else
                    stringBuilder.AppendLine("  Niedostępny");

                return stringBuilder.ToString();
            }          
        }

        public void Send()
        {
            Console.WriteLine("Wyslij pocztą...");
            Console.WriteLine("");

        }
    }

    enum Gender
    {
        Woman,
        Man,
        Unisex
    };

    enum Size
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL
    };
}
