using System;

public class RefOutExample
{
    public static void Main()
    {
        int refValue = 5;//başlangıç değeri atanması zorunludur.
        int outValue;//başlangıç değeri atanması zorunlu değildir.

        ChangeMethod(out outValue, ref refValue);

        Console.WriteLine("ChangeMethod'dan sonra refValue : " + refValue); //Output 7
        Console.WriteLine("ChangeMethod'dan sonra outValue: " + outValue); //Output 8
    }

    static void ChangeMethod(out int i, ref int j)
    {
        i = 8; // i argümanına bir değer atamak zorunludur.
        j = j + 2; // j için böyle bir zorunluluk yoktur.
    }
}