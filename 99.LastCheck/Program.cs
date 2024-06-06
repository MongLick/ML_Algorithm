namespace _99.LastCheck
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 리스트 런타임 중 크기를 확장할 수 있는 배열기반의 자료구조이다.
			// 배열요소의 갯수를 특정할 수 없는 경우 사용이 용이하다

			// 리스트 구현
			// 리시트는 배열기반의 자료구조이며, 배열은 크기를 변경할 수 없는 자료구조이다.
			// 리스트는 동작 중 크기를 확장하기 위해 포함한 데이터보다 더욱 큰 배열을 사용한다.

			// 리스트 삽입
			// 중간에 데이터를 추가하기 위해 이후 데이터들을 뒤로 밀어내고 삽입을 진행한다.

			// 리스트 삭제
			// 중간에 데이터를 삭제한 뒤 빈자리를 채우기 위해 이후 데이터들을 앞으로 당긴다.

			// 리스트 용량
			// 용량을 가득 채운 상황에서 데이터를 추가하는 경우
			// 더 큰 용량의 배열을 새로 생성한 뒤 데이터를 복사하여 새로운 배열을 사용한다.

			// 리스트가 가득찬 상황에서 새로운 데이터 추가 시도
			// 새로운 더 큰 배열을 생성(2배)
			// 새로운 배열에 기존의 데이터를 복사한다.
			// 기본 배열 대신 새로운 배열을 사용한다.
			// 빈 공간에 데이터를 추가한다.

			// 리스트는 접근은 1 탐색은 n 삽입은 n 삭제는 n

			List<string> list = new List<string>();
			List<int> list1 = new List<int>();
			list1.Capacity = 10000; // 배열의 크기를 정해주는 것
			List<int> list2 = new List<int>(10000); // 혹은 이렇게 크기를 정해줄 수도 있다.

			// 삽입하는 방법
			list.Add("0번 데이터");
			list.Add("1번 데이터");
			list.Add("2번 데이터");
			list.Insert(1, "중간 데이터 1");
			list.Insert(3, "중간 데이터 2");
			list.Insert(5, "끝");

			foreach (string listString in list)
			{
				Console.WriteLine(listString);
			}

			// 둘 다 사용해도 상관없을 떄는 Add가 더 좋다
			// Insert는 중간에 끼워넣어야하기 때문에 들어갈 자리 뒤에를 한 칸씩 다 미루는 작업이 필요함.
			// Add는 맨 뒤에 추가만 하기 되기 때문이다.

			// 삭제
			list.Remove("1번 데이터");
			list.RemoveAt(1); // 인덱스를 가지고 지우는 것 1번째 인덱스를 지우는 것
			list.RemoveAt(list.Count -1);

			// 접근
			list[0] = "데이터0";
			string value = list[0];

			// 탐색
			int indexof = list.IndexOf("2번 데이터");
			for(int i = 0; i < list.Count; i++)
			{
				list[i] = value;
			}

			// 연결리스트
			// 데이터를 포함하는 노드들을 연결식으로 만든 자료구조이다.
			// 데이터와 다른 데이터 지점의 참조변수를 가진 노드를 기본 단위로 사용한다.
			// 데이터를 노드를 통해 연결식으로 구성하기 때문에 데이터의 추가/삭제에 유용하다.
			// 노드가 메모리에 연속적으로 배치되지 않고 연결 구조로 다른 데이터의 위치를 확인한다.

			// 연결리스트 구현
			// 연결리스트는 노드를 기본 단위로 연결식으로 구현한다.
			// 노드간의 연결구조에 따라 단방향, 양방향, 환형으로 구분한다.
			// 1. 단방향 연결리스트
			// 노드가 다음 노드를 참조
			// 2. 양방향 연결리스트
			// 노드가 이전/다음 노드를 참조
			// 3. 환형 연결리스트
			// 노드가 이전/다음 노드를 참조하며, 시작 노드와 마지막 노드를 참조한다.

			// 연결리스트 삽입
			// 새로 추가하는 노드가 이전/이후 노드를 잠조한 뒤
			// 이전/이후 노드가 새로 추가하는 노드를 참조한다.

			// 연결리스트 삭제
			// 삭제하는 노드의 이전 노드가 이후 노드를 참조한 뒤
			// 삭제하는 노드의 이후 노드가 이전 노드를 참조한다.

			// 연결리스트 특징
			// 연결리스트의 경우 데이터를 연속적으로 배치하는 배열과 다르게 연결식으로 구현한다.
			// 따라서 데이터의 추가 삭제 과정에서 다른 데이터의 위치와 무관하게 진행되므로 수월하다.
			// 하지만 데이터의 접근 과정에서 연속적인 데이터 배치가 아니기 때문에 인덱스 사용이 불가능하여 처음부터 끝까지 탐색을 해야한다.

			// 연결리스틑 접근 n 탐색 n 삽입 1 삭제 1 이다

			LinkedList<string> linkedList = new LinkedList<string>();

			// 삽입
			LinkedListNode<string> node0 = linkedList.AddFirst("0번 데이터");
			LinkedListNode<string> node1 = linkedList.AddFirst("1번 데이터");
			LinkedListNode<string> node2 = linkedList.AddLast("2번 데이터");
			LinkedListNode<string> node3 = linkedList.AddLast("3번 데이터");
			LinkedListNode<string> node4 = linkedList.AddBefore(node0, "4번 데이터");
			LinkedListNode<string> node5 = linkedList.AddAfter(node0, "5번 데이터");

			foreach(string linkedListString in linkedList)
			{
				Console.WriteLine(linkedListString);
			}

			// 삭제
			linkedList.Remove("1번 데이터");
			linkedList.Remove(node3);
			linkedList.RemoveFirst();
			linkedList.RemoveLast();

			// 접근
			LinkedListNode<string> firstNode = linkedList.First;
			LinkedListNode<string> lastNode = linkedList.Last;
			LinkedListNode<string> prevNode = node0.Previous;
			LinkedListNode<string> newxtNode = node0.Next;

			// 탐색
			LinkedListNode<string> findNode = linkedList.Find("5번 데이터");

			// 노드
			// 여러 자료구조에서 사용하는 기본 단위이다.
			// 데이터와 다른 노드를 참조하는 값을 가진다.
			// 다른 노드의 참조를 연결하는 방식에 따라 여러 자료구조를 구현 가능하다.

			// 노드 구현
			// 노드에 데이터와 다른 노드를 참조하는 값을 구성하여 구현한다.

			// 연결된 노드를 가지는 일정갯수의 변수 또는 배열응 통해 고정적인 연결구조를 가진다.
			// 연결구조가 일정한 연결리스트/트리 등에 사용한다.

			// 연결된 노드를 List를 통해 유동적인 연결구조를 가진다
			// 연결구조가 일정하지 않은 트리/그래프 등에 사용한다.

			// 반복기
			// 자료구조에 저장되어 있는 요소들을 순차적으로 접근하기 위한 객체이다.
			// c# 대부분의 자료구조는 반복기를 포함하고 있다.
			// 이를 통해 자료구조종류와 내부구조에 무관하게 순회가 가능하다.

			// 반복기 사용
			// 반복기 객체를 자료구조에서 생성하여 순척적으로 확인하며 순회한다.
			// IEnumerable : 자료구조의 반복기 생성 인터페이스
			// IEnumerator : 자료구조의 반복기 객체 인터페이스

			List<int> list3 = new List<int>();

			// 반복기 객체 생성
			IEnumerator<int> iter = list3.GetEnumerator();

			// 반복기 객체가 현재 가리키는 데이터 확인
			Console.WriteLine(iter.Current);

			// 반복기 객체가 다음 데이터를 가리키도록 이동 (반환은 다음 데이터 유무)
			bool isEnd = iter.MoveNext();

			// 반복기 객체가 처음 데이터를 가리키도록 초기화
			iter.Reset();

			iter.Reset();
			while(iter.MoveNext())
			{
				Console.WriteLine(iter.Current);
			}

			// 반복기 사용의의
			// 반복기 사용하는 경우 자료구조종류와 내부구조에 무관하게 순회가 가능하다.

			int size = 5;
			List<int> list4 = new List<int>();
			LinkedList<int> linkedList4 = new LinkedList<int>();

			for(int i = 0; i < size; i++)
			{
				list4.Add(i);
				linkedList4.AddLast(i);
			}

			// 반복기 사용이 없는 경우
			// 자료구조 내 데이트를 순회하기 위해 자료구조 내부구조를 이용해야 한다.

			for(int i = 0; i < list4.Count; i++)
			{
				Console.WriteLine(list4[i]);
			}

			for(LinkedListNode<int> node6 = linkedList4.First; node6 != null; node6 = node6.Next)
			{
				Console.WriteLine(node6.Value);
			}

			// 반복기를 사용하는 경우
			// 자료구조 내 데이트를 순회하기 위해 반복기 사용만을 필요하다.

			for(IEnumerator<int> iter1 = list4.GetEnumerator(); iter1.MoveNext();)
			{
				Console.WriteLine(iter.Current);
			}

			for(IEnumerator<int> iter1 = linkedList4.GetEnumerator(); iter1.MoveNext();)
			{
				Console.WriteLine(iter1.Current);
			}

			// foreach 반복문
			// 반복기를 이용하는 반복문이다
			// IEnumerable 인터페이스를 포함하는 객체에 사용가능하다.

			int size1 = 5;
			int[] array = new int[size1];
			List<int> list5 = new List<int>();
			LinkedList<int> linkedList5 = new LinkedList<int>();
			Stack<int> stack = new Stack<int>();
			Queue<int> queue = new Queue<int>();
			SortedSet<int> set = new SortedSet<int>();

			for(int i = 0; i < size1; i++)
			{
				array[i] = i;
				list5.Add(i);
				linkedList5.AddLast(i);
				stack.Push(i);
				queue.Enqueue(i);
				set.Add(i);
			}

			IEnumerable<int> IterFunc()
			{
				yield return 0;
				yield return 1;
				yield return 2;
				yield return 3;
				yield return 4;
			}

			foreach(int element in array)
			{
				Console.WriteLine(element);
			}
			foreach (int element in list5)
			{
				Console.WriteLine(element);
			}
			foreach (int element in linkedList5)
			{
				Console.WriteLine(element);
			}
			foreach (int element in stack)
			{
				Console.WriteLine(element);
			}
			foreach (int element in queue)
			{
				Console.WriteLine(element);
			}
			foreach (int element in set)
			{
				Console.WriteLine(element);
			}
			foreach (int element in IterFunc())
			{
				Console.WriteLine(element);
			}
		}
	}
}
