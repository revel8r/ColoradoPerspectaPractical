using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperInterviewPractical
{
    // ********  Instructions 
    //Refactor the GetDogsBiggerThanWeight function to return all of the dog objects as a list where the Dog objects AverageWeight is greater than the minimumWeight parameter passed in.
    //This function should also sort the returning list by the BreedName.
    //The contents of the GetDogsBiggerThanWeight function should be no more than one line long and should not have an explicit loop I.e foreach(var d in DogBreeds){etc...}.	public class Dog
	public class Dog
	{
		public string BreedName { get; set; }
		public int AverageWeight { get; set; }
	}
}
