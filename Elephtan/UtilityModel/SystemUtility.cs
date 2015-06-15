using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace store.sg.edu.nus.utility
{
    public class SystemUtility
    {
        public static Guid guid;


        public static HttpApplicationState application;

        public static string  GetDictString(string key, string value) {
            Dictionary<string, Dictionary<string, string>> dicts = (Dictionary<string, Dictionary<string, string>>)
                application["dict"];
            string dictName = null;

            Dictionary<string, string> dict = null;

            //
            if (dicts != null) {

                dicts.TryGetValue(key, out dict);

                if (null != dict) {
                    if(null != value)
                       dict.TryGetValue(value, out dictName);
                }
            }
            return dictName;
        
        }


        public static string GetCurrentDateString() {
            DateTime dateTime = DateTime.Now;
            string result = dateTime.ToString("yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            return result;
        }

        public static string GenerateUUID()
        {
            guid = Guid.NewGuid();
            return guid.ToString().Replace("-", "");
        }

        public static String Encrypt(String source)
        {
            String hash = "";
            if (null != source && !"".Equals(source))
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    hash = GetMd5Hash(md5Hash, source);
                }
            }

            return hash;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        // Verify a hash against a string. 
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}