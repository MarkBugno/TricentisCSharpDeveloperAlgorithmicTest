using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BoxChooser;

public class Chooser {
    private const double MinQualityThresholdInclusive = 0.5;    // If quality < MinQualityThresholdInclusive, Discard box.
    private const double MinClashIoUInclusive = 0.4;            // If IoU >= MinClashIoUInclusive, Suppress lower quality box

    public ChosenBoxes ChooseBoxes(ImmutableArray<Box> allBoxes) {
        var boxesRetained = new List<Box>();
        var boxesDiscardedCount = 0;
        var boxesSuppressedCount = 0;

        // TODO

        return new(boxesRetained.ToImmutableArray(), boxesDiscardedCount, boxesSuppressedCount);
    }

    public double CalculateIntersectionOverUnion(Box box1, Box box2) {
        var intersection = CalculateIntersection(box1, box2);
        var union = CalculateUnion(/*...*/);
        return intersection / (double)union;
    }

    public int CalculateIntersection(Box box1, Box box2) {
        throw new NotImplementedException();
    }

    public int CalculateUnion(/*...*/) {
        throw new NotImplementedException();
    }
}
