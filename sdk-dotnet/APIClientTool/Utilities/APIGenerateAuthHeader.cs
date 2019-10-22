using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace APIClientTool.Utilities
{
    public class APIGenerateAuthHeader
    {
        static string emailAddress = string.Empty;
        static string userToken = string.Empty;

        #region Generate Headers with Hashed Signature 

        #region Generate Auth Header
        public static void GenerateAuthHeader(PublicAPIClient client, string requestUri, string methodType)
        {
            userToken = Utility.GetAppSettings("UserToken");
            string apiPrivateKey = Utility.GetAppSettings("PrivateKey");
            string apiPublicKey = Utility.GetAppSettings("PublicKey");
            var apiVersion = Utility.GetAppSettings("ApiVersion");

            client.DefaultRequestHeaders.Clear();

            if (!string.IsNullOrWhiteSpace(userToken))
            {
                string authorizeHeader = !string.IsNullOrWhiteSpace(userToken) ? userToken : string.Empty;
                client.DefaultRequestHeaders.Add("UserToken", authorizeHeader);
            }
            string IPAddress = HttpContext.Current.Request.UserHostAddress; // Map Your Public IP
            client.DefaultRequestHeaders.Add("IpAddress", IPAddress);

            var utcDate = DateTime.Now.ToUniversalTime().ToString("MM/dd/yyyy hh:mm:ss.fff tt");
            string utcDateString = string.Format("{0:U}", utcDate); //"Thursday, May 21, 2015 4:33:50 AM"

            client.DefaultRequestHeaders.Add("Timestamp", utcDateString);

            string authenticationHeader = apiPublicKey + ":" + ComputeHash(apiPrivateKey, BuildAuthSignature(apiVersion, methodType, utcDateString, IPAddress, userToken, requestUri.ToLower()));
            client.DefaultRequestHeaders.Add("Authentication", authenticationHeader);

            string uniqueId = Guid.NewGuid().ToString();
            client.DefaultRequestHeaders.Add("IdempotentKey", uniqueId);


        }
        #endregion

        public static string BuildAuthSignature(string version, string methodType, string date, string IPAddress, string userToken, string absolutePath)
        {
            if (!(string.IsNullOrEmpty(version)))
            {
                absolutePath = "/" + version + "/" + absolutePath;
            }
            else
            {
                absolutePath = "/" + absolutePath;
            }
            var uri = HttpContext.Current.Server.UrlDecode(absolutePath);
            var message = string.Join("\n", methodType, date, IPAddress, userToken, uri);
            return message;
        }

        #region Compute Hash
        private static string ComputeHash(string privateKey, string message)
        {
            var key = Encoding.UTF8.GetBytes(privateKey);
            string hashString;

            using (var hmac = new HMACSHA256(key))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
                hashString = Convert.ToBase64String(hash);
            }

            return hashString;
        }

        #endregion

        #endregion
    }
}