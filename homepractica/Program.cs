using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homepractica.Models;

namespace homepractica
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Store store = new Store();
         
           

            //Card card = new Card();
            //card.Holder = "Elvin Fatalizade";
            //card.Number = 232323223232322;
            //card.Type = CardType.Visa;
            //card.Balance = 3000;
            //card.Expire = new DateTime(2020, 12, 6);
            //card.CVV = 422;

            //store.AddCard(card);

            //Card card1 = new Card();
            //card1.Holder = "Orxan Memmedov";
            //card1.Number = 232323224322322;
            //card1.Type = CardType.VisaElectron;
            //card1.Balance = 3000;
            //card1.Expire = new DateTime(2019, 12, 3);
            //card1.CVV = 120;

            //store.AddCard(card1);

            //Card card2 = new Card();
            //card2.Holder = "Yolchu Nasib";
            //card2.Number = 232323224124322;
            //card2.Type = CardType.Master;
            //card2.Balance = 3300;
            //card2.Expire = new DateTime(2021, 12, 4);
            //card2.CVV = 564;

            //store.AddCard(card2);

            Console.WriteLine("Virtual Card secimine xos gelmissiniz");

            int selection = 0;
            do
            {
               
                Console.WriteLine("Seciminizi edin");
                Console.WriteLine("1.Kartlarim");
                Console.WriteLine("2.Virtual Kartlarim");
                Console.WriteLine("3. Xerclerim");
                Console.WriteLine("0. Cixis");

                string input = Console.ReadLine();

                while(!int.TryParse(input, out selection))
                {
                    Console.WriteLine("Duzgun reqem secin");

                   input = Console.ReadLine();
                }

                Console.WriteLine(input);

                switch (selection)
                {
                    case 1:
                       
                        if (store.Cards.Length == 0)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine("Kartiniz yoxdur");
                            Console.WriteLine("==============================================");
                        }

                        for (int i = 0; i < store.Cards.Length; i++)
                        {
                         Console.WriteLine("{0}. {1}  {2}  {3}  {4}", (i + 1), store.Cards[i].Holder, store.Cards[i].Number, store.Cards[i].Expire.ToString("MM/yy"), store.Cards[i].Balance);
                        }

                        Console.WriteLine("===================================================");

                        int selectionCards = 0;

                        Console.WriteLine("1. Yeni Kart elave et");
                        Console.WriteLine("2. Kart sil");

                        string inputCards = Console.ReadLine();

                        if(!int.TryParse(inputCards, out selectionCards))
                        {
                            Console.WriteLine("Duzgun secim edin");
                        }
                        if(selectionCards == 1)
                        {
                            Console.WriteLine("Yeni Kart Yarat");
                            Card card = new Card();

                            Console.WriteLine("Ad Soyadinizi Yazin");
                            card.Holder = Console.ReadLine();

                            store.AddCard(card);

                            Console.WriteLine("Kartin Nomresi");
                         

                            string cardNo = Console.ReadLine();

                            ulong no = 0;
                            while (!ulong.TryParse(cardNo, out no))
                            {
                                Console.WriteLine("Duzgun Nomre Yazin");
                                cardNo = Console.ReadLine();
                            }
                            card.Number = no;
                              
                            store.AddCard(card);



                            Console.WriteLine("Kartiniz ugurla yaradildi");

                        }else if (selectionCards == 2)
                        {
                            Console.WriteLine("Karti sil");
                        }

                        break;
                    case 2:
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Virtual listi");
                        break;
                    case 3:
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Xercler listi");
                        break;
                    case 0:
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Cixis");
                        break;
                    default:
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Duzgun secim edin");
                        break;

                       

                }
            } while (selection != 0);

        }
    }
}
