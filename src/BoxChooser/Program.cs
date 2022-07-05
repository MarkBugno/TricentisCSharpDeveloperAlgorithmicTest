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

csvHandler.Save(@$".\KeptBoxes.csv", result.BoxesRetained);
Console.WriteLine($"Retained:   {result.BoxesRetainedCount}");
Console.WriteLine($"Suppressed: {result.BoxesSuppressedCount}");
Console.WriteLine($"Discarded:  {result.BoxesDiscardedCount}");
Console.WriteLine($"Time:       {timer.ElapsedMilliseconds} ms");
Console.ReadLine();
