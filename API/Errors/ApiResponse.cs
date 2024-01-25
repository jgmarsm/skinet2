using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLitePCL;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch 
            {
                400 => "A bad request occurred",
                401 => "Authorization failed",
                404 => "The requested page does not exist",
                500 => "Internal Server Error",
                _ => null
            };
        }
    }
}