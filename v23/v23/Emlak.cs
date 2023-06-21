using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v23;

namespace v23
{
    public class Emlak
    {
        public string Adres;
        public string Sahibi;
        public decimal m2;
        public string EmlakTipi;

    }
}
public class Konut : Emlak
{
    public int BinaKatSayisi;
    public int BulunduguKat;
    public int OdaSayisi;
    public string Isitma;
    public int BanyoSayisi;


}
public class Arsa : Emlak

{
    public string ImarDurumu;
    public int AdaNo;
    public int ParselNo;
}
public class Ev : Konut
{
    public string Cephesi;
    public int BalkonSayisi;


}
public class Villa : Konut
{
    public decimal BahceBüyüklügü;
    public string HavuzDurumu;
    public string MüştamilatDurumu;



}
public class KiralikEv : Ev
{


    public KiralikEmlakBilgileri kiralikBilgileri;

}
public class SatilikEv : Ev
{
    public SatilikEmlakBilgileri satilikBilgileri;
}

public class KiralikVilla : Villa
{
    public KiralikEmlakBilgileri kiralikBilgileri;

}
public class SatilikVilla : Villa
{
    public SatilikEmlakBilgileri satilikBilgileri;

}
public class KiralikArsa : Arsa
{
    public KiralikEmlakBilgileri kiralikBilgileri;
}
public class SatilikArsa : Arsa
{
    public SatilikEmlakBilgileri satilikBilgileri;

}
public class KiralikEmlakBilgileri
{
    public decimal Depozito;
    public int KiraSüresi;
}
public class SatilikEmlakBilgileri
{
    public string KrediyeUygunluk;
    public string TakasDurumu;


}
public class Adres
{
    public string Mahalle;
    public string Cadde;
    public string Sokak;
    public int BinaNo;
    public int DaireNo;
}
public class Sahibi
{
    public string Adi;
    public string SoyAdi;
}