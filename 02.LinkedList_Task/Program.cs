namespace _02.LinkedList_Task
{
	internal class Program
	{
		// 사용자의 입력으로 숫자를 입력 받아서(마이너스도 허용)
		// 음수는 앞에 추가하고, 양수는 뒤에 추가하여
		// 음수&양수를 반으로 나누는 연결리스트 구현
		// 입력 받을 때마다 처음부터 끝까지 출력 진행

		// 요세푸스 문제는 다음과 같다.
		// 1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다.이제 순서대로 K번째 사람을 제거한다.
		// 한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다. 이 과정은 N0명의 사람이 모두 제거될 때까지 계속된다.
		// 원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다.예를 들어 (7, 3)-요세푸스 순열은<3, 6, 2, 7, 5, 1, 4>이다.
		// N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오.

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
				else if (key > 0)
				{
					linkedList.AddLast(key);
				}
				else
				{
					break; // 반복문종료
				}
				foreach (int item in linkedList)
				{
					Console.Write($"{item}");
				}
				Console.WriteLine();
			} while (true);

			// 요세푸스 순열 문제
			LinkedList<int> list = new LinkedList<int>();

			int n = 0;
			int k = 0;

			do
			{
				Console.WriteLine("1보다 낮은 숫자를 입력하면 안 됩니다.");
				Console.WriteLine("총 숫자를 입력해주세요");
				n = int.Parse(Console.ReadLine());
				Console.WriteLine("몇번 째 숫자 마다 제거를 할지 입력해주세요");
				k = int.Parse(Console.ReadLine());
			} while (n <= 0 || k <= 0);

			// 요세푸스 순열 생성
			List<int> josephus = Josephus(n, k);

			// 요세푸스 순열 출력
			Console.WriteLine("요세푸스 순열:");
			foreach (int num in josephus)
			{
				Console.Write(num + " ");
			}
		}

		// 요세푸스 순열을 생성하는 함수
		static List<int> Josephus(int n, int k)
		{
			LinkedList<int> list = new LinkedList<int>();

			// 원형 연결 리스트 초기화
			for (int i = 1; i <= n; i++)
			{
				list.AddLast(i);
			}

			List<int> josephus = new List<int>();

			LinkedListNode<int> current = list.First;

			while (list.Count > 0)
			{
				// k번째 노드까지 이동
				for (int i = 1; i < k; i++)
				{
					current = current.Next ?? list.First;
				}

				// 현재 노드의 값을 요세푸스 순열에 추가하고 다음 노드 기억
				josephus.Add(current.Value);
				LinkedListNode<int> next = current.Next ?? list.First;

				// 현재 노드 제거
				list.Remove(current);
				current = next;
			}

			return josephus;

			// 다른 풀이도 해볼 것
		}
	}
}