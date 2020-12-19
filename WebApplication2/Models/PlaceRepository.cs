using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    //repositorynin anlamı depo demek. sanal bir veritabanı diyebiliriz.
    //yani place sınıfıyla ilgili işlemleri yaparken vt açısından bir yönetici sınıfı olacak.
    //normalde public class placeRepository idi.
    //ama biz onu public static class PlaceRepository yaptık.
    //çünkü uygulamanın çalışması sürece tek bir repository kullanılsın istiyoruz.

    //oluşturduğumuz yapı çalıştığı anda yani PlaceRepositoy'den bir yer
    //tahsis edildiği anda constructor çalışacak.
    //constructor içerisinde  List<Place> Places bu liste doldurulacak.
    //daha sonra bu liste üzerinde AddPlace ve GetById methodları çalıştırılacak.

    public static class PlaceRepository
    {
        private static List<Place> places = null;

        static PlaceRepository()
        {
            places = new List<Place>()
            {
                //Category Id: 1 MÜZE
                new Place(){Id=2,
                            Name ="Yere Batan Sarnıcı",
                            CategoryId=1,
                            Image ="yerebatansarnici.jpg",
                            Description =@" İstanbul'un görkemli tarihsel yapılarından birisi de Ayasofya’nın güneybatısında bulunan Bazilika Sarnıcı’dır. Bizans İmparatoru I. Justinianus (527-565) tarafından yaptırılan bu büyük yeraltı sarnıcı, suyun içinden yükselen ve sayısız gibi görülen mermer sütunlar sebebiyle halk arasında “Yerebatan Sarayı” olarak isimlendirilmiştir. Sarnıcın bulunduğu yerde daha önce bir Bazilika bulunduğundan, Bazilika Sarnıcı olarak da anılır.

                                            Sarnıç, uzunluğu 140 metre, genişliği 70 metre olan dikdörtgen biçiminde bir alanı kaplayan, dev bir yapıdır. Toplam 9.800 m2 alanı kaplayan bu sarnıç, yaklaşık 100.000 ton su depolama kapasitesine sahiptir. 52 basamaklı taş bir merdivenle inilen bu sarnıcın içerisinde her biri 9 metre yüksekliğinde 336 sütun bulunmaktadır. Birbirine 4.80 metre aralıklarla dikilen bu sütunlar, her biri 28 sütun içeren 12 sıra meydana getirirler.  Çoğunluğu daha eski yapılardan toplandığı anlaşılan ve çeşitli mermer cinslerinden yontulmuş sütunların büyük bir kısmı tek parçadan, bir kısmı da iki parçadan oluşmaktadır. Bu sütunların başlıkları, yer yer farklı özellikler taşır. Bunlardan 98 adedi Corint üslûbu yansıtırken bir bölümü de Dor üslûbunu yansıtmaktadır.  Sarnıçtaki sütunların köşeli veya yivli biçimde olan birkaç tanesi hariç büyük bir çoğunluğu silindir biçimindedir. Sarnıcın ortasına doğru kuzeydoğu duvarı önünde yer alan 8 sütun, 1955-1960 yıllarında yapılan bir inşaat sırasında kırılma tehlikesine maruz kaldıklarından, bunların her biri, kalın bir beton tabaka içine alınarak dondurulmuş ve bu yüzden eski özelliklerini kaybetmişlerdir. Sarnıcın tavan aralığı kemerler vasıtasıyla sütunlara aktarılmıştır. Sarnıcın tuğladan örülmüş 4.80 metre kalınlığındaki duvarları ve tuğla döşeli zemini, Horasan harcından kalın bir tabakayla sıvanarak su geçmez hale getirilmiştir.

                                            Bizans döneminde bu çevrede geniş bir sahayı kaplayan ve imparatorların ikamet ettiği büyük sarayın ve bölgedeki diğer sakinlerin su ihtiyacını karşılayan Yerebatan Sarnıcı, İstanbul’un Osmanlılar tarafından 1453 yılında fethinden sonra bir müddet daha kullanılmış ve padişahların oturduğu Topkapı Sarayı’nın bahçelerine buradan su verilmiştir.

                                            İslâmî kaidelerin temizlik esasları gereği durgun su yerine akar vaziyetteki suyu tercih eden Osmanlılar’ın şehirde kendi su tesislerini kurduktan sonra kullanmadıkları anlaşılan Sarnıç, 16. yüzyılın ortalarına gelinceye kadar Batılılar tarafından fark edilmemiş, nihayet 1544-1550 yıllarında Bizans kalıntılarını araştırmak üzere İstanbul’a gelen Hollandalı gezgin P. Gyllius tarafından yeniden keşfedilerek Batı âlemine tanıtılmıştır. P. Gyllius, araştırmalarından birinde, Ayasofya civarında dolaşırken, buradaki evlerin zemin katlarında bulunan kuyu benzeri yuvarlak büyük deliklerden ev halkının aşağıya sarkıttıkları kovalarla su çektikleri, hatta balık tuttuklarını öğrendi. Büyük bir yeraltı sarnıcının üzerinde bulunan ahşap bir binanın duvarlarla çevrili avlusundan, yerin altına inen taş basamaklardan elinde bir meşaleyle sarnıcın içerisine girdi. P. Gyllius, çok zor şartlarda sarnıcı sandalla dolaşarak ölçülerini alıp sütunlarını tespit etti. Gördüklerini ve edindiği bilgileri seyahatnamesinde yayımlanan Gyllius, birçok seyyahı etkilemiştir.

                                            Sarnıç, kurulduğundan günümüze kadar çeşitli onarımlardan geçmiştir. Osmanlı İmparatorluğu Dönemi'nde iki defa onarılan sarnıcın ilk onarımı 3. Ahmet zamanında (1723) Mimar Kayserili Mehmet Ağa tarafından yaptırılmıştır. İkinci onarım ise Sultan 2. Abdülhamid (1876-1909) zamanında gerçekleştirilmiştir. Cumhuriyet Dönemi'nde de sarnıç, 1987'de İstanbul Belediyesi tarafından temizlenerek ve bir gezi platformu yapılmak suretiyle ziyarete açılmıştır. 1994 yılının Mayıs ayında yeniden büyük bir temizlik ve bakımdan geçmiştir. Medusa Başı

                                            Sarnıcın kuzeybatı köşesindeki iki sütunun altında kaide olarak kullanılan iki Medusa Başı, Roma Dönemi heykel sanatının şaheserlerindendir. Sarnıcı ziyaret eden insanların en çok ilgisini çeken Medusa başlarının hangi yapılardan alınıp buraya getirildiği bilinmemektedir. Araştırmacılar, genellikle sarnıcın inşası sırasında salt sütun kaidesi olarak kullanılması amacıyla getirildiklerini düşünmektedirler. Bu görüşe rağmen, Medusa Başı hakkında birtakım efsaneler oluşmuştur.

                                            Bir efsaneye göre Medusa, Yunan mitolojisinde yeraltı dünyasının dişi canavarı olan üç Gorgona’ dan biridir. Bu üç kız kardeşten yılan başlı Medusa, kendisine bakanları taşa çevirme gücüne sahiptir. Bir görüşe göre o dönemde büyük yapılar ve özel yerleri korumak için Gorgona resim ve heykelleri kullanılırdı ve Sarnıca Medusa başının konulması da bu yüzdendir.

                                            Başka bir rivayete göre de Medusa, siyah gözleri, uzun saçları ve güzel vücudu ile övünen bir kızdı. Medusa, Zeus’ un oğlu Perseus’u seviyordu. Bu arada Athena da Perseus’u seviyor ve Medusa’yı kıskanıyordu. Bu yüzden Athena, Medusa’nın saçlarını yılana çevirdi. Artık Medusa’nın baktığı herkes, taşa dönüşüyordu. Daha sonra Perseus, Medusa’nın başını kesti ve onun bu gücünden yararlanarak pek çok düşmanını yendi.

                                            Buna dayanarak Medusa Başı, Bizans’da kılıç kabzalarına işlenmiş ve sütun kaidelerine (bakanların taş kesilmemesi için) ters olarak yerleştirilmiştir. Bir rivayete göre de Medusa, yana bakıp kendisini taşa çevirmiştir. Bu yüzden buradaki heykeli yapan heykeltıraş, ışığın yansıma açılarına göre Medusa’ yı üç ayrı konumda yapmıştır.

                                            İstanbul gezi programlarının ayrılmaz bir parçası olan bu gizemli mekânı, bugüne kadar ABD eski Başkanı Bill Clinton'dan Hollanda Başbakanı Wim Kok'a, İtalyan eski Dışişleri Bakanı Lamberto Dini'den İsveç eski Başbakanı Göran Persson'a ve Avusturya eski Başbakanı Thomas Klestil'e kadar birçok kişi ziyaret etti.

                                            Hâlihazırda İstanbul Büyükşehir Belediyesi iştiraklerinden Kültür A.Ş. tarafından işletilen Yerebatan Sarnıcı, müze olmanın yanı sıra, ulusal ve uluslararası birçok etkinliğe ev sahipliği etmektedir.",
                            Address=" Alemdar, Yerebatan Cd. 1/3, 34110 Fatih/İstanbul"
                },

                new Place(){Id=9,
                            Name ="İstanbul Modern Müzesi",
                            CategoryId =1,
                            Image ="istanbul-modern-museum.jpg",
                            Description =@"Türkiye’nin sanatsal yaratıcılığını ve kültürel kimliğini ulusal ve uluslararası sanat ortamıyla paylaşmak amacıyla 2004 yılında ülkemizin ilk modern ve çağdaş sanat müzesi olarak kurulan İstanbul Modern, disiplinlerarası etkinliklere ev sahipliği yapmaktadır.

                                        İstanbul Modern, uluslararası bir yönelimle, modern ve çağdaş sanat yapıtlarını, fotoğraf, tasarım, mimari, yeni medya ve sinema alanlarındaki üretimleri koleksiyonunda toplar, korur, sergiler ve belgeler. Türkiye’nin kültürel kimliğinin uluslararası sanat ortamıyla paylaşılmasına aracılık eder. Sanatçıların üretimlerine ve uluslararası işbirlikleri kurabilmelerine destek olur. Sanatı kitleler için kolayca erişilebilir kılmayı misyon edinen İstanbul Modern, bu amaçla her yaştan sanat izleyicisine eğitim programları sunar.

                                        Müzenin koleksiyonları, sergileri ve eğitim programları, her kesimden ziyaretçiye sanatı sevdirmeyi ve ziyaretçilerin etkin biçimde sanata katılımlarını sağlamayı hedefler. İstanbul Boğazı’nın kıyısındaki Karaköy’de 8.000 metrekarelik bir alana kurulan ve 14 yıl boyunca faaliyetlerini bu binada sürdüren İstanbul Modern, yeni binası tamamlanana kadar, Mayıs 2018 itibariyle 3 yıl boyunca Beyoğlu’ndaki geçici mekânında ziyaretçilerini ağırlamaktadır. Süreli ve sürekli sergi salonları, fotoğraf galerisi, eğitim ve sosyal programları, kütüphane, sinema ve mağazasıyla kültürel faaliyetlerini sürdürmektedir.",
                            Address ="Asmalımescit Mahallesi Meşrutiyet Caddesi, No:99 34430, Beyoğlu İstanbul"
                },

                new Place(){Id=12,
                           Name ="Topkapı Sarayı",
                           CategoryId =1,
                           Image ="topkapi-sarayi.jpg",
                           Description =@"Topkapı Sarayı, İstanbul Sarayburnu'nda, Osmanlı İmparatorluğu'nun 600 yıllık tarihinin 400 yılı boyunca, devletin idare merkezi olarak kullanılan ve Osmanlı padişahlarının yaşadığı saraydır. Bir zamanlar içinde 4.000'e yakın insan yaşamıştır. Topkapı Sarayı Fatih Sultan Mehmed tarafından 1478’de yaptırılmış, Abdülmecid’in Dolmabahçe Sarayı’nı yaptırmasına kadar yaklaşık 380 sene boyunca devletin idare merkezi ve Osmanlı padişahlarının resmi ikâmetgâhı olmuştur. Kuruluş yıllarında yaklaşık 700.000 m²'lik bir alanda yer alan sarayın bugünkü alanı 80.000 m²'dir. 
                                            Topkapı Sarayı, saray halkının Dolmabahçe Sarayı, Yıldız Sarayı ve diğer saraylarda yaşamaya başlaması ile birlikte boşaltılmıştır. Padişahlar tarafından terk edildikten sonra da içinde birçok görevlinin yaşadığı Topkapı Sarayı hiçbir zaman önemini kaybetmemiştir. Saray zaman zaman onarılmıştır. Ramazan ayı içerisinde padişah ve ailesi tarafından ziyaret edilen Kutsal Emanetler'in bulunduğu Hırka-i Saadet Dairesi’nin her yıl bakımının yapılmasına ayrı bir önem verilmiştir. Topkapı Sarayı’nın ilk defa, adeta bir müze gibi ziyarete açılması Abdülmecid dönemine rastlamıştır. O dönemin İngiliz elçisine Topkapı Sarayı Hazinesi’ndeki eşyalar gösterilmiştir. 
                                            Bundan sonra Topkapı Sarayı Hazinesi’ndeki eski eserleri yabancılara göstermek gelenek haline gelir ve Abdülaziz zamanında, ampir üslupta camekanlı vitrinler yaptırılır, hazinedeki eski eserler bu vitrinler içinde yabancılara gösterilmeye başlanır. II. Abdülhamid tahttan indirildiği sıralarda Topkapı Sarayı Hazine-i Hümâyûn’un pazar ve salı günleri olmak üzere halkın ziyaretine açılması düşünülmüşse de bu gerçekleşememiştir. Mustafa Kemal Atatürk’ün emriyle 3 Nisan 1924 tarihinde halkın ziyaretine açılmak üzere İstanbul Âsâr-ı Atika Müzeleri Müdürlüğü’ne bağlanan Topkapı Sarayı önce Hazine Kethüdalığı, sonra Hazine Müdüriyeti adıyla hizmet vermeye başlamıştır. 
                                            Bugün ise Topkapı Sarayı Müzesi Müdürlüğü adıyla hizmet vermeye devam etmektedir. 1924 yılında bazı ufak onarımlar yapıldıktan ve ziyaretçilerin gezebilmeleri için gereken idari önlemler de alındıktan sonra Topkapı Sarayı 9 Ekim 1924 tarihinde müze olarak ziyarete açılmıştır. O tarihte ziyarete açılan bölümler Kubbealtı, Arz Odası, Mecidiye Köşkü, Hekimbaşı Odası, Mustafa Paşa Köşkü ve Bağdat Köşkü’dür. Günümüzde büyük turist kitlelerini kendine çeken saray 1985 yılında UNESCO Dünya Mirasları Listesi'ne giren İstanbul Tarihî yarımada içerisindeki tarihi eserlerin en başında gelmektedir. Günümüzde müze olarak hizmet vermektedir.",

                            Address ="Cankurtaran, 34122 Fatih/İstanbul"

                },

                new Place(){Id=13,
                           Name ="İstanbul Arkeoloji Müzesi",
                           CategoryId =1,
                           Image ="arkeoloji.jpg",
                           Description ="Osmanlı Devleti’nden miras kalmış olan bu müze binalarının önemi ilk müzecilik çalışmalarını bünyesinde toplamasından gelmektedir. Fatih Sultan Mehmet döneminden itibaren tarihi eserlerin toplandığını görmekteyiz. O dönemde sistemli bir şekilde yürütülmeyen bu kurum, 1869 yılında Müze-i Hümayun yani İmparatorluk Müzesi kurulduktan sonra düzenli bir şekilde yürütülmeye başlanmıştır. Bu müze İstanbul Arkeoloji müzesinin temellerini oluşturmaktır. İlk görülen eserler Aya İrini kilisesinden toplanmış olan tarihi parçalardır. Müze bir dönem kaldırılmıştır lakin 1872 yılında yeniden hayata kazandırılması hedeflenmiştir. " +
                           "Yalnız yetersiz olabileceği düşüncesi ise yeni bir mekan düşünülmüş ve Fatih Sultan Mehmet Döneminde yapılmış olan Çinili Köşk müzeye dönüştürülmüştür. 1880 yılında restore edilerek halka açılan müze bugün de hala İstanbul Arkeoloji Müzesine bağlı kalarak varlığını sürdürmektedir. 1881 yılında Osman Hamdi Bey’in müzeye müdür olarak atanması sonucunda Türk müzeciliğinin seyri değişmiştir. Aynı zamanda arkeoloji çalışmalarında bulunan Osman Hamdi Bey, buluntuları bu müzede toplayarak koleksiyonu genişletmiştir. İskender Lahti başta olmak üzere çok sayıda lahit müzenin en kıymetli parçalarındandır. Çinili Köşk mimari tarihi en erken olanıdır. " +
                           "Sonradan yapılan iki bina köşkün çevresine konumlandırılmıştır. Bu binalardan biri Osmanlı Devletinin ilk Güzel Sanatlar Akademisi olarak inşa ettiği ve sonradan Eski Şark Eserleri Müzesi olarak düzenlenmiştir. 1883 yılında ise bu müze Osman Hamdi Bey tarafından Sanay-i Nefise Mektebi olarak inşa ettirmiştir. Bu binanın ve İstanbul Arkeoloji Müzeleri Klasik binanın mimarı Alexander Vallaury’dir. 1917 yılında mektep olan bu bina müzeler müdürlüğüne tahsis edilmiştir. Halil Ethem Bey binanın yeniden Eski Şark Eserleri Müzesi olarak kullanılması için düzenlemelerde bulunmuştur. " +
                           "2000 yılına gelinceye kadar pek çok bakım ve onarımlar geçiren müze, bu yıldan sonra bugün ki halini almıştır. Arkeoloji Müzesi ise dünyada müze binası olarak inşa edilmiş nadir yapılardan biri olma özelliğini taşımaktadır. Neo-Klasik mimarinin en güzel örneklerindendir.",
                           Address="Cankurtaran, 34122 Fatih/İstanbul"
                },

                new Place(){Id=14,
                           Name ="Deniz Müzesi",
                           CategoryId =1,
                           Image ="denizmuzesi.jpg",
                           Description =@"İstanbul Deniz Müzesi, Türkiye'nin denizcilik alanında en büyük müzesidir, içerdiği koleksiyon çeşitliliği açısından dünyanın sayılı müzelerinden biridir. Koleksiyonunda yaklaşık 20.000 adet eser bulunmaktadır. Deniz Kuvvetleri Komutanlığı'na bağlı olan İstanbul Deniz Müzesi Türkiye'de kurulan ilk askeri müzedir. İstanbul Deniz Müzesi; 1897 yılında, dönemin Bahriye Nazırı Hasan Hüsnü Paşa'nın emirleri, Miralay (Albay) Hikmet Bey ve Yüzbaşı Süleyman Nutku'nin büyük gayret ve çabaları sonucu Tersane-i Amire'de (Osmanlı Devlet Tersanesi Kasımpaşa, İstanbul'da) küçük bir binada " +
                           @"'Müze ve Kütüphane İdaresi' İsmi ile kurulmuştur Önceleri düzenlemesi yapılmamış, müze deposu olarak sergiye açılmıştır. 1914 yılında Bahriye Nazırı olan Cemal Paşa, denizciliğin tüm kollarında olduğu gibi müzede de reform yapmış ve müdürlüğe Deniz Yüzbaşı Ressam Ali Sami Boyar'ı getirerek, bilimsel anlamda yeniden düzenlenmesine olanak sağlamıştır. Boyar, Türk gemilerinin tam ve yarım modellerinin yapılması için 'gemi model atelyesi' ve mankenlerin yapıldığı 'mulaj-manken atelyesi'ni kurarak, müzeciliğin geliştirilmesine ve bugünkü halini almasına temel oluşturmuştur. II. Dünya Savaşı 'nın başlamasıyla, eserler korunma amacıyla Anadolu'ya nakledilmiştir. " +
                           "Savaş sonunda 1946 yılında müzenin tekrar İstanbul'a taşınmasına karar verilmiş ve müze o günün koşullarında en uygun yer olan Dolmabahçe Camii Külliyesi'ne taşınmış, yeni müze müdürü Haluk Şehsyvaroğlu idaresinde iki yıllık bir çalışmadan sonra 27 Eylül 1948 yılında ziyarete açılmıştır. 1961 yılında müze Beşiktaş İskele Meydanı'nda Türk Amirali Kaptan-ı Derya Barbaros Hayreddin Paşa'nın anıtı ve türbesi yanında, bugünkü bulunduğu yere taşınmıştır. Ana sergi binası 3 katlı olup, 1500 m² lik alana sahiptir. Binada bulunan 4 büyük salon ve 17 oda sergileme alanı olarak kullanılmış ve salonlara rüzgâr yönlerinin isimleri verilmiştir. " +
                           "Müzede, saltanat kayıkları, bahriyeli kıyafetleri, el yazmaları, gemi modelleri,sancaklar,haritalar ve portolanlar, tablolar, tuğralar ve armalar, kadırgalar, seyir aletleri, gemi baş figürleri ile silahlar sergilenmektedir.Giriş bölümde ise küçük yaş gruplarının eğitici oyun alanı ve hediyelik eşya bölümü vardır. Restorasyonu tamamlanan müze, 4 Ekim 2013 tarihinde tekrar ziyarete açılmıştır.",
                           Address="Sinanpaşa, Beşiktaş Cd. No:6 D:1, 34353 Beşiktaş/İstanbul"
                },

                new Place(){Id=15,
                           Name ="Sakıp Sabancı Müzesi",
                           CategoryId =1,
                           Image ="sakipsabanci.jpg",
                           Description ="1927 yılında İtalyan mimar Edouard De Nari'ye yaptırılan köşkün ilk sahipleri Mısır Hıdiv ailesidir. Uzun yıllar yazlık konut olarak kullanılan villa, kısa bir süre de Karadağ Sefareti olarak hizmet vermiştir. Hacı Ömer Sabancı tarafından 1950 yılında satın alınan köşk, aynı yıl bahçesine yerleştirilen Fransız heykeltıraş Louis Doumas'ın 1864 yapımı at heykelinden ötürü 'Atlı Köşk' olarak anılmaya başlanmıştır. " +
                           "Köşkün arazisi içindeki ikinci at heykeli ise 1204 yılında 4. Haçlı Seferi sırasında Haçlı kuvvetlerince yağmalanan İstanbul Sultanahmet Meydanından alınarak, Venedik San Marco kilisesi önüne yerleştirilen 4 attan birisinin dökümüdür. 1966'dan itibaren köşkte yaşayan Sakıp Sabancı, 1998 yılında zengin hat ve resim koleksiyonuyla birlikte köşkü içindeki eşyalarla müzeye dönüştürülmek üzere Sabancı Üniversitesi'ne tahsis etmiştir. " +
                           "Modern bir galerinin eklenmesiyle 2002 yılında ziyarete açılan müzenin sergileme alanları 2005 yılındaki düzenleme ile genişletilerek, teknik düzeyde uluslararası standartlara kavuşmuştur. Sabancı Üniversitesi Sakıp Sabancı Müzesi, zengin bir hat ve resim koleksiyonunu bünyesinde barındıran ve düzenlediği geçici sergilerle birçok ünlü sanatçının eserlerine ev sahipliği yapan bir sanat müzesidir. " +
                           "2002 yılında ziyarete açılan müze, İstanbul'da Boğaziçi'nin en eski yerleşimlerinden Emirgan'da bulunan Atlı Köşk'te hizmet vermektedir. ‘Picasso İstanbul'da’ ve ‘Heykelin Büyük Ustası Rodin İstanbul'da’ sergileriyle son yıllarda uluslararası alanda dikkat çekmeyi başarmıştır. Bu ve benzeri sergiler, Müze Müdürü Nazan Ölçer'e etkinlik dalında İstanbul Turizm ödülünü kazandırmıştır. ",
                           Address="Emirgan, Sakıp Sabancı Cd. No:42, 34467 Sarıyer/İstanbul"
                },






                //Category Id: 2 TARİHİ YERLER
                new Place(){Id=4,
                            Name ="Galata Kulesi",
                            CategoryId =2,
                            Image ="galata.jpg",
                            Description =@"Galata Kulesi dünyanın en eski kulelerinden biri olup, Bizans İmparatoru Anastasius tarafından 528 yılında Fener Kulesi olarak inşa ettirilmiştir. 1204 yılındaki IV. Haçlı Seferi'nde geniş çapta tahrip edilen kule, daha sonra 1348 yılında İsa Kulesi adıyla yığma taşlar kullanılarak Cenevizliler tarafından Galata surlarına ek olarak yeniden yapılmıştır. 1348 yılında yeniden yapıldığında kentin en büyük binası olmuştur.

                                            Galata kulesi 1445-1446 yılları arasında yükseltilmiştir. Kule Türklerin eline geçtikten sonra hemen hemen her yüzyıl yenilenmiş ve tamir edilmiştir. 16. yüzyılda Kasımpaşa tersanelerinde çalıştırılan Hristiyan savaş esirlerinin barınağı olarak kullanılmıştır. Sultan III. Murat'ın müsaadesiyle burada müneccim Takiyüddin tarafından bir rasathane kurulmuş, ancak bu rasathane 1579'da kapatılmıştır.

                                            17. yüzyılın ilk yarısında IV. Murat döneminde Hezarfen Ahmet Çelebi, Okmeydanı'nda rüzgarları kollayıp uçuş talimleri yaptıktan sonra, tahtadan yaptırdığı kartal kanatlarını sırtına takarak 1632 yılında Galata Kulesi'nden Üsküdar-Doğancılar'a uçmuştur. Bu uçuş Avrupa'da ilgi ile karşılanmış, İngiltere'de bu uçuşu gösteren gravürler yapılmıştır.

                                            1717'den itibaren kule yangın gözleme kulesi olarak kullanılmıştır. Yangın, ahalinin duyabilmesi için büyük bir davul çalınarak haber verilmekteydi. III. Selim döneminde çıkan bir yangında kulenin büyük bölümü yanmıştır. Onarılan kule 1831 yılında başka bir yangında yine hasar görmüş ve onarılmıştır. 1875 yılında bir fırtınada külahı devrilmiştir. 1965'te başlanıp 1967'de bitirilen son onarımla da kulenin bugünkü görünümü sağlanmıştır.

                                            Özellikleri",
                            Address ="Bereketzade, Galata Kulesi, 34421 Beyoğlu/İstanbul"
                },

                

                new Place(){Id=5,
                            Name ="Kız Kulesi",
                            CategoryId =2,
                            Image ="kizkulesi.jpg",
                            Description =@"Boğaz manzarasının vazgeçilmezlerinden biri kuşkusuz Kız Kulesi'dir. Salacak açıklarındaki küçücük bir adanın üzerine inşa edilmiş bu kule, pek çok efsane barındırıyor. Bunlardan biri, kuleye adını da vermiş olan (Leander's Tower) Leandros efsanesidir. Aralarındaki denize meydan okuyan aşıklar Leondros ve Hero'nun hikayesi trajediyle bitecektir. Fırtınalı bir gecede, Leondros kulede ışık yandığını görünce, sevgilisi Hero'nun kendisini çağırdığını düşünür ve denize atlar. Oysaki bu kez ışığı yakan Hero değil, aşıkların her gece gizlice buluştuğunu anlayan bir başkasıdır ve ışığı söndürüverir. Leondros, Boğazın dalgalarına gömülür; bunun acısına dayanamayan Hero ise kuleden atlayarak hayatına son verir. Efsanenin sonunda aşıklar adına kulenin olduğu yere bir deniz feneri yapılır. Tarihi M.O. 24 yılına dek uzanan Kız Kulesi, uzun tarihi boyunca savunma kalesi, sürgün istasyonu, hapishane, karantina odası, radyo istasyonu, vergi noktası ve deniz feneri olarak kullanılmış. Üsküdar'ın sembolü olan kule, 2000 yılında özel bir şirket tarafından restore edildikten sonra gün içerisinde kafe ve restoran olarak hizmete açılmıştır.",
                            Address ="Kız Kulesi'ne Üsküdar Salacak ve Kabataş'tan tekne ile ulaşım yapılmaktadır. Salacak Mevkii Üsküdar 34668"
                },

                new Place(){Id=16,
                           Name ="Dolmabahçe Sarayı",
                           CategoryId =2,
                           Image ="dolmabahce-sarayi-2.jpg",
                           Description ="Evliya Çelebi; Dolmabahçe Sarayı’nın bugünkü yerinde Yavuz Sultan Selim’in bir köşk yaptırdığını yazar. I Ahmet zamanında, mekân taşla doldurulur ve köşk büyütülür. Sarayın ve yerleşimin adı buradan gelir. 19 yy.da II. Mahmut aynı yerde yeni bir saray bina eder. Bugünkü yapı ise; 1842 yılında I. Abdülmecit tarafından, Karabet Balyan’a inşa ettirilir. Yapımı 1853 senesine kadar devam eden Saray; Abdülmecit’in İkamet ettiği yer olmasının yanı sıra, resmi işleri de gördüğü mekândır. Abdülmecit’ten sonra kardeşi Abdülaziz’de bu Saray’da yaşamıştır. " +
                           "Cumhuriyet’in ilanından sonra Atatürk’ün İstanbul’daki Cumhurbaşkanlığı Konutu olan Dolmabahçe Sarayı, 10 Kasım 1938 tarihinde Atatürk’ün öldüğü yer olması münasebetiyle, Cumhuriyet tarihinde ayrı bir öneme sahiptir. Dolmabahçe Sarayı’nın ana yapıları; Harem, Mabeyn, Saat Kulesi ve Dolmabahçe Camiidir. Saray’da 285 oda ve 46 adet salon, 6 hamam ve 68 tuvalet vardır. Saray 110 bin metrekare alana kurulmuş ve 1910’larda elektrik ve kalorifer sistemine geçmiştir. Mabeyn merdivenlerinin korkulukları, kristallerle süslenmiş harikulade bir görünümde olup; Mabeyndeki Taht Salonu’nda bulunan 36 metrelik kubbeden sarkan dört tonluk ve yedi yüz elli ampullü kristal avize, salona Avrupai bir hava katmaktadır. " +
                           "Bu avize Kraliçe Victoria’nın hediyesidir. Bu Taht Salonu 19 Mart 1877 tarihinde, II Abdülhamit’in Osmanlı meclisini açılışına ev sahipliği de yapmıştır. Ayrıca; Haremde, Taht Salonu’nun izlenebileceği bir koridor vardır. Harem, törenlerin yapıldığı Mavi Salon, kadınların eğlendiği Pembe Salon, Atatürk’ün kaldığı odalar, Valide Sultan odaları gibi farkı mekânları barındırır. Saray’ın girişinde yer alan 30 metre yüksekliğindeki saat kulesininse 1895 yılında tamamlandığı söylenir. Saray’ın yanındaki Dolmabahçe Camii, Osmanlı mimarisine damgasını vuran; Balyanlardan, Nikoğos Balyan tarafından 1853 yılında tamamlanmıştır. Dolmabahçe Sarayı’nın arka kısmında Sultan’ın kuşları için 19 yy.da inşa edilmiş ufak bir köşk yer alır. " +
                           "Yapıda o dönem farklı türden, birçok kuş barındırılmıştır. Günümüzde müzeye dönüştürülen Dolmabahçe Sarayı, Milli Saraylar Daire Başkanlığına bağlıdır.",
                           Address="Vişnezade, Dolmabahçe Cd., 34357 Beşiktaş/İstanbul"
                },

                 new Place(){Id=17,
                           Name ="Kapalı Çarşı",
                           CategoryId =2,
                           Image ="kapalicarsi.jpg",
                           Description ="Kapalıçarşı'nın çekirdeğini oluşturan iki bedestenden İç Bedesten yani Cevahir Bedesteni müellifler arasında tartışmalı olmakla beraber büyük olasılıkla Bizans'tan kalma bir yapı olup 48 m x 36 m ölçülerindedir. Yeni Bedesten ise 1460 yılında Fatih Sultan Mehmet tarafından yaptırılan Kapalıçarşı'nın ikinci önemli yapısıdır ve Sandal Bedesteni olarak anılmaktadır. Burada bir yolu pamuk bir yolu ipekten dokunan ve Sandal adı verilen kumaş satıldığı için Sandal Bedesteni ismi verilmiştir. Fatih Sultan Mehmet'in Kapalıçarşı'nın inşaatına başladığı yıl olan 1460[ Kapalıçarşı'nın kuruluş yılı olarak kabul görmüştür. " +
                           "Asıl büyük çarşı ise Kanuni Sultan Süleyman tarafından ahşap olarak inşa ettirilmiştir. Dev ölçülü bir labirent gibi, 30.700 metrekarede 66 kadar sokağı, 4.000 kadar dükkânı ile Kapalıçarşı, İstanbul’un görülmesi gereken, benzersiz bir merkezidir. Adeta bir şehri andıran, bütünü ile örtülü bu site zaman içerisinde gelişip büyümüştür. İçinde son zamanlara kadar 5 cami, 1 mektep, 7 çeşme, 10 kuyu, 1 sebil, 1 şadırvan, 24 kapı, 17 han bulunmaktaydı. 15. yüzyıldan kalan kalın duvarlı, bir seri kubbe ile örtülü eski iki yapının etrafı sonraki yüzyıllarda, gelişen sokakların üzerleri örtülerek, ekler yapılarak bir alışveriş merkezi haline gelmiştir." +
                           " Geçmişte burası her sokağında belirli mesleklerin yer aldığı ve bunların da, el işi imalatının (manifaktür) sıkı denetim altında bulundurulduğu, ticari ahlak ve törelere çok saygı gösterilen bir çarşı idi. Her türlü değerli kumaş, mücevherat, silah, antika eşya, konusunda nesillerce uzmanlaşmış aileler tarafından, tam bir güven içinde satışa sunulurdu. Geçen yüzyılın sonlarında deprem ve birkaç büyük yangın geçiren Kapalıçarşı eskisi gibi onarılmışsa da, geçmişteki özellikleri değişikliğe uğramıştır. Bütün dükkânların genişliği aynı olacak şekilde inşa edilmiştir. Her sokakta ayrı ürünün ustaları loncalar halinde bulunurdu (yorgancılar, terlikçiler vs.) " +
                           "Satıcılar arasında rekâbet kesinlikle yasaktı. Hatta bir usta, tezgâhını dükkânın önüne çıkarıp kalabalığa göstererek ürün işleyemezdi. Ürünlere devletin belirlediğinden yüksek fiyat konulamazdı. ",
                           Address="Beyazıt, Kalpakçılar Cd. No:22, 34126 Fatih/İstanbul"
                 },

                 new Place(){Id=18,
                           Name ="Mısır Çarşısı",
                           CategoryId =2,
                           Image ="misircarsisi.jpg",
                           Description =@"Bizans zamanında Makro Envalos adında bir çarşının aynı yerde bulunduğu rivâyet edilmektedir. Bugünkü yapı, 1660 yılında Turhan Sultan tarafından Hassa baş mimarı Kâzım Ağa'ya yaptırılmıştır. Önceleri Yeni Çarşı ya da Vâlide Çarşısı olarak anılan ve rivâyete göre Mısır'dan alınan vergilerle inşâ edilen çarşı, 18. yüzyıldan sonra bugün bilinen adıyla anılmaya başlanmıştır. 
                                        1691 ve 1940'ta iki büyük yangın tehlikesini atlatmıştır. Çarşı, son olarak 1940-1943 yılları arasında İstanbul Belediyesi tarafından restore edilmiştir. Yeni Cami'nin yanında yer alan L şeklindeki yapının altı kapısı bulunmaktadır. Bunlardan biri Haseki Kapısı'dır. Bunun üstündeki kısım iki katlı olup üst katta zamanında mahkeme olup esnafın kendi arasında ve halkla sorunları çözülürmüş. 
                                        Mısır Çarşısı, Eminönü'nde Yeni Camii'nin arkasında ve Çiçek Pazarı'nın yanındadır. İstanbul'un en eski kapalı çarşılarından biridir. Aktarlarıyla meşhur bu çarşıda hâlen tabii ilaçlar, baharat, çiçek tohumları, nadir bitki kök ve kabukları gibi eski geleneğine uygun ürünlerin yanı sıra; kuruyemiş, şarküteri ürünleri, değişik gıda maddeleri satılmaktadır.Mısır Çarşısı pazar günleri de açıktır.
                                        ",
                           Address="Rüstem Paşa, Erzak Ambarı Sok. No:92, 34116 Fatih/İstanbul"
                 },
                 new Place(){Id=19,
                           Name ="Haydarpaşa Garı",
                           CategoryId =2,
                           Image ="haydarpasa.jpg",
                           Description ="Devrin Osmanlı padişahı II. Abdülhamid döneminde, 30 Mayıs 1906] tarihinde yapımına başlanmış ve 19 Ağustos 1908 tarihinde hizmete girmiştir. Bir rivayete göre binanın bulunduğu sahaya III. Selim'in paşalarından Haydar Paşa'nın adı verilmiştir. Binanın inşaatı, Anadolu Bağdat adı altında bir Alman şirketi gerçekleştirmiştir. Ayrıca bir Alman'ın teşebbüsüyle garın önünde mendirek inşa edilerek Anadolu'dan gelecek veya Anadolu'ya gidecek vagonların ticari eşyasını yükleme ve boşaltma işlevi için tesisler yapılmıştır. " +
                           "İki Alman mimar Otto Ritter ve Helmuth Cuno tarafından hazırlanan proje yürürlüğe girmiş, garın yapımında Alman ustalarla İtalyan taş ustaları birlikte çalışmıştır. I. Dünya Savaşı sırasında gar deposunda bulunan cephanelere 1917'de yapılan bir sabotajla çıkan yangın sonucu binanın büyük bir bölümü hasar görmüştür. Yeniden onarılan bina bugünkü şeklini almıştır. 1979'da Haydarpaşa'nın açıklarında Independenta adlı tankerin bir gemiyle çarpışması sonu meydana gelen patlamadan ve sıcaktan dolayı binanın O Linneman adlı ustanın yaptığı kurşun vitrayları hasara uğramıştır. " +
                           "1976'da aslına uygun olarak yeniden geniş çapta onarılmış ve 1983'ün sonunda dört dış cepheyle iki kulenin restorasyonu tamamlanmıştır. 28 Kasım 2010 tarihinde çatısında çıkan ağır yangından dolayı çatısı çökmüş ve 4. katı kullanılamaz hale gelmiştir.  Ankara - İstanbul YHD projesi kapsamında İstanbul-Eskişehir bölümündeki demiryolu çalışmaları nedeniyle, 1 Şubat 2012 tarihinden itibaren tren seferlerine ara verildi. Gar, 19 Haziran 2013 günü tren seferlerine tamamen kapatıldı. Garın altından Khalkedon Antik Kentine ait tarihi kalıntılar çıkmıştır.",
                           Address="Rasimpaşa, 34716 Kadıköy/İstanbul"
                 },

                 new Place(){Id=20,
                           Name ="Fener Rum Erkek Lisesi",
                           CategoryId =2,
                           Image ="fenerrum.jpg",
                           Description ="İstanbul'un fethinden sonra Bizans'ın yönetici sınıfı ve tüccarları kenti terk ederek Ege adaları, İtalya ve Fransa'ya sığındı. Dönemin padişahı Fatih Sultan Mehmet, 1454'te, tüm İstanbullu Ortodoksları kente geri çağırdı. Bu çağrısını bir fermanla resmileştiren padişah, Ortodoksların kendi dillerinde eğitim yapabileceklerini, patrikhanelerini yeniden ihya edebileceklerini ve tüm ibadetlerinin eskiden olduğu gibi serbestçe yerine getibileceklerini bildirdi. Bunun üzerine İstanbul'dan ayrılan eski Bizanslılardan bazıları, kente geri döndü. " +
                           "Patrikhane, Havariyyun Kilisesine yerleştirildi. Daha sonra Fethiye Kilisesine (günümüzdeki Fethiye Camii) nakledilen Patriklik makamı son olarak Fener'deki, bugünkü yerine taşındı. Patrik Gennadios ile Fatih Sultan arasında yapılan anlaşma gereği 1454'te Fener sınırları içinde bir okul kuruldu. Osmanlı, bu eğitim kurumuna geniş olanaklar sağladı. Bu okulda pek çok yönetici, baştercüman, patrik ve din görevlisi yetişti. Osmanlı döneminde okulun müdürleri din görevlileri arasından seçilirdi.Okutulan dersler teolojik ağırlıklıydı. " +
                           "Bunun yanı sıra antik ve çağdaş felsefe ve edebiyat dersleri de mevcuttu. Okulun hocaları arasında da çok ünlü yazar ve araştırmacılar bulunuyordu. Bunlardan baba ve oğul Zigomolar , Teofilos Koridaleus, Aleksandros Mavrokordatos, Avgenios Vulgaris ve Konstantin Kumas, dünyaca ünlü isimlerdi. Okul, 1861´den sonra klasik eğitim veren bir liseye dönüştü. 1903´te okulun bünyesine, ilkokul öğretmeni yetiştirmeye yönelik, klasik filoloji ve pedogoji eğitimi veren bölüm eklendi. Okul, cumhuriyetten sonra Fener Rum Erkek Lisesi adını aldı. " +
                           "Okulun, hemen bitişiğinde, Tevkii Cafer Mektebi Sokak´ta bulanan bir binada ise kız öğrencilere eğitim veriliyordu. Okulların karma olmasına karar verildikten sonra kız öğrenciler, Fener Rum Erkek Lisesi binasına taşındi.",
                           Address="Balat, Sancaktar Ykş. No:36, 34087 Fatih/İstanbul"
                 },

                 


                
                
                //Category Id: 3 DİNİ YAPILAR
                new Place(){Id=1,
                            Name ="Sultan Ahmet Camisi",
                            CategoryId =3,
                            Image ="1.jpg",
                            Description =@"Sultan Ahmet Camii veya Sultânahmed Camiî, 1609-1617 yılları arasında Osmanlı Padişahı I. Ahmed tarafından İstanbul'daki tarihî yarımadada, Mimar Sedefkâr Mehmed Ağa'ya yaptırılmıştır. Cami mavi, yeşil ve beyaz renkli İznik çinileriyle bezendiği için ve yarım kubbeleri ve büyük kubbesinin içi de yine mavi ağırlıklı kalem işleri ile süslendiği için Avrupalılarca Mavi Camii (Blue Mosque) olarak adlandırılır. Ayasofya'nın 1935 yılında camiden müzeye dönüştürülmesiyle, İstanbul'un ana camii konumuna ulaşmıştır.

                                            Aslında Sultanahmet Camii külliyesiyle birlikte, İstanbul’daki en büyük eserlerden biridir. Bu külliye bir cami, medreseler, hünkar kasrı, arasta, dükkânlar, hamam, çeşme, sebiller, türbe, darüşşifa, sıbyan mektebi, imarethane ve kiralık odalardan oluşmaktadır. Bu yapıların bir kısmı günümüze ulaşamamıştır.

                                            Yapının mimari ve sanatsal açıdan dikkate şayan en önemli yanı, 20.000'i aşkın İznik çinisiyle bezenmesidir. Bu çinilerin süslemelerinde sarı ve mavi tonlardaki geleneksel bitki motifleri kullanılmış, yapıyı sadece bir ibadethane olmaktan öteye taşımıştır. Caminin ibadethane bölümü 64 x 72 metre boyutlarındadır. 43 metre yüksekliğindeki merkezi kubbesinin çapı 23,5 metredir. Caminin içi 200'den fazla renkli cam ile aydınlatılmıştır. Yazıları Diyarbakırlı Seyyid Kasım Gubarî tarafından yazılmıştır. Çevresindeki yapılarla birlikte bir külliye oluşturur ve Sultanahmet, Türkiye'nin altı minareli ilk camiidir.",
                            Address ="Sultan Ahmet, Atmeydanı Cd. No:7, 34122 Fatih/İstanbul"
                },

                new Place(){Id=7,
                            Name ="Çamlıca Camisi",
                            CategoryId =3,
                            Image ="camlicacamisi.jpg",
                            Description =@"Çamlıca Camii, Türkiye'nin İstanbul şehrinde yer alan bir camidir. Çamlıca, Üsküdar'da yapımına 29 Mart 2013'te başlanan cami, cumhuriyet tarihinin en büyük camisidir. 63 bin kişi kapasiteli ve 6 minareli cami 57 bin 500 metrekarelik alana sahiptir. Cami külliyesinde aynı zamanda müze, sanat galerisi, kütüphane, bin kişilik konferans salonu, 8 sanat atölyesi ve 3 bin 500 araçlık otoparkı bulunmaktadır.

                                          Caminin ana kubbesinin çapı İstanbul'u simgeleyecek şekilde 34 metre, yüksekliği ise İstanbul'da yaşayan 72 milleti simgeleyecek şekilde 72 metre olarak yapılmıştır. Kubbenin iç yüzeyine 16 Türk devletine ithafen, Allah'ın isimlerinden 16'sı yazılmıştır. Caminin altı minaresinden ikisi 90'ar metre iken, diğer dört minare Malazgirt Meydan Muharebesi'ni simgeleyecek şekilde 107,1 metre yüksekliğinde inşa edilmiştir.",
                            Address ="Ferah, Ferah Yolu Sk. No:87, 34692 Üsküdar/İstanbul"
                },

                new Place(){Id=8,
                            Name ="Ortaköy Camisi",
                            CategoryId =3,
                            Image ="ortakoycamisi.jpg",
                            Description =@"Ortaköy Camisinin inşa edilmiş olduğu bölgede daha önceden Vezir İbrahim Paşa’nın damadı olan Mahmut Ağa’nın yaptırmış olduğu mescit bulunuyordu. 1721 yılında ortaya çıkan Patrona Halil İsyanı sonrasında zarar gören mescit çeşitli nedenlerden dolayı yıkılmış ve yerine günümüzde eşsiz güzellik barındıran Ortaköy Camisi inşa edilmiştir. Camiye girişte caminin yaptırılmasına vesile olan Sultan Abdülmecid Han’ın tuğrası bulunmaktadır. 
                                           Cami barok inşa şekli kullanılarak ibadete hazır hale getirilmiştir.
                                           Boğazın eşsiz görünümüne sahip olan Ortaköy Camisinin en belirgin özellerinin başında dört tarafında güneş alacak şekilde tasarlanmasıdır. İki adet minaresi bulunan camide aynı zamanda hünkâr bölümleri yer alıyor. Hünkâr bölümleri padişah ve ailesine aittir. Bahsedilen Hünkâr bölümü camiyi ziyarete gelen kişiler için açık şekilde tutulmakta ve burayı ziyarete gittiğinizde sorunsuz görebilme imkânına erişebilirsiniz. 
                                           Caminin iç kısmı dönemin padişahlarının kullanmış olduğu Osmanlı sarayı görünümünü andırmakta ve özel olarak korunmaktadır.",
                            Address ="Mecidiye, Mecidiye Köprüsü Sk. No:1 D:1, 34347 Beşiktaş/İstanbul"
                },

                new Place(){Id=21,
                           Name ="Bulgar Sveti Stefan Kilisesi",
                           CategoryId =3,
                           Image ="stefankilisesi.jpg",
                           Description =@"‘Sveti Stefan’  Demir kilise bahsi geçtiğinde heyecan duymayan Bulgar kalbi yok denecek kadar azdır. Şanlı bir geçmişe sahip olan  bu anıt kilise Bulgaristan veya her nerede yaşarsa yaşasın kendini Bulgar hisseden herkesin gurur ve güven vesilesidir.
                                        ‘Altın Boynuz’ Haliç kıyısında, Fener semtinde yükselen bu kilise, eski ve ebedi şehrin tacındaki bir inci tanesi  gibi dikkatleri üzerine çeker. Prens Stefan Bogoridi’nin bağışladığı arazi ve üzerindeki ahşap hane, Istanbul’daki Bulgarların gönüllü yardımlarıyla kiliseye dönüştürülür. 9 Ekim 1849 yılında Slavca dilinde bir ayinle takdis edilen kilise ve iki sene sonra karşısına inşa edilen metoh binası Bulgarların kültürel ve dini bilincinin uyanışının beşiği olurlar. Bulgarların, Osmanlı İmparatorluğu sınırları dahilinde ilk defa ayrı bir dini cemaat olarak tanındığı 28 Şubat 1870 tarihli fermanilk olarak burada okunur, kısa bir süre sonraysa başka bir fermanlaBulgar eksarhanesi kurulur. 1898 yılında yanmış olan ahşap kilisenin yerine, bugün hala ayakta olan Demir kilise inşa edilir. Projenin mimarıHovsep Aznavour’dur. İmalatçı ve inşaatçı firma ise Avusturya’da Viyana şehrinde faaliyet gösteren Rudolf von Wagner’dir. Toplam 500 ton ağırlığında demir dökülmüş ve sonradan parçalar burada birleştirilmiştir. Bina zamanının 4.000.000 gümüş levasına mal olmuştur.Dökülmüş olan parçalar, Viyana’dan Tuna ve Boğazlar yoluyla gemilerle getirilmiştir. Kilise 08.Eylül.1898 günü Ekzarh Yosif tarafından kutsanarak ibadete açılmıştır.
                                        Zamanında, tüm dünyada sadece 2 adet olan demir kiliselerden diğeri zamanla yok olunca  Sveti Stefan dünyadaki tek demir kilise olarak varlığını sürdürmektedir. 3 kubbeli ve haç şeklinde olan kilise, diş süslemelerinin zenginliği ile de dikkatleri üzerine çeker. Mihrabı Haliç’e dönüktür. Çan kulesi giriş kapısının üzerinde ve 40 metre yüksekliktedir. Çan kulesindeki altı adet çanın hepsi Rusya’nın Yaroslavl şehrinde dökülmüş olup, günümüzde iki tanesi mükemmel bir şekilde kullanılabilmektedir. Modern rönesans stilindeyapılmış olan  ahşap ikonostas bir mükemmellik ve zerafet örneğidir. Hayırseverler tarafından bağışlanmış olan  kilise eşyaları ve ikonaların tarihsel önemi büyüktür.
                                        Günümüzde Demir Kilise Sveti Stefan Bulgar dini inanışının en büyük sembollerinden biri olmaya devam etmektedir. ",
                           Address="Balat, 34087 Fatih/İstanbul"
                },

               
                //Category Id: 4 SOSYAL TESİSLER
                  new Place(){Id=10,
                            Name ="Çamlıca Sosyal Tesisleri",
                            CategoryId =4,
                            Image ="camlicasosyaltesis.jpg",
                            Description =@"Çamlıca Tepesi, Üsküdar‘da gezilecek yerler arasında en popüler olan yerlerden birisi konumunda. Üsküdar’ın yaklaşık 4 km. kadar sırtlarında 260 metrelik bir tepede bulunan Çamlıca Tepesi’nde muhteşem İstanbul manzarası eşliğinde güzel bir dinlence keyfi sürmek mümkün. " +
                                         "Özellikle hafta sonu manzaralı güzel bir mekanda sabah kahvaltıları ve akşam yemekleri için çok ideal. İstanbul’un en güzel, en iyi manzaralarından birisine sahip ve en yüksek mekanlarından birisi konumunda olan Çamlıca Tepesi, Büyük Çamlıca ve Küçük Çamlıca olarak ikiye ayrılıyor." +
                                         "Bunlardan en popüler olanı şüphesiz Büyük Çamlıca. Deniz seviyesinden yaklaşık 265 metre yükseklikte bulunuyor. Küçük Çamlıca ise ağaçlarla kaplı ve yine manzarası çok güzel. Çamlıca Tepesi’nden İstanbul Boğazı, Adalar, Haliç ve İstanbul Avrupa Yakası manzaralarını izlemek büyük bir keyif. " +
                                         "Çamlıca Tepesi aynı zamanda Avrupa’dan Afrika’ya göç eden büyük gövdeli göçmen kuşların Eylül ve Ekim aylarında uğrak noktası. İstanbul’da göçmen kuşların en net ve uzun süreli olarak gözlemlenebileceği tek yer. Kuş gözlemcileri için çok ideal." +
                                         "Çamlıca Sosyal Tesisleri, Çamlıca Tepesi’nin en popüler mekanı. Bünyesinde birbirinden güzel köşkleri, çeşmeleri, rengarenk çiçekleri, çay bahçeleri, tarihi anıt ağaçları, restoranları, yürüyüş ve gezi parkurları, spor alanları, çocuk parkları barındırıyor. Aynı zamanda tarihsel atmosferiyle de etkileyici bir yer." +
                                         "Çamlıca Sosyal Tesislerinde Klasik Türk müziği eşliğinde öğle veya akşam yemeğinizi yiyebilir, boğaz manzarası eşliğinde çayınızı yudumlayabilirsiniz. 400 metrekarelik kapalı restoran alanı ile birlikte Osmanlı Kahvehanesi ve Bahçe Kafeterya isimli iki aperatif yeme içme mekanı bulunuyor.",
                            Address="Kısıklı, Turistik Çamlıca Cd., 34692 Üsküdar/İstanbul"
                  },

                  new Place(){Id=22,
                           Name ="Beykoz Sahil Sosyal Tesisleri",
                           CategoryId =4,
                           Image ="beykozsosyal.jpg",
                           Description =@"Anadolu yakasının vazgeçilmez mekanları arasında yer alan Beykoz Sahil Sosyal Tesisi, Boğaz sularının Karadeniz ile kucaklaştığı Çubuklu sahilinde yemyeşil ağaçların gölgesinde karşılar konuklarını.
                                            Enfes Boğaz manzarasının yanı sıra dekorasyonunda kullanılan Osmanlı motifleriyle de ön plana çıkan Beykoz Sahil Sosyal Tesisi, 1999 yılından buyana İstanbullulara restoran hizmeti veriyor.
                                            Denizin hemen yanı başında iki katlı olarak inşa edilen Beykoz Sahil Sosyal Tesisi, misafirlerini 1.050 metrekarelik açık alan ve 1.300 metrekarelik kapalı alanıyla oldukça ferah ve şık bir ortamda ağırlar. 
                                            Tesisin ikinci katta yer alan restoran bölümü, olağanüstü güzellikteki manzarasının yanı sıra Türk mutfağına has lezzetlere katılan modern yorumlarla hazırlanan menüleri ile de misafirlerinin beğenisini kazanıyor. Beykoz Sahil Sosyal Tesisi’nde restoran bölümünün yanı sıra misafirlerin dört mevsim ağırlandığı bir de kafeterya bulunuyor. 
                                            Beykoz Sahil Kafeterya; denizin hemen yanı başında muhteşem manzaraya karşı kahvaltı yapmak, dost sohbetleri eşliğinde sıcacık çayınızı yudumlamak ya da bir fincan kahve eşliğinde tatlı bir kaçamak için sizleri bekliyor.",
                           Address ="Kanlıca, Hayal Kahvesi Yanı Burunbahçe, Piri Reis Cd., 34810 Beykoz/İstanbul"
                  },
                
                //Category Id: 5 MESİRE ALANLARI
                 new Place(){Id=11,
                            Name ="Belgrad Ormanı",
                            CategoryId =5,
                            Image ="belgradormani.jpg",
                            Description ="Belgrad Ormanı, Çatalca Yarımadası'nın en doğu ucunda, İstanbul ilinin Avrupa Yakası'nda yer alan doğal oluşumlu ağaçlık bölgedir. Doğusunda İstanbul Boğazı, kuzeyinde ise Karadeniz doğal sınırlarıdır. Bizans ve Osmanlı döneminde İstanbul'a içmesuyu sağlayan en önemli kaynakken; günümüzde kente sağladığı su kentin gereksiniminin çok altında olduğu için daha çok rekreasyonel işlevi ağır basmaktadır.  " +
                            "Orman adını, Kanuni Sultan Süleyman'ın Sırbistan seferi dönüşü beraberinde getirdiği Belgradlıların yerleştirildiği Belgrad köyünden almaktadır. Köy sakinlerinin su kaynaklarını kirlettiği anlaşılınca padişah buyruğuyla köy taşınmış; bu tarihten sonra ormanın ve barındırdığı su kaynaklarının korunması için ilk kez resmî önlemler alınmıştır. " +
                            "Denizden yüksekliği fazla olmamasına karşın yoğun yağış alan bir bölge olan Belgrad Ormanı, Orta Avrupa ve Akdeniz iklimleri arasında geçiş özelliği göstermektedir. Ormanın bu niteliği, farklı bitki türlerinin aynı alanda iç içe büyümesine olanak sağlamaktadır. Ormanın bitki varlığı genel olarak kışın yaprağını döken ağaç ve çalılardan oluşmaktadır. " +
                            "Sapsız meşe, ormandaki baskın ağaç türüdür.  Belgrad Ormanı, İstanbul ve çevresinde canlı varlığı açısından da önemli bir bölgedir. Çok sayıda kuş, sürüngen ve memelinin doğal yaşama ortamıdır. Ormana yönelik koruma tedbirleri ve hayvanlar için koyulan av yasaklarıyla, tehlikede olan türler burada rahatça üreme olanağı bulabilmektedir. " +
                            "Su varlığı bakımından da oldukça zengin bir coğrafyası olan Belgrad Ormanları, irili ufaklı pek çok akarsuya ev sahipliği yapmaktadır. Bu akarsulardan bazılarının önüne Osmanlı döneminde bentler kurulmuştur. Orman sınırları içinde farklı noktalara dağılmış toplam 6 adet tarihî bent bulunmaktadır. " +
                            "Günümüzde İstanbul Orman Bölge Müdürlüğü'nün idari sınırları içinde kalan Belgrad Ormanı, 1956 yılında bir mesire ve piknik alanı olarak düzenlenerek halka açılmış ve İstanbulluların kullanımınına sunulmuştur. " ,
                            Address=" Kemer, 34450 Sarıyer/İstanbul"
                 },

                 new Place(){Id=23,
                           Name ="Büyükada Dilburnu Mesire Alanı",
                           CategoryId =5,
                           Image ="dilburnu.jpg",
                           Description ="Adalar, İstanbulluların vazgeçilmez adreslerinden biri. Hal böyle olunca listemizde mutlaka adalardan bir piknik alanının olmasını istedik ve sizin için piknikçilerin gözdesi Dilburnu Mesire Alanını bulduk. Piknik aktivitesinin yanı sıra size denize girme şansı da tanıyan bu yerde İstanbul’u uzaktan izleyebilirsiniz.",
                           Address="Büyükada-nizam, 34970 Adalar/İstanbul"
                 },

                 
                
                //Category Id: 6 PARKLAR
                new Place(){Id=6,
                            Name ="Gülhane Parkı",
                            CategoryId =6,
                            Image ="gulhaneparki.jpg",
                            Description ="Gülhane Parkı, Osmanlı İmparatorluğu döneminde Topkapı Sarayı'nın dış bahçesiydi ve içinde bir koru ve gül bahçelerini barındırırdı. Türk tarihinde demokratikleşmenin ilk somut adımı olan Tanzimat Fermanı, 3 Kasım 1839'da Abdülmecit döneminde Hariciye Nazırı Mustafa Reşit Paşa tarafından Gülhane Parkı'nda okunmuştur ve bu nedenle Gülhane Hatt-ı Hümayunu da denir. " +
                            "İstanbul şehremini operatör Cemil Paşa (Topuzlu) zamanında düzenlenerek 1912 yılında park haline getirildi ve halka açıldı. Toplam alanı 163 dönüm kadardır. Parkın girişinde sağ tarafta İstanbul şehremini ve belediye başkanlarının büstleri vardır. Parkın ortasından iki yanı ağaçlı yol geçer. Bu yolun sağında ve solunda dinlenme yerleri, çocuk bahçesi bulunmaktadır. " +
                            "Boğaza doğru kıvrılarak inen yokuşun hemen sağında bir Aşık Veysel heykeli, yokuşun sonuna doğru biraz üst kısımda ise Romalılardan kalma Gotlar Sütunu vardır.Sarayburnu Parkı kısmı eskiden Sirkeci Demiryolu hattı üstünden bir köprüyle ana parka bağlıydı. Bu kısım sonradan sahilyolu (1958) ile parktan ayrıldı. Sarayburnu kısmında Atatürk'ün Cumhuriyetten sonra dikilen ilk heykeli (3 Ekim 1926) bulunur." +
                            " Heykel, Avustralyalı mimar Kripel tarafından yapılmıştır. Atatürk, halka latin harflerini halka ilk defa bu parkta 1 Eylül 1928 tarihinde gösterdi. Atatürk'ün naaşı Ankara'ya gönderilirken, İstanbul'daki son tören Gülhane Parkı'nın Sarayburnu bölümünde 19 Kasım 1938 tarihinde yapıldı. Tabut, top arabasından 12 general tarafından alınarak Yavuz zırhlısına götürülmek üzere rıhtımdaki bir dubaya yanaşan Zafer destroyerine konuldu." +
                            "Ayrica 25 Mayıs 2008'de Gülhane Parkı içindeki Has Ahırlar Binası’nda, İstanbul İslam Bilim ve Teknoloji Tarihi Müzesi hizmete girmiştir.",
                            Address ="Cankurtaran, Kennedy Cd., 34122 Fatih/İstanbul"
                },

                 new Place(){Id=3,
                            Name ="Bostancı Lunapark",
                            CategoryId =6,
                            Image="bostancilunapark.jpg",
                            Description =@"Bostancı gösteri merkezinin hemen yanında kurulu olan bu park 30 yılı aşkın süredir İstanbullulara hizmet vermeye devam etmekte. Burası asla eskimeyen bir yerdir. Sürekli bir şekilde kendini yeniliyor, sürekli daha ilgi çekici ve vazgeçilmez bir hale geliyor. Lunapark, 1983 yılında Ümit, Savaş, Celasun kardeşler tarafınca limited şirket olarak kurulmuş ve İstanbul Anadolu yakasında Bostancı lunapark adlı bu şirkete bağlı ilk yerleşik lunaparkını açmışlardır. 
                                           Celasun ailesinin 1940’lar senesine dayanan lunapark geçmişleri Luna Lunapark’ın gerek kalite, gerekse yenilikçilik anlamında büyümesinde büyük bir rol oynamıştır. Bünyesinde bulunan tüm oyuncakların İtalyan yapımı olması, Bostancı Lunaparkın ve Celasun adının güven teşkil etmesini sağlamıştır. 2008 yılında Anonim şirket olarak yeni dönemine geçen Luna Lunapark 2010 yılı itibariyle Bostancı lunaparkın yanı sıra Çekmeköy- Taşdelen parkını da hizmete açmıştır. 
                                           Günümüzde hem gençler hem de olgun bireyler bu parka gelerek son derece fazla eğlenebiliyorlar. Parkın en güzel özelliği ise şehrin içinde, kalabalık bir bölgede yer alması. Böylece ulaşım da son derece kolaylaşıyor. Aynı zamanda zaman zaman çeşitli gösteriler de bu parkın içerisinde düzenleniyor. Park, eskiye göre daha az ilgi görse de halen son derece popüler.",
                            Address ="Bostancı mah, Mehmet Şevki Paşa Cd. No:8, 34744 Kadıköy/İstanbul"
                 },






                 new Place(){Id=24,
                           Name ="Yıldız Parkı",
                           CategoryId =6,
                           Image ="yildiz-parki-selale-2.jpg",
                           Description =@"Osmanlı döneminde, özellikle 1600'lerin başlarında ön plana çıkmaya başladı. O zamanlar Kazancıoğlu Bahçesi adını taşıyan ve bu ailenin mülkü olan topraklar padişah IV. Murat tarafından satın alınarak kızı Kaya Sultan'a hediye edildi.Lale Devri döneminde süsleme zevkine dayalı düzenlenen çırağan alemleri sırasında çeşitli eğlencelere mekân olmuştur. Önce Çırağan Sarayı'nın arka bahçesi, sonra da 1877'den itibaren genişletilmesine geçilen Yıldız Sarayı'nın dış koruluğu olan yeşillik, 1940'tan sonra Yıldız Parkı olarak adlandırıldı.

                                        1925'te bir İtalyan işletmeciye verilen ve bir casino olarak kullanılan Şale Köşkü, Atatürk’ün müdahalesiyle bu işletmeciden alınmıştır. 1930'larda üçe bölünerek; duvarın deniz tarafındaki koruluk ve içindeki Çadır ve Malta Köşkleri İstanbul Belediyesi'ne, tepe kısmındaki yapılar Harp Akademisi'ne(1978'de Kültür Bakanlığı'na bırakıldı), yine duvarın arkasında kuzey yönünde yer alan Şale Köşkü TBMM'ye bırakıldı.

                                        1979'da Türkiye Turing ve Otomobil Kurumu (TTOK) ile İstanbul Belediyesi arasında imzalanan bir sözleşmeyle Malta ve Çadır köşklerinin onarımıyla beraber Yıldız Parkı'nın bütün bakımı 15 yıllığına bu kuruluşa bırakıldı. 1994 yılında anlaşmanın yenilenmemesi üzerine kullanım hakkı tekrar İstanbul Büyükşehir Belediyesi'ne geçti.",

                     Address ="Yıldız, 34349 Beşiktaş/İstanbul" }


            };
        }
        public static List<Place> Places
        {
            get { return places; }
        }
        public static void AddPlace(Place place)
        {
            places.Add(place);
        }
        public static Place GetById(int id)
        {
            return places.FirstOrDefault(i => i.Id == id);
        }


    }
}
