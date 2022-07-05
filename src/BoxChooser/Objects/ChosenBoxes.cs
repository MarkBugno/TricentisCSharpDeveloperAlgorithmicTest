using System.Collections.Immutable;

namespace BoxChooser;

public class ChosenBoxes {
    public ChosenBoxes(ImmutableArray<Box> boxesRetained, int boxesDiscardedCount, int boxesSuppressedCount) {
        BoxesRetained = boxesRetained;
        BoxesDiscardedCount = boxesDiscardedCount;
        BoxesSuppressedCount = boxesSuppressedCount;
    }

    public ImmutableArray<Box> BoxesRetained { get; }
    public int BoxesRetainedCount => BoxesRetained.Length;
    public int BoxesDiscardedCount { get; }
    public int BoxesSuppressedCount { get; }
}
