using AutoItX3Lib;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.stepdefinitions
{
    [Binding]
    public class AddPatientsSteps
    {
       
        AutoItX3 obj;
        String title = "Control Room";

        [Given(@"No patient is admitted")]
        public void GivenNoPatientIsAdmitted()
        {

        }

        [Given(@"Hemo Application is launched")]
        public void GivenHemoApplicationIsLaunched()
        {
            obj = new AutoItX3();
            string title = "Control Room";

            if (obj.WinExists(title, "") == 0)
            {
                obj.Run(@"C:\NextXperFlexCardio\HemoApp.exe", "", obj.SW_SHOW);
                obj.WinWait(title, "", 15);
            }

            else
            {
                obj.WinActivate("Control Room", "");
            }

            click(obj, "Addmit Patient", 31, 66);
            click(obj, "Scheduled patient category", 351, 86);
            click(obj, "Add Patient Button", 555, 301, 10);
        }

        [When(@"user admits and starts a patient with (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void WhenUserAdmitsAndStartsAPatientWithAlexAndJohnAndAndTestAnd(string lastname, string firstname, int mrn, string weight, string height)
        {
            setText(obj, "Last name ", 758, 62, "Jhon");
            setText(obj, "First name ", 767, 93, "Alex");
            setText(obj, "Comments ", 1146, 545, "Cooments");
            obj.Send("{TAB}");
            obj.Send("{TAB}");
            obj.Send("{TAB}");
            obj.Send("{ENTER}");

        }

        [Then(@"user verifies that the task of the philips Hemodynamic application is set to monitoring")]
        public void ThenUserVerifiesThatTheTaskOfThePhilipsHemodynamicApplicationIsSetToMonitoring()
        {

        }

        [Then(@"user verifies the default layout for the procedure is applied")]
        public void ThenUserVerifiesTheDefaultLayoutForTheProcedureIsApplied()
        {

        }

        public static void click(AutoItX3 obj, string objectname, int xCoor, int yCoor, int wait = 10)
        {
            Console.WriteLine("Click on " + objectname);
            if (wait > 0)
            {
                obj.Sleep(wait);
            }
            obj.MouseClick("LEFT", xCoor, yCoor, 2);

        }

        public static void setText(AutoItX3 obj, string objectname, int xCoor, int yCoor, string value, int wait = 10)
        {
            Console.WriteLine("Enter data in  " + objectname);
            if (wait > 0)
            {
                obj.Sleep(wait);
            }
            obj.MouseClick("LEFT", xCoor, yCoor, 1);
            obj.Send(value);

        }
    }
}