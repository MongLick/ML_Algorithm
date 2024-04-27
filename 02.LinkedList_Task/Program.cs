namespace _02.LinkedList_Task
{
	internal class Program
	{
		// 사용자의 입력으로 숫자를 입력 받아서(마이너스도 허용)
		// 음수는 앞에 추가하고, 양수는 뒤에 추가하여
		// 음수&양수를 반으로 나누는 연결리스트 구현
		// 입력 받을 때마다 처음부터 끝까지 출력 진행

		static void Main(string[] args)
		{
			LinkedList<int> linkedList = new LinkedList<int>();
			Console.WriteLine("숫자를 입력해주세요");
			Console.WriteLine("끝내고 싶으면 0을 눌러주세요");
			do
			{
				int key = int.Parse(Console.ReadLine());
				if (key < 0)
				{
					linkedList.AddFirst(key);
				}
				else if(key > 0)
				{
					linkedList.AddLast(key);
				}
				else
				{
					break;
				}
				foreach (int item in linkedList)
				{
					Console.Write($"{item}");
				}
				Console.WriteLine();
			}while (true);
		}
	}
}
