using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitution
{
    internal class RotN : SubstitutionCipher
    {
        int n;
        public RotN(int n)
        {
            this.n = n;
            if (n < 0)
                n = -n;
            n = n % 26;
            GenerateEncryptionKey();
            GenerateDecryptionKey();
        }
        

        protected override void GenerateDecryptionKey()
        {
            for (int i = 0; i < 26; i++)
            {
                decryptionKey.Add((char)('A' + i), (char)('A' + ((i - n + 26) % 26)));
            }
        }

        protected override void GenerateEncryptionKey()
        {
            for (int i = 0; i < 26; i++)
            {
                encryptionKey.Add((char)('A' + i), (char)('A' + ((i + n) % 26)));
            }
        }
    }
}
