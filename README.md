# CodeFirstRelation  
## İstenilenler  
Code First Yaklaşımı ile Veri Tabanı ve İlişkiler Oluşturma  
Entity Framework Core kullanarak Code First yaklaşımını uygulamanız gerekiyor.  

User Tablosu:  

Id: int, birincil anahtar ve otomatik artan.  

Username: string, kullanıcının kullanıcı adı.  

Email: string, kullanıcının e-posta adresi.  

Post Tablosu:  

Id: int, birincil anahtar ve otomatik artan.  

Title: string, gönderinin başlığı.  

Content: string, gönderinin içeriği.  

UserId: int, gönderinin yazarı (kullanıcının kimliği).  

Bir kullanıcının birden fazla gönderisi olabilir, ancak her gönderi yalnızca bir kullanıcıya ait olacak.  

Context sınıfımızın ismi PatikaSecondDbContext olsun.  
Veritabanı ismi PatikaCodeFirstDb2 olsun.  
Veritabanında tablolar Users ve Posts olsun.  
İstenilen kodu yazdıktan sonra MsSQL DB'imizde oluşan Db ve Table alttaki diyagramdaki gibi olmakta UserId primary key, PostId foren key olmaktadır.  
![Db2](https://github.com/ugurarican/CodeFirstRelation/blob/master/db2-one-to-many.png)  
