using System.Collections.Immutable;

namespace BoxChooser;

public class ChosenBoxes {
    public ChosenBoxes(ImmutableArray<Box> keptBoxes, int boxesDiscarded, int boxesSuppressed) {
        RetainedBoxes = keptBoxes;
        BoxesDiscarded = boxesDiscarded;
        BoxesSuppressed = boxesSuppressed;
    }

    public ImmutableArray<Box> RetainedBoxes { get; }
    public int BoxesRetained => RetainedBoxes.Length;
    public int BoxesDiscarded { get; }
    public int BoxesSuppressed { get; }
}
