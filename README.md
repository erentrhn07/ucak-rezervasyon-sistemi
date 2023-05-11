# ucak-rezervasyon-sistemi
C# Projesi/Uçak Rezervasyon Sistemi

Bu projede uçak rezervasyon sistemi modellemesi yaptık. Bu proje C# program dilinde yazılmıştır. Müşteriler, seyahat edecekleri lokasyon ve seçecekleri tarihe göre uçuşlarını rezerve edebilir ve görebilirler. Uçak Rezervasyon Sistemi Modellemenin konstrüksiyon yapısı şu şekildedir:

1)Projemiz Ucak, Lokasyon, Musteri, MusteriOlusturma, LokasyonOlusturma, Rezervasyon, UcakOlusturma, UcusOlusturma ve Program sınıflarından oluşmaktadır.

2)Ucak sınıfı, uçak ile ilgili kavramları içerir.

3)UcakOlusturma sınıfı, uçak hakkındaki bilgileri tanımlar. Model, YolcuKapasitesi, BagajKapasitesi ve Hiz özellikleri bu sınıfta bulunmaktadır.

4)Lokasyon sınıfı, ülke, şehir ve havaalanı özelliklerini gösterir.

5)LokasyonOLusturma sınıfı ise gidecelecek ülkenin, o ülkenin şehri ve havaalanları bilgilerini içerir. Kısacası seyahat edilecek konum bilgilerini oluşturur.

6)Musteri sınıfı, müşteri bilgilerini içerir. Ad, Soyad, Yaş, KimlikNo, TelNo, Cinsiyet ve Engel özelliklerini gösterir.

7)MusteriOlusturma sınıfında ise, müşteri hakkındaki bilgileri konsola yazdırmayı sağlar.

8)Rezervasyon sınıfı, müşterinin yaptığı rezervasyonu gösterir. Rezervasyon sonunda seçtiğimiz uçuş lokasyonuna ait bilet ücretini gösterir. Ücret özelliği yer alır.

9)UcusOlusturma sınfı, gideceğimiz yerin uçuş bilgilerini döküm halinde gösterir.

10)Program sınfı, tüm sınıfları bir araya getirerek çalıştırılmasını ve girdiğimiz tüm bilgileri Console uygulamasında gözükmesini sağlar.

Bu projeyi çalıştırmak için, klasörde yer alan Program.cs dosyasını açabilirsiniz. Ardından uygulamayı çalıştırıp başlatabilirsiniz. Müşteri adı, soyadı, yaşı, kimlik numarası, telefon numarası, cinsiyeti, engel durumu, lokasyon ve tarih bilgilerini girmesini sağlayan arayüz görünür. Müşteri ile ilgili bilgiler girildikten sonra, uçuş rezervasyon bilgileri Console üzerinde ekrana yazdırılır.
