using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BoxChooser;

// Feel free to replace this code. It's just here to save you googling "C# load csv". This isn't the part of the code we're worried about. If you'd
// prefer a different way of doing this, go for it.
public class CsvHandler {
    public IEnumerable<Box> Load(string filepath) {
        using var parser = new TextFieldParser(filepath);
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");
        _ = parser.ReadFields();
        while (!parser.EndOfData) {
            var fields = parser.ReadFields()!;
            var left = fields[0];
            var top = fields[1];
            var width = fields[2];
            var height = fields[3];
            var quality = fields[4];
            // TODO
            yield return new Box();
        }
    }

    public void Save(string filepath, IEnumerable<Box> boxes) {
        var csv = new StringBuilder();
        foreach (var box in boxes) {
            string left = null!, top = null!, width = null!, height = null!, quality = null!;
            // TODO
            _ = csv.AppendLine($"{left},{top},{width},{height},{quality}");
        }
        File.WriteAllText(filepath, csv.ToString());
    }
}
