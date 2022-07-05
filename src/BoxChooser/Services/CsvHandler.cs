using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;

namespace BoxChooser;

public class CsvHandler {
    public ImmutableArray<Box> Load(string filepath) {
        using var parser = new TextFieldParser(filepath);
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");
        _ = parser.ReadFields();
        var boxes = Load(parser);
        return boxes.ToImmutableArray();

        static IEnumerable<Box> Load(TextFieldParser parser) {
            var index = 0;
            while (!parser.EndOfData) {
                var fields = parser.ReadFields()!;
                var x = int.Parse(fields[0]);
                var y = int.Parse(fields[1]);
                var width = int.Parse(fields[2]);
                var height = int.Parse(fields[3]);
                var quality = double.Parse(fields[4]);
                yield return new Box(x, y, width, height, quality, index++);
            }
        }
    }

    public void Save(string filepath, ImmutableArray<Box> boxes) {
        var csv = new StringBuilder();
        _ = csv.AppendLine("x,y,width,height,quality");
        foreach (var box in boxes.OrderBy(b => b.Index))
            _ = csv.AppendLine($"{box.X},{box.Y},{box.Width},{box.Height},{box.Quality}");
        File.WriteAllText(filepath, csv.ToString());
    }
}
