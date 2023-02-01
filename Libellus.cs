using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

using Microsoft.AspNetCore.Builder;
using FrostSteelCorporation.Index;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;






namespace FrostSteelCorporation
{
    public class Libellus
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        

           


        }
      
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Nightmare>();










                });

 

    }
}
