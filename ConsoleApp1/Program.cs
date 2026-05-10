using System;
using AljabarLibraries;

double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });

Console.WriteLine("Akar Persamaan Kuadrat:");
Console.WriteLine($"Output: {{ {akar[0]}, {akar[1]} }}");

double[] hasil = Aljabar.HasilKuadrat(new double[] { 2, -3 });

Console.WriteLine();
Console.WriteLine("Hasil Kuadrat:");
Console.WriteLine($"Output: {{ {hasil[0]}, {hasil[1]}, {hasil[2]} }}");