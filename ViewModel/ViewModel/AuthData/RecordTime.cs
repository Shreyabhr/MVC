using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewModel.AuthData
{
    public class RecordTime : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            RecordLogTime();
        }

        private void RecordLogTime()
        {
            Debug.WriteLine("Action filter "+ DateTime.Now, "Action Filter Log");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            RecordLogTime();
        }
    }
    
}