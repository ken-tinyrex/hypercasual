using NUnit.Framework;
using UnityEngine;
using Grid = Hypercasual.Implementation.Grid;

public class GridTest
{
    [TestCase(4, 4, 1)]
    public void GridTest_WidthAndHeightAreCorrect(int width, int height, float cellSize)
    {
        int expectedWidth = width;
        int expectedHeight = height;

        Grid grid = new Grid(width, height, cellSize, Vector3.zero);
        bool actualValue = grid.Width == expectedWidth && grid.Height == expectedHeight;

        Assert.IsTrue(actualValue);
    }

    [TestCase(2, 1, 20)]
    public void SetValue_ByXandY_IsDebugTextCorrect(int x, int y, int value)
    {
        string expectedValue = value.ToString();

        Grid grid = new Grid(10, 10, 1, Vector3.zero);
        grid.SetValue(x, y, value);
        string actualValue = grid.DebugTextArray[x, y].text;

        Assert.IsTrue(expectedValue == actualValue);
    }

    [TestCase(20)]
    public void SetValue_ByWorldPosition_IsDebugTextCorrect(int value)
    {
        string expectedValue = value.ToString();
        Vector3 worldPosition = new Vector3(2, 0, 1);

        Grid grid = new Grid(5, 5, 1, Vector3.zero);
        grid.SetValue(worldPosition, value);
        string actualValue = grid.DebugTextArray[(int) worldPosition.x, (int) worldPosition.z].text;

        Assert.IsTrue(expectedValue == actualValue);
    }

    [TestCase(2, 1, 20)]
    public void GetValue_ByXandY_IsValueCorrect(int x, int y, int value)
    {
        int expectedValue = value;

        Grid grid = new Grid(4, 6, 1, Vector3.zero);
        grid.SetValue(x, y, value);
        int actualValue = grid.GetValue(x, y);

        Assert.AreEqual(expectedValue, actualValue);
    }

    [TestCase(20)]
    public void GetValue_ByWorldPosition_IsValueCorrect(int value)
    {
        int expectedValue = value;
        Vector3 worldPosition = new Vector3(2, 0, 1);

        Grid grid = new Grid(8, 4, 1, Vector3.zero);
        grid.SetValue(worldPosition, value);
        int actualValue = grid.GetValue(worldPosition);

        Assert.AreEqual(expectedValue, actualValue);
    }
}
