namespace MatrixTraceTask;

public class Matrix
{
	private readonly int _height, _width;
	internal int[,] _matrix;
	public int[,] MatrixArray => _matrix;

	public Matrix(int height, int width)
	{
		_height = CheckParameter(height);
		_width = CheckParameter(width);
		_matrix = new int[_height, _width];
		FillMatrix();
	}

	public Matrix(int[,]? matrixArray)
	{
		_matrix = matrixArray ?? throw new InvalidMatrixSizeException(nameof(matrixArray));
		_height = CheckParameter(matrixArray.GetLength(0));
		_width = CheckParameter(matrixArray.GetLength(1));
	}

	public int CalculateMatrixTrace()
	{
		var trace = 0;
		var smallestBorder = _height <= _width ? _height : _width;

		for (var x = 0; x < smallestBorder; x++)
			trace += MatrixArray[x, x];

		return trace;
	}

	public int[,] GetMatrixSnake()
	{
		var snake = new int[1, _matrix.Length];
		var workMatrix = _matrix;

		for (var i = 0; i < _matrix.Length; )
		{
			Array.Copy(workMatrix, 0, snake, i, workMatrix.GetLength(1));
			i += workMatrix.GetLength(1);
			workMatrix = RemoveFirstLine(workMatrix);
			workMatrix = Transpose(workMatrix);
		}

		return snake;
	}

	private int[,] Transpose(int[,] initialMatrix)
	{
		var transposedMatrix = new int[initialMatrix.GetLength(1), initialMatrix.GetLength(0)];

		for (var rows = 0; rows < initialMatrix.GetLength(0); rows++)
		{
			for (var columns = 0; columns < initialMatrix.GetLength(1); columns++)
			{
				var transposedRow = rows;
				var transposedColumn = initialMatrix.GetLength(1) - 1-columns;
				transposedMatrix[columns, rows] = initialMatrix[transposedRow, transposedColumn];
			}
		}

		return transposedMatrix;
	}

	private int[,] RemoveFirstLine(int[,] initialMatrix)
	{
		const int startInsertion = 0;

		var startCopying = initialMatrix.GetLength(1);
		var trimmedMatrix = new int[initialMatrix.GetLength(0) - 1, initialMatrix.GetLength(1)];

		Array.Copy(initialMatrix, startCopying, trimmedMatrix, startInsertion, trimmedMatrix.Length);

		return trimmedMatrix;
	}

	private void FillMatrix()
	{
		const int minItemsValue = 0;
		const int maxItemsValue = 101;

		var random = new Random();

		for (var i = 0; i < _height; i++)
		{
			for (var j = 0; j < _width; j++)
				MatrixArray[i, j] = random.Next(minItemsValue, maxItemsValue);
		}
	}

	private int CheckParameter(int parameter)
	{
		if (parameter > 0)
		{
			return parameter;
		}

		throw new InvalidMatrixSizeException(nameof(parameter));
	}
}