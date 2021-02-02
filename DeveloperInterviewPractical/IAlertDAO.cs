using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperInterviewPractical
{
	public interface IAlertDAO
	{
		Guid AddAlert(DateTime time);

		DateTime GetAlert(Guid id);
	}
}
