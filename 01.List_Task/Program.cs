namespace _01.List_Task
{
	internal class Program
	{
		// 사용자에게 숫자를 입력 받아서
		// 0부터 숫자까지 가지는 리스트 만들기
		// 0 요소를 제거
		// 리스트가 가지는 모든 요소들을 출력해주는 반복문 작성

		// 사용자의 입력을 받아서 없던 데이터면 추가, 있던 데이터면 삭제하는 리스트
		// ex) 1, 6, 7, 8, 3 들고 있던 상황이면
		// 2 입력하면 없던 경우니까 1, 6, 7, 8, 3, 2
		// 7 입력하면 있던 경우니까 1, 6, 8, 3

		static void Main(string[] args)
		{
			Console.WriteLine("숫자를 입력해주세요");
			int key = int.Parse(Console.ReadLine());
			List<int> list = new List<int>();
			for(int i = 0; i < key; i++)
			{
				list.Add(i);
			}
			foreach(int i in list)
			{
				Console.Write(i);
			}
			list.Remove(0);
			Console.WriteLine();
			foreach (int i in list)
			{
				Console.Write(i);
			}
			Console.WriteLine();

			List<int> list2 = new List<int>();
			list2.Add(1);
			list2.Add(6);
			list2.Add(7);
			list2.Add(8);
			list2.Add(3);
			Console.WriteLine("현재 리스트에 있는 데이터 : 1, 6, 7, 8, 3");
			Console.WriteLine("없던 데이터를 입력하면 추가 있던 데이터를 입력하면 해당 데이터를 삭제합니다.");
			int userKey = int.Parse(Console.ReadLine());

			if (list2.Contains(userKey))
			{
				list2.Remove(userKey);
			}
			else
			{
				list2.Add(userKey);
			}

			foreach (int i in list2)
			{
				Console.Write(i);
			}
		}
	}
}
