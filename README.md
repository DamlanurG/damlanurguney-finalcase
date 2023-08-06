# .NET, MİCROSOFT SQL SERVER VE POSTMAN KULLANARAK SİTE YÖNETİMİ APİ OLUŞTURMAK
![55](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/8d579c9d-e140-47e7-bddc-5f526a86dfc0)

_Bu projede bir site yönetiminin sitenin yöneticisi tarafından kolayca yapılması amaçlanmıştır. Yönetici yapılan apide daire ve kullanıcı bilgilerini, aidat ve fatura bilgilerini girebilir, görüntüleyebilir, güncelleyebilir, silebilir ve değiştirebilir._

_Daire bilgileri şu şekildedir :_
- _Blok Adı_
- _Boş/Dolu durumu_
- _Tipi_
- _Bulunduğu Kat_
- _Daire No_
- _Sahibi/Kiracı_

_Kullanıcı bilgileri ise şu şekilde yer almaktadır :_ 
- _Ad Soyad_
- _TCno_
- _E-mail_
- _Telefon_
- _Araç Bilgisi (varsa plaka)_

_Aidat kısmında ise :_
- _DaireID_
- _Ay_
- _Tutar_
- _Ödendi mi(boolean olarak kullanılıyor.)_
  
_bilgileri girilerek aidat ekleniyor. Eklendikten sonra listeleme ve güncelleme işlemleri yapılabiliyor._

_Fatura kısmında :_
- _DaireID_
- _Ay_
- _Tutar_
- _Ödendi mi(boolean olarak kullanılıyor.)_
  
_bilgileri girilerek fatura ekleniyor. Eklendikten sonra listeleme ve güncelleme işlemleri yapılabiliyor._

_Mesaj kısmında ise kullanıcı ID ve iletilmek istenen mesaj girilebiliyor. Mesajın okundu durumunu false olarak girdiğimizde ise okunmamış mesajlar kısmında listeleniyor. Eklenen mesajlar tümüyle de listelenebiliyor._

#### Api Geliştirirken Kullandığım Teknolojiler
1. .Net Core
2. C# dili
3. MS SQL Server
4. Repository Design Pattern
5. Postman

### Kurulum 
1. Veritabanına tabloların aktarılması için Tools sekmesine tıklanır. Nuget Package Manager menüsüne tıklanır ve Package Manager Console açılır. 
2. Add-Migration Initial komutu çalıştırılır.
3. Update-Database komutu çalıştırılarak veritabanı aktarımı tamamlanır.
4. IIS Express butonuna tıklanarak proje ayağa kaldırılır.
5. Postman üzerinden api istekleri gönderilerek işlemler yapılır.

Bu adımlar uygulanarak proje sorunsuz çalıştırılır.

## PROJEDE :
.Net Core v3.1 baz alınarak Entity Framework Code First yapısı kullanılmış olup veritabanı için Microsoft SQL Server kullanılmıştır.

Entity klasör içerisinde tablo yansımaları bulunmaktadır. 

Migrations klasöründe ise tablolarda yapılan değişiklikler bulunmaktadır. 

Package Manager Console üzerinden Add-Migration Initial komutu çalıştırılarak sqlde değişikler belirlenir ve update-database komutu çalıştırılarak tablolardaki değişikler sqle aktarılır. 

Controller katmanındaki apicontroller'da ise veritabanı okuma yazma işlemleri yapılmaktadır.




## KULLANIM
[https://guneyapartmani.com/] adresinde backend kısmında program çalışmaktadır.

Bu apide oldukça kullanılan HTTP metotlarının kullanım amaçları aşağıdaki gibidir :
- HTTP GET : Sunucudan veri almak ve listelemek için kullanılır.
- HTTP POST : Sunucuya veri göndermek için kullanılır. Aynı zamanda güncelleme yapmak için de kullanılabilir.
- HTTP DELETE : Verilerin silinmesi için kullanılır.

![Ekran Alıntısı](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/6a1f8dc7-8f76-42ad-b56d-93b634e09192)

⏹ Daire klasörüne girdiğimizde yukarıdakileri görürüz. Sitenin yöneticisi(admin) bu kısımda aşağıdakileri yapabilir :
- Get metodu ile yazılmış daire listesi kısmına geldiğinde sağ üstte bulunan "send'e" tıklayıp daire bilgilerini listeleyebilir..
- Post metodu ile yazılmış daire ekleme kısmına geldiğinde body kısmından daire bilgilerini girip send kısmından daireyi ekleyebilir.
- Aynı yöntem ile daire güncellemeyi de daire güncelleme kısmından yapabilir.
- Delete metodu ile yazılmış daire silme kısmından daire silebilir.

![1](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/ae42abf7-3fbb-446b-aae1-8c78d596280d)

- Get metodu ile aylık aidat listesinde send'e tıklayıp aylık aidat listesini görüntüleyebilir.
- Aynı şekilde aylık fatura listesini görüntüleyebilir.
- Ödenmemiş aidat ve fatura bilgilerini ayrı ayrı görüntüleyebilir.


![2](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/6fb00877-43ca-4b7e-b5fd-b380b1a45ee4)

- Send'e tıklayarak kullanıcıları listeleyebilir.
- Post metodu ile kullanıcı ekleme kısmında body ve send kısımlarını kullanarak kullanıcı ekleyebilir.
- Aynı şekilde kullanıcı bilgilerinde değişiklik yapılarak kullanıcı güncelleme işlemi yapabilir.
- Delete metodu ile kullanıcı silebilir.
- Get metodu ile kullanıcı e-maili ve şifresini girerek kullanıcı tanımlayabilir.

![3](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/666661ae-f2b5-45d6-83df-fa3f551646d7)

- Get metodu ile aidet listesini görüntüleyebilir.
- Aidat ekleme kısmında DaireID, ay, tutar ve ödendi kısmını doldurarak aidat ekleyebilir.
- Bilgilerde değişiklik yaparak aidatı güncelleyebilir.

![4](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/14aebd9a-f2cb-46a5-aa6a-58c0b8f5afdc)

- Fatura listesini görüntüleyebilir.
- Fatura ekleme kısmında DaireID, ay, tutar ve ödendi kısmını doldurarak fatura ekleyebilir.
- Bilgilerde değişiklik yaparak faturayı güncelleyebilir.

![5](https://github.com/DamlanurG/damlanurguney-finalcase/assets/138982566/db3e86dd-ac68-45b0-87ba-7baceb3062b5)

- KullanıcıID ve metin bilgilerini doldurarak mesaj ekleyebilir.
- Mesaj listesini görüntüleyebilir.
- Okunmamış mesajları listeleyebilir.
