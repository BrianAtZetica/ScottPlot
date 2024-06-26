using ScottPlot;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

Plot plt = new();
//plt.Add.Signal(Generate.Sin());
//plt.Add.Signal(Generate.Cos());
double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
}; 

var hm = plt.Add.Heatmap(data);

hm.VerticalSmooth = true;

plt.SavePng("test.png", 600, 300).LaunchFile();
plt.SavePng("test.png", 600, 300).LaunchInBrowser();
plt.SavePng("test.png", 600, 300).ConsoleWritePath();
