namespace MatrixTraceTask;

public class MatrixHelper
{
	public static void DemonstrateTask()
	{
		var testQuery = new MatrixFromConsole();
		var numberRows = testQuery.NumberRows;
		var numberColumns = testQuery.NumberColumns;

		var testMatrix = new Matrix(numberRows, numberColumns);

		var traceMatrix = testMatrix.CalculateMatrixTrace();
		Console.WriteLine($"\nTrace of matrix: {traceMatrix}.\n");

		testQuery.Print(testMatrix.MatrixArray);

		Console.WriteLine($"\nPrint the matrix in a line by passing along a spiral:");

		var linearMatrix = testMatrix.GetMatrixSnake();
		testQuery.SpiralPrint(linearMatrix);
	}
}