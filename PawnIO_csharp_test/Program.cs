using PawnIO_csharp_test;

Console.WriteLine($"PawnIO version: {PawnIO.Version():x}");
var pawnIO = new PawnIO();
var bytes = File.ReadAllBytes("LpcIO.bin");
pawnIO.Load(bytes);
var outVals = pawnIO.Execute("ioctl_detect", new long[] { 1, 1 }, 2);
Console.WriteLine($"Detected chips: 2E {outVals[0]:x} 4E {outVals[1]:x}");
