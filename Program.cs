class Program
{
	static int[] TranslitTo1mass(int[,]massfortranslit)
	{
		int razmmass = 9;
				int[] arraysort = new int[razmmass];
		int tamp = 0;
		for(int i = 0; i < massfortranslit.GetLength(0); i++)
		{
			for(int j = 0; j < massfortranslit.GetLength(1); j++)
			{
				arraysort[tamp] = massfortranslit[i,j];
				tamp++;
			}
		}
		return arraysort;

	}

	static int[,] Sort(int[,] massforsort)
	{

		int[] sortarray = TranslitTo1mass(massforsort);

		for (int i = 0; i < sortarray.Length; i++) { }
		int[] result = sortarray.OrderBy(i => i).ToArray();
		for (int i = 0; i < result.Length; i++) { }
		int[,] sortedmatrix = new int[3, 3];
		int k = 0;
		for (int i = 0; i < sortedmatrix.GetLength(0); i++)
		{
			for (int j = 0; j < sortedmatrix.GetLength(1); j++)
			{
				sortedmatrix[i, j] = result[k];
				
				k++;
			}
			
		}
		return sortedmatrix;
	}



	static void Main(string[] args)

	{

		int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
		Sort(a);

	}
}