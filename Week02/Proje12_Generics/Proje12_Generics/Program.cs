/*
Generic yapılar, özellikle tip güvenliği sağlama konusunda işimizi görürler. Fakat aynı zamanda kodun YENİDEN KULLANILABİLİRLİĞİNİ arttırır.
DRY-Don't Repeat Yourself( Kendini Tekrar Etme)
*/

// Dictionary<TKey, TValue>
// Dictionary, bir anahtar-değer koleksiyonudur. Anahtar ve değerlerin türleri belirtilir.

Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("Ali", 25);
ages.Add("Veli", 30);
ages.Add("Can", 35);

// foreach (var item in ages)
// {
//     System.Console.WriteLine($"{item.Key} : {item.Value}");
// }

// if (ages.ContainsKey("Ali"))
// {
//     System.Console.WriteLine(ages["Ali"]);
// }

ages.Remove("Can");

foreach (var item in ages)
{
    System.Console.WriteLine($"{item.Key} : {item.Value}");
}

// Box<int> numberBox = new Box<int>();
// numberBox.Add(5);
// System.Console.WriteLine(numberBox.Get());

// Box<string> stringBox = new Box<string>();
// stringBox.Add("Hello World");
// System.Console.WriteLine(stringBox.Get());


class Box<T>
{
    private T content;
    public void Add(T item)
    {
        content = item;
    }
    public T Get()
    {
        return content;
    }
}
//TEntity nedir? TEntity, Generic yapılar için kullanılan bir isimlendirme standardıdır. 