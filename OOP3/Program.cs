using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager= new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager=new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
            //ihtiyacKrediManager1.Hesapla();

            //IKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager1.Hesapla();

            //IKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager efnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            //List<ILoggerService> allOfTheLoggerService = new List<ILoggerService>() { smsLoggerService, databaseLoggerService, fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            
            basvuruManager.BasvuruYap(efnafKrediManager, new List<ILoggerService> {databaseLoggerService, smsLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            







        }
    }
}
