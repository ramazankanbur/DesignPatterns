# Pattern'ler

## Creational Pattern'ler

## Factory pattern

- Bu pattern ile benzer işleri yapan farklı metotları tüketecek client'lar detaylardan soyutlanırlar. Hangi class instance'nın oluşturulacağına factory class'ı karar verir. Factory class içinde instance'ı oluşturulacak class'ın nasıl oluşturulacağına da burada karar verilir. Örneğin oluşuturulacak class'ın parametre ihtiyacı (dependency) varsa ya da instance alınmadan yapılması gereken bir business ihtiyacı var ise burada yapılabilir.

![alt text](https://github.com/ramazankanbur/DesignPatterns/blob/main/DesignPatterns/images/factory.png)

### Abstract Factory pattern

- Ben hangi nesneleri kullanacağımı bilmek istemiyorum, sadece aynı gruba ait olanları otomatik olarak üret.

- Bu pattern'de de client'ın tüketilecek alt class detaylarından soyutlanması hedeflenir. Factory pattern'den farklı olarak tek bir soyut arayüzün olmadığı, class sayısının fazla olduğu, fabrikaların çoklandığı pattern'dir.

- Bu pattern ile ihtiyaç duyulan class'lar, fabrika ile seçilebilir. Bu sayede ihtiyaç duyulan class ailesinin nasıl üretildiği client tarafından bilinmeden işlem yapılabilir.

![alt text](https://github.com/ramazankanbur/DesignPatterns/blob/main/DesignPatterns/images/abstract_factory.jpeg)

### Builder pattern

- Bu pattern ile bir nesne turetirken constructure'da cok fazla parametre vermeye ihtiyac var ise bunun yonetimini daha kolay yapabiliiriz. Bu pattern ile cok daha okunakli anlasilabilir bir koda sahip oluruz.

- Zincir metotlar opsiyonel ya da zorunlu olarak tasarlanabilir.

### Prototype-Clone pattern

- Prototype pattern, “hazır bir örneği klonla ve kullan” prensibiyle, nesne oluşturmayı hızlandırır, karmaşıklığı azaltır ve esneklik sağlar.

- Kodun “nasıl oluşturulduğunu” bilmeden nesneleri çoğaltabiliriz.

### Singleton pattern

- Bu pattern 2 problemi cozer. Ilki bir objenin sadece bir instance i oldugundan emin olmamizi saglar. Digeri, bu instance a global olarak erismemizi mumkun kilar.

- Dikkatli kullanmak gerekir, aksi durumda bagimliliklari arttirabilir ve test yazilabilir bir code baseden uzaklasabiliriz.

