// -----------------------------------------------------------------  Alıştırmalar -------------------------------------------------------------------------------------

// 1.Uygulama

// while (true)
// {
//     Console.Write("Ortalamasını Bulmak İstediğiniz Değeri Giriniz: ");
//     var result1 = int.Parse(Console.ReadLine());

//     Console.Write("2.Değeri Giriniz: ");
//     var result2 = int.Parse(Console.ReadLine());

//     float ortalama = (result1 + result2) / 2;
//     Console.WriteLine($" Ortalama => {ortalama}");

//     Console.Write("Çıkmak İsterseniz 0 , Devam Etmek İsterseniz Lütfen 1'e basınız. ");
//     var cıkıs = int.Parse(Console.ReadLine());

//     if(cıkıs == 1) {
//         continue;
//     } else {
//         break;
//     }
// }

// 2. Uygulama

// while (true)
// {

//     Console.Write("Asal Olup Olmadığına Bakmak İstediğiniz Değeri Giriniz: ");
//     int result = int.Parse(Console.ReadLine());

//     if(result == 2 || result == 3 || result == 5 ||result == 7) {
//         Console.WriteLine("Girilen Değerdir Asaldır");
//         return;
//     }

//     else if((result % 2 == 0) || (result % 3 == 0) || (result % 5 == 0) || (result % 7 == 0)) {
//         Console.WriteLine("Değeriniz Asaldeğildir. ");
//     } else {
//         Console.WriteLine("Girilen Değer Asal Değildir. ");
//     }
// }

// 3. Uygulama

using System.Globalization;

Console.Write("Şuanki Kilo Değerin Giriniz: ");
int weight = int.Parse(Console.ReadLine());

Console.Write("Şuanki Boy Bilginizi Giriniz(Noktalı Şekilde Giriniz): ");
float length = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(length);

Console.Write("Yaş Bilginizi Giriniz: ");
int age = int.Parse(Console.ReadLine());


var bki_hesaplama = (weight / (length * length));

if(age <= 24 && age >= 19) {
    
    if(bki_hesaplama >= 19 && bki_hesaplama <= 24) {
        Console.WriteLine($"Kilonuz İdeal Durumdadır. BKİ Değeriniz => {bki_hesaplama}");
    } else {
        Console.WriteLine($"BKİ Değeriniz Maalesef İdeal Durumda Değilsiniz => {bki_hesaplama}");
    }

}

if(age <= 34 && age >= 25) {
    
    if(bki_hesaplama >= 20 && bki_hesaplama <= 25) {
        Console.WriteLine($"Kilonuz İdeal Durumdadır. BKİ Değeriniz => {bki_hesaplama}");
    } else {
        Console.WriteLine($"BKİ Değeriniz İdeal Durumda Değilsiniz => {bki_hesaplama}");
    }

}

if(age <= 44 && age >= 35) {
    
    if(bki_hesaplama >= 21 && bki_hesaplama <= 26) {
        Console.WriteLine($"Kilonuz İdeal Durumdadır. BKİ Değeriniz => {bki_hesaplama}");
    } else {
        Console.WriteLine($"BKİ Değeriniz İdeal Durumda Değilsiniz => {bki_hesaplama}");
    }

}
if(age <= 54 && age >= 45) {
    
    if(bki_hesaplama >= 22 && bki_hesaplama <= 27) {
        Console.WriteLine($"Kilonuz İdeal Durumdadır. BKİ Değeriniz => {bki_hesaplama}");
    } else {
        Console.WriteLine($"BKİ Değeriniz İdeal Durumda Değilsiniz => {bki_hesaplama}");
    }

}

if(age <= 65 && age >= 55) {
    
    if(bki_hesaplama >= 23 && bki_hesaplama <= 28) {
        Console.WriteLine($"Kilonuz İdeal Durumdadır. BKİ Değeriniz => {bki_hesaplama}");
    } else {
        Console.WriteLine($"BKİ Değeriniz İdeal Durumda Değilsiniz => {bki_hesaplama}");
    }

}


if(age >= 65) {
    
    if(bki_hesaplama >= 24 && bki_hesaplama <= 29) {
        Console.WriteLine($"Kilonuz İdeal Durumdadır. BKİ Değeriniz => {bki_hesaplama}");
    } else {
        Console.WriteLine($"BKİ Değeriniz => {bki_hesaplama}");
    }

}
