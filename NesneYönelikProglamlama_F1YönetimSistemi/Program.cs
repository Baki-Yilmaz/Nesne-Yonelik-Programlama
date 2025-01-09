using System;
using System.Collections.Generic;
using System.Linq;

namespace Formula_1_MS
{
    // === Kalıtım için BaseEntity ===
    abstract class BaseEntity
    {
        public string Name { get; set; }

        protected BaseEntity(string name)
        {
            Name = name;
        }

        public abstract void DisplayInfo();
    }

    // === Driver sınıfı ===
    class Driver : BaseEntity
    {
        public string Team { get; set; }
        public int Points { get; set; }

        public Driver(string name, string team, int points) : base(name)
        {
            Team = team;
            Points = points;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Sürücü: {Name} | Takım: {Team} | Puan: {Points}");
        }
    }

    // === Team sınıfı ===
    class Team : BaseEntity
    {
        public List<Driver> Drivers { get; set; } = new List<Driver>();

        public Team(string name) : base(name) { }

        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Takım: {Name}");
            foreach (var driver in Drivers)
            {
                driver.DisplayInfo();
            }
        }
    }

    // === Program sınıfı ===
    class Program
    {
        static List<Team> teams = new List<Team>();

        static void Main(string[] args)
        {
            if (!Login())
            {
                Console.WriteLine("Hatalı giriş yaptınız! Programdan çıkılıyor...");
                return;
            }

            do
            {
                Console.Clear();
                Console.WriteLine("=== Formula 1 Yönetim Sistemi ===\n");
                Console.WriteLine("1- Takım Ekle/Sil");
                Console.WriteLine("2- Sürücü Ekle/Sil");
                Console.WriteLine("3- Takımları Görüntüle");
                Console.WriteLine("4- Genel Sürücü Sıralaması");
                Console.WriteLine("5- Yarış Sonucu Ekle");
                Console.WriteLine("6- Çıkış\n");
                Console.Write("Seçiminiz: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Geçersiz giriş! Bir sayı giriniz.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        TeamMenu();
                        break;
                    case 2:
                        DriverMenu();
                        break;
                    case 3:
                        DisplayTeams();
                        break;
                    case 4:
                        DisplayDriverStandings();
                        break;
                    case 5:
                        AddRaceResults();
                        break;
                    case 6:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();

            } while (true);
        }

        // Kullanıcı giriş kontrolü
        static bool Login()
        {
            const string validNickname = "sehasalim";
            const string validPassword = "123456";

            Console.Clear();
            Console.WriteLine("=== Formula 1 Yönetim Sistemi Girişi ===");
            Console.Write("Kullanıcı Adı: ");
            string nickname = Console.ReadLine();
            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            if (nickname == validNickname && password == validPassword)
            {
                Console.WriteLine("Giriş başarılı! Yönlendirme yapılıyor...");
                return true;
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı veya şifre!");
                return false;
            }
        }

        // === Takım Menüsü ===
        static void TeamMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=== Takım Ekle/Sil ===\n");
                Console.WriteLine("1- Takım Ekle");
                Console.WriteLine("2- Takım Sil");
                Console.WriteLine("3- Geri Dön\n");
                Console.Write("Seçiminiz: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Geçersiz giriş! Bir sayı giriniz.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddTeam();
                        break;
                    case 2:
                        RemoveTeam();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();

            } while (true);
        }

        static void AddTeam()
        {
            Console.Write("Takım Adı: ");
            string name = Console.ReadLine();
            teams.Add(new Team(name));
            Console.WriteLine($"'{name}' adlı takım başarıyla eklendi.");
        }

        static void RemoveTeam()
        {
            if (teams.Count == 0)
            {
                Console.WriteLine("Silinecek bir takım bulunamadı.");
                return;
            }

            Console.WriteLine("=== Mevcut Takımlar ===");
            foreach (var team in teams)
            {
                Console.WriteLine($"- {team.Name}");
            }

            Console.Write("\nSilmek istediğiniz takımın adını giriniz: ");
            string teamName = Console.ReadLine();

            var teamToRemove = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));
            if (teamToRemove != null)
            {
                teams.Remove(teamToRemove);
                Console.WriteLine($"'{teamName}' takımı başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Hata: Takım bulunamadı!");
            }
        }

        // === Sürücü Menüsü ===
        static void DriverMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=== Sürücü Ekle/Sil ===\n");
                Console.WriteLine("1- Sürücü Ekle");
                Console.WriteLine("2- Sürücü Sil");
                Console.WriteLine("3- Geri Dön\n");
                Console.Write("Seçiminiz: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Geçersiz giriş! Bir sayı giriniz.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddDriver();
                        break;
                    case 2:
                        RemoveDriver();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();

            } while (true);
        }

        static void AddDriver()
        {
            Console.Write("Sürücü Adı: ");
            string driverName = Console.ReadLine();
            Console.Write("Takım Adı: ");
            string teamName = Console.ReadLine();

            var team = teams.FirstOrDefault(t => t.Name.Equals(teamName, StringComparison.OrdinalIgnoreCase));
            if (team != null)
            {
                team.AddDriver(new Driver(driverName, teamName, 0));
                Console.WriteLine($"'{driverName}' adlı sürücü '{teamName}' takımına eklendi.");
            }
            else
            {
                Console.WriteLine("Hata: Takım bulunamadı!");
            }
        }

        static void RemoveDriver()
        {
            Console.Write("Silmek istediğiniz sürücünün adını giriniz: ");
            string driverName = Console.ReadLine();

            var team = teams.FirstOrDefault(t => t.Drivers.Any(d => d.Name.Equals(driverName, StringComparison.OrdinalIgnoreCase)));
            if (team != null)
            {
                var driverToRemove = team.Drivers.First(d => d.Name.Equals(driverName, StringComparison.OrdinalIgnoreCase));
                team.Drivers.Remove(driverToRemove);
                Console.WriteLine($"'{driverName}' adlı sürücü başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Hata: Sürücü bulunamadı!");
            }
        }

        // === Takımları Görüntüleme ===
        static void DisplayTeams()
        {
            if (teams.Count == 0)
            {
                Console.WriteLine("Herhangi bir takım bulunamadı.");
                return;
            }

            foreach (var team in teams)
            {
                team.DisplayInfo();
                Console.WriteLine(); // Takımlar arasında boşluk bırak
            }
        }

        // === Genel Sürücü Sıralaması ===
        static void DisplayDriverStandings()
        {
            var allDrivers = teams.SelectMany(t => t.Drivers).OrderByDescending(d => d.Points).ToList();

            Console.WriteLine("=== Genel Sürücü Sıralaması ===");
            foreach (var driver in allDrivers)
            {
                driver.DisplayInfo();
            }
        }

        // === Yarış Sonuçlarını Ekle ===
        static void AddRaceResults()
        {
            Console.Write("Kaç sürücünün sonucu girilecek? ");
            int driverCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < driverCount; i++)
            {
                Console.Write($"Sürücü {i + 1} Adı: ");
                string driverName = Console.ReadLine();

                var driver = teams.SelectMany(t => t.Drivers).FirstOrDefault(d => d.Name.Equals(driverName, StringComparison.OrdinalIgnoreCase));
                if (driver != null)
                {
                    Console.Write($"'{driver.Name}' için alınan puan: ");
                    int points = int.Parse(Console.ReadLine());
                    driver.Points += points;
                    Console.WriteLine($"{driver.Name} için toplam puan: {driver.Points}");
                }
                else
                {
                    Console.WriteLine("Hata: Sürücü bulunamadı!");
                }
            }
        }
    }
}