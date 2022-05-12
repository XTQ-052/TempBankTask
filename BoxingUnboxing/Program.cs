using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank
            {
                Name = "KapitalBank",
                Budget = 5000000,
                Profit = 250000,
                CEO = new CEO
                {
                    Name = "Tural",
                    Surname = "Novruzlu",
                    Age = 29,
                    Position = "CEO",
                    Salary = 10000
                },
                Workers = new Worker[]
                {
                    new Worker
                    {
                        Name = "samir",
                        Surname = "mammadov",
                        Age = 20,
                        Position = "Developer",
                        Salary = 1500,
                        StartTime = new DateTime(2021, 12, 12),
                        EndTime = new DateTime(2022, 12, 12),
                        Operations = new Operation[]
                        {
                            new Operation
                            {
                                OperationName = "Operation1",
                                DateTime = new DateTime()
                            },
                            new Operation
                            {
                                OperationName = "Operation2",
                                DateTime = new DateTime()
                            }
                        }
                    },
                    new Worker
                    {
                        Name = "worker",
                        Surname = "workerov",
                        Age = 66,
                        Position = "Senior Developer",
                        Salary = 5800,
                        StartTime = new DateTime(2021, 12, 12),
                        EndTime = new DateTime(2022, 12, 12),
                        Operations = new Operation[]
                        {
                            new Operation
                            {
                                OperationName = "Operation2.1",
                                DateTime = new DateTime()
                            },
                            new Operation
                            {
                                OperationName = "Operation2.2",
                                DateTime = new DateTime()
                            }
                        }
                    }
                },
                Managers = new Manager[]
                 {
                     new Manager
                     {
                          Name = "test1",
                          Surname = "test1",
                          Age = 23,
                          Position = "Manager",
                          Salary = 2000
                     },
                     new Manager
                     {
                          Name = "test2",
                          Surname = "test2",
                          Age = 25,
                          Position = "Manager",
                          Salary = 3000
                     }
                 },
                Clients = new Client[]
                 {
                     new Client
                     {
                          Name = "client1_name",
                          Surname = "client1_surname",
                          Age = 38,
                          Salary = 2000,
                          LiveAddress = "Sumgayit",
                          WorkAddress = "Baku"
                     },
                     new Client
                     {
                          Name = "client2_name",
                          Surname = "client2_surname",
                          Age = 30,
                          Salary = 1400,
                          LiveAddress = "Baku",
                          WorkAddress = "Sumgayit"
                     }
                 }
            };

            Console.WriteLine(bank.CEO);

            Console.ReadKey();
        }
    }
}