using CVM.NET.COM.Controllers;
using CVM.NET.COM.Models;
using System;
using System.Threading.Tasks;

namespace CVM.NET.COM
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Token lobj_token = new Token();
            string access_token = await lobj_token.ObtenerTokenAsync();


            Test lobj_test = new Test();

            UserResponse lobj_user = await lobj_test.ObtenerUserAsync(access_token);

            Console.WriteLine(lobj_user.userPrincipalName);
            Console.ReadKey(true);
        }
    }
}
