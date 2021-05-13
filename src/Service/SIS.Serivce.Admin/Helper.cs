using SIS.Data;
using SIS.Data.App;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Serivce.Admin
{
    public class Helper
    {

        #region AppSettings
        public AppSettings get_AppSettings(string _AppPath)
        {
            AppSettings _AppSettings = new AppSettings();

            if (CheckConfig(_AppPath))
            {
                string text = System.IO.File.ReadAllText(_AppPath + @"\AppSettings.json");

                MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(text));
                System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(_AppSettings.GetType());
                _AppSettings = serializer.ReadObject(ms) as AppSettings;
                ms.Close();

                SetupDefination();

                _AppSettings.Password = SifreCoz(_AppSettings.Password);
            }
            return _AppSettings;

        }

        public bool CheckConfig(string _AppPath)
        {
            string path = _AppPath + @"\AppSettings.json";
            if (File.Exists(path))
            {
                path = _AppPath + @"\AppSettings.json";
            }
            return !string.IsNullOrEmpty(path) ? true : false;
        }


        #region Crypto

        private DataTable DT_MultiplierList { get; set; }
        private DataTable DT_Val { get; set; }
        private DataTable DT_Total { get; set; }
        private DataTable DT_ByPassList { get; set; }

        public void SetupDefination()
        {
            DT_MultiplierList = new DataTable();
            DT_ByPassList = new DataTable();
            DT_Val = new DataTable();
            DT_Total = new DataTable();
            DT_MultiplierList.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_MultiplierList.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_MultiplierList.Columns.Add("Multiplier", System.Type.GetType("System.Int32"));
            DT_MultiplierList.Rows.Add(new object[] { 1, "P", 25 });
            DT_MultiplierList.Rows.Add(new object[] { 2, "Y", 33 });
            DT_MultiplierList.Rows.Add(new object[] { 3, "H", 18 });
            DT_MultiplierList.Rows.Add(new object[] { 4, "E", 14 });
            DT_MultiplierList.Rows.Add(new object[] { 5, "T", 21 });
            DT_MultiplierList.Rows.Add(new object[] { 6, "M", 11 });
            DT_MultiplierList.Rows.Add(new object[] { 7, "G", 22 });
            DT_MultiplierList.Rows.Add(new object[] { 8, "S", 8 });
            DT_MultiplierList.Rows.Add(new object[] { 9, "R", 7 });
            DT_MultiplierList.Rows.Add(new object[] { 10, "L", 26 });
            //SednaMhsMain.sednaMhsSet.Tables.Add(DT_MultiplierList);
            //SednaMhsMain.sednaMhsSet.Tables["Table1"].TableName = "DT_MultiplierList";
            //DataTable DT_ByPassList = new DataTable();
            DT_ByPassList.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_ByPassList.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_ByPassList.Rows.Add(new object[] { 1, "Q" });
            DT_ByPassList.Rows.Add(new object[] { 2, "W" });
            DT_ByPassList.Rows.Add(new object[] { 3, "X" });
            //SednaMhsMain.sednaMhsSet.Tables.Add(DT_ByPassList);
            //SednaMhsMain.sednaMhsSet.Tables["Table1"].TableName = "DT_ByPassList";
            DT_Val.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_Val.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_Val.Columns.Add("Multiplier", System.Type.GetType("System.String"));
            //SednaMhsMain.sednaMhsSet.Tables.Add(DT_Val);
            //SednaMhsMain.sednaMhsSet.Tables["Table1"].TableName = "DT_Val";
            DT_Total.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_Total.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_Total.Columns.Add("Total", System.Type.GetType("System.Int32"));
            DT_Total.Rows.Add(new object[] { 1, "Q", 11 });
            DT_Total.Rows.Add(new object[] { 2, "W", 23 });
            DT_Total.Rows.Add(new object[] { 3, "X", 21 });
            DT_Total.Rows.Add(new object[] { 4, "C", 32 });
            DT_Total.Rows.Add(new object[] { 5, "D", 13 });
            //SednaMhsMain.sednaMhsSet.Tables.Add(DT_Total);
            //SednaMhsMain.sednaMhsSet.Tables["Table1"].TableName = "DT_Total";
        }
        private string EncryptBackOffice(string lcpass)
        {
            DataTable DT_MultiplierList = new DataTable(), DT_ByPassList = new DataTable(),
            DT_Val = new DataTable(), DT_Total = new DataTable();

            DT_ByPassList.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_ByPassList.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_ByPassList.Rows.Add(new object[] { 1, "Q" });
            DT_ByPassList.Rows.Add(new object[] { 2, "W" });
            DT_ByPassList.Rows.Add(new object[] { 3, "X" });


            DT_MultiplierList.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_MultiplierList.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_MultiplierList.Columns.Add("Multiplier", System.Type.GetType("System.Int32"));

            DT_MultiplierList.Rows.Add(new object[] { 1, "P", 25 });
            DT_MultiplierList.Rows.Add(new object[] { 2, "Y", 33 });
            DT_MultiplierList.Rows.Add(new object[] { 3, "H", 18 });
            DT_MultiplierList.Rows.Add(new object[] { 4, "E", 14 });
            DT_MultiplierList.Rows.Add(new object[] { 5, "T", 21 });
            DT_MultiplierList.Rows.Add(new object[] { 6, "M", 11 });
            DT_MultiplierList.Rows.Add(new object[] { 7, "G", 22 });
            DT_MultiplierList.Rows.Add(new object[] { 8, "S", 8 });
            DT_MultiplierList.Rows.Add(new object[] { 9, "R", 7 });
            DT_MultiplierList.Rows.Add(new object[] { 10, "L", 26 });

            DT_Val.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_Val.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_Val.Columns.Add("Multiplier", System.Type.GetType("System.String"));

            DT_Total.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_Total.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_Total.Columns.Add("Total", System.Type.GetType("System.Int32"));

            DT_Total.Rows.Add(new object[] { 1, "Q", 11 });
            DT_Total.Rows.Add(new object[] { 2, "W", 23 });
            DT_Total.Rows.Add(new object[] { 3, "X", 21 });
            DT_Total.Rows.Add(new object[] { 4, "C", 32 });
            DT_Total.Rows.Add(new object[] { 5, "D", 13 });


            string lcreturn = "";
            string Multiplier = "";
            try
            {
                if (Convert.ToString(lcpass).Trim().Length == 0)
                {
                    return "";
                }
                DT_Val.Clear();
                string lcStr = lcpass.Trim();
                for (int i = 0; i < lcStr.Length; i++)
                {
                    string lcVal = lcStr.Substring(i, 1).Trim();
                    byte[] lnAscii = Encoding.ASCII.GetBytes(lcVal);
                    //
                    // int  = Convert.ToInt32(GetRandomMultiplier());
                    Random numbers = new Random();
                    int ix = numbers.Next(1, 10);
                    Multiplier = DT_MultiplierList.Select("ID=" + ix, "")[0]["Code"].ToString();
                    int liCarpanId = ix;
                    int liCarpan = Convert.ToInt32(DT_MultiplierList.Select("ID=" + liCarpanId, "")[0]["Multiplier"]);
                    int lnProcess = Convert.ToInt32(lnAscii[0]) * liCarpan;
                    string lcMultiplier = DT_MultiplierList.Select("ID=" + liCarpanId, "")[0]["Code"].ToString();
                    DT_Val.Rows.Add(new object[] { i, Convert.ToString(lnProcess), lcMultiplier });
                }
                //int Byp = GetRandomByPass();
                Random number = new Random();
                int Byp = number.Next(1, 3);
                string ByPass = DT_ByPassList.Select("ID=" + Byp, "")[0]["Code"].ToString();

                foreach (DataRow oRow in DT_Val.Rows)
                {
                    lcreturn += Convert.ToString(oRow["Code"]).Trim() + "-" + Convert.ToString(oRow["Multiplier"]);
                    lcreturn += " ";
                }
                //lcCry = lcCry.Substring(0, lcCry.Trim().Length);
                lcreturn = lcreturn + "*" + ByPass;
                return lcreturn;
            }
            catch
            {
                return lcreturn;
            }
        }
        private string DecryptBackOffice(string lcpass)
        {
            DataTable DT_MultiplierList = new DataTable(), DT_ByPassList = new DataTable(),
            DT_Val = new DataTable(), DT_Total = new DataTable();

            DT_ByPassList.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_ByPassList.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_ByPassList.Rows.Add(new object[] { 1, "Q" });
            DT_ByPassList.Rows.Add(new object[] { 2, "W" });
            DT_ByPassList.Rows.Add(new object[] { 3, "X" });


            DT_MultiplierList.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_MultiplierList.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_MultiplierList.Columns.Add("Multiplier", System.Type.GetType("System.Int32"));

            DT_MultiplierList.Rows.Add(new object[] { 1, "P", 25 });
            DT_MultiplierList.Rows.Add(new object[] { 2, "Y", 33 });
            DT_MultiplierList.Rows.Add(new object[] { 3, "H", 18 });
            DT_MultiplierList.Rows.Add(new object[] { 4, "E", 14 });
            DT_MultiplierList.Rows.Add(new object[] { 5, "T", 21 });
            DT_MultiplierList.Rows.Add(new object[] { 6, "M", 11 });
            DT_MultiplierList.Rows.Add(new object[] { 7, "G", 22 });
            DT_MultiplierList.Rows.Add(new object[] { 8, "S", 8 });
            DT_MultiplierList.Rows.Add(new object[] { 9, "R", 7 });
            DT_MultiplierList.Rows.Add(new object[] { 10, "L", 26 });

            DT_Val.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_Val.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_Val.Columns.Add("Multiplier", System.Type.GetType("System.String"));

            DT_Total.Columns.Add("ID", System.Type.GetType("System.Int32"));
            DT_Total.Columns.Add("Code", System.Type.GetType("System.String"));
            DT_Total.Columns.Add("Total", System.Type.GetType("System.Int32"));

            DT_Total.Rows.Add(new object[] { 1, "Q", 11 });
            DT_Total.Rows.Add(new object[] { 2, "W", 23 });
            DT_Total.Rows.Add(new object[] { 3, "X", 21 });
            DT_Total.Rows.Add(new object[] { 4, "C", 32 });
            DT_Total.Rows.Add(new object[] { 5, "D", 13 });

            string lcreturn = "";
            string Multiplier = "";
            try
            {
                if (lcpass.Trim().Length == 0)
                {
                    return "";
                }
                DT_Val.Clear();
                string ByPass = lcpass.Substring(lcpass.Trim().Length - 1, 1);
                lcpass = lcpass.Substring(0, lcpass.Length - 2);
                string lcorjpass = lcpass;
                int lnRecCount = 0;
                string lcRow;
                bool ilk = true;
                int baslangic = 0;
                string lccarpan;
                for (int i = 0; i < lcpass.Length; i++)
                {
                    lcRow = "";
                    if (lcpass.Substring(i, 1).Trim() == "")
                    {
                        if (ilk)
                        {
                            lcRow = lcpass.Substring(0, i);
                            baslangic = i + 1;
                            ilk = false;
                        }
                        else
                        {
                            lcRow = lcpass.Substring(baslangic, i - baslangic);
                            baslangic = i + 1;
                        }
                        lnRecCount += 1;
                        if (lcRow != "")
                        {
                            lccarpan = lcRow.Substring(lcRow.Length - 1, 1);
                            lcRow = lcRow.Substring(0, lcRow.Length - 2);
                            lcRow = Convert.ToString(Convert.ToInt32(lcRow) / Convert.ToInt32(DT_MultiplierList.Select("CODE='" + lccarpan.ToString().Trim() + "'", "")[0]["Multiplier"]));
                            DT_Val.Rows.Add(new object[] { i, Convert.ToString(lcRow) });
                        }
                    }
                }
                foreach (DataRow oRow in DT_Val.Rows)
                {
                    char lcchar = Convert.ToChar(Convert.ToInt32(oRow["Code"]));
                    lcreturn += lcchar;
                }
                return lcreturn;
            }
            catch
            {
                return lcreturn;
            }

        }


        public string Sifrele(string lcpass)
        {
            string password = "";

            password = EncryptBackOffice(lcpass);


            return password;
        }

        public string SifreCoz(string lcpass)
        {
            string password = "";

            password = DecryptBackOffice(lcpass);

            return password;
        }

        private string get_Decrypt(string cipherText)
        {

            string Password = "cemalbekirriza";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                 new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,
            0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] decryptedData = Decrypt(cipherBytes,
               pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }

        private string do_Encrypt(string clearText)
        {
            string Password = "cemalbekirriza";
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
            0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] encryptedData = Encrypt(clearBytes,
                     pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(encryptedData);

        }

        private byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms,
                alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();

            return decryptedData;
        }

        private byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms,
            alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(clearData, 0, clearData.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        #endregion

        #endregion

        #region ApplicationServer

        public static string get_sql_ApplicationServer(int _AppType, string _UserCode, string __CustomerGuidId)
        {
            bool x = false;
            string _Sql;

            _Sql = " select \n"
                                        + " App.Id,App.Server,App.ServerName,App.Username,App.Password ,App.Mask, App.ApiLocal,App.ApiNet,App.ServerCloude,App.ApiJob \n"
                                        + " from ApplicationServer App  \n"
                                        + " left outer join ApplicationDatabase D on D.ServerId =App.Id  \n";
            if (!x)
            {
                _Sql += " left outer join ApplicationUserDatabase U on U.DatabaseId = D.Id  \n";
            }

            if (_AppType == (int)AdminAppType.GMP)
            {
                _Sql += " where D.ApplicationId in (1) ";
            }
            else
            {
                _Sql += " where D.ApplicationId = " + _AppType;
            }

            if (!x)
            {
                _Sql += " and U.UserCode = N'" + _UserCode + "'";
            }


            _Sql += " group by " + " App.Id,App.Server,App.ServerName,App.Username,App.Password ,App.Mask, App.ApiLocal,App.ApiNet,App.ApiJob,App.ServerCloude\n";

            return _Sql;

        }



        #endregion
    }
}
