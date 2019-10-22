using APIClientTool.ViewModels;
using APIClientTool.ViewModels.Form941;
using APIClientTool.ViewModels.Form941SCHR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.Utilities
{
    public class APISession
    {
        #region Form W-2

        #region Session Property for Return
        public static List<FormW2ReturnResponse> ReturnResponses
        {
            get
            {
                if (HttpContext.Current.Session["ReturnResponse"] != null)
                {
                    return (List<FormW2ReturnResponse>)HttpContext.Current.Session["ReturnResponse"];
                }
                else
                {
                    return new List<FormW2ReturnResponse>();
                }
            }
            set
            {
                if (value != null)
                {
                    HttpContext.Current.Session["ReturnResponse"] = value;
                }
            }
        }
        #endregion

        #region Add Form W-2 API Response
        /// <summary>
        /// Add API Response
        /// </summary>
        /// <param name="returnResponse"></param>
        public static void AddAPIResponse(FormW2ReturnResponse returnResponse)
        {
            if (returnResponse != null && returnResponse.SubmissionId != Guid.Empty)
            {
                List<FormW2ReturnResponse> returnResponses = ReturnResponses;
                returnResponses.Add(returnResponse);
                ReturnResponses = returnResponses;
            }
        }
        #endregion

        #region Get Form W-2 API Response 
        /// <summary>
        ///  Get API Response 
        /// </summary>
        /// <returns></returns>
        public static List<EFileStatus> GetAPIResponse()
        {
            List<EFileStatus> formW2list = new List<EFileStatus>();
            List<FormW2ReturnResponse> returnResponses = ReturnResponses;
            if (returnResponses != null && returnResponses.Count > 0)
            {
                var apiResponse = returnResponses.Where(a => a.StatusCode == (int)StatusCode.Success && a.SubmissionId != Guid.Empty).ToList();
                foreach (var submission in apiResponse)
                {
                    var eFileStatus = new EFileStatus();
                    eFileStatus.SubmissionId = submission.SubmissionId;
                    eFileStatus.IsReturnTransmitted = submission.IsReturnTransmitted;
                    formW2list.Add(eFileStatus);
                }
            }
            return formW2list;
        }
        #endregion

        #region Get RecordIDs by SubmissionId
        /// <summary>
        ///  Get RecordIDs by SubmissionId
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static TransmitForm GetRecordIdsBySubmissionId(Guid submissionId)
        {
            TransmitForm transmitForm = new TransmitForm();
            List<FormW2ReturnResponse> returnResponses = ReturnResponses;
            if (submissionId != Guid.Empty)
            {
                transmitForm.SubmissionId = submissionId;
                if (returnResponses != null && returnResponses.Count > 0)
                {
                    var returnResponse = returnResponses.Where(r => r.SubmissionId == submissionId).SingleOrDefault();
                    if (returnResponse != null && returnResponse.FormW2Records != null
                        && returnResponse.FormW2Records.SuccessRecords != null && returnResponse.FormW2Records.SuccessRecords.Count > 0)
                    {
                        var recordIds = returnResponse.FormW2Records.SuccessRecords.Select(r => r.RecordId).ToList();
                        if (recordIds != null && recordIds.Any())
                        {
                            transmitForm.RecordIds = new List<Guid>();
                            foreach (var recordId in recordIds)
                            {
                                transmitForm.RecordIds.Add(recordId ?? Guid.Empty);
                            }
                        }
                    }
                }
            }
            return transmitForm;
        }
        #endregion

        #region Get Coma seperated RecordIDs by SubmissionId
        /// <summary>
        ///  Get Coma seperated RecordIDs by SubmissionId
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static string GetComaseperatedRecordIdsBySubmissionId(Guid submissionId)
        {
            string recordIdStr = string.Empty;
            List<FormW2ReturnResponse> returnResponses = ReturnResponses;
            if (submissionId != Guid.Empty)
            {
                if (returnResponses != null && returnResponses.Count > 0)
                {
                    var returnResponse = returnResponses.Where(r => r.SubmissionId == submissionId).SingleOrDefault();
                    if (returnResponse != null && returnResponse.FormW2Records != null
                        && returnResponse.FormW2Records.SuccessRecords != null && returnResponse.FormW2Records.SuccessRecords.Count > 0)
                    {
                        var recordIds = returnResponse.FormW2Records.SuccessRecords.Select(r => r.RecordId).ToList();
                        if (recordIds != null && recordIds.Any())
                        {
                            foreach (var recordId in recordIds)
                            {
                                recordIdStr = !string.IsNullOrEmpty(recordIdStr) ? ("," + (recordId ?? Guid.Empty).ToString()) : (recordId ?? Guid.Empty).ToString();
                            }
                        }
                    }
                }
            }
            return recordIdStr;
        }
        #endregion

        #region Update Filing Status
        /// <summary>
        /// Update Filing Status
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static bool UpdateFilingStatus(Guid submissionId)
        {
            bool isUpdated = false;
            if (submissionId != Guid.Empty)
            {
                if (ReturnResponses != null && ReturnResponses.Count > 0)
                {
                    var apiResponse = ReturnResponses.Where(a => a.SubmissionId == submissionId).SingleOrDefault();
                    apiResponse.IsReturnTransmitted = true;
                    isUpdated = true;
                }
            }

            return isUpdated;
        }
        #endregion

        #region Delete Form W2 API Response
        /// <summary>
        /// Delete Form 941 API Response
        /// </summary>
        /// <param name="returnResponse"></param>
        public static void DeleteFormW2APIResponse(Guid? submissionId)
        {
            if (submissionId != null && submissionId != Guid.Empty)
            {
                var formw2SessionResponse = ReturnResponses;
                if (formw2SessionResponse != null)
                {
                    var formw2return = formw2SessionResponse.Where(a => a.SubmissionId == submissionId).FirstOrDefault();
                    formw2SessionResponse.Remove(formw2return);
                    ReturnResponses = formw2SessionResponse;
                }
            }
        }
        #endregion

        #endregion

        #region Form 941

        #region Session Property for Form 941 Return
        public static List<Form941ReturnResponse> Form941ReturnResponses
        {
            get
            {
                if (HttpContext.Current.Session["Form941ReturnResponses"] != null)
                {
                    return (List<Form941ReturnResponse>)HttpContext.Current.Session["Form941ReturnResponses"];
                }
                else
                {
                    return new List<Form941ReturnResponse>();
                }
            }
            set
            {
                if (value != null)
                {
                    HttpContext.Current.Session["Form941ReturnResponses"] = value;
                }
            }
        }
        #endregion

        #region Add Form 941 API Response
        /// <summary>
        /// Add Form 941 API Response
        /// </summary>
        /// <param name="returnResponse"></param>
        public static void AddForm941APIResponse(Form941ReturnResponse returnResponse)
        {
            if (returnResponse != null && returnResponse.SubmissionId != Guid.Empty)
            {
                List<Form941ReturnResponse> returnResponses = Form941ReturnResponses;
                returnResponses.Add(returnResponse);
                Form941ReturnResponses = returnResponses;
            }
        }
        #endregion

        #region Get Form 941 API Response 
        /// <summary>
        ///  Get API Response 
        /// </summary>
        /// <returns></returns>
        public static List<EFileStatus> GetForm941APIResponse()
        {
            List<EFileStatus> efileStatusList = new List<EFileStatus>();
            List<Form941ReturnResponse> returnResponses = Form941ReturnResponses;
            if (returnResponses != null && returnResponses.Count > 0)
            {
                var apiResponse = returnResponses.Where(a => a.StatusCode == (int)StatusCode.Success && a.SubmissionId != Guid.Empty).ToList();
                foreach (var submission in apiResponse)
                {
                    var formW2 = new EFileStatus();
                    formW2.SubmissionId = submission.SubmissionId;
                    formW2.IsReturnTransmitted = submission.IsReturnTransmitted;
                    efileStatusList.Add(formW2);
                }
            }
            return efileStatusList;
        }
        #endregion

        #region Delete Form 941 API Response
        /// <summary>
        /// Delete Form 941 API Response
        /// </summary>
        /// <param name="returnResponse"></param>
        public static void DeleteForm941APIResponse(Guid? submissionId)
        {
            if (submissionId != null && submissionId != Guid.Empty)
            {
                var form941SessionResponse = Form941ReturnResponses;
                if (form941SessionResponse != null)
                {
                    var form941return = form941SessionResponse.Where(a => a.SubmissionId == submissionId).FirstOrDefault();
                    form941SessionResponse.Remove(form941return);
                    Form941ReturnResponses = form941SessionResponse;
                }
            }
        }
        #endregion

        #region Get Form941 RecordIDs by SubmissionId
        /// <summary>
        ///  Get Form941 RecordIDs by SubmissionId
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static TransmitForm GetForm941RecordIdsBySubmissionId(Guid submissionId)
        {
            TransmitForm transmitForm = new TransmitForm();
            List<Form941ReturnResponse> returnResponses = Form941ReturnResponses;
            if (submissionId != Guid.Empty)
            {
                transmitForm.SubmissionId = submissionId;
                if (returnResponses != null && returnResponses.Count > 0)
                {
                    var returnResponse = returnResponses.Where(r => r.SubmissionId == submissionId).SingleOrDefault();
                    if (returnResponse != null && returnResponse.Form941Records != null
                        && returnResponse.Form941Records.SuccessRecords != null && returnResponse.Form941Records.SuccessRecords.Count > 0)
                    {
                        var recordIds = returnResponse.Form941Records.SuccessRecords.Select(r => r.RecordId).ToList();
                        if (recordIds != null && recordIds.Any())
                        {
                            transmitForm.RecordIds = new List<Guid>();
                            foreach (var recordId in recordIds)
                            {
                                transmitForm.RecordIds.Add(recordId ?? Guid.Empty);
                            }
                        }
                    }
                }
            }
            return transmitForm;
        }
        #endregion

        #region Get Coma seperated Form 941 RecordIDs by SubmissionId
        /// <summary>
        ///  Get Coma seperated RecordIDs by SubmissionId
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static string GetComaseperatedForm941RecordIdsBySubmissionId(Guid submissionId)
        {
            string recordIdStr = string.Empty;
            List<Form941ReturnResponse> returnResponses = Form941ReturnResponses;
            if (submissionId != Guid.Empty)
            {
                if (returnResponses != null && returnResponses.Count > 0)
                {
                    var returnResponse = returnResponses.Where(r => r.SubmissionId == submissionId).SingleOrDefault();
                    if (returnResponse != null && returnResponse.Form941Records != null
                        && returnResponse.Form941Records.SuccessRecords != null && returnResponse.Form941Records.SuccessRecords.Count > 0)
                    {
                        var recordIds = returnResponse.Form941Records.SuccessRecords.Select(r => r.RecordId).ToList();
                        if (recordIds != null && recordIds.Any())
                        {
                            foreach (var recordId in recordIds)
                            {
                                recordIdStr = !string.IsNullOrEmpty(recordIdStr) ? ("," + (recordId ?? Guid.Empty).ToString()) : (recordId ?? Guid.Empty).ToString();
                            }
                        }
                    }
                }
            }
            return recordIdStr;
        }
        #endregion

        #region Form941 Return Update Filing Status
        /// <summary>
        /// Update Filing Status
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static bool UpdateForm941ReturnFilingStatus(Guid submissionId)
        {
            bool isUpdated = false;
            if (submissionId != Guid.Empty)
            {
                if (Form941ReturnResponses != null && Form941ReturnResponses.Count > 0)
                {
                    var apiResponse = Form941ReturnResponses.Where(a => a.SubmissionId == submissionId).SingleOrDefault();
                    apiResponse.IsReturnTransmitted = true;
                    isUpdated = true;
                }
            }

            return isUpdated;
        }
        #endregion

        #endregion


        #region Form 941 SCHR

        #region Session Property for Form 941 SCHR Return
        public static List<Form941SchRReturnResponse> Form941SCHRReturnResponses
        {
            get
            {
                if (HttpContext.Current.Session["Form941SCHRReturnResponses"] != null)
                {
                    return (List<Form941SchRReturnResponse>)HttpContext.Current.Session["Form941SCHRReturnResponses"];
                }
                else
                {
                    return new List<Form941SchRReturnResponse>();
                }
            }
            set
            {
                if (value != null)
                {
                    HttpContext.Current.Session["Form941SCHRReturnResponses"] = value;
                }
            }
        }
        #endregion

        #region Add Form 941 API Response
        /// <summary>
        /// Add Form 941 API Response
        /// </summary>
        /// <param name="returnResponse"></param>
        public static void AddForm941SCHRAPIResponse(Form941SchRReturnResponse returnResponse)
        {
            if (returnResponse != null && returnResponse.SubmissionId != Guid.Empty)
            {
                List<Form941SchRReturnResponse> returnResponses = Form941SCHRReturnResponses;
                returnResponses.Add(returnResponse);
                Form941SCHRReturnResponses = returnResponses;
            }
        }
        #endregion

        #region Get Form 941 SCHR API Response 
        /// <summary>
        ///  Get API Response 
        /// </summary>
        /// <returns></returns>
        public static List<EFileStatus> GetForm941SCHRAPIResponse()
        {
            List<EFileStatus> efileStatusList = new List<EFileStatus>();
            List<Form941SchRReturnResponse> returnResponses = Form941SCHRReturnResponses;
            if (returnResponses != null && returnResponses.Count > 0)
            {
                var apiResponse = returnResponses.Where(a => a.StatusCode == (int)StatusCode.Success && a.SubmissionId != Guid.Empty).ToList();
                foreach (var submission in apiResponse)
                {
                    var formW2 = new EFileStatus();
                    formW2.SubmissionId = submission.SubmissionId;
                    formW2.IsReturnTransmitted = submission.IsReturnTransmitted;
                    efileStatusList.Add(formW2);
                }
            }
            return efileStatusList;
        }
        #endregion

        #region Delete Form 941 API Response
        /// <summary>
        /// Delete Form 941 API Response
        /// </summary>
        /// <param name="returnResponse"></param>
        public static void DeleteForm941SCHRAPIResponse(Guid? submissionId)
        {
            if (submissionId != null && submissionId != Guid.Empty)
            {
                var form941SchrSessionResponse = Form941SCHRReturnResponses;
                if (form941SchrSessionResponse != null)
                {
                    var form941return = form941SchrSessionResponse.Where(a => a.SubmissionId == submissionId).FirstOrDefault();
                    form941SchrSessionResponse.Remove(form941return);
                    Form941SCHRReturnResponses = form941SchrSessionResponse;
                }
            }
        }
        #endregion

        #region Get Form941SCHR RecordIDs by SubmissionId
        /// <summary>
        ///  Get Form941SCHR RecordIDs by SubmissionId
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static TransmitForm GetForm941SCHRRecordIdsBySubmissionId(Guid submissionId)
        {
            TransmitForm transmitForm = new TransmitForm();
            List<Form941SchRReturnResponse> returnResponses = Form941SCHRReturnResponses;
            if (submissionId != Guid.Empty)
            {
                transmitForm.SubmissionId = submissionId;
                if (returnResponses != null && returnResponses.Count > 0)
                {
                    var returnResponse = returnResponses.Where(r => r.SubmissionId == submissionId).SingleOrDefault();
                    if (returnResponse != null && returnResponse.Form941SchRRecords != null
                        && returnResponse.Form941SchRRecords.SuccessRecords != null && returnResponse.Form941SchRRecords.SuccessRecords.Count > 0)
                    {
                        var recordIds = returnResponse.Form941SchRRecords.SuccessRecords.Select(r => r.RecordId).ToList();
                        if (recordIds != null && recordIds.Any())
                        {
                            transmitForm.RecordIds = new List<Guid>();
                            foreach (var recordId in recordIds)
                            {
                                transmitForm.RecordIds.Add(recordId ?? Guid.Empty);
                            }
                        }
                    }
                }
            }
            return transmitForm;
        }
        #endregion

        #region Get Coma seperated Form 941 SCHR RecordIDs by SubmissionId
        /// <summary>
        ///  Get Coma seperated RecordIDs by SubmissionId
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static string GetComaseperatedForm941SCHRRecordIdsBySubmissionId(Guid submissionId)
        {
            string recordIdStr = string.Empty;
            List<Form941SchRReturnResponse> returnResponses = Form941SCHRReturnResponses;
            if (submissionId != Guid.Empty)
            {
                if (returnResponses != null && returnResponses.Count > 0)
                {
                    var returnResponse = returnResponses.Where(r => r.SubmissionId == submissionId).SingleOrDefault();
                    if (returnResponse != null && returnResponse.Form941SchRRecords != null
                        && returnResponse.Form941SchRRecords.SuccessRecords != null && returnResponse.Form941SchRRecords.SuccessRecords.Count > 0)
                    {
                        var recordIds = returnResponse.Form941SchRRecords.SuccessRecords.Select(r => r.RecordId).ToList();
                        if (recordIds != null && recordIds.Any())
                        {
                            foreach (var recordId in recordIds)
                            {
                                recordIdStr = !string.IsNullOrEmpty(recordIdStr) ? ("," + (recordId ?? Guid.Empty).ToString()) : (recordId ?? Guid.Empty).ToString();
                            }
                        }
                    }
                }
            }
            return recordIdStr;
        }
        #endregion

        #region Form941 Return Update Filing Status
        /// <summary>
        /// Update Filing Status
        /// </summary>
        /// <param name="submissionId"></param>
        /// <returns></returns>
        public static bool UpdateForm941SCHRReturnFilingStatus(Guid submissionId)
        {
            bool isUpdated = false;
            if (submissionId != Guid.Empty)
            {
                if (Form941SCHRReturnResponses != null && Form941SCHRReturnResponses.Count > 0)
                {
                    var apiResponse = Form941SCHRReturnResponses.Where(a => a.SubmissionId == submissionId).SingleOrDefault();
                    apiResponse.IsReturnTransmitted = true;
                    isUpdated = true;
                }
            }

            return isUpdated;
        }
        #endregion

        #endregion
    }
}