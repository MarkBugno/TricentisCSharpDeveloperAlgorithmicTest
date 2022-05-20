namespace BoxChooser.Tests;

public class ChooserTests {
    private readonly Chooser chooser;
    public ChooserTests() => chooser = new();

    // This test checks that your intersection calculation is correct.
    [Theory]
    [MemberData(nameof(GetData))]
    public void CalculateIntersection(Box box1, Box box2, int expectedArea) {
        var actualArea = chooser.CalculateIntersection(box1, box2);
        Assert.Equal(expectedArea, actualArea);
    }

    public static IEnumerable<object[]> GetData() {
        Box box1, box2;
        int expectedArea;

        // No Intersection
        // West (box2 is West of box1; i.e., box2 is to the left of box1)
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1,  2, 10, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };
        // North (box2 is North of box1; i.e., box2 is above box1)
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10,  2, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };
        // East
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 18, 10, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };
        // South
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10, 18, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };

        // Adjacent (No Intersection)
        // W
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1,  5, 10, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };
        // N
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10,  5, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };
        // E
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 15, 10, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };
        // S
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10, 15, 5, 5, 1);
        expectedArea = 0;
        yield return new object[] { box1, box2, expectedArea };

        // Overlap
        // W
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1,  7, 10, 5, 5, 1);
        expectedArea = 10;
        yield return new object[] { box1, box2, expectedArea };
        // N
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10,  7, 5, 5, 1);
        expectedArea = 10;
        yield return new object[] { box1, box2, expectedArea };
        // E
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 13, 10, 5, 5, 1);
        expectedArea = 10;
        yield return new object[] { box1, box2, expectedArea };
        // S
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10, 13, 5, 5, 1);
        expectedArea = 10;
        yield return new object[] { box1, box2, expectedArea };
        // NW
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1,  7,  7, 5, 5, 1);
        expectedArea = 4;
        yield return new object[] { box1, box2, expectedArea };
        // SW
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1,  7, 13, 5, 5, 1);
        expectedArea = 4;
        yield return new object[] { box1, box2, expectedArea };
        // NE
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 13,  7, 5, 5, 1);
        expectedArea = 4;
        yield return new object[] { box1, box2, expectedArea };
        // SE
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 13, 13, 5, 5, 1);
        expectedArea = 4;
        yield return new object[] { box1, box2, expectedArea };
        // Overlap
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 10, 10, 5, 5, 1);
        expectedArea = 25;
        yield return new object[] { box1, box2, expectedArea };
        // Inside
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1, 11, 11, 3, 3, 1);
        expectedArea = 9;
        yield return new object[] { box1, box2, expectedArea };
        // Outside
        box1 = new(0, 10, 10, 5, 5, 1);
        box2 = new(1,  9,  9, 7, 7, 1);
        expectedArea = 25;
        yield return new object[] { box1, box2, expectedArea };
    }
}
