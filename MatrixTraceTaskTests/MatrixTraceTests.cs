using MatrixTraceTask;

namespace MatrixTraceTaskTests;

public class MatrixTraceTests
{
	[Fact]
	public void Matrix_null_Exeption()
	{
		Assert.Throws<InvalidMatrixSizeException>(() => new Matrix(null));
	}

	[Fact]
	public void Matrix_1x0__0x1_Exeption()
	{
		var testArray = new int [1, 0];

		Assert.Throws<InvalidMatrixSizeException>(() => new Matrix(testArray));
	}

	[Fact]
	public void CalculateMatrixTrace_1x1_61()
	{
		const int expectedTrace = 61;

		var testArray = new[,]
		{
			{
				61
			}
		};

		var testMatrix = new Matrix(testArray);
		var actualTrace = testMatrix.CalculateMatrixTrace();

		Assert.Equal(expectedTrace, actualTrace);
	}

	[Fact]
	public void CalculateMatrixTrace_2x3_101()
	{
		const int expectedTrace = 101;

		var testArray = new[,]
		{
			{12, 45, 58},
			{65, 89, 8}
		};

		var testMatrix = new Matrix(testArray);
		var actualTrace = testMatrix.CalculateMatrixTrace();

		Assert.Equal(expectedTrace, actualTrace);
	}
	
	[Fact]
	public void CalculateMatrixTrace_3x4_52()
	{
		const int expectedTrace = 52;

		var testArray = new[,]
		{
			{ 42,84,61,54 },
			{ 89,3,61,17 },
			{1,70,7,87 }
		};

		var testMatrix = new Matrix(testArray);
		var actualTrace = testMatrix.CalculateMatrixTrace();

		Assert.Equal(expectedTrace, actualTrace);
	}
	
	[Fact]
	public void CalculateMatrixTrace_5x4_223()
	{
		const int expectedTrace = 223;

		var testArray = new[,]
		{
			{ 73,71,37,96 },
			{ 0,10,8,28 },
			{ 14,28,55,45 },
			{ 84,100,53,85 },
			{ 96,55,10,2 }
		};

		var testMatrix = new Matrix(testArray);
		var actualTrace = testMatrix.CalculateMatrixTrace();

		Assert.Equal(expectedTrace, actualTrace);
	}
	
	[Fact]
	public void CalculateMatrixTrace_4x4_141()
	{
		const int expectedTrace = 141;

		var testArray = new[,]
		{
			{ 63,36,69,72},
			{ 45,14,2,92},
			{ 51,5,8,67},
			{ 81,29,58,56}
		};

		var testMatrix = new Matrix(testArray);
		var actualTrace = testMatrix.CalculateMatrixTrace();

		Assert.Equal(expectedTrace, actualTrace);
	}
}