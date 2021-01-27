using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.TcNO = "111";
            player1.BirthYear = "1111";
            player1.FirstName = "Diego";
            player1.LastName = "Maradona";

            Player player2 = new Player() { TcNO = "222", BirthYear = "2222", FirstName = "Alex", LastName = "De Souza" };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Update(player2);
            playerManager.Delete(player1);


            List<Player> players = new List<Player>() { player1, player2 };
            foreach (var player in players)
            {
                Console.WriteLine("Bütün Playerlar eklendi");
            }

            Game game1 = new Game();
            game1.GameName = "witcher";
            game1.GameType = "Action";

            Game game2 = new Game();
            game2.GameName = "LOTR";
            game2.GameType = "RPG";

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Updated(game2);

            while (true)
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1-)Oyuncu Ekle,2-)Oyuncu Sil,3-)Oyuncu Yenilendi");

                Console.Write("Lütfen bir numara giriniz:");
                int Numara = Convert.ToInt32(Console.ReadLine());
                if (Numara == 1)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı bilgilerini giriniz");
                    Console.WriteLine("TcNO:");
                    string playerTcNo = Console.ReadLine();
                    Console.WriteLine("FirstName:");
                    string playerFirstName = Console.ReadLine();
                    Console.WriteLine("LastName:");
                    string playerLastName = Console.ReadLine();
                    Console.WriteLine("Oyuncu Eklendi");

                }

                else if (Numara == 2)
                {
                    Console.WriteLine("Silmek istediğiniz Oyuncu TcNO sunu Giriniz");
                    Console.Write("TcNo:");
                    string playerTcNo = Console.ReadLine();
                    Console.WriteLine("Oyuncu Silindi");
                }
                else if (Numara == 3)
                {
                    Console.WriteLine("Yenilemek İstediğiniz Oyuncunun Bilgilerini giriniz");
                    Console.Write("TcNo:");
                    string playerTcNo = Console.ReadLine();
                    Console.WriteLine("FirsName:");
                    string playerFirstName = Console.ReadLine();
                    Console.WriteLine("LastName:");
                    string playerLastName = Console.ReadLine();
                    Console.WriteLine("Oyuncu Yenilendi");

                }
                else
                {
                    Console.WriteLine("Lütfen Tekrar  Numaraları Girmeyi Deneyiniz");
                }

                while (true)
                {
                    Console.WriteLine("**********MENU**********");
                    Console.WriteLine("1-)Oyun Ekle,2-)Oyun Sil,3-)Oyun Yenile");

                    Console.Write("Lütfen bir numara giriniz:");
                    int Numara1 = Convert.ToInt32(Console.ReadLine());
                    if (Numara1 == 1)
                    {
                        Console.WriteLine("Eklemek istediğiniz Oyun bilgilerini giriniz");
                        Console.WriteLine("GameName:");
                        string GameName = Console.ReadLine();
                        Console.WriteLine("GameType:");
                        string GameType = Console.ReadLine();
                        Console.WriteLine("Oyun Eklendi");

                        break;
                    }

                    else if (Numara1 == 2)
                    {
                        Console.WriteLine("Silmek istediğiniz Oyunun adını Giriniz");
                        Console.Write("GameName:");
                        string GameName = Console.ReadLine();
                        Console.WriteLine("Oyuncu Silindi");
                        break;

                    }
                    else if (Numara1 == 3)
                    {
                        Console.WriteLine("Yenilemek İstediğiniz Oyunun Bilgilerini giriniz");
                        Console.WriteLine("GameName:");
                        string GameName = Console.ReadLine();
                        Console.WriteLine("GameType:");
                        string GameType = Console.ReadLine();
                        Console.WriteLine("Oyuncu Yenilendi");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Tekrar  Numaraları Girmeyi Deneyiniz");

                    }
                }
            }
        }
    }
}