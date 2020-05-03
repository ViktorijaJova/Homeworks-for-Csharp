using Hoemwork08e.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hoemwork08e.Data
{
     public class Data
    {
             public  List<Product> products = new List<Product>
{
                new Product("Keyboard", 100, Category.ItEquipment),
                new Product("Mouse", 150, Category.ItEquipment),
                new Product("Headphones", 80, Category.ItEquipment),
                new Product("Microphone", 220, Category.ItEquipment),
                new Product("Camera",  1000, Category.ItEquipment),
                new Product("Hp-580",  20000, Category.LapTop),
                new Product("Lenovo G200",  18500, Category.LapTop),
                new Product("Hp ProBook",  12000, Category.LapTop),
                new Product("Acer S1200",  28000, Category.LapTop),
                new Product("Dell MS300",  74000, Category.LapTop),
                new Product("Office 1",  10200, Category.PC),
                new Product("Office 2",  12400, Category.PC),
                new Product("Gaming",  22000, Category.PC),
                new Product("Ultra Gaming",  32200, Category.PC),
                new Product("Ultra Ultra Gaming",  61600, Category.PC),
                new Product("Alienware",  128000, Category.PC),
                new Product("Samsung Proview",  56200, Category.TV),
                new Product("LG LG420MQ8",  32000, Category.TV),
                new Product("SONY Plasma",  18000, Category.TV),
                new Product("SONY RW78OS",  179999,Category.TV),
                new Product("Samsung Oval", 247999,Category.TV)
};
    }
}
