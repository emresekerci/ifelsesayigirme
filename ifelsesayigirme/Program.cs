Console.Write("Lütfen bir sayi giriniz: ");
// Kullanıcıdan bir sayi girmesi istenir

int sayi = Convert.ToInt32(Console.ReadLine());
// Kullanıcıdan alınan veri string türünde olduğundan, bunu int türüne dönüştür

// Sayı 10 veya daha büyükse
if (sayi >= 10)
{

    Console.WriteLine("Girilen sayi 10'dan büyüktür.");

}

// Sayı 10'a eşitse
else if (sayi == 10)
{
    Console.WriteLine("Girilen sayi 10 ile eşittir.");

}

// Sayı 10'dan küçükse
else
{
    Console.WriteLine("Girilen sayi 10'dan küçüktür.");

}

// Girilen sayının çift mi yoksa tek mi olduğunu kontrol et
// % (mod) operatörünü kullanarak sayının 2 ile bölümünden kalanı kontrol edilir
// sayi % 2 == 0  ifadesi sayının çift olup olmadığını kontrol eder. Eğer 2 ile bölümünden kalan 0 ise sayı çifttir.
if (sayi % 2 == 0)
{
    Console.WriteLine("Girilen sayi çifttir.");

}
else
{
    Console.WriteLine("Girilen sayi tektir.");
}