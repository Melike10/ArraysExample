/*
 Bu pratikte aşağıdaki 4 aşamayı kodlamanız isteniyor.

1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.

2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.

3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
 */

int[] array = new int[10]; // I defined an int array. its length 10.

Random random = new Random();
// I add random nums in the array
for (int i = 0; i < array.Length; i++)
{
    array[i]=random.Next(1,100);
}

Console.WriteLine("Dizinin elemanları:");
foreach (int i in array)
{
    Console.WriteLine(i);
}

Console.WriteLine("--------------------");


bool deger ;
int newNum;
do
{
    Console.WriteLine("11.sayımızı giriniz:");
    deger = int.TryParse(Console.ReadLine(), out  newNum);

} while (!deger);

// resize array
Array.Resize(ref array, 11);
array[10] =newNum;

//Sort array
Array.Sort(array);
Console.WriteLine("--------------------");
Console.WriteLine("Son eleman eklendikten sonra büyükten küçüğe sıralanmış dizimiz.");
// Printing to the screen in order from largest to smallest
for (int i = array.Length-1; i >= 0; i--)
{
    Console.WriteLine(array[i]);
}





