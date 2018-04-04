using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.KKB.Module;
using GeneratorName;
namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client Client01 = new Client();
                Service.CreateClients(ref Client01, "111111111111", "Client@mail.net", "Client", "Clients", "+77052261814");
                string log, pas;

                while (!Client01.isBlocked)
                {
                    Console.Clear();
                    Console.Write("Enter LOGIN && PASSWORD ");
                    log = Console.ReadLine();
                    pas = Console.ReadLine();
                    if (Client01.Log != log || Client01.Pass != pas)
                        Client01.WRONGENTER++;
                    else break;
                    if (Client01.isBlocked)
                    {
                        Console.WriteLine("BLOCKED");
                        return;     
                    }
                        

                }


                Console.WriteLine("Вы успешно законнектились");
                Console.ReadLine();

                int menu;
                
                while (true)
                {
                    Console.WriteLine("1 - Просмотре балансов \n2- Добавить счет\n 3 - выход");
                    Int32.TryParse(Console.ReadLine(), out menu);
                    switch (menu)
                    {   
                        case 1:
                            Console.Clear();
                            Client01.ShowAccountInfo();
                            
                            break;
                        case 2:
                            Client01.Accounts.Add(Service.CreateAccounts());
                            Console.WriteLine("cчет добавлен");

                            break;
                        default:
                            return;
                    }

                    Console.ReadLine();
                    Console.Clear();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }









            Generator RandName = new Generator();
            List<Client> Clients = new List<Client>();
            Clients.Add(new Client()
            {

                FName = RandName.GenerateDefault(Gender.woman),
                DOB = DateTime.Now.AddYears(-60),
                Log = "ClientList1",
                Pass = "Passw1",
                PhoneNumber = "8747545545",

            });

            Console.ReadLine();

        }
    }
}
