namespace BoxChooser.Tests;

public class ChooserTests {
    private readonly Chooser chooser;
    public ChooserTests() => chooser = new();

    #region No intersection - space in between

    [Fact]
    public void CalculateIntersection_Box2IsLeftOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 2, 10, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsAboveBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 2, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsRightOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 18, 10, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsBelowBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 18, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    #endregion

    #region No intersection - adjacent

    [Fact]
    public void CalculateIntersection_Box2TouchesLeftOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 5, 10, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesTopOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 5, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesRightOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 15, 10, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2TouchesBottomOfBox1_DoNotIntersect() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 15, 5, 5, 1);
        var expectedArea = 0;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    #endregion

    #region Intersects

    [Fact]
    public void CalculateIntersection_Box2IntersectsLeftSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 7, 10, 5, 5, 1);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsTopSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 7, 5, 5, 1);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsRightSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 13, 10, 5, 5, 1);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsBottomSideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 13, 5, 5, 1);
        var expectedArea = 10;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsTopLeftCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 7, 7, 5, 5, 1);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsBottomLeftCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 7, 13, 5, 5, 1);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsTopRightCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 13, 7, 5, 5, 1);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IntersectsBottomRightCornerOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 13, 13, 5, 5, 1);
        var expectedArea = 4;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2MatchesBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 10, 10, 5, 5, 1);
        var expectedArea = 25;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2IsInsideOfBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 11, 11, 3, 3, 1);
        var expectedArea = 9;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void CalculateIntersection_Box2ContainsBox1_Intersects() {
        // Arrange
        var box1 = new Box(0, 10, 10, 5, 5, 1);
        var box2 = new Box(1, 9, 9, 7, 7, 1);
        var expectedArea = 25;

        // Act
        var actualArea = chooser.CalculateIntersection(box1, box2);

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    #endregion
}
