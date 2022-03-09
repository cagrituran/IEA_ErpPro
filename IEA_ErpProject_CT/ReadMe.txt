-------------------------------------------14.02.2022------------------------------------------------------
Server Explorer üzerinden db açtık
Create Table yaptık
Veri tiplerini girip update database yaptık olusturduk
2.dbyi olusturup update database yaptık(Tip)
Foreign Keys kısmından add new foreign key bağlantısı yapıp alttaki script kısmından boşluk kısımlarını doldurduk ve updateledik
Entity kısmına new folderdan ADO.NET DB bağlantısını yaptık ve App.config üzerinden yeni string name olusturmus mu diye kontrol ettik
HastaneGiris design kısmına 5 buton ekledik ,butonların backgroundlarına imageler ekledik
Sayfayı 2ye bölmek için splitcontainer ekledik ve propertieslerini yaptık
DataGridView ekledik
DataGridView üzerindeki kulakcığa tıklayıp edit columns yapıp 4 adet data ekledik
Ardından üst kısma 8 label ekledik ve combobox maskedtextbox ekleyip ayarladık ve tabviewden tab sırasına soktuk.(Combobox 'un içine yazı yazılmasını engellemek için drop down style yapmak gerek)
tables kısmına new query açtık ve şehirler tablosunu olusturup hastane dbsine(sehir id) ekledik , ardından ssms 'e girip diagramı güncelledik sonra entity e gelip update modal from database yapıp refresh ve add yapıp ardından ana tabloyu silip tekrar upload edip tabloyu güncel tuttuk.
Diger comboboxa veri göndermek için HastaneTipleri dbsini manipüle edip data ekledik
HastaneGiris.cs ' ine gelip kodlamalar yapıldı.Database'yi(Entity) readonly yaparak tanıttık ve olustururken buradan çektik ardından databaseye düşmesi için YeniKayıt metodu ve gerekli kodları yazdık
-------------------------------------------15.02.2022------------------------------------------------------
Listele adında bir metod oluşturup kodları yazdık , onu yazarken datagridview'e telefon ekledik.sonrasında sırayı takip etmek için sıra ekledik ve gerekli kodları yazdık
gridview için doubleclick eventi olusturup kodları yazdık
Güncelleme butonuna çift tıklayarak gerekli güncelleme kodlarını yazdık(global olarak kullanmam gereken fieldları en yukarıya attık !)
Silme çift tıklayarak gerekli kodları yazdık
Ardından HastanelerListesine gelerek splitcontainer alıp ayarlamaları yaptık daha sonra HastaneGirisin datagrid view alıp yapıstırdık HastanelerListesine yapıstırıp HastanelerListesi.cs girip kodlamaları yaptık
Doubleclick metodu ekledik daha sonra iki form arası aktarma yapabilmek için anasayfa.cs'in içine static bir metod olusturduk ardından OnLoad bir method olusturduk sonra Fonksiyonlar içine bir class açtık
-------------------------------------------16.02.2022------------------------------------------------------
Doubleclick metodundan devam ettik eğer hastanegiriş formu açıksa açık olan forma erişmek için new kullanamayız bu yüzden newlemeden kodu yazdık
Ardında HastaneGirişe tıklamadan da hastanelerlistesine gelerek ordan seçim yapıp hastane girişi açtırmamız için gerekli kodlar eklendi.
HastanelerListesi'ne bir textbox bir button ekleyip arama kısmı eklemek için gerekli kodlar yazıldı ( Listele metodunda sorguda değişiklik yapıldı)
Detaylar tablosu olusturuldu , departmanlar tablosu olusturuldu fk(detaylar-hastaneler , detaylar-departmanlar) baglantısı yapıldı,departmanlar tablosu dolduruldu
Hastanelerin içine HastaneDetay formu açıldı üzerine labeller(id ve isim için) eklendi,hastane girişe Detay Ekle(Formlar kısmına HastaneDetayAc metod yazdık) butonu eklendi butona çift tıklayarak methodu yazdık
HastaneListesi'nin içine datagridview , 5 tane (textbox,richtextbox,maskedtextbox) ve 1 buton ekledik
Butona çift tıklayıp metodun yapması gerekenleri yazdık
-------------------------------------------17.02.2022------------------------------------------------------
btnKayit(Kaydet) butonu eklendi ve tıklayıp kodları yazıldı daha sonra boxları sıfırlamak için temizleme butonu yazıldı ve ayrıca cursorun yanıp sönmesi için 2 ayrı komut yazıldı denendi,gerekli kontroller için komutlar eklendi(boş kayıt eklememek için,boş kayıt butonuna basmamak için vs)
Detayların listesine erişmek için HastaneDetayGoster formu olusturuldu listeleme kodu yazıldı ve detaygoster butonu olusturuldu ve iki butonu visibleları false yaptık kayda tıkladıgında görünür hale temizledigimizde ise görünmeyecek hale getirdik
-------------------------------------------18.02.2022------------------------------------------------------
tblDoktorlar tablosu olusturup (tblDoktorlar-tblHastaneler(3))FK yapıldı
DoktorlarListesinin DoktorlarListesiAc yapması için Formlar(DoktorlarListesiAc methodu yazıldı),Ana Sayfaya(f.DoktorlarlistesiAc) ve DoktorlarListesine(bool secim tanımlandı) kodlar yazıldı
DoktorGiris designini güncellemek için HastaneGirisi kopyalayıp düzenledik ve tblDoktorlar tablosuna vergino vergiadı ve sehirıd(tbldoktorlar-sehirler) fk yapıldı
Unvan adında bir class olusturuldu ve içine public enum içerisinde unvan tanımlamaları yapıldı
DoktorGiris designina gelindi ve datagridview içine gerekli ihtiyacımız olan bilgiler eklendi (Doktor Adı,Tel1,Tel2,Email,Unvan)
DoktorGirise çift tıklayıp load'a kodları yazdık(önce combodoldur metodu yazıldı,Listele,Temizle,kaydet metodları yazıldı)
Sanal buton olusturmak için HastaneGiristen kodları alıp DoktorGirisE yapıstırdık ve methodları olusturduk
Güncelle ve Silme methodları HastaneGiristen kodları alıp DoktorGirise tasıdık düzenledik
Sanal butona tıklayınca DoktorlarListesi açılmalı birine çift tıklayınca o kayıt gelmeli ve o ekran kapanması için kodlar yazıldı