namespace BoxChooser;

public class Box {
    public Box(int x, int y, int width, int height, double quality, int index = 0) {
        Index = index;
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Quality = quality;

        Left = x;
        Right = x + width;
        Top = y;
        Bottom = y + height;
        Area = width * height;
    }

    public int Index { get; }
    public int X { get; }
    public int Y { get; }
    public int Width { get; }
    public int Height { get; }
    public double Quality { get; }

    public int Left { get; }
    public int Right { get; }
    public int Top { get; }
    public int Bottom { get; }
    public int Area { get; }
}
