using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.Admin
{
    public class Tool
    {
        public static string ConvertStringToMD5(string ClearText)
        {

            byte[] ByteData = Encoding.ASCII.GetBytes(ClearText);
            MD5 oMd5 = MD5.Create();
            byte[] HashData = oMd5.ComputeHash(ByteData);

            StringBuilder oSb = new StringBuilder();
            for (int x = 0; x < HashData.Length; x++)
            {
                oSb.Append(HashData[x].ToString("x2"));
            }
            return oSb.ToString();
        }

    }
}
