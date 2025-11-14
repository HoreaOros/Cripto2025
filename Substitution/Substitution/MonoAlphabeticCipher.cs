using Substitution;

internal class MonoAlphabeticCipher: SubstitutionCipher
{
    public MonoAlphabeticCipher()
    {
        GenerateEncryptionKey();
    }

    protected override void GenerateDecryptionKey()
    {
        throw new NotImplementedException();
    }

    protected override void GenerateEncryptionKey()
    {
        int[] v = new int[26];
        for (int i = 0; i < v.Length; i++) 
            v[i] = i;
        Util.Shuffle(v);

        for (int i = 0; i < 26; i++)
        {
            encryptionKey.Add((char)('A' + i), (char)('A' + v[i]));
            decryptionKey.Add((char)('A' + v[i]), (char)('A' + i));
        }
    }
}