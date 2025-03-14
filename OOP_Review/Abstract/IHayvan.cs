using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review.Abstract
{

    // INTERFACE -> İçinde sadece imzalar bulunur. İmzaların içi dolu olamaz. İçindeki metotlar ve özellikler soyut kabul edilir. 
    // Sözleşme gibi çalışır. Hangi metotların ve özelliklerin kullanılması gerektiğini belirtir.
    // Bir sınıf, birden fazla interface i uygulayabilir.
    // İçindeki metotlar ve özellikler default olarak public tir.
    // Abstract class tan farklı olarak constructor ı yoktur.
    public interface IHayvan
    {
        void SesCikar();
        void YemekYe();
        void Uyu();

    }
}
