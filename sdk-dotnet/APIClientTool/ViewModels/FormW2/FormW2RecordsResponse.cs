using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels
{
    public class FormW2RecordsResponse : BaseResponseStatus
    {
        /// <summary>
        /// A detailed information about the Business, Employees and Form W-2 records
        /// </summary>
        public List<FormW2ListResponse> FormW2Records { get; set; }

        /// <summary>
        /// Total number of Businesses
        /// </summary>
        public int TotalRecords { get; set; }
        /// <summary>
        /// Total number of pages
        /// </summary>
        public int TotalPages { get; set; }
        /// <summary>
        /// Page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Range: 10, 25, 50, 100
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// It will show the detailed information about the error.
        /// </summary>
        public List<Error> Errors { get; set; }
    }
}