## Creational Pattern'ler
### Factory pattern

- Bu pattern ile benzer işleri yapan farklı metotları tüketecek client'lar detaylardan soyutlanırlar. Hangi class instance'nın oluşturulacağına factory class'ı karar verir. Factory class içinde instance'ı oluşturulacak class'ın nasıl oluşturulacağına da burada karar verilir. Örneğin oluşuturulacak class'ın parametre ihtiyacı (dependency) varsa ya da instance alınmadan yapılması gereken bir business ihtiyacı var ise burada yapılabilir.
<br />
![alt text](https://github.com/ramazankanbur/DesignPatterns/blob/main/DesignPatterns/images/factory.png)

### Abstract Factory pattern

- Bu pattern'de de client'ın tüketilecek alt class detaylarından soyutlanması hedeflenir. Factory pattern'den farklı olarak tek bir soyut arayüzün olmadığı, class sayısının fazla olduğu, fabrikaların çoklandığı pattern'dir.
<br />
- Bu pattern ile ihtiyaç duyulan class'lar, fabrika ile seçilebilir. Bu sayede ihtiyaç duyulan class ailesinin nasıl üretildiği client tarafından bilinmeden işlem yapılabilir.
<br />
![alt text](https://github.com/ramazankanbur/DesignPatterns/blob/main/DesignPatterns/images/abstract_factory.jpeg)