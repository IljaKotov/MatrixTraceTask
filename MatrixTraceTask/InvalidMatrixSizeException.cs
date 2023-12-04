namespace MatrixTraceTask;

public class InvalidMatrixSizeException: Exception
{
	public InvalidMatrixSizeException(string message)
		: base(message)
	{
	}
}