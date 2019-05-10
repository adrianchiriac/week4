using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> listaHoteluri = InitializareListaHoteluri();
            DisplayHotels(listaHoteluri);
            listaHoteluri = AdaugaHotel(listaHoteluri);
            Console.WriteLine();
            DisplayHotels(listaHoteluri);
            listaHoteluri = StergeHotel(listaHoteluri);
            Console.WriteLine();
            DisplayHotels(listaHoteluri);
            Console.Write("Pret limita pentru camera: ");
            int pretMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindRoom(listaHoteluri, pretMax));
            Console.ReadLine();
        }

        private static string FindRoom(List<Hotel> list, int pret)
        {
            string rezultat = "Nu s-a gasit o camera cu un pret mai mic sau egal cu valoarea introdusa!";
            bool br = false;
            foreach (var item in list)
            {
                for (int i = 0; i < item.room.Count; i++)
                {
                    if (item.room[i].rate.Ammount <= pret)
                    {
                        //rezultat = $"Hotel: {item.Name}  Camera: {item.room[i].Name}  Pret: {item.room[i].rate.Ammount}";
                        rezultat = "Hotel: " + item.Name + "  Camera: " + item.room[i].Name + "  Pret: " + item.room[i].rate.Ammount.ToString();
                        br = true;
                        break;
                    }
                }
                if (br)
                {
                    break;
                }
            }
            return rezultat;
        }

        private static void DisplayHotels(List<Hotel> listaHoteluri)
        {
            Console.WriteLine("Lista hoteluri: ");
            for (int i = 0; i < listaHoteluri.Count; i++)
            {
                Console.WriteLine($"  {listaHoteluri[i].Name}");
            }
        }

        private static List<Hotel> StergeHotel(List<Hotel> list)
        {
            Console.Write($"Sterge hotelul de pe pozitia (1 .. {list.Count}): ");
            int pozHotel = Convert.ToInt32(Console.ReadLine());
            Hotel hs = list[pozHotel-1];
            list.Remove(hs);
            return list;
        }

        private static List<Hotel> AdaugaHotel(List<Hotel> list)
        {
            Hotel newHotel = new Hotel();
            list.Add(newHotel);
            Console.Write("Introdu nume hotel: ");
            newHotel.Name = Console.ReadLine();
            Console.Write("Introdu nume oras: ");
            newHotel.City = Console.ReadLine();
            Room room1 = new Room();
            newHotel.room.Add(room1);
            Console.Write("Introdu nume camera 1: ");
            newHotel.room[0].Name = Console.ReadLine();
            Console.Write("Introdu numar adulti camera 1: ");
            newHotel.room[0].Adults = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu numar copii camera 1: ");
            newHotel.room[0].Children = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu pret/noapte camera 1: ");
            newHotel.room[0].rate.Ammount = Convert.ToInt32(Console.ReadLine());
            newHotel.room[0].rate.Currency = "$";

            Room room2 = new Room();
            newHotel.room.Add(room2);
            Console.Write("Introdu nume camera 2: ");
            newHotel.room[1].Name = Console.ReadLine();
            Console.Write("Introdu numar adulti camera 1: ");
            newHotel.room[1].Adults = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu numar copii camera 1: ");
            newHotel.room[1].Children = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu pret/noapte camera 1: ");
            newHotel.room[1].rate.Ammount = Convert.ToInt32(Console.ReadLine());
            newHotel.room[1].rate.Currency = "$";

            Room room3 = new Room();
            newHotel.room.Add(room3);
            Console.Write("Introdu nume camera 3: ");
            newHotel.room[2].Name = Console.ReadLine();
            Console.Write("Introdu numar adulti camera 3: ");
            newHotel.room[2].Adults = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu numar copii camera 3: ");
            newHotel.room[2].Children = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu pret/noapte camera 3: ");
            newHotel.room[2].rate.Ammount = Convert.ToInt32(Console.ReadLine());
            newHotel.room[2].rate.Currency = "$";

            Room room4 = new Room();
            newHotel.room.Add(room4);
            Console.Write("Introdu nume camera 4: ");
            newHotel.room[3].Name = Console.ReadLine();
            Console.Write("Introdu numar adulti camera 4: ");
            newHotel.room[3].Adults = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu numar copii camera 4: ");
            newHotel.room[3].Children = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu pret/noapte camera 4: ");
            newHotel.room[3].rate.Ammount = Convert.ToInt32(Console.ReadLine());
            newHotel.room[3].rate.Currency = "$";

            return list;
        }

        private static List<Hotel> InitializareListaHoteluri()
        {
            List<Hotel> list = new List<Hotel>();
            Hotel unirea = new Hotel();
            unirea.Name = "Unirea";
            unirea.City = "Iasi";
            Room room1u = new Room();
            unirea.room.Add(room1u);
            unirea.room[0].Name = "Camera 1";
            unirea.room[0].Adults = 1;
            unirea.room[0].Children = 0;
            unirea.room[0].rate.Ammount = 40;
            unirea.room[0].rate.Currency = "$";
            Room room2u = new Room();
            unirea.room.Add(room2u);
            unirea.room[1].Name = "Camera 2";
            unirea.room[1].Adults = 2;
            unirea.room[1].Children = 0;
            unirea.room[1].rate.Ammount = 50;
            unirea.room[1].rate.Currency = "$";
            Room room3u = new Room();
            unirea.room.Add(room3u);
            unirea.room[2].Name = "Camera 3";
            unirea.room[2].Adults = 2;
            unirea.room[2].Children = 1;
            unirea.room[2].rate.Ammount = 60;
            unirea.room[2].rate.Currency = "$";
            Room room4u = new Room();
            unirea.room.Add(room4u);
            unirea.room[3].Name = "Camera 4";
            unirea.room[3].Adults = 2;
            unirea.room[3].Children = 2;
            unirea.room[3].rate.Ammount = 70;
            unirea.room[3].rate.Currency = "$";
            list.Add(unirea);
            //---------------------------------
            Hotel traian = new Hotel();
            traian.Name = "Traian";
            traian.City = "Iasi";
            Room room1t = new Room();
            traian.room.Add(room1t);
            traian.room[0].Name = "Camera 1";
            traian.room[0].Adults = 11;
            traian.room[0].Children = 0;
            traian.room[0].rate.Ammount = 35;
            traian.room[0].rate.Currency = "$";
            Room room2t = new Room();
            traian.room.Add(room2t);
            traian.room[1].Name = "Camera 2";
            traian.room[1].Adults = 2;
            traian.room[1].Children = 0;
            traian.room[1].rate.Ammount = 45;
            traian.room[1].rate.Currency = "$";
            Room room3t = new Room();
            traian.room.Add(room3t);
            traian.room[2].Name = "Camera 3";
            traian.room[2].Adults = 2;
            traian.room[2].Children = 1;
            traian.room[2].rate.Ammount = 55;
            traian.room[2].rate.Currency = "$";
            Room room4t = new Room();
            traian.room.Add(room4t);
            traian.room[3].Name = "Camera 4";
            traian.room[3].Adults = 2;
            traian.room[3].Children = 2;
            traian.room[3].rate.Ammount = 65;
            traian.room[3].rate.Currency = "$";
            list.Add(traian);
            //---------------------------------
            Hotel hilton = new Hotel();
            hilton.Name = "Hilton";
            hilton.City = "Bucuresti";
            Room room1h = new Room();
            hilton.room.Add(room1h);
            hilton.room[0].Name = "Camera 1";
            hilton.room[0].Adults = 1;
            hilton.room[0].Children = 0;
            hilton.room[0].rate.Ammount = 45;
            hilton.room[0].rate.Currency = "$";
            Room room2h = new Room();
            hilton.room.Add(room2h);
            hilton.room[1].Name = "Camera 2";
            hilton.room[1].Adults = 2;
            hilton.room[1].Children = 0;
            hilton.room[1].rate.Ammount = 55;
            hilton.room[1].rate.Currency = "$";
            Room room3h = new Room();
            hilton.room.Add(room3h);
            hilton.room[2].Name = "Camera 3";
            hilton.room[2].Adults = 2;
            hilton.room[2].Children = 1;
            hilton.room[2].rate.Ammount = 65;
            hilton.room[2].rate.Currency = "$";
            Room room4h = new Room();
            hilton.room.Add(room4h);
            hilton.room[3].Name = "Camera 4";
            hilton.room[3].Adults = 2;
            hilton.room[3].Children = 2;
            hilton.room[3].rate.Ammount = 75;
            hilton.room[3].rate.Currency = "$";
            list.Add(hilton);
            return list;
        }
    }
}
