using System.Collections;
using System.Security.Cryptography;

public static class Personel{


    // Static bir class'ın içerisinde static olmayan bir üye bulunmamalıdır!!!

    // Static bir sınıfın içerisinde , static olmayan bir elemanın olması durumda derleyici hata verecektir
    // bunun sebebi, static olmayan bir öğeye erişmek için, nesne örneği alınması gerekmektedir!!

    // Static sınıflarda ise nesne örneği alınmaz!' bu sebeoten ötürü, static bir sınıf içerisinde static olmauan bir 
    // öğe barınamaz!!!
    public static ArrayList Liste { get; set; }
    public static void MaasAl(){

        Console.WriteLine("Static sınıf içerisindeki static metot çalıştı1!!");
    }

}