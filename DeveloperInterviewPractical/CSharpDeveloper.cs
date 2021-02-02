using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperInterviewPractical
{
	public class CSharpDeveloper : Developer
	{
		protected override string Language
		{
			get
			{
				return "C#";
			}
		}

		public CSharpDeveloper(string input)
		{
			this.Name = input;
		}

		public override void StartCoding()
		{
			Console.WriteLine(this.OutputLine);
		}
	}
}
