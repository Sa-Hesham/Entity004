using Entity003.ClassConfugurations;
using Entity003.Data;
using Entity003.DatatSeeding;
using Entity003.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection.Metadata.Ecma335;

namespace Entity003
{
    internal class Program
    {
        static void Main(string[] args)


        {

            using AireDbContext dbContext = new AireDbContext();

            #region seedingData

            //bool data = false;



            //try
            //{
            //    //Seedingdata.dataseeding<AireLine>("Files/airlines_with_names.json", dbContext);
            //    //data= Seedingdata.dataseeding<Employee>("Files/employees_300_airlines.json", dbContext);
            //    //data= Seedingdata.dataseeding<AireCraft>("Files/AireCraft.json", dbContext);
            //    // data = Seedingdata.dataseeding<Route>("Files/Route.json", dbContext);
            //    // data = Seedingdata.dataseeding<AireCraftRoute>("Files/aireCraftRoute.json", dbContext);
            //    //  data = Seedingdata.dataseeding<Qualifacion>("Files/EmployeeQualifications (1).json", dbContext);
            //      data = Seedingdata.dataseeding<Transaction>("Files/trans.json", dbContext);



            //}

            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine(" File not found: " + ex.FileName);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error while seeding Airlines: {ex.Message}");



            //}


            //if (data)
            //{

            //    Console.WriteLine(" Airlines data saved successfully.");
            //}
            //else
            //{
            //    Console.WriteLine(" Airlines data not saved.");
            //}


            #endregion



            #region SectionA

            // 1.Load "EgyptAir" With all its aircrafts and their routes

            //var travel = dbContext.Set<AireLine>().Where(A => A.AireLine_Name == "EgyptAir")
            //                                      .Include(A => A.airecraftsOwned)
            //                                      .ThenInclude(Air => Air.AireCraftAssign)
            //                                      .ThenInclude(c => c.Routes);
            //Console.WriteLine($"Egypt Aire company has ==> ");
            //foreach (var item in travel) {


            //    foreach(var aircraft in item.airecraftsOwned)
            //    {
            //        Console.WriteLine($"AirecraftModesl {aircraft.Model}");
            //        foreach (var assign in aircraft.AireCraftAssign) 
            //        {

            //            var route = assign.Routes; 
            //            Console.WriteLine($"    Route: {route.Origin} -> {route.Distnation}, Distance: {route.Distance}");




            //        }
            //    }


            //}



            ///// 2.Retrieve all airlines with their employees, and for each
            /////employee load their qualifications.



            ////var aireline = dbContext.Set<AireLine>().ToList();


            ////if (aireline is not null ){

            ////    foreach (var line in aireline)
            ////    {

            ////        Console.WriteLine($"Aireline name = {line.AireLine_Name}");


            ////        dbContext.Entry(line) // entry take one obj not list 
            ////       .Collection(E => E.employeesworks).Load();

            ////        foreach (var employee in line.employeesworks)
            ////        {
            ////            Console.WriteLine($"Emloyess name are  works in  {employee.Name}");

            ////            dbContext.Entry(employee)
            ////                .Collection(Q=>Q.EmpQualifications).Load();
            ////            foreach(var qualifacion in employee.EmpQualifications)
            ////            {
            ////                Console.WriteLine($"qualifications are {qualifacion.Qualificatons}");


            ////            }

            ////        }


            ////        Console.WriteLine("#######################################################");
            ////    }

            ////}



            //            3.Load all airlines with their transactions, but only include
            //transactions where Amount > 10000

            //var airlines = dbContext.Set<AireLine>()
            //                        .Include(a => a.transactions.Where(t => t.Amuont > 4000))
            //                        .ToList();

            //foreach (var airline in airlines)
            //{
            //    Console.WriteLine($"===============================");
            //    Console.WriteLine($"Aireline name = {airline.AireLine_Name}");

            //    if (airline.transactions.Any())
            //    {
            //        foreach (var trans in airline.transactions)
            //        {
            //            Console.WriteLine($"\tTransaction Amount: {trans.Amuont}, Date: {trans.Date:yyyy-MM-dd}, Description: {trans.discription}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\tNo transactions above 10000.");
            //    }
            //}





            // 4.Select all routes along with the model of aircrafts assigned
            //  to them


            //var aircraft = dbContext.Set<AireCraft>().ToList();

            //foreach (var aircraftItem in aircraft) {

            //    Console.WriteLine($"airecaftmodel = {aircraftItem.Model}");

            //    dbContext.Entry(aircraftItem)
            //         .Collection(a => a.AireCraftAssign).Load();
            //    foreach (var assign in aircraftItem.AireCraftAssign)
            //    {
            //        Console.WriteLine($"arrival {assign.Arrival} price = {assign.Price:C}  depature = {assign.Departure} duration = {assign.Duration}");

            //        dbContext.Entry(assign)
            //            .Reference(r=>r.Routes).Load();

            //        Console.WriteLine($"route = {assign.Routes.Origin}  distinaion ={assign.Routes.Distnation}  distance = {assign.Routes.Distnation}");

            //    }

            //    Console.WriteLine("-------------------------------------------------------------------");

            //}



            #endregion



            #region Section-B

            //1.List all employees with their airline name.

            //var airlineNameWithEmployee = dbContext.Set<AireLine>()
            //    .GroupJoin(dbContext.Set<Employee>(),
            //    aireline => aireline.AireLineId,
            //    emp => emp.EmpId,
            //    (aireline, employes) => new
            //    {

            //        AireLineName = aireline.AireLine_Name,
            //        employes




            //    });


            //var airlineNameWithEmployee = from a in dbContext.Set<AireLine>()
            //                              join e in (dbContext.Set<Employee>())
            //                              on a.AireLineId equals e.EmpId into groups
            //                              select new
            //                              {
            //                                  airlinename = a.AireLine_Name,
            //                                  employees =groups


            //                              };











            //foreach (var airline in airlineNameWithEmployee) {

            //    Console.WriteLine($"AireLine name ===> {airline.airlinename}");
            //    foreach (var item in airline.employees)
            //    {
            //        Console.WriteLine($"Employess Name ={item.Name} ----- employeeID{item.EmpId} ");
            //    }

            //}


            //            2.Show all routes with the aircraft model assigned and the
            //airline name that owns the aircraft.

            //var result = from a in dbContext.Set<AireLine>()
            //             join c in dbContext.Set<AireCraft>()
            //             on a.AireLineId equals c.AireLineOwnerId
            //             join airrou in dbContext.Set<AireCraftRoute>()
            //             on c.Id equals airrou.AireCraftId
            //             join ro in dbContext.Set<Route>()
            //          on airrou.RouteId equals ro.RouteId
            //             select new
            //             {

            //                 AirlineName = a.AireLine_Name,
            //                 AircraftModel = c.Model,
            //                 AirCraftRouteId = airrou.AireCraft.Model,
            //                 RouteName = ro.Origin

            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Airline: {item.AirlineName}, Aircraft: {item.AircraftModel}, AirCraftRouteID: {item.AirCraftRouteId}, Route: {item.RouteName}");
            //}


            //  3.For each airline, list its aircraft models.



           // 4.Show all transactions(id, amount, description) along with the
//airline name, but only where Amount > 20000.


            //var result = from t in dbContext.Set<Transaction>()
            //             join a in dbContext.Set<AireLine>()
            //             on t.AireLineId equals a.AireLineId
            //             where t.Amuont> 20000
            //             select new
            //             {
            //                 TransactionId = t.TransactId,
            //                 Amount = t.Amuont,
            //                 Description = t.discription,
            //                 AirlineName = a.AireLine_Name
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"TransactionID: {item.TransactionId}, Amount: {item.Amount}, Description: {item.Description}, Airline: {item.AirlineName}");
            //}



            #endregion




        }
    }
}
