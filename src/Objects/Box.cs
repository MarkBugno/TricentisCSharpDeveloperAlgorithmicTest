namespace BoxChooser;

// You are welcome to change this class around - I just added it so the CSV Handler would work.
public class Box {
    public Box(int index, int x, int y, int width, int height, double quality) {
        Index = index;
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Quality = quality;
    }

    public int Index { get; }
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }
    public double Quality { get; }
}
