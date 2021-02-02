using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperInterviewPractical
{
    #region * Alert Service *
    // ********  Instructions 
    //Refactor the AlertService and AlertDAO classes to implement Inversion of Control/Dependency Injection:
    //Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.
    //AlertDAO should implement the IAlertDAO interface.
    //AlertService should have a constructor that accepts IAlertDAO and assigns the local storage variable to the injected object.
    //The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.
    //Uncomment lines 45-50 to execute this class implementation.

    public class AlertService
    {
        private readonly IAlertDAO storage = null;

        public AlertService(IAlertDAO dao)
		{
            this.storage = dao;
		}

        public Guid RaiseAlert()
        {
            return this.storage.AddAlert(DateTime.Now);
        }

        public Guid RaiseAlert(DateTime time)
        {
            return this.storage.AddAlert(time);
        }

        public DateTime GetAlertTime(Guid id)
		{
			return this.storage.GetAlert(id);
		}
	}

	#endregion  * Alert Service *
}
