using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1Sharp
{
    internal class Queries
    {
        public IEnumerable<Transport> AllCars(List<Transport> cars)
        {
            return from c in cars
                   select c;
        }

        public IEnumerable<Transport> CarsWithYearMoreThatTwentyTen(List<Transport> cars) //# я думаю тут замінити на рік
        {
            return from car in cars where car.ManufactureYear > 2010 select car;
        }

        public IEnumerable<Person> OrderByLicenseDesc(List<Person> people)
        {
            return from p in people
                   orderby p.LicsenseNumber descending
                   select p;
        }

        public IEnumerable<Transport> CarsFromFrance(List<Transport> cars)
        {
            return cars
                .Where(car => car.ProducerID == 3);            
        }
        public IEnumerable<int> CarsWithExperiencedDrivers(List<Person> people, 
            List<PersonCarConnection> connections) 
        {
            var PersID = people.Where(pers => pers.Experience > 20).Select(pers => pers.LicsenseNumber);
            return connections
                .Join(PersID,
                con => con.PersonLicenseNumber,
                pers => pers,
                (con, pers) => con)
                .Where(con => !con.isOwner)
                .Select(con => con.CarIDNumber);
        }
        public Dictionary<int, List<Person>> OwnersByExperience(List<Person> people)
        {
            var res = from p in people
                   orderby p.Experience
                   group p by p.Experience;
            return res.ToDictionary(r => r.Key, r => r.ToList());
        }     
        public IEnumerable<Person>DriverMaxExp(List<Person> people,
            List<PersonCarConnection> connections)
        {
            var DriverID = connections
                .Join(people,
                con => con.PersonLicenseNumber,
                pers => pers.LicsenseNumber,
                (con, pers) => con)
                .Where(con => !con.isOwner)
                .Select(con => con.PersonLicenseNumber) 
                .Distinct();
            int MaxExp = DriverID
                .Join(people,
                drive => drive,
                pers => pers.LicsenseNumber,
                (drive, pers) => pers.Experience).Max();
            return people.Where(pers => pers.Experience == MaxExp);
        }
        public IEnumerable<Transport> CarsInCertainChassis(List<Transport> cars)
        {
            return from car in cars
                   where car.ChassisNumber >= 30000 && car.ChassisNumber <= 60000
                   select car;
        }
        public IEnumerable<Person> PersonsWithExpLessThanAverage(List<Person> people)
        {
            var AvgExp = people.Select(p => p.Experience).Average();
            return people.Where(pers => pers.Experience <= AvgExp);
        }
        public IEnumerable<Mark> MarksWithTwoWords(List<Mark> marks) 
        {
            return marks.Where(mark => mark.MarkName.Contains(' '));                
        }
        public IEnumerable<Transport> CarsOwnersExpMoreThanNumber(List<Transport> cars, List<Person> people,
            List<PersonCarConnection> connections, int number)
        {
            var ownersNum = people
                .Where(pers => pers.Experience >= number)
                .Select(pers => pers.LicsenseNumber);

            var carsNum = connections
                .Where(con => con.isOwner)
                .Join(ownersNum,
                con => con.PersonLicenseNumber,
                owners => owners,
                (con, owners) => con.CarIDNumber)
                .Distinct();

            return cars
                .Join(carsNum,
                car => car.CarID,
                cons => cons,
                (car, cons) => car);
        }
        public Dictionary<int, List<Person>> OwnersGroupingWithDriverMoreExp(List<Transport> cars,
            List<Person> people, List<PersonCarConnection> connections, int number) 
        {
            var cardrivers = connections
                .Where(con => !con.isOwner)
                .Join(people.Where(pers => pers.Experience >= number),
                cons => cons.PersonLicenseNumber,
                pers => pers.LicsenseNumber,
                (cons, cardr) => cons.CarIDNumber);

            var licenses = connections
                .Where(con => con.isOwner)
                .Join(cardrivers,
                cons => cons.CarIDNumber,
                cardr => cardr,                
                (cons, cardr) => cons.PersonLicenseNumber);

            var exp = people
                .Join(licenses,
                pers => pers.LicsenseNumber,
                lic => lic,
                (pers, lic) => pers)
                .GroupBy(pers=>pers.Experience);
            return exp.ToDictionary(ex => ex.Key, ex => ex.ToList());
        }
        public IEnumerable<Person> OwnersWithBlueAndRedCars(List<Transport> cars, List<Person> people,
            List<PersonCarConnection> connections) 
        {
            var rightcarid = from car in cars
                       where car.CarColor == Color.Blue || car.CarColor == Color.Red
                             select car.CarID;

            var rightlicense = from cons in connections
                       where (cons.isOwner)
                       join rightids in rightcarid on cons.CarIDNumber equals rightids
                       select cons;

            var rightowners = from pers in people
                   join rightlic in rightlicense on pers.LicsenseNumber equals rightlic.PersonLicenseNumber
                   orderby pers.Name
                   select pers;
            return rightowners.Distinct();
        }
        public IEnumerable<Person> DriversOfRightOwners(List<Transport> cars, List<Person> people,
            List<PersonCarConnection> connections)  
        {
            var rightcarid = from pers in people
                               where pers.LicsenseNumber >= 2500
                               join cons in connections on pers.LicsenseNumber equals cons.PersonLicenseNumber
                               where cons.isOwner
                               select cons.CarIDNumber;            

            var rightdriversid = from con in connections
                            where !con.isOwner
                            join rightcar in rightcarid on con.CarIDNumber equals rightcar
                            select con.PersonLicenseNumber;

            return from pers in people
                   join rightdriver in rightdriversid on pers.LicsenseNumber equals rightdriver
                   select pers;
        }
        public IEnumerable<Person> RedCarDriversID(List<Transport> cars, List<Person> people,
            List<PersonCarConnection> connections) 
        {
            var rightdriverid = cars.Where(car => car.CarColor == Color.Red)
                .Join(connections.Where(con => !con.isOwner),
                car => car.CarID,
                con => con.CarIDNumber,
                (car, con) => con.PersonLicenseNumber);

            return people
                .Join(rightdriverid,
                pers => pers.LicsenseNumber,
                rd => rd,
                (pers, rd) => pers);
        }
        public IEnumerable<Person> MaxAndMinExp(List<Person> people)
        {
            var MaxExp = people.Where(pers => pers.Experience.Equals(people.Select(pers => pers.Experience).Max()));
            var MinExp = people.Where(pers => pers.Experience.Equals(people.Select(pers => pers.Experience).Min()));
            return MaxExp.Concat(MinExp);
        }
    }
}
