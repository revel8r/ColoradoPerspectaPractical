using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DeveloperInterviewPractical
{
    public class Program
    {
        #region * Dog Breeds *

        private static readonly List<Dog> DogBreeds = new List<Dog>();

        public static List<Dog> GetDogsBiggerThanWeight(int minimumWeight)
        {
            var breeds = (from db in DogBreeds where db.AverageWeight > minimumWeight select db).OrderBy(db => db.BreedName).ToList<Dog>();

            return (breeds);
        }

        #endregion * Dog Breeds *
        
        // ********   Instructons ***********
        // Follow the instructions in each region below to implement/change the code to meet the objective.
        // Thre are 7 implementation challenges to complete.
        // When you run the application, you will see console output with the status of each implementation.


        static void Main(string[] args)
        {
			// ***********  CAUTION *************
			// ***********  CAUTION *************
			// Do not modify this method other than uncommenting lines, otherwise the application will not run propperly.
			// ***********  CAUTION *************
			// ***********  CAUTION *************

			Console.WriteLine("**********  DrawHourglass Start **********");
			DrawHourglass();
			Console.WriteLine("**********  DrawHourglass End **********");
			Console.WriteLine("");
			Console.WriteLine("");

			Console.WriteLine("**********  Fibonacci Sequence Start **********");
			FibonacciSequence(0, 1, 0);
			Console.WriteLine("**********  Fibonacci Sequence End **********");
			Console.WriteLine("");
			Console.WriteLine("");

			Console.WriteLine("**********  Abstract Implementation Start **********");
			Console.WriteLine("Enter a developers name, then enter:");
			Developer d = new CSharpDeveloper(Console.ReadLine());
			d.StartCoding();
			Console.WriteLine("**********  Abstract Implementation End **********");
			Console.WriteLine("");
			Console.WriteLine("");

			Console.WriteLine("**********  Alert Service Start **********");
			IAlertDAO alertDAO = new AlertDAO();
			var alertService = new AlertService(alertDAO);
			Guid alert1 = alertService.RaiseAlert();
			Guid alert2 = alertService.RaiseAlert(); //// Recommend: alertService.RaiseAlert(DateTime.Now.AddDays(2));
			Console.WriteLine(alertService.GetAlertTime(alert1).ToString("o"));
			Console.WriteLine(alertService.GetAlertTime(alert1).ToString("o")); //// Did you mean alert2? 
			Console.WriteLine("**********  Alert Service End **********");
			Console.WriteLine("");
			Console.WriteLine("");

			Console.WriteLine("**********  Dog Breeds Start **********");
            DogBreeds.Add(new Dog() { BreedName = "Weimaraners", AverageWeight = 80 });
            DogBreeds.Add(new Dog() { BreedName = "Poodle", AverageWeight = 65 });
            DogBreeds.Add(new Dog() { BreedName = "Beagle", AverageWeight = 25 });
            DogBreeds.Add(new Dog() { BreedName = "Lab", AverageWeight = 95 });
            DogBreeds.Add(new Dog() { BreedName = "Affenpinschers", AverageWeight = 8 });
            DogBreeds.Add(new Dog() { BreedName = "Great Danes", AverageWeight = 155 });
            DogBreeds.Add(new Dog() { BreedName = "Boxer", AverageWeight = 70 });
            DogBreeds.Add(new Dog() { BreedName = "Bullmastiffs", AverageWeight = 120 });
            DogBreeds.Add(new Dog() { BreedName = "Maltese", AverageWeight = 5 });
            DogBreeds.Add(new Dog() { BreedName = "Samoyeds", AverageWeight = 50 });
            var breeds = GetDogsBiggerThanWeight(50);
            foreach (var b in breeds)
            {
                Console.WriteLine(b.BreedName + ": " + b.AverageWeight);
            }
            Console.WriteLine("**********  Dog Breeds End **********");
            Console.WriteLine("");
            Console.WriteLine("");

            ////Console.WriteLine("**********  Game Start  **********");
            ////Game g = new Game() { Name = "", Price = 120 };
            ////if (!Validate(g, out ICollection<ValidationResult> validationResults))
            ////{
            ////    if (validationResults.Where(o => o.MemberNames.Contains("Name")).Count() == 1 && validationResults.Where(o => o.MemberNames.Contains("Price")).Count() == 1)
            ////    {
            ////        Console.WriteLine(String.Join("\n", validationResults.Select(o => o.ErrorMessage)));
            ////        Console.WriteLine("This is the expected result");
            ////    }
            ////}
            ////else
            ////{
            ////    Console.WriteLine("The Game is Valid, this is not the expected result.");
            ////}
            ////Console.WriteLine("**********  Game End  **********");
            ////Console.WriteLine("");
            ////Console.WriteLine("");

            ////Console.WriteLine("**********  XML Parsing Start  **********");

            ////string xmlresults = GetXmlValue("releaseDate");
            ////xmlresults = GetXmlValue("author");
            ////if (GetXmlValue("releaseDate").Equals("1945") && GetXmlValue("author").Equals("George Orwell") && GetXmlValue("BadElement") == null)
            ////{
            ////    Console.WriteLine("XML Parsing is successful");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("XML Parsing Failed");
            ////}
            ////Console.WriteLine("**********  XML Parsing End  **********");


            ////Console.WriteLine("");
            ////Console.WriteLine("");

            ////Console.WriteLine("Press any Key to end");
            ////Console.ReadKey();
        }

        // Done
        #region * Draw Hourglass *
        // ********  Instructions
        // Implement the DrawHourglass function to generate the following output into the console window.
        //Note:  the intial // are there for comment purposes.
        //***********
        // *********
        //  *******
        //   *****
        //    ***
        //     *
        //    ***
        //   *****
        //  *******
        // *********
        //***********
        private static void DrawHourglass()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("             ***********");
            Console.WriteLine("              *********");
            Console.WriteLine("               *******");
            Console.WriteLine("                *****");
            Console.WriteLine("                 ***");
            Console.WriteLine("                  *");
            Console.WriteLine("                 ***");
            Console.WriteLine("                *****");
            Console.WriteLine("               *******");
            Console.WriteLine("              *********");
            Console.WriteLine("             ***********");
            Console.WriteLine(Environment.NewLine);
        }
        #endregion * Draw Hourglass *

        // Done
        #region * Fibonacci Sequence *
        // ********  Instructions
        //Implement the FibonacciSequence function to generate the Fibonacci sequence out to the console.
        //This function will stop calling after 10 interations.
        //The implementation of this function cannot use any loops and can only use if/else statements and/or recursive calls.
        //The Fibonacci sequence is 0,1,1,2,3,5,8,13,21,34 .. The next number is generated by adding the previous 2 numbers
        //The expected output is 0,1,1,2,3,5,8,13,21,34

        private const int maxCount = 10;

        private static void FibonacciSequence(int val1, int val2, int callCount)
        {
            if (callCount < maxCount)
            {
                int newVal1 = val1 + val2;

                Console.WriteLine(val1);

                callCount++;

                FibonacciSequence(val2, newVal1, callCount);
            }
        }

        #endregion * Fibonacci Sequence *

        // Abstract implementation done; separated into separate class files.

        // Alert Service implementation done; separated into separate class files.

        // Dogbreeds implementation done; separated into separate class files.

        #region * Games *
        // ********  Instructions 
        // Apply Data Annotations to the Game class properties to meet the following requirements.
        // Name is a required field.
        // Price must be between 0 and 100
        public class Game
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        static bool Validate<T>(T obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
        }
        #endregion * Games *

        #region * XML Parsing *
        // ********  Instructions 
        // Given the following xml string, fill out the contents of the GetXmlValue function so it returns the
        // correct value in the xml based on the element name or attribute name passed into the function.
        // If the element name or attribute name does not exist, the function should return null
        // for example if the value "name" is passed into the function the funtion will return "Animal Farm"

        //private static readonly string xmlContent = "<book isHarback=\"true\" releaseDate=\"1945\"><name>Animal Farm</name><author>George Orwell</author><price>14.19</price></book>";

        public static string GetXmlValue( string elementOrAttributeName)
        {
            string retVal = string.Empty;

            return retVal;
        }

        #endregion * XML parsing *
    }
}
