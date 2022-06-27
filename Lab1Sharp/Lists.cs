using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1Sharp
{
    internal class Lists
    {
        public List<Person> People { get; set; } = new List<Person>() 
        {
            new Person(){LicsenseNumber = 1234, Name = "Владислав", Surname = "Фiлiмоненков",
                Patronymic = "Олексiйович", BirthDate = "12.07.2003", RegisterAdress = "Темна, 12",
                Experience = 20},
            new Person(){LicsenseNumber =  2056, Name = "Максим", Surname = "Новицький",
                Patronymic = "Сергiйович", BirthDate = "02.02.2001", RegisterAdress = "Академiчна, 21",
                Experience = 27},
            new Person(){LicsenseNumber = 1956, Name = "Лiя", Surname = "Павленко",
                Patronymic = "Олегiвна", BirthDate = "20.08.2003", RegisterAdress = "Янгольська, 01",
                Experience = 18},
            new Person(){LicsenseNumber = 2789, Name = "Олександр", Surname = "Черненко",
                Patronymic = "Євгенович", BirthDate = "27.01.2003", RegisterAdress = "Райджу, 03",
                Experience = 20},
            new Person(){LicsenseNumber = 2543, Name = "Анастасiя", Surname = "Лiнчук",
                Patronymic = "Вадимiвна", BirthDate = "03.05.2003", RegisterAdress = "Темна, 12",
                Experience = 11},
            new Person(){LicsenseNumber = 3000, Name = "Олександр", Surname = "Юрченко",
                Patronymic = "Іванович", BirthDate = "04.11.2002", RegisterAdress = "Світла, 14",
                Experience = 18},
            new Person(){LicsenseNumber = 5069, Name = "Олександр", Surname = "Ворона",
                Patronymic = "Дмитрович", BirthDate = "04.07.2003", RegisterAdress = "Марiупольська, 20",
                Experience = 11},
            new Person(){LicsenseNumber = 8234, Name = "Надiя", Surname = "Булботка",
                Patronymic = "Вікторiвна", BirthDate = "01.10.2002", RegisterAdress = "Iфська, 09",
                Experience = 13},
            new Person(){LicsenseNumber = 5098, Name = "Денис", Surname = "Хропост",
                Patronymic = "Сергiйович", BirthDate = "02.10.2002", RegisterAdress = "Героїчна, 12",
                Experience = 19},
            new Person(){LicsenseNumber = 8592, Name = "Орест", Surname = "Главацький",
                Patronymic = "Сергiйович", BirthDate = "01.10.2002", RegisterAdress = "Іфська, 09",
                Experience = 25},
            new Person(){LicsenseNumber = 6078, Name = "Дар`я", Surname = "Колмичек",
                Patronymic = "Олексiiвна", BirthDate = "27.01.2003", RegisterAdress = "Марiупольська, 59",
                Experience = 18},
            new Person(){LicsenseNumber = 2390, Name = "Лев", Surname = "Лашин",
                Patronymic = "Олексiйович", BirthDate = "05.06.2003", RegisterAdress = "Хайпова, 98",
                Experience = 21}
        };

        public List<Transport> Cars { get; set; } = new List<Transport>()
        {
            new Transport(){CarID = 1001, MarkID = 1, ProducerID = 1, Model = "MX-3600",
                BodyID = 1, ChassisNumber = 67583, CarColor = Color.Black,
                Sign = "AA5156KA", StateID = 2, ManufactureYear = 2022},
            new Transport(){CarID = 1053, MarkID = 2, ProducerID = 2, Model = "AE-5670",
                BodyID = 2, ChassisNumber = 28423, CarColor = Color.Red,
                Sign = "BN8193AK", StateID = 2, ManufactureYear = 2021},
            new Transport(){CarID = 1009, MarkID = 3, ProducerID = 3, Model = "LK-9801",
                BodyID = 3, ChassisNumber = 47783, CarColor = Color.Blue,
                Sign = "MH7053LK", StateID = 1, ManufactureYear = 2002},
            new Transport(){CarID = 1089, MarkID = 4, ProducerID = 4, Model = "OI-5768",
                BodyID = 1, ChassisNumber = 38796, CarColor = Color.Red,
                Sign = "KW0183KL", StateID = 4, ManufactureYear = 1990},
            new Transport(){CarID = 1099, MarkID = 5, ProducerID = 2, Model = "HY-2308",
                BodyID = 2, ChassisNumber = 28423, CarColor = Color.White,
                Sign = "BN9223PL", StateID = 2, ManufactureYear = 2021},
            new Transport(){CarID = 1014, MarkID = 6, ProducerID = 3, Model = "LK-2361",
                BodyID = 3, ChassisNumber = 47783, CarColor = Color.Pink,
                Sign = "BT8753LK", StateID = 1, ManufactureYear = 2002},
            new Transport(){CarID = 1075, MarkID = 7, ProducerID = 4, Model = "PQ-0173",
                BodyID = 1, ChassisNumber = 38796, CarColor = Color.Gold,
                Sign = "NM5338YR", StateID = 4, ManufactureYear = 1990}
        };
        public List<PersonCarConnection> Connections { get; set; } = new List<PersonCarConnection>()
        {
            new PersonCarConnection(){RegistrationNumber = 1, PersonLicenseNumber = 1234, CarIDNumber = 1001,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 2, PersonLicenseNumber = 1234, CarIDNumber = 1053,
                isOwner = true  },
            new PersonCarConnection(){RegistrationNumber = 3, PersonLicenseNumber = 1234, CarIDNumber = 1009, 
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 4, PersonLicenseNumber = 2056, CarIDNumber = 1053,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 5, PersonLicenseNumber = 2056, CarIDNumber = 1009,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 6, PersonLicenseNumber = 1956, CarIDNumber = 1001,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 7, PersonLicenseNumber = 1956, CarIDNumber = 1009,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 8, PersonLicenseNumber = 2789, CarIDNumber = 1053,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 9, PersonLicenseNumber = 2543, CarIDNumber = 1089,
                isOwner = true },
            new PersonCarConnection(){RegistrationNumber = 10, PersonLicenseNumber = 5069, CarIDNumber = 1001,
                isOwner = false },
            new PersonCarConnection(){RegistrationNumber = 11, PersonLicenseNumber = 8234, CarIDNumber = 1001,
                isOwner = false },
            new PersonCarConnection(){RegistrationNumber = 12, PersonLicenseNumber = 5098, CarIDNumber = 1053,
                isOwner = false },
            new PersonCarConnection(){RegistrationNumber = 13, PersonLicenseNumber = 8592, CarIDNumber = 1053,
                isOwner = false },
            new PersonCarConnection(){RegistrationNumber = 14, PersonLicenseNumber = 6078, CarIDNumber = 1009,
                isOwner = false },
            new PersonCarConnection(){RegistrationNumber = 15, PersonLicenseNumber = 2390, CarIDNumber = 1089,
                isOwner = false }
        };                                                    
        public List<Country> Producers { get; set; } = new List<Country>()
        {
            new Country(){CountryID = 1, CountryName = "Japan"},
            new Country(){CountryID = 2, CountryName = "GB"},
            new Country(){CountryID = 3, CountryName = "France"},
            new Country(){CountryID = 4, CountryName = "USA"}
        };
        public List<Mark> Marks { get; set; } = new List<Mark>()
        {
            new Mark(){MarkID = 1, MarkName = "BMW"},
            new Mark(){MarkID = 2, MarkName = "Toyota"},
            new Mark(){MarkID = 3, MarkName = "Mercedes-Benz"},
            new Mark(){MarkID = 4, MarkName = "Bugati Veyron"}
        };
        public List<State> States { get; set; } = new List<State>()
        {
            new State(){StateID = 1, StateName = "Well"},
            new State(){StateID = 2, StateName = "Good"},
            new State(){StateID = 3, StateName = "Bad"},
            new State(){StateID = 4, StateName = "Terrible"}
        };
        public List<Body> Bodies { get; set; } = new List<Body>()
        {
            new Body(){BodyID = 1, BodyName = "Sedan"},
            new Body(){BodyID = 2, BodyName = "Universal"},
            new Body(){BodyID = 3, BodyName = "Minivan"}
        };
        public List<Mark> MoreMarks { get; set; } = new List<Mark>()
        {
            new Mark(){MarkID = 5, MarkName = "Tesla"},
            new Mark(){MarkID = 6, MarkName = "Volvo"},
            new Mark(){MarkID = 7, MarkName = "Lexus"}
        };
    }
}
