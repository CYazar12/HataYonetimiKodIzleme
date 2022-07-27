using System;

namespace hatayonetimikodizleme{
class Program
{
 static void Main(string[] args)
    {
      try // hataya neden olacak  kodu yaziyoruz
      {
    Console.WriteLine("Bir Sayi Giriniz.");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmis oldugunuz sayi :" + sayi);
   }

   catch(Exception ex) //Hatayi Exception class ile yaz , ex burda bizim hatamizi temsil ediyor.
   {
    Console.WriteLine("Hata : "+ ex.Message.ToString());
   }
finally
{
    Console.Write("Islem tamamlandi."); // Hata alsin almasin kullaniciya konsolda gössterilcek mesaji bu alana yaziyoruz.

}
try  // Daha User friendly Hata yönetmleri burda Catch parantezinde  degisik Exception modelleri deniycez // farkli örneklerde
{  int a = int.Parse(null);

    
}
catch (ArgumentNullException ex) // Yanlis Deger hatasi
{

  Console.WriteLine("Bos Deger verdiniz");
  Console.WriteLine(ex);
}
try
{ int b= int.Parse("test");
    
}
catch (FormatException ex) //Format hatasi  Yanlis Veri tipi
{
    Console.WriteLine(" Veritipi Uygun Degil.");
    Console.WriteLine(ex);
 }
  try                                
  { int c= int.Parse("-200000000000"); // Girilen deger veri tipinin kapasitesinin disinda olmasi
    
  }
  catch (OverflowException ex){
     
      Console.WriteLine("Cok Kücük ve Cok Büyük Deger Girdiniz ");
      Console.WriteLine(ex);}

    finally{

        Console.WriteLine("Islem Basariyla Tamamlandi");
                                              }
                                      }  
                         }
                }

 





    


