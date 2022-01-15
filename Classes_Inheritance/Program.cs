using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IT> bilgiislems = new List<IT>();
            List<IK> ıKs = new List<IK>();
            List<Muhasebe> m = new List<Muhasebe>();
            List<Pazarlama> p = new List<Pazarlama>();
            //bilgiislems.Add(IT.Kaydet());
            Personel personel = new Personel();
            personel.Kaydet();
            IT b = new IT(personel);
            IK k = new IK(personel);
            Muhasebe mu = new Muhasebe(personel);
            Pazarlama pazar = new Pazarlama(personel);
            bilgiislems.Add(b.ItKaydet());
            ıKs.Add(k.IkKaydet());
            m.Add(mu.MuhasebeKaydet());
            p.Add(pazar.PazarlamaKaydet());
            while (true)
            {
                Console.WriteLine("Giriş Yapın: Ad");
                string ad = Console.ReadLine();
                Console.WriteLine("Giriş Yapın: Soyad");
                string soyad = Console.ReadLine();
                if (ad == personel.Name)
                {
                    if (soyad == personel.SurName)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Giriş Eşleşmiyor.");
                }
            }
            while (true)
            {
                Console.WriteLine("IT Görüntüle ==> 1\nIK Görüntüle ==> 2\nMuhasebe Görüntüle ==> 3\nPazarlama Görüntüle ==> 4");
                int sec = Convert.ToInt32(Console.ReadLine());
                if (sec == 1)
                {
                    foreach (var item in bilgiislems)
                    {
                        Console.WriteLine(item.Name + " " + item.SurName + " " + " " + "TC: " + item.TC + " " + "Program Sayisi: " + item.ProgramSayisi);
                    }
                    break;
                }
                else if (sec == 2)
                {
                    foreach (var item in ıKs)
                    {
                        Console.WriteLine(item.Name + " " + item.SurName + " " + " " + "TC: " + item.TC + " " + "Personel Sayisi: " + item.PersonelSayisi);
                    }
                    break;
                }
                else if (sec == 3)
                {
                    foreach (var item in m)
                    {
                        Console.WriteLine(item.Name + " " + item.SurName + " " + " " + "TC: " + item.TC + " " + "Defter Sayisi: " + item.DefterSayisi);
                    }
                    break;
                }
                else if (sec == 4)
                {
                    foreach (var item in p)
                    {
                        Console.WriteLine(item.Name + " " + item.SurName + " " + " " + "TC: " + item.TC + " " + "Teklif Sayisi: " + item.TeklifSayisi);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");

                }
            }


            Console.ReadLine();
        }
    }
    class Personel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TC { get; set; }

        public void Kaydet()
        {
            Console.WriteLine("Adınız");
            this.Name = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            this.SurName = Console.ReadLine();
            Console.WriteLine("TC");
            this.TC = Console.ReadLine();
        }
    }
    class IT : Personel
    {
        public IT(Personel personel)
        {
            this.Name = personel.Name;
            this.SurName = personel.SurName;
            this.TC = personel.TC;
        }
        public int ProgramSayisi { get; set; }

        public IT ItKaydet()
        {
            Console.WriteLine("Program Sayısı:");
            this.ProgramSayisi = Convert.ToInt32(Console.ReadLine());
            return this;
        }
    }
    class IK : Personel
    {
        public IK(Personel personel)
        {
            this.Name = personel.Name;
            this.SurName = personel.SurName;
            this.TC = personel.TC;
        }
        public int PersonelSayisi { get; set; }
        public IK IkKaydet()
        {

            Console.WriteLine("Personel Sayısı:");
            this.PersonelSayisi = Convert.ToInt32(Console.ReadLine());
            return this;
        }
    }
    class Muhasebe : Personel
    {
        public Muhasebe(Personel personel)
        {
            this.Name = personel.Name;
            this.SurName = personel.SurName;
            this.TC = personel.TC;
        }
        public int DefterSayisi { get; set; }
        public Muhasebe MuhasebeKaydet()
        {
            Console.WriteLine("Defter Sayısı:");
            this.DefterSayisi = Convert.ToInt32(Console.ReadLine());
            return this;
        }
    }
    class Pazarlama : Personel
    {
        public Pazarlama(Personel personel)
        {
            this.Name = personel.Name;
            this.SurName = personel.SurName;
            this.TC = personel.TC;
        }
        public int TeklifSayisi { get; set; }
        public Pazarlama PazarlamaKaydet()
        {
            Console.WriteLine("Teklif Sayısı:");
            this.TeklifSayisi = Convert.ToInt32(Console.ReadLine());
            return this;
        }
    }
    }

