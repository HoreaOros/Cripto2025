using Substitution;

RotN es = new RotN(10);

es.PlaintText = "ABC 123 WXYZ";
es.Encrypt();
Console.WriteLine(es.CipherText);

Caesar c = new Caesar();
c.PlaintText = "attack at dawn";
c.Encrypt();
Console.WriteLine(c.CipherText);


MonoAlphabeticCipher mc = new MonoAlphabeticCipher();

mc.PlaintText = "ABC";
mc.Encrypt();
Console.WriteLine(mc.CipherText);
