using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DeveloperInterviewPractical
{
    // Done
    #region * Abstract Implementation *
    // ********  Instructions 
    // Create a class called CSharpDeveloper that implements the Developer abstract class.
    // The new class will take in the developers name from the console on line 22 as a paramenter to the constructor and set the Name property
    // The StartCoding function will write out the developers name and a message about their code to the console.
    // For example:  If I enter Bob for the developers name, the output would be "Bob is writing C# code"
    // To execue the code, uncomment lines 38, 39, and 40, then execute the program.
    public abstract class Developer
    {
        protected string Name { get; set; }

        protected abstract string Language { get; }

        protected string OutputLine 
        { 
            get
			{
                string outLine = string.Format(
                    CultureInfo.InvariantCulture,
                    "{0} is writing {1}",
                    this.Name,
                    this.Language);

                return outLine;
			}
        }

        public abstract void StartCoding();
    }

    #endregion * Abstract Implementation *
}
