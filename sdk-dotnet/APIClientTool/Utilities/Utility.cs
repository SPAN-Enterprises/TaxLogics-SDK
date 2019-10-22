using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace APIClientTool.Utilities
{
    public static class Utility
    {

        #region Get App Settings
        /// <summary>
        /// Get the appsetting value from the web.config
        /// </summary>
        /// <param name="appKey">appsettings key</param>
        /// <returns></returns>
        public static string GetAppSettings(string appKey)
        {
            object value = null;
            value = ConfigurationManager.AppSettings[appKey];
            if (value != null)
            {
                return value.ToString();
            }
            return string.Empty;
        }
        #endregion

        #region Get Enum Display Name values
        public static string GetEnumDisplayName(this Enum value)
        {
            var type = value.GetType();   //will get the enum name which matches the input enum value
            if (type.IsEnum)
            {
                var members = type.GetMember(value.ToString());  // will get the member type
                if (members.Length > 0)
                {
                    var member = members[0];
                    var attributes = member.GetCustomAttributes(typeof(DisplayAttribute), false);  // gets the custom attribute we described in enum
                    if (attributes.Length > 0)
                    {
                        var attribute = (DisplayAttribute)attributes[0];
                        return attribute.GetName();     // returns the display name string
                    }
                }
            }
            return string.Empty;
        }
        #endregion

        #region Convert to Int
        /// <summary>
        /// Convert to Int.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static int GetInt(object value)
        {
            int result = 0;
            if (value != null)
            {
                int.TryParse(value.ToString(), out result);
            }
            return result;
        }
        #endregion

        #region Convert to Bool
        /// <summary>
        /// Convert to Bool.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static bool GetBool(object value)
        {
            bool result = false;
            if (value != null)
            {
                bool.TryParse(value.ToString(), out result);
            }
            return result;
        }
        #endregion

        #region Format Json
        public static string FormatJson(string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                if ((json.StartsWith("{") && json.EndsWith("}")) || (json.StartsWith("[") && json.EndsWith("]")))
                {
                    dynamic parsedJson = JsonConvert.DeserializeObject(json);
                    return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
                }
            }
            return json;
        }
        #endregion
    }
}