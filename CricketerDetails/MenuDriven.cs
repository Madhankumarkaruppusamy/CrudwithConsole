using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using DapperDataAccessLayer;


namespace CricketerDetails
{
    class MenuDriven
    {

        List<Cricketer> run = new List<Cricketer>();
        private readonly ICricketer _obje = null;


        public MenuDriven()
        {
            _obje = new CricketerRepos();
        }
        public void menu()
        {

            int choice;

            do
            {
                Console.WriteLine("1.READ");
                Console.WriteLine("2.INSERT");
                Console.WriteLine("3.UPDATE");
                Console.WriteLine("4.DELETE");
                Console.WriteLine("5.EX it");
                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {

                            var Score = _obje.ReadSP();
                            Console.WriteLine($"ID\tCricketerName\tTotalODI\tTotalScore\t Fifties\tHundreds");
                            foreach (var p in Score)

                            {
                                Console.WriteLine($"{p.CricketerId} \t{p.CricketerName}\t \t{p.TotalODI}\t \t{p.TotalScore}\t  \t {p.Fifties}\t \t{p.Hundreds}");
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Num of Players");
                            int noc = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < noc; i++)
                            {
                                Cricketer details = new Cricketer();
                                Console.WriteLine("Enter Player Name");
                                details.CricketerName = Console.ReadLine();
                                Console.WriteLine("Total ODI");
                                details.TotalODI = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Total Score");
                                details.TotalScore = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Fifties");
                                details.Fifties = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Hundreds");
                                details.Hundreds = Convert.ToInt64(Console.ReadLine());
                                run.Add(details);
                                _obje.InsertSP(details);
                                var score = _obje.ReadSP();
                                Console.WriteLine($"ID    \tCricketerName\tTotalODI\tTotalScore\t Fifties\tHundreds");
                                foreach (var p in score)

                                {
                                    Console.WriteLine($"{p.CricketerId} \t{p.CricketerName}\t \t{p.TotalODI}\t \t{p.TotalScore}\t  \t {p.Fifties}\t \t{p.Hundreds}");
                                }
                            }

                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter number to Update Player");
                            long cricketerId = Convert.ToInt64(Console.ReadLine());
                            Cricketer neu = new Cricketer();
                            Console.WriteLine("Enter Player Name");
                            neu.CricketerName = Console.ReadLine();
                            Console.WriteLine("Total ODI");
                            neu.TotalODI = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Total Score");
                            neu.TotalScore = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Fifties");
                            neu.Fifties = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Hundreds");
                            neu.Hundreds = Convert.ToInt64(Console.ReadLine());
                            _obje.UpdateSP(cricketerId, neu);

                            var Score = _obje.ReadSP();
                            Console.WriteLine($"ID    \tCricketerName\tTotalODI\tTotalScore\t Fifties\tHundreds");
                            foreach (var p in Score)

                            {
                                Console.WriteLine($"{p.CricketerId} \t{p.CricketerName}\t \t{p.TotalODI}\t \t{p.TotalScore}\t  \t {p.Fifties}\t \t{p.Hundreds}");
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter num to Delete Player");
                            long delet = Convert.ToInt64(Console.ReadLine());
                            _obje.DeleteSP(delet);
                            var Score = _obje.ReadSP();
                            Console.WriteLine($"ID    \tCricketerName\tTotalODI\tTotalScore\t Fifties\tHundreds");
                            foreach (var p in Score)

                            {
                                Console.WriteLine($"{p.CricketerId} \t{p.CricketerName}\t \t{p.TotalODI}\t \t{p.TotalScore}\t  \t {p.Fifties}\t \t{p.Hundreds}");
                            }

                            break;
                        }
                    
                        
                    
                    case 5:
                        {
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice[Choice Wisely]");
                            break;

                        }

                }

            } while (5 != choice);
        }
    }
}

