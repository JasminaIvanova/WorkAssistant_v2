using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;

namespace WorkAssistantFV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MicronConfig config = new MicronConfig()
            {
                DatabaseName = "WorkAssistant",
                Host = "127.0.0.1",
                User = "root",
                Password = "0000",
                Port = "3306"
            };
            MicronDbContext db = new MicronDbContext("config");
            MicronDbContext.AddConnectionSetup(config);
            var micron = new MicronDbContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TestDbContext dbContext = new TestDbContext();
            
            Application.Run(new WorkAssistant());
           

         
        }
        public static string CalculateMD5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
