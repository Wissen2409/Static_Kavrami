
// Yazılan bir sınıfı kullanmak iki çesittir : 

//1-  Daha önce öğrendiğimiz o sınıftan bir nesne üretmek ve nesne üzerinden sınıfı kullanmak!!!


//2- Hiç nesne üretmeye gerek kalmadan o sınıfı kullanmak!!!

// Static kavramı, 2. yol olarak karşımıza çıkmaktadır!!!

// Static kavramı içerisinde sınıfa ait nesne üretilmez!!!!

// Static kavramı ile ilgili örnek vermek gerkirse,

//Örnek 1 : Math.PI;
//Örnek 2 : int.Parse
//Örnek 3 : ToString()
//Örnek 4 : Console

// Static class neden kullanılmalı ? 
// Çok hızlı bir şekilde erişmek istediğim metotları yada property yada conts ları static yaparım!!!
// Static class'ın hiç bir şekilde nesne örneği alınamaz!! 
//Personel p = new Personel();

// Static class'ların içerisindeki öğelere erişmek için nesne örneği almaya gerek yoktur!!

// Static sınıf içerisindeki öğeye şu şekilde erişilir!!

//Sınıf adı sonrasında erişelecek öğenin adı yazılıp erişebilir.!!!

var liste = Personel.Liste;

Personel.MaasAl();
