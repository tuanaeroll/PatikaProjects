namespace OOP_Review.Abstract
{

    // Abstract class -> Bir sınıfın sadece şablon veya base olarak kullanılmasını sağlayan ve doğrudan bir nesnesi oluşturulamayan sınıf türüdür. Diğer sınıflar tarafından miras alınarak kullanılır.
    // Hem soyut metotlar hem de somut metotlar içerebilir.
    // Doğrudan bir nesnesi oluşturulamaz.
    // Başka sınıflara temel oluşturmak için tasarlanır.
    public abstract class BaseHayvan : IHayvan
    {
        public string Ad { get; set; }
        public string Tur { get; set; }

        // Abstract class tan nesne oluşturulmasa bile constructor ı vardır. Miras alınan sınıf new lendiğinde tetiklenir.
        public BaseHayvan() 
        {
            Console.WriteLine( "Hayvan constructor tetiklendi.");
        }

        // Abstract metotlar bir abstract class içinde tanımlanan, ancak gövdesi olmayan bir metottur. Bu metot sadece bir imza oluşturur ve bu imza, türetilen sınıflar tarafından uygulanmalıdır.
        // Abstract metot -> Gövdesiz
        // Abstract metot içeren sınıftan miras alan class bu metodu kesinlikle uygulamak zorundadır.
        public abstract void SesCikar();

        public void Uyu()
        {
            Console.WriteLine("Hayvan uyuyor.. zZzZzZ..");
        }

        public virtual void YemekYe()
        {
            Console.WriteLine("Hayvan yemek yiyor.. mMmMmHhh..");
        }
    }
}
