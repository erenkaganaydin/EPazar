using System;
using System.Security.Cryptography;
using System.Text;

namespace EPazar.Attributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class SifreAttribute : Attribute
    {
        #region Properties

        private StringBuilder StringBuilder { get; set; }
        private MD5 MD5 { get; set; }

        #endregion Properties

        #region Constructure

        public SifreAttribute()
        {
            StringBuilder = new StringBuilder();
            MD5 = new MD5CryptoServiceProvider();
        }

        #endregion Constructure

        #region MD5Hash

        public string SifreCoz(string sifre)
        {
            MD5.ComputeHash(Encoding.ASCII.GetBytes(sifre));
            var result = MD5.Hash;

            for (int i = 0; i < result.Length; i++)
            {
                StringBuilder.Append(result[i].ToString("x2"));
            }

            return StringBuilder.ToString();
        }

        #endregion MD5Hash
    }
}