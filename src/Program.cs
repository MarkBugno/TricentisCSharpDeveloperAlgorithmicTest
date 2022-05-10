using BoxChooser;
using System;
using System.Diagnostics;

var csvHandler = new CsvHandler();
var chooser = new Chooser();
var timer = new Stopwatch();
var boxes = csvHandler.Load(@".\boxes.csv");

timer.Start();
var result = chooser.ChooseBoxes(boxes);
timer.Stop();

csvHandler.Save(@$".\KeptBoxes.csv", result.RetainedBoxes);
Console.WriteLine($"Retained:   {result.BoxesRetained}");
Console.WriteLine($"Suppressed: {result.BoxesSuppressed}");
Console.WriteLine($"Discarded:  {result.BoxesDiscarded}");
Console.WriteLine($"Time:       {timer.ElapsedMilliseconds} ms");
Console.ReadLine();
