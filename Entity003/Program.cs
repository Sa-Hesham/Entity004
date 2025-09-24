using Entity003.Data;
using Entity003.Models;

namespace Entity003
{
    internal class Program
    {
        static void Main(string[] args)


        {
            using AireDbContext dbContext = new AireDbContext();

            #region Add Airline
            //dbContext.Set<AireLine>().Add(new AireLine
            //{

            //    AireLine_Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Adress = "Cairo",
            //    AirelinePhones = new List<Phones>
            //    {
            //        new Phones
            //        {
            //            Phonenumber ="0113654789"
            //        } ,

            //        new Phones
            //        {

            //            Phonenumber = "0123456789"
            //        }




            //   }





            //});
            //dbContext.SaveChanges();

            #endregion

            #region AddAirCraftData
            //dbContext.Set<AireCraft>().Add(new AireCraft
            //{

            //    AireLineOwnerId = 1,
            //    Model = "Model01",
            //    Capcity = 180,



            //    crewDetails = new Crew

            //    {
            //        MajorPilot = "ebrahim",
            //        AssitantPilot = "Hmada",
            //        Host1 = "Ola",
            //        Host2 = "Ayat"
            //    },
            //    //AireLineOwnerId=AireLine aireline.





            //});

            //dbContext.SaveChanges();

            #endregion

            //#region RecordTransaction
            //dbContext.Set<Transaction>().Add(

            //    new Transaction
            //    {


            //        discription = "Tickets",
            //        Amuont = 50000,
            //        Date = DateTime.Now,
            //        AireLineId = 1
            //    });

               
           
            //dbContext.SaveChanges();

           // #endregion
        }
    }
}
