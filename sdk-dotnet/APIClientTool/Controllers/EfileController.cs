using APIClientTool.Utilities;
using APIClientTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIClientTool.Controllers
{
    public class EfileController : Controller
    {

        #region Get Form W-2 EFile Status
        /// <summary>
        /// Get Form W-2 EFile Status
        /// </summary>
        /// <returns></returns>
        public ActionResult _GetEFileStatus()
        {
            return PartialView(APISession.GetAPIResponse());
        }
        #endregion

        #region  EFile Status
        /// <summary>
        /// Function loads list of all SubmissionIds created in Form941Return page
        /// </summary>
        /// <returns>List of all SubmissionIds</returns>
        public ActionResult EFileStatus()
        {
            return View(APISession.GetAPIResponse());
        }
        #endregion

        #region Get Form 941 EFile Status
        /// <summary>
        /// Get Form 941 EFile Status
        /// </summary>
        /// <returns></returns>
        public ActionResult _GetForm941EFileStatus()
        {
            return PartialView(APISession.GetForm941APIResponse());
        }
        #endregion

        #region Get Form 941 SCHR EFile Status
        /// <summary>
        /// Get Form 941 SCHR EFile Status
        /// </summary>
        /// <returns></returns>
        public ActionResult _GetForm941SCHREFileStatus()
        {
            return PartialView(APISession.GetForm941SCHRAPIResponse());
        }
        #endregion

    }
}