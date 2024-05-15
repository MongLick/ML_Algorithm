using System.Text;

namespace _08.DesignTechnique_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1번 문제

			int n = 0, m = 0;
			string[] temp = Console.ReadLine().Split();
			n = int.Parse(temp[0]);
			m = int.Parse(temp[1]);
			StringBuilder sb = new StringBuilder();
			Go(new int[m], sb, n, m, 0);
			Console.WriteLine(sb.ToString());

		}

		static void Go(int[] arr, StringBuilder sb, int n, int m, int c)
		{
			if (c == m)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					sb.Append(arr[i]);
					sb.Append(' ');
				}
				sb.AppendLine();
				return;
			}

			for (int i = 0; i < n; i++)
			{
				arr[c] = i + 1;
				Go(arr, sb, n, m, c + 1);
			}
		}
	}
}
