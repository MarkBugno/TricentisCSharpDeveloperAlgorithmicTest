using BoxChooser;
using System;
using System.Diagnostics;
using System.Linq;

var csvHandler = new CsvHandler();
var timer = new Stopwatch();
var boxes = csvHandler.Load(@".\boxes.csv").ToArray();

timer.Start();
// TODO
var keptBoxes = Enumerable.Empty<Box>();
var (retained, suppressed, discarded) = (0, 0, 0);
timer.Stop();

csvHandler.Save(@$".\KeptBoxes.csv", keptBoxes);
Console.WriteLine($"Retained:   {retained}");
Console.WriteLine($"Suppressed: {suppressed}");
Console.WriteLine($"Discarded:  {discarded}");
Console.WriteLine($"Time:       {timer.ElapsedMilliseconds}");
Console.ReadLine();
