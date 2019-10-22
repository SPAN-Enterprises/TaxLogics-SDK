using APIClientTool.Utilities;
using Newtonsoft.Json;
using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Net.Http;
using APIClientTool.ViewModels;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace APIClientTool.Controllers
{
    public class FormW2Controller : Controller
    {

        #region Create Form W-2 Return
        /// <summary>
        /// Function returns the form view to create W-2 return
        /// </summary>
        /// <param name="id">Parameter id is passed to prefill default values in the W-2 Form</param>
        /// <returns>FormW2 View</returns>
        public ActionResult FormW2Return(bool? id)
        {
            FormW2 formw2 = new FormW2();
            bool _prePopulate = id ?? false;
            if (_prePopulate)
            {
                PrePopulate(formw2);
            }
            return View(formw2);
        }

        private static void PrePopulate(FormW2 formw2)
        {
            //Mapping FormW2
            formw2.TaxYear = 2017;
            formw2.Sequence = "Record1";

            //Mapping BusinessDetails
            formw2.Business = new Business();
            formw2.Business.BusinessNm = "Test Business";
            formw2.Business.TradeNm = "";
            formw2.Business.Email = "employer@company.com";
            formw2.Business.IsEIN = true;
            formw2.Business.EINorSSN = "123456789";
            formw2.Business.ContactNm = "John Doe";
            formw2.Business.Phone = "1234567890";
            formw2.Business.BusinessType = "ESTE";

            formw2.Business.SigningAuthority = new SigningAuthority();
            formw2.Business.SigningAuthority.Name = "John Doe";
            formw2.Business.SigningAuthority.Phone = "1234567890";
            formw2.Business.SigningAuthority.BusinessMemberType = "Owner";

            formw2.Business.KindOfEmployer = "FEDERALGOVT";
            formw2.Business.KindOfPayer = "REGULAR941";

            formw2.Business.IsForeign = false;
            formw2.Business.USAddress = new USAddress();
            formw2.Business.USAddress.Address1 = "Address Line 1";
            formw2.Business.USAddress.City = "Rockhill";
            formw2.Business.USAddress.State = "SC";
            formw2.Business.USAddress.ZipCd = "29730";


            //Mapping Employee
            formw2.Employee = new Employee();
            formw2.Employee.SSN = "123456789";
            formw2.Employee.FirstNm = "Steve";
            formw2.Employee.LastNm = "Smith";

            formw2.Employee.USAddress = new USAddress();
            formw2.Employee.USAddress.Address1 = "Address Line 1";
            formw2.Employee.USAddress.City = "Rockhill";
            formw2.Employee.USAddress.State = "SC";
            formw2.Employee.USAddress.ZipCd = "29730";
            formw2.Employee.Phone = "9876543210";
            formw2.Employee.Email = "employee@company.com";

            //Mapping FormW2Details
            formw2.FormDetails = new FormW2Details();
            formw2.FormDetails.Box1 = 10000.00M;

            //Optional BusinessDetails
            formw2.Business.PhoneExtn = "";
            formw2.Business.Fax = "";

            //Optional Employee
            formw2.Employee.MiddleNm = "";
            formw2.Employee.Suffix = "";
            formw2.Employee.Fax = "";
            formw2.Employee.USAddress.Address2 = "";
        }
        #endregion

        #region Update Form W-2 Return
        public ActionResult FormW2UpdateReturn()
        {
            FormW2UpdateRequest formw2 = new FormW2UpdateRequest();
            formw2.W2Forms = new List<FormW2>();
            formw2.W2Forms.Add(new FormW2());
            return View(formw2);
        }
        #endregion

        #region Form W-2 Create Return Response Status
        /// <summary>
        /// Function inputs Form W-2 details, POST all those details to the API and returns the response.
        /// Successful response contains SubmissionId, StatusCode and RecordSuccessStatus details (Sequence, RecordId, RecordStatus etc)
        /// Error response contains StatusCode and RecordErrorStatus details (RecordId, Sequence and list of Error information such as Code, Name, Message and Type)
        /// </summary>
        /// <param name="formw2">Form W-2 details passed through formw2 parameter</param>
        /// <returns>W2CreateReturnResponse</returns>
        public ActionResult APIResponseStatus(FormW2 formw2)
        {
            //Hardcoded values for Sequence and TaxYear
            var responseJson = string.Empty;
            formw2.TaxYear = 2017;
            formw2.Sequence = "Record1";

            W2CreateReturnResponse w2response = new W2CreateReturnResponse();
            W2CreateReturnRequest w2ReturnList = new W2CreateReturnRequest();
            w2ReturnList.W2Forms = new List<FormW2>();
            w2ReturnList.W2Forms.Add(formw2);

            // Generate JSON for Form W-2
            var requestJson = JsonConvert.SerializeObject(w2ReturnList, Formatting.Indented);

            using (var client = new PublicAPIClient())
            {
                //API URL to Create Form W-2 Return
                string requestUri = "FormW2/Create";

                //POST
                APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "POST");

                //Get Response
                var _response = client.PostAsJsonAsync(requestUri, w2ReturnList).Result;
                if (_response != null && _response.IsSuccessStatusCode)
                {
                    //Read Response
                    var createResponse = _response.Content.ReadAsAsync<W2CreateReturnResponse>().Result;
                    if (createResponse != null)
                    {
                        responseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to W2CreateReturnResponse object
                        w2response = new JavaScriptSerializer().Deserialize<W2CreateReturnResponse>(responseJson);
                        if (w2response.SubmissionId != null && w2response.SubmissionId != Guid.Empty)
                        {
                            //Adding W2CreateReturnResponse Response to Session
                            APISession.AddAPIResponse(w2response);
                        }
                    }
                }
                else
                {
                    var createResponse = _response.Content.ReadAsAsync<Object>().Result;
                    responseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);

                    //Deserializing JSON (Error Response) to W2CreateReturnResponse object
                    w2response = new JavaScriptSerializer().Deserialize<W2CreateReturnResponse>(responseJson);
                }
            }
            return PartialView(w2response);
        }
        #endregion

        #region Get EFile Status
        public ActionResult _GetEFileStatus()
        {
            List<EFileStatus> _formw2List = new List<EFileStatus>();
            _formw2List = APISession.GetAPIResponse();
            return PartialView(_formw2List);
        }
        #endregion

        /// <summary>
        /// Function loads list of all SubmissionIds created in FormW2Return page
        /// </summary>
        /// <returns>List of all SubmissionIds</returns>
        /// 

        #region  EFile Status
        public ActionResult EFileStatus()
        {
            List<EFileStatus> _formw2List = new List<EFileStatus>();
            _formw2List = APISession.GetAPIResponse();
            return View(_formw2List);
        }
        #endregion

        #region Transmit Return
        /// <summary>
        /// Function transmit the Form W-2 Return to Efile
        /// </summary>
        /// <param name="submissionId">SubmissionId passed to transmit the W-2 return</param>
        /// <returns>TransmitFormW2Response</returns>
        public ActionResult _TransmitReturn(Guid submissionId)
        {
            TransmitForm transmitFormW2 = new TransmitForm();
            TransmitFormW2Response transmitFormW2Response = new TransmitFormW2Response();
            var transmitFormW2ResponseJSON = string.Empty;
            if (submissionId != null && submissionId != Guid.Empty)
            {
                // Getting the RecordIds for SubmissionId
                transmitFormW2 = APISession.GetRecordIdsBySubmissionId(submissionId);

                // Generate JSON for TransmitFormW2
                var requestJson = JsonConvert.SerializeObject(transmitFormW2, Formatting.Indented);

                if (transmitFormW2 != null)
                {
                    using (var client = new PublicAPIClient())
                    {
                        //API URL to Transmit Form W-2 Return
                        string requestUri = "FormW2/Transmit";

                        //POST
                        APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "POST");

                        //Get Response
                        var _response = client.PostAsJsonAsync(requestUri, transmitFormW2).Result;
                        if (_response != null && _response.IsSuccessStatusCode)
                        {
                            //Read Response
                            var createResponse = _response.Content.ReadAsAsync<TransmitFormW2Response>().Result;
                            if (createResponse != null)
                            {
                                transmitFormW2ResponseJSON = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                                transmitFormW2Response = new JavaScriptSerializer().Deserialize<TransmitFormW2Response>(transmitFormW2ResponseJSON);
                                if (transmitFormW2Response.SubmissionId != null && transmitFormW2Response.SubmissionId != Guid.Empty && transmitFormW2Response.StatusCode == (int)StatusCode.Success)
                                {
                                    //Updating Filing Status (Transmitted) for a specific SubmissionId in Session 
                                    APISession.UpdateFilingStatus(transmitFormW2Response.SubmissionId);
                                }
                            }
                        }
                        else
                        {
                            var createResponse = _response.Content.ReadAsAsync<Object>().Result;
                            transmitFormW2ResponseJSON = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                            transmitFormW2Response = new JavaScriptSerializer().Deserialize<TransmitFormW2Response>(transmitFormW2ResponseJSON);
                        }
                    }
                }
            }
            return PartialView(transmitFormW2Response);
        }
        #endregion

        #region Get Efile Status
        /// <summary>
        /// Function returns the Efile status of Form W-2
        /// </summary>
        /// <param name="submissionId">SubmissionId is passed to get the efile status</param>
        /// <returns>EfileStatusResponse</returns>
        public ActionResult _GetEfileStatusResponse(Guid submissionId)
        {
            EfileStatusResponse efileStatusResponse = new EfileStatusResponse();
            if (submissionId != null && submissionId != Guid.Empty)
            {
                var efileRequest = new EfileStatusGetRequest { SubmissionId = submissionId };
                var recordIds = APISession.GetRecordIdsBySubmissionId(submissionId);
                var recordIdsString = string.Empty;
                if (recordIds != null && recordIds.RecordIds != null && recordIds.RecordIds.Count > 0)
                {
                    efileRequest.RecordIds = recordIds.RecordIds;
                    recordIdsString = string.Join(",", recordIds.RecordIds);
                }
                var transmitFormW2ResponseJSON = string.Empty;

                // Request JSON
                var requestJson = JsonConvert.SerializeObject(efileRequest, Formatting.Indented);

                if (submissionId != null && submissionId != Guid.Empty)
                {
                    using (var client = new PublicAPIClient())
                    {
                        //GET
                        string requestUri = "FormW2/Status?SubmissionId=" + submissionId + "&RecordIds=" + recordIdsString;

                        //Get Response
                        APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "GET");

                        //Read Response
                        var _response = client.GetAsync(requestUri).Result;
                        if (_response != null && _response.IsSuccessStatusCode)
                        {
                            var createResponse = _response.Content.ReadAsAsync<EfileStatusResponse>().Result;
                            if (createResponse != null)
                            {
                                transmitFormW2ResponseJSON = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                                efileStatusResponse = new JavaScriptSerializer().Deserialize<EfileStatusResponse>(transmitFormW2ResponseJSON);
                            }
                        }
                        else
                        {
                            var createResponse = _response.Content.ReadAsAsync<Object>().Result;
                            transmitFormW2ResponseJSON = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                            efileStatusResponse = new JavaScriptSerializer().Deserialize<EfileStatusResponse>(transmitFormW2ResponseJSON);
                        }
                    }
                }
            }
            return PartialView(efileStatusResponse);
        }
        #endregion

        #region Delete Return
        /// <summary>
        /// Function delete the Form W2 Return to Efile
        /// </summary>
        /// <param name="submissionId">SubmissionId passed to delete the W-2 return</param>
        /// <returns></returns>
        public ActionResult Delete(Guid submissionId)
        {
            var deleteReturnRequest = new DeleteReturnRequest();
            var deleteReturnResponse = new FormW2DeleteReturnResponse();
            var deleteReturnResponseJSON = string.Empty;
            var recordIdsString = string.Empty;
            if (submissionId != null && submissionId != Guid.Empty)
            {
                if (submissionId != null && submissionId != Guid.Empty)
                {
                    deleteReturnRequest.SubmissionId = submissionId;
                    // Getting the RecordIds for SubmissionId
                    var recordIdsFromSession = APISession.GetRecordIdsBySubmissionId(submissionId);
                    deleteReturnRequest.RecordIds = recordIdsFromSession != null ? recordIdsFromSession.RecordIds : null;
                    if (deleteReturnRequest.RecordIds != null && deleteReturnRequest.RecordIds.Count > 0)
                    {
                        recordIdsString = string.Join(",", deleteReturnRequest.RecordIds);
                        using (var client = new PublicAPIClient())
                        {
                            //API URL to Delete Form W-2 Return
                            string requestUri = "FormW2/Delete?SubmissionId=" + submissionId + "&RecordIds=" + recordIdsString;

                            //Delete
                            APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "DELETE");

                            //Get Response
                            var _response = client.DeleteAsync(requestUri).Result;
                            if (_response != null && _response.IsSuccessStatusCode)
                            {
                                //Read Response
                                var createResponse = _response.Content.ReadAsAsync<FormW2DeleteReturnResponse>().Result;
                                if (createResponse != null)
                                {
                                    deleteReturnResponseJSON = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                                    deleteReturnResponse = new JavaScriptSerializer().Deserialize<FormW2DeleteReturnResponse>(deleteReturnResponseJSON);
                                    if (deleteReturnResponse != null && deleteReturnResponse.StatusCode == (int)StatusCode.Success)
                                    {
                                        //Todo Remove Submission and RecordId from session
                                        APISession.DeleteFormW2APIResponse(submissionId);
                                    }
                                }
                            }
                            else
                            {
                                var createResponse = _response.Content.ReadAsAsync<Object>().Result;
                                deleteReturnResponseJSON = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                                deleteReturnResponse = new JavaScriptSerializer().Deserialize<FormW2DeleteReturnResponse>(deleteReturnResponseJSON);
                            }
                        }
                    }
                }
            }
            return PartialView(deleteReturnResponse);
        }
        #endregion

        #region Get Form W2
        /// <summary>
        /// Function get the Form W2 Return to Efile
        /// </summary>
        /// <param name="submissionId">SubmissionId passed to get the W2 return</param>
        /// <returns>Form941GetReturnResponse</returns>
        public ActionResult GetFormW2(Guid submissionId)
        {
            var getReturnResponse = new FormW2GetReturnResponse();
            var getReturnResponseJSON = string.Empty;
            if (submissionId != null && submissionId != Guid.Empty)
            {
                using (var client = new PublicAPIClient())
                {
                    //API URL to Get Form W2 Return
                    string requestUri = "FormW2/Get?submissionId=" + submissionId;

                    //Get
                    APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "GET");

                    //Get Response
                    var _response = client.GetAsync(requestUri).Result;
                    if (_response != null && _response.IsSuccessStatusCode)
                    {
                        //Read Response
                        var getResponse = _response.Content.ReadAsAsync<FormW2GetReturnResponse>().Result;
                        if (getResponse != null)
                        {
                            getReturnResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                            getReturnResponse = new JavaScriptSerializer().Deserialize<FormW2GetReturnResponse>(getReturnResponseJSON);
                            if (getReturnResponse != null && getReturnResponse.StatusCode == (int)StatusCode.Success)
                            {
                                ViewData["GetResponseJSON"] = getReturnResponseJSON;
                                return PartialView();
                            }
                        }
                    }
                    else
                    {
                        var getResponse = _response.Content.ReadAsAsync<Object>().Result;
                        getReturnResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                        getReturnResponse = new JavaScriptSerializer().Deserialize<FormW2GetReturnResponse>(getReturnResponseJSON);
                    }
                }
            }
            return PartialView(getReturnResponseJSON);
        }
        #endregion

        #region Form W-2 Update Return Response Status
        /// <summary>
        /// Function inputs Form W-2 details, PUT all those details to the API and returns the response.
        /// Successful response contains SubmissionId, StatusCode and RecordSuccessStatus details (Sequence, RecordId, RecordStatus etc)
        /// Error response contains StatusCode and RecordErrorStatus details (RecordId, Sequence and list of Error information such as Code, Name, Message and Type)
        /// </summary>
        /// <param name="formw2">Form W-2 details passed through formw2 parameter</param>
        /// <returns>W2UpdateReturnResponse</returns>
        public ActionResult _APIUpdateResponseStatus(FormW2UpdateRequest formw2)
        {
            //Hardcoded values for Sequence and TaxYear
            var responseJson = string.Empty;
            formw2.W2Forms[0].TaxYear = 2017;
            formw2.W2Forms[0].Sequence = "Record1";

            W2CreateReturnResponse w2response = new W2CreateReturnResponse();
            // Generate JSON for Form W-2
            var requestJson = JsonConvert.SerializeObject(formw2, Formatting.Indented);

            using (var client = new PublicAPIClient())
            {
                //API URL to Create Form W-2 Return
                string requestUri = "FormW2/Update";

                //POST
                APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "PUT");

                //Get Response
                var _response = client.PutAsJsonAsync(requestUri, formw2).Result;
                if (_response != null && _response.IsSuccessStatusCode)
                {
                    //Read Response
                    var createResponse = _response.Content.ReadAsAsync<W2CreateReturnResponse>().Result;
                    if (createResponse != null)
                    {
                        responseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);
                        //Deserializing JSON (Success Response) to W2CreateReturnResponse object
                        w2response = new JavaScriptSerializer().Deserialize<W2CreateReturnResponse>(responseJson);
                        if (w2response.SubmissionId != null && w2response.SubmissionId != Guid.Empty)
                        {
                            //Adding W2CreateReturnResponse Response to Session
                            APISession.AddAPIResponse(w2response);
                        }
                    }
                }
                else
                {
                    var createResponse = _response.Content.ReadAsAsync<Object>().Result;
                    responseJson = JsonConvert.SerializeObject(createResponse, Formatting.Indented);

                    //Deserializing JSON (Error Response) to W2CreateReturnResponse object
                    w2response = new JavaScriptSerializer().Deserialize<W2CreateReturnResponse>(responseJson);
                }
            }
            return PartialView(w2response);
        }
        #endregion

        #region List Form W2
        /// <summary>
        /// Function List the Form W2 Return to Efile
        /// </summary>
        public ActionResult _ListFormW2(Guid? id, string Ein, int Page, int PageSize, string ES, string FD, string TD)
        {
            var getReturnResponse = new FormW2RecordsResponse();
            var getReturnResponseJSON = string.Empty;

            string requestURI = string.Empty;
            Guid Bid = id ?? Guid.Empty;
            if (string.IsNullOrWhiteSpace(ES))
            {
                ES = "null";
            }
            if (string.IsNullOrWhiteSpace(FD))
            {
                FD = "null";
            }
            if (string.IsNullOrWhiteSpace(TD))
            {
                TD = "null";
            }
            requestURI = "?BusinessId=" + Bid + "&EIN=" + Ein + "&Page=" + Page + "&PageSize=" + PageSize + "&EfileStatus=" + ES + "&FromDate=" + FD + "&ToDate=" + TD;
            using (var client = new PublicAPIClient())
            {
                //API URL to Get Form W2 Return
                string requestUri = "FormW2/List" + requestURI;

                //Get
                APIGenerateAuthHeader.GenerateAuthHeader(client, requestUri, "GET");

                //Get Response
                var _response = client.GetAsync(requestUri).Result;
                if (_response != null && _response.IsSuccessStatusCode)
                {
                    //Read Response
                    var getResponse = _response.Content.ReadAsAsync<FormW2RecordsResponse>().Result;
                    if (getResponse != null)
                    {
                        getReturnResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                        getReturnResponse = new JavaScriptSerializer().Deserialize<FormW2RecordsResponse>(getReturnResponseJSON);
                        ViewData["GetResponseJSON"] = getReturnResponseJSON;
                        return PartialView();
                    }
                }
                else
                {
                    var getResponse = _response.Content.ReadAsAsync<Object>().Result;
                    getReturnResponseJSON = JsonConvert.SerializeObject(getResponse, Formatting.Indented);
                    getReturnResponse = new JavaScriptSerializer().Deserialize<FormW2RecordsResponse>(getReturnResponseJSON);
                    ViewData["GetResponseJSON"] = getReturnResponseJSON;
                    return PartialView();
                }
            }
            return PartialView(getReturnResponseJSON);
        }
        #endregion

        #region List Form W-2 Return
        public ActionResult GetFormW2List()
        {
            FormW2ListRequest formw2list = new FormW2ListRequest();
            return View(formw2list);
        }
        #endregion


    }
}