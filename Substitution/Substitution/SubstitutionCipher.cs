using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Substitution
{
    internal abstract class SubstitutionCipher
    {
        protected string plainText;
        protected string cipherText;

        protected Dictionary<char, char> encryptionKey = new Dictionary<char, char>();
        protected Dictionary<char, char> decryptionKey = new Dictionary<char, char>();

        public string PlaintText 
        { 
            get
            {
                return plainText;
            }
            set
            {
                plainText = value;
            }
        }

        public string CipherText
        {
            get
            {
                return cipherText;
            }
            set
            {
                cipherText = value;
            }
        }

        public void Encrypt()
        {
            cipherText = Substitute(plainText, encryptionKey);
        }
        public void Decrypt()
        {
            plainText = Substitute(cipherText, decryptionKey);
        }

        protected abstract void GenerateEncryptionKey();
        protected abstract void GenerateDecryptionKey();


        /// <summary>
        /// Genereaza un string in care fiecare litera din text este inlocuita cu litera indicata de key
        /// </summary>
        /// <param name="text">textul pe care se face substitutie</param>
        /// <param name="key">Permutarea a alfabetului</param>
        /// <returns></returns>
        protected string Substitute(string text, Dictionary<char, char> key)
        {
            StringBuilder sb = new StringBuilder();
            text = text.ToUpper();
            foreach (char c in text)
            {
                if (!char.IsUpper(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append(key[c]);
                }
            }
            return sb.ToString();
        }
    }
}
