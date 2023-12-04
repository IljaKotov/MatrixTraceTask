namespace MatrixTraceTask;

public class MatrixFromConsole
{
	public int NumberRows { get; private set; }
	public int NumberColumns { get; private set; }

	public MatrixFromConsole()
	{
		const string linesQuery = "Enter number of rows in matrix:";
		const string columnsQuery = "Enter number of columns in matrix:";

		NumberRows = IndicateSize(linesQuery);
		NumberColumns = IndicateSize(columnsQuery);
	}

	public void Print(int[,] matrix)
	{
		for (int y = 0; y < matrix?.GetLength(0); y++)
		{
			for (int x = 0; x < matrix?.GetLength(1); x++)
			{
				var separator = x == matrix.GetLength(1) - 1 ? "\n" : "\t";
				Console.ForegroundColor = x == y ? ConsoleColor.Green : ConsoleColor.White;
				Console.Write($"{matrix[y, x]}{separator}");
			}
		}
		Console.ResetColor();
	}

	public void SpiralPrint(int[,] matrix)
	{
		for (int i = 0; i < matrix?.Length; i++)
		{
			Console.Write($"{matrix[0, i]}\t");
		}
	}

	private int IndicateSize(string directionQuery)
	{
		Console.WriteLine(directionQuery);

		int.TryParse(Console.ReadLine(), out var size);

		return CheckParameter(size);
	}

	private int CheckParameter(int consoleInput)
	{
		if (consoleInput > 0)
			return consoleInput;

		throw new InvalidMatrixSizeException(nameof(consoleInput));
	}
}
	
