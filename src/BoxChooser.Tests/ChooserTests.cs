namespace BoxChooser.Tests;

public class ChooserTests {
    private Chooser chooser = new();

    #region CalculateIntersection

    [Fact]
    public void CalculateIntersection_Box2IsLeftOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(2, 10, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsAboveBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 2, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsRightOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(18, 10, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsBelowBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 18, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesLeftOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(5, 10, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesTopOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 5, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesRightOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(15, 10, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesBottomOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 15, 5, 5, 1.0);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsLeftSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(7, 10, 5, 5, 1.0);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsTopSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 7, 5, 5, 1.0);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsRightSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(13, 10, 5, 5, 1.0);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsBottomSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 13, 5, 5, 1.0);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsTopLeftCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(7, 7, 5, 5, 1.0);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsBottomLeftCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(7, 13, 5, 5, 1.0);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsTopRightCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(13, 7, 5, 5, 1.0);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsBottomRightCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(13, 13, 5, 5, 1.0);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2MatchesBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(10, 10, 5, 5, 1.0);
        var expectedArea = 25;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsInsideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(11, 11, 3, 3, 1.0);
        var expectedArea = 9;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2ContainsBox1_Intersects() {
        // Arrange
        var box1 = new Box(10, 10, 5, 5, 1.0);
        var box2 = new Box(9, 9, 7, 7, 1.0);
        var expectedArea = 25;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    #endregion

    #region CalculateUnion

    [Fact]
    public void CalculateUnion_NoOverlap_Zero() {
        // Arrange
        var box1 = new Box(2, 10, 5, 5, 1.0);
        var box2 = new Box(10, 10, 5, 5, 1.0);
        var intersection = chooser.CalculateIntersection(box1, box2);
        var expectedUnion = 50;

        // Act
        var actualUnion = chooser.CalculateUnion(box1, box2, intersection);

        // Assert
        Assert.Equal(expectedUnion, actualUnion);
    }

    [Fact]
    public void CalculateUnion_Touches_Zero() {
        // Arrange
        var box1 = new Box(5, 10, 5, 5, 1.0);
        var box2 = new Box(10, 10, 5, 5, 1.0);
        var intersection = chooser.CalculateIntersection(box1, box2);
        var expectedUnion = 50;

        // Act
        var actualUnion = chooser.CalculateUnion(box1, box2, intersection);

        // Assert
        Assert.Equal(expectedUnion, actualUnion);
    }

    [Fact]
    public void CalculateUnion_Overlaps_NonZero() {
        // Arrange
        var box1 = new Box(2, 2, 6, 6, 1.0);
        var box2 = new Box(6, 4, 6, 6, 1.0);
        var intersection = chooser.CalculateIntersection(box1, box2);
        var expectedUnion = 64;

        // Act
        var actualUnion = chooser.CalculateUnion(box1, box2, intersection);

        // Assert
        Assert.Equal(expectedUnion, actualUnion);
    }


    [Fact]
    public void CalculateUnion_Contains_NonZero() {
        // Arrange
        var box1 = new Box(2, 2, 4, 4, 1.0);
        var box2 = new Box(2, 2, 5, 5, 1.0);
        var intersection = chooser.CalculateIntersection(box1, box2);
        var expectedUnion = 25;

        // Act
        var actualUnion = chooser.CalculateUnion(box1, box2, intersection);

        // Assert
        Assert.Equal(expectedUnion, actualUnion);
    }

    #endregion

    #region CalculateIntersectOverUnion

    [Fact]
    public void CalculateIntersectionOverUnion_NoOverlap_Zero() {
        // Arrange
        var box1 = new Box(2, 10, 5, 5, 1.0);
        var box2 = new Box(10, 10, 5, 5, 1.0);
        var expectedIoU = 0;

        // Act
        var actualIoU = chooser.CalculateIntersectionOverUnion(box1, box2);

        // Assert
        Assert.Equal(expectedIoU, actualIoU);
    }

    [Fact]
    public void CalculateIntersectionOverUnion_Touches_Zero() {
        // Arrange
        var box1 = new Box(5, 10, 5, 5, 1.0);
        var box2 = new Box(10, 10, 5, 5, 1.0);
        var expectedIoU = 0;

        // Act
        var actualIoU = chooser.CalculateIntersectionOverUnion(box1, box2);

        // Assert
        Assert.Equal(expectedIoU, actualIoU);
    }

    [Fact]
    public void CalculateIntersectionOverUnion_Overlaps_NonZero() {
        // Arrange
        var box1 = new Box(2, 2, 6, 6, 1.0);
        var box2 = new Box(6, 4, 6, 6, 1.0);
        var expectedIoU = 0.125;

        // Act
        var actualIoU = chooser.CalculateIntersectionOverUnion(box1, box2);

        // Assert
        Assert.Equal(expectedIoU, actualIoU);
    }


    [Fact]
    public void CalculateIntersectionOverUnion_Contains_NonZero() {
        // Arrange
        var box1 = new Box(2, 2, 4, 4, 1.0);
        var box2 = new Box(2, 2, 5, 5, 1.0);
        var expectedIoU = 0.64;

        // Act
        var actualIoU = chooser.CalculateIntersectionOverUnion(box1, box2);

        // Assert
        Assert.Equal(expectedIoU, actualIoU);
    }

    #endregion

    #region ChooseBoxes

    [Fact]
    public void ChooseBoxes_Sample_ChoosesCorrectBoxes() {
        // Arrange
        var boxes = new Box[] {
            new(5, 4, 5, 4, 0.5, 0),
            new(4, 3, 5, 4, 0.6, 1),
            new(2, 2, 6, 5, 0.8, 2),
            new(2, 8, 4, 3, 0.9, 3),
            new(8, 9, 2, 2, 0.3, 4)
        }.ToImmutableArray();
        var expectedBoxesRetainedIndices = new[] { 0, 2, 3 };
        var expectedBoxesDiscardedCount = 1;
        var expectedBoxesSuppressedCount = 1;

        // Act
        var actualResult = chooser.ChooseBoxes(boxes);

        // Assert
        Assert.Equal(expectedBoxesRetainedIndices.Length, actualResult.BoxesRetainedCount);
        Assert.Equal(expectedBoxesDiscardedCount, actualResult.BoxesDiscardedCount);
        Assert.Equal(expectedBoxesSuppressedCount, actualResult.BoxesSuppressedCount);
        var actualBoxesRetainedIndices = actualResult.BoxesRetained.Select(b => b.Index).OrderBy(i => i).ToArray();
        Assert.True(expectedBoxesRetainedIndices.SequenceEqual(actualBoxesRetainedIndices));
    }

    [Fact]
    public void ChooseBoxes_AllData_CorrectNumberOfBoxesRetained() {
        // Arrange
        var csvHandler = new CsvHandler();
        var boxes = csvHandler.Load(@".\boxes.csv");
        var expectedBoxesRetainedCount = 2510;

        // Act
        var actualResult = chooser.ChooseBoxes(boxes);

        // Assert
        Assert.Equal(expectedBoxesRetainedCount, actualResult.BoxesRetainedCount);
    }

    [Fact]
    public void ChooseBoxes_AllData_CorrectNumberOfBoxesDiscarded() {
        // Arrange
        var csvHandler = new CsvHandler();
        var boxes = csvHandler.Load(@".\boxes.csv");
        var expectedBoxesDiscardedCount = 5026;

        // Act
        var actualResult = chooser.ChooseBoxes(boxes);

        // Assert
        Assert.Equal(expectedBoxesDiscardedCount, actualResult.BoxesDiscardedCount);
    }

    [Fact]
    public void ChooseBoxes_AllData_CorrectNumberOfBoxesSuppressed() {
        // Arrange
        var csvHandler = new CsvHandler();
        var boxes = csvHandler.Load(@".\boxes.csv");
        var expectedBoxesSuppressedCount = 2464;

        // Act
        var actualResult = chooser.ChooseBoxes(boxes);

        // Assert
        Assert.Equal(expectedBoxesSuppressedCount, actualResult.BoxesSuppressedCount);
    }

    #endregion

    #region Other

    [Fact]
    public void NoOp_AllData_CorrectNumberOfBoxesLoaded() {
        // Arrange
        var csvHandler = new CsvHandler();
        var boxes = csvHandler.Load(@".\boxes.csv");
        var expectedBoxesLoadedCount = 10000;

        // Assert
        Assert.Equal(expectedBoxesLoadedCount, boxes.Length);
    }

    #endregion
}
