using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.DbC
{
    public class erasmusBaslagicData : System.Data.Entity.DropCreateDatabaseIfModelChanges<ErasmusContext>
    {
        protected override void Seed(WebApplication3.DbC.ErasmusContext context)
        {
            var Universiteler = new List<Universite>
            {
                new Universite{Ad="Sakarya Üniversitesi",Sehirler="Sakarya",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="Sakarya Üniversitesi",Sehirler="Sakarya",Bolum="Elektirik Elektronik Mühendisliği"},
                new Universite{Ad="Sakarya Üniversitesi",Sehirler="Sakarya",Bolum="Endüstri Mühendisliği"},
                new Universite{Ad="Sakarya Üniversitesi",Sehirler="Sakarya",Bolum="İnşaat Mühendisliği"},
                new Universite{Ad="Sakarya Üniversitesi",Sehirler="Sakarya",Bolum="Makina Mühendisliği"},
                new Universite{Ad="Boğaziçi Üniversitesi",Sehirler="İstanbul",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="Boğaziçi Üniversitesi",Sehirler="İstanbul",Bolum="Elektirik Elektronik Mühendisliği"},
                new Universite{Ad="Boğaziçi Üniversitesi",Sehirler="İstanbul",Bolum="Endüstri Mühendisliği"},
                new Universite{Ad="Boğaziçi Üniversitesi",Sehirler="İstanbul",Bolum="İnşaat Mühendisliği"},
                new Universite{Ad="Boğaziçi Üniversitesi",Sehirler="İstanbul",Bolum="Makina Mühendisliği"},
                new Universite{Ad="ODTÜ",Sehirler="Ankara",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="ODTÜ",Sehirler="Ankara",Bolum="Elektirik Elektronik Mühendisliği"},
                new Universite{Ad="ODTÜ",Sehirler="Ankara",Bolum="Endüstri Mühendisliği"},
                new Universite{Ad="ODTÜ",Sehirler="Ankara",Bolum="İnşaat Mühendisliği"},
                new Universite{Ad="ODTÜ",Sehirler="Ankara",Bolum="Makina Mühendisliği"},
                new Universite{Ad="Münih Teknik üniversitesi",Sehirler="Münih",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="Münih Teknik üniversitesi",Sehirler="Münih",Bolum="Elektirik Elektronik Mühendisliği"},
                new Universite{Ad="Münih Teknik üniversitesi",Sehirler="Münih",Bolum="İnşaat Mühendisliği"},
                new Universite{Ad="Münih Teknik üniversitesi",Sehirler="Münih",Bolum="Makina Mühendisliği"},
                new Universite{Ad="Münih Teknik üniversitesi",Sehirler="Münih",Bolum="Endüstri Mühendisliği"},
                new Universite{Ad="Berlin Humboldt Üniversitesi",Sehirler="Berlin",Bolum="Tıp Fakültesi"},
                new Universite{Ad="Berlin Humboldt Üniversitesi",Sehirler="Berlin",Bolum="Hukuk Fakültesi"},
                new Universite{Ad="HEC Paris Üniversitesi",Sehirler="Paris",Bolum="İşletme Fakültesi"},
                new Universite{Ad="HEC Paris Üniversitesi",Sehirler="Paris",Bolum="İktisat Fakültesi"},
                new Universite{Ad="Strasbourg Üniversitesi",Sehirler="Strasbourg",Bolum="Tıp Fakültesi"},
                new Universite{Ad="Strasbourg Üniversitesi",Sehirler="Strasbourg",Bolum="Hukuk Fakültesi"},
                new Universite{Ad="Madrid Complutense Üniversitesi",Sehirler="Madrid",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="Madrid Complutense Üniversitesi",Sehirler="Madrid",Bolum="Kimya Mühendisliği"},
                new Universite{Ad="Barselona Üniversitesi",Sehirler="Barcelona",Bolum="Sanat Tarihi"},
                new Universite{Ad="Barselona Üniversitesi",Sehirler="Barcelona",Bolum="Tıp Fakületesi"},
                new Universite{Ad="Oxford Üniversitesi",Sehirler="Oxford",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="Oxford Üniversitesi",Sehirler="Oxford",Bolum="Pazarlama"},
                new Universite{Ad="Cambridge Üniversitesi",Sehirler="Cambridge",Bolum="Bilgisayar Mühendisliği"},
                new Universite{Ad="Cambridge Üniversitesi",Sehirler="Cambridge",Bolum="Mimarlık"}

            };
            Universiteler.ForEach(s => Universiteler.Add(s));
            context.SaveChanges();
            var IsImkanlar = new List<IsImkanlari>
            {
                new IsImkanlari{SirketIsmi="Ford",Sehir="Türkiye Sakarya"},
                new IsImkanlari{SirketIsmi="Lostar",Sehir="Türkiye Sakarya",Bolum=Bolumler.SiberGüvenlik},
                new IsImkanlari{SirketIsmi="Nrs Siber Güvenlik",Sehir="Türkiye Sakarya",Bolum=Bolumler.SiberGüvenlik},
                new IsImkanlari{SirketIsmi="Toyata",Sehir="Türkiye Sakarya"},
                new IsImkanlari{SirketIsmi="DEMİRCİOĞLU ROBOTİK ",Sehir="Türkiye Sakarya"},
            };
            IsImkanlar.ForEach(s => IsImkanlar.Add(s));
            context.SaveChanges();

            var Konaklamaa = new List<Konaklama>
            {
                new Konaklama{Ad="Vadi54",Sehirler="Sakarya",YurtmuEvmi="Yurt",KızmıErkek="Erkek",KisiSayısı=4,YakinlikUzaklik=2,Fiyat=500},
                new Konaklama{Ad="Kampüs Saray",Sehirler="Sakarya",YurtmuEvmi="Yurt",KızmıErkek="Erkek",KisiSayısı=3,YakinlikUzaklik=0.5,Fiyat=600},
                new Konaklama{Ad="Necip Fazıl",Sehirler="Sakarya",YurtmuEvmi="Yurt",KızmıErkek="Erkek",KisiSayısı=4,YakinlikUzaklik=0.5,Fiyat=300},
                new Konaklama{Ad="Sakarya Uni Yurt",Sehirler="Sakarya",YurtmuEvmi="Yurt",KızmıErkek="Kız",KisiSayısı=4,YakinlikUzaklik=2.5,Fiyat=700},
                new Konaklama{Ad="Huzur Kampus Yurdu",Sehirler="Sakarya",YurtmuEvmi="Yurt",KızmıErkek="Kız",KisiSayısı=2,YakinlikUzaklik=1.5,Fiyat=600},
                new Konaklama{Ad="Asyalı Kampus Yurdu",Sehirler="Sakarya",YurtmuEvmi="Yurt",KızmıErkek="Kız",KisiSayısı=3,YakinlikUzaklik=0.5,Fiyat=800},
                new Konaklama{Ad="Serdivan AVM Yanı",Sehirler="Sakarya",YurtmuEvmi="Ev",Kaçoda=2+1,KızmıErkek="Kız",YakinlikUzaklik=6,Fiyat=1000},
                new Konaklama{Ad="Serdivan Apart",Sehirler="Sakarya",YurtmuEvmi="Ev",Kaçoda=2+1,KızmıErkek="Erkek",YakinlikUzaklik=5,Fiyat=1200},
            };
            Konaklamaa.ForEach(s => Konaklamaa.Add(s));
            context.SaveChanges();
        }
    }
}