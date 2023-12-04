using MatrixTraceTask;

namespace MatrixTraceTaskTests;

public class GetMatrixSnakeTests
{
	[Fact]
	public void GetMatrixSnake_1x1()
	{
		var expectedRow = new [,] { { 61 } };

		var testArray = new[,] { { 61 } };

		var testMatrix = new Matrix(testArray);
		var actualRow = testMatrix.GetMatrixSnake();

		Assert.Equal(expectedRow, actualRow);
	}
	
	[Fact]
	public void GetMatrixSnake_2x3()
	{
		var expectedRow = new[,]
		{
			{ 12, 45, 58, 8, 89, 65 }
		};

		var testArray = new[,]
		{
			{ 12, 45, 58 },
			{ 65, 89, 8 }
		};

		var testMatrix = new Matrix(testArray);
		var actualRow = testMatrix.GetMatrixSnake();

		Assert.Equal(expectedRow, actualRow);
	}
	
	[Fact]
	public void GetMatrixSnake_3x4()
	{
		var expectedRow = new[,]
		{
			{ 42,84,61,54,17,87,7,70,1,89,3,61}
		};

		var testArray = new[,]
		{
			{ 42,84,61,54 },
			{ 89,3,61,17 },
			{1,70,7,87 }
		};

		var testMatrix = new Matrix(testArray);
		var actualRow = testMatrix.GetMatrixSnake();

		Assert.Equal(expectedRow, actualRow);
	}
	
	[Fact]
	public void GetMatrixSnake_5x4()
	{
		var expectedRow = new[,]
		{
			{ 73,71,37,96,28,45,85,2,10,55,96,84,14,0,10,8,55,53,100,28}
		};

		var testArray = new[,]
		{
			{ 73,71,37,96 },
			{ 0,10,8,28 },
			{ 14,28,55,45 },
			{ 84,100,53,85 },
			{ 96,55,10,2 }
		};
		var testMatrix = new Matrix(testArray);
		var actualRow = testMatrix.GetMatrixSnake();

		Assert.Equal(expectedRow, actualRow);
	}
	
	[Fact]
	public void GetMatrixSnake_4x4()
	{
		var expectedRow = new[,]
		{
			{ 63,36,69,72,92,67,56,58,29,81,51,45,14,2,8,5}
		};

		var testArray = new[,]
		{
			{ 63,36,69,72},
			{ 45,14,2,92},
			{ 51,5,8,67},
			{ 81,29,58,56}
		};
		
		var testMatrix = new Matrix(testArray);
		var actualRow = testMatrix.GetMatrixSnake();

		Assert.Equal(expectedRow, actualRow);
	}
}