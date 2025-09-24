using Entity003.Data;
using Entity003.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entity003.DatatSeeding
{
    public static class Seedingdata
    {


       public static bool dataseeding<T>(string filebath ,AireDbContext dbContext) where T : class
        {
            
        if(!File.Exists(filebath)) throw  new FileNotFoundException("The specified file was not found.", filebath);

        string file = File.ReadAllText(filebath);
            if (string.IsNullOrEmpty(file)) return false;

          






            if (dbContext.Set<T>().Any()) return false;





            var option = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };


            var AireLineData = JsonSerializer.Deserialize<List<T>>(file, option);

            if (AireLineData == null || AireLineData.Count == 0) return false;



            dbContext.Set<T>().AddRange(AireLineData);
            dbContext.SaveChanges();
            return true;
        }
    }
}
