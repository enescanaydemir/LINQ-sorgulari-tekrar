/*
Collections: C# içerisinde dizi benzeri bir veri yapısını ifade eder. Bir kaç türü vardır.

1) IEnumerable: En temel collection yapılarından biridir. Ve şu özelliklere sahiptir:
    * Iteration sağlar(döngü kullanabilme)
    * Verilerin sadece OKUNMASI GEREKEN durumlarda tercih edilir.
    * Bu durumda ekleme silme gibi operasyonlara izin vermez. Veriler üzerinde değişiklik/oynama yapılamaz.
    * Özellikle for each döngü ile kullanmaya oldukça uygundur.
    * Verileri belleğe almadan işlem yapar. Bu nedenle bellek kullanımı konusunda daha avantajlıdır.
*/

// List<string> names = new List<string>{"Ali", "Veli", "Murat", "Sezen"};
// IEnumerable<string> enumerableNames = names;
// foreach (var name in enumerableNames)
// {
//     Console.WriteLine(name);
// }


/*
2) ICollection: IEnumerable'dan türetilmiştir. Ek olarak şu özelliklere sahiptir:
    * Veri ekleme ve silme operasyonlarını destekler.
    * Eleman sayısını öğrenme imkanı sağlar.
    * Veri üzerinde iteration yaparken manipülasyon(ekleme, silme gibi) yapma ihtiyacı olan durumlarda tercih edilir.
    * Verileri belleğe almadan işlem yapar. Bu nedenle bellek kullanımı konusunda daha avantajlıdır.
*/

// ICollection<string> names = new List<string> { "Ali", "Veli", "Murat", "Sezen" };
// System.Console.WriteLine(names.Count);

/*
3) IList: ICollection'dan türetilmiştir. Ek olarak sahip olduğu özellikler şunlardır:
    * Indeksleme imkanı sunar. Bu sayede collection elemanlarına bir index numarası ile erişilebilir. ([])
    * Sıralı veri yapılarında tercih edilebilir.
    Döngü kurmana (iteraction) ihtiyacın varsa, aynı zamanda ICollection'ın verdiği ekleme silme gibi işlemlere ihtiyacın varsa, aynı zamanda Indexerlara erişmek istiyorsan IList kullanılır.
*/

// IList<string> names = new List<string> { "Ali", "Veli", "Murat", "Sezen" };
// System.Console.WriteLine(names[0]);

/*
4)  IQuerable: Bu collection yapısı biraz daha özel amaçlara hizmet eder:
    * Daha çok veri tabanı sorguları oluşturmak için tercih edilir.
    * Sorguyu, veritabanına göndermeden önce optimize eder.
    * Büyük veri setlerinde çok ciddi bir performans sağlar.
    * Filtreleme operasyonlarını direkt olarak veri tabanı üzerinde yaparak, hız kazandırır.
*/

//IEnumerable ve IQueryable sıkça kullanılır. 
//farkları IEnumerable verileri genellikle bellekte yani belleğe aldıktan sonra işlem yaparken IQueryable veritabanı üzerinde işlem yapar. 

//NOT: IEnumerable, ICollection, IList ve IQueryable interface'lerinin hepsi IEnumerable interface'inden türetilmiştir. Bu nedenle hepsi de IEnumerable interface'ini implemente ederler. 
//implemente ne demek? Bir interface'i implemente etmek, o interface'in içerdiği metotları ve property'leri kullanılabilir hale getirmek demektir.