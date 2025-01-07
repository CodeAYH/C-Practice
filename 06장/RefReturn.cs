using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06장;

class Product
{
    private int price = 100;
    public ref int GetPrice()
    {
        return ref price;
    }

    public void PrintPrice()
    {
        Console.WriteLine(price);
    }
}

internal class RefReturn
{
    static void MaiRefRetrurn()
    {
        Product carrot = new Product();
        ref int refLocal = ref carrot.GetPrice();
        int normalLocal = carrot.GetPrice();

        carrot.PrintPrice();
        Console.WriteLine(refLocal);
        Console.WriteLine(normalLocal);

        refLocal = 200;
        carrot.PrintPrice();
        Console.WriteLine(refLocal);
        Console.WriteLine(normalLocal);
    }
}
