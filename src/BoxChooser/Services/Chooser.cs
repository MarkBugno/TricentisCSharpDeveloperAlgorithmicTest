using System;
using System.Collections.Immutable;

namespace BoxChooser;

public class Chooser {
    private const double MinQualityToKeepInclusive = 0.5;   // If quality < MinQualityToKeepInclusive, Discard box.
    private const double MinClashIoUInclusive = 0.4;        // If IoU >= MinClashIoUInclusive, Suppress lower quality box

    public ChosenBoxes ChooseBoxes(ImmutableArray<Box> allBoxes) {
        throw new NotImplementedException();
    }

    public double CalculateIntersectionOverUnion(Box box1, Box box2) {
        var intersection = CalculateIntersection(box1, box2);
        var union = CalculateUnion(box1, box2, intersection);
        return intersection / (double)union;
    }

    public int CalculateIntersection(Box box1, Box box2) {
        throw new NotImplementedException();
    }

    public int CalculateUnion(Box box1, Box box2, int intersection) {
        throw new NotImplementedException();
    }
}
