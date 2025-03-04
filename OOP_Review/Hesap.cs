using System.Runtime.ConstrainedExecution;

namespace OOP_Review
{
    internal class Hesap
    {
        //public decimal Bakiye { get; set; }

        decimal _bakiye; // Field -> Class içinde tanımlanan değişkenlerdir. Bu bir kapsül oluşturur ve get set metotlarıı açarak Encapsulation yapmış oluruz. Field'lar default private olur ve private variable ları  _ ile başlar.

        // Field -> Sınıfın içinde veri saklamak için kullanılan değişkenlerdir. Field'lar doğrudan sınıfın bir parçasıdır ve genellikle private olarak tanımlanır.

        // Bu değişkene doğrudan dışardan erişilemez, property ile kontrol edilir.

        // ENCAPSULATION -> Veriyi (field'ları) doğrudan erişime kapatarak, kontrollü bir şekilde erişim sağlama yöntemidir. Bu, sınıfın iç yapısını gizler ve dışarıdan sadece izin verilen şekilde veri ile işlem yapılmasına olanak tanır.  - güvenlik görevlisi gibi düşünülebilir.
        public decimal Bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value<0)
                    Console.WriteLine("Bakiyeye negatif bir değer atanamaz.");
                else
                    _bakiye = value;
            }
        }
    }
}

// ÖZET

// Field: Veriyi saklayan temel değişken. Örneğin, _bakiye.
//Property: Field'a kontrollü erişim sağlayan bir mekanizma. Getter ve Setter içerir. Örneğin, Bakiye.
//Encapsulation: Field'ları dışarıdan gizleyip, property'ler aracılığıyla güvenli ve kontrollü bir erişim sağlar.
