namespace WeekFourProject
{
    public class Bilgisayar : BaseMakine
    {
        public bool BluetoothVarMi { get; set; }
        public int UsbGirisi { get; }

        public Bilgisayar(string ad, string aciklama, string isletimSistemi, int seriNumarasi, int usbGirisi, bool bluetoothVarMi) : base(ad, aciklama, isletimSistemi, seriNumarasi)
        {
            BluetoothVarMi = bluetoothVarMi;
            
            if(UsbGirisi == 2 || UsbGirisi == 4)
            {
                UsbGirisi = usbGirisi;
            }
            else
            {
                UsbGirisi = -1;
                Console.WriteLine("Geçersiz bir USB giriş sayısı girdiniz. Lütfen 2 veya 4 seçeneğini yazınız.");
            }
           
        }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisi}");
            Console.WriteLine($"Bluetooth: {(BluetoothVarMi ? "Var" : "Yok")}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın Adı -> {Ad}");
        }
    }
}
