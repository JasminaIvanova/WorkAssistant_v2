using Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkAssistantFV.ViewModel;
using System;
using System.Windows.Forms;    

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void User_With_Correct_Username_And_Pass_Should_Login_Successfully()
        {
            WorkAssistantFV.WorkAssistant Form1 = new WorkAssistantFV.WorkAssistant();
            Form1.Show();
            
            

        }
    }
}
