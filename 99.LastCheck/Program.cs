using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace _99.LastCheck
{
	internal class Program
	{
		const int INF = 99999;

		static void Main(string[] args)
		{
			Console.WriteLine();
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
			list.RemoveAt(list.Count - 1);

			// 접근
			list[0] = "데이터0";
			string value = list[0];

			// 탐색
			int indexof = list.IndexOf("2번 데이터");
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = value;
			}

			Console.WriteLine();
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

			foreach (string linkedListString in linkedList)
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
			while (iter.MoveNext())
			{
				Console.WriteLine(iter.Current);
			}

			// 반복기 사용의의
			// 반복기 사용하는 경우 자료구조종류와 내부구조에 무관하게 순회가 가능하다.

			int size = 5;
			List<int> list4 = new List<int>();
			LinkedList<int> linkedList4 = new LinkedList<int>();

			for (int i = 0; i < size; i++)
			{
				list4.Add(i);
				linkedList4.AddLast(i);
			}

			// 반복기 사용이 없는 경우
			// 자료구조 내 데이트를 순회하기 위해 자료구조 내부구조를 이용해야 한다.

			for (int i = 0; i < list4.Count; i++)
			{
				Console.WriteLine(list4[i]);
			}

			for (LinkedListNode<int> node6 = linkedList4.First; node6 != null; node6 = node6.Next)
			{
				Console.WriteLine(node6.Value);
			}

			// 반복기를 사용하는 경우
			// 자료구조 내 데이트를 순회하기 위해 반복기 사용만을 필요하다.

			for (IEnumerator<int> iter1 = list4.GetEnumerator(); iter1.MoveNext();)
			{
				Console.WriteLine(iter.Current);
			}

			for (IEnumerator<int> iter1 = linkedList4.GetEnumerator(); iter1.MoveNext();)
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

			for (int i = 0; i < size1; i++)
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

			foreach (int element in array)
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

			// 스택 선입후출 후입선출 방식의 자료구조
			// 가장 최신 입력된 순서대로 처리해야 하는 상황에 이용한다.

			// 스택 구현 스택은 리스트를 사용법만 달리하여 구현 가능하다.

			Stack<int> stack1 = new Stack<int>();

			for (int i = 0; i < 5; i++)
			{
				stack1.Push(i);
			}

			Console.WriteLine(stack1.Peek());

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(stack1.Pop());
			}

			for (int i = 5; i < 10; i++)
			{
				stack1.Push(i);
			}

			while (stack1.Count > 0)
			{
				Console.WriteLine(stack1.Pop());
			}

			// 어댑터 패턴
			// 한 클래스의 인터페이스를 사용하고자 하는 다른 인터페이스로 변환

			// 큐 선입선출 후임후출 방식의 자료구조
			// 입력된 순서대로 처리해야 하는 상황에 이용한다.

			// 큐 구현
			// 1. 배열 사용 선입선출 후입후출을 구현하기 위해 배열을 생성하고 순차적으로 데이터를 배치한다.

			// 삽입 
			// 비어있는 가장 뒷쪽에 데이터를 배치

			// 가장 앞쪽 데이터를 출력하고 빈자리를 채우기 위해 나머지 데이트를 앞당기기를 진행한다.

			// 문제 발생
			// 큐의 삭제 과정시 나머지 데이트를 앞당겨야하는 n번의 작업이 발생한다.

			// 전단 후단
			// 삽입 삭제시 데이터를 앞당기지 않고 head와 tail을 표시하여 삽입할 위치와 삭제할 위치를 지정

			// 삽입
			// tail 위치에 데이터를 추가하고 tail을 한 칸 뒤로 이동한다.

			// 삭제
			// head 위치에 데이터를 추가하고 head를 한 칸 뒤로 이동한다.

			// 문제 발생
			// 큐의 배열 마지막 위치까지 사용하는 경우 빈자리가 없어 저장 불가한 상황이 발생한다.

			// 순환 배열
			// 배열의 끝까지 도달하여 빈자리가 없을 경우 처음으로 돌아가서 빈공간을 활용한다.

			// 마지막위치 도달시
			// 다시 가장 앞 위치를 사용하여 빈공간을 재활용한다.

			// 문제 발생
			//tail이 head를 침범하는 경우 모든 공간이 비어있는 상황과 가득차 있는 상황을 구분할 수 없음

			// 포화상태확인
			//head와 tail이 일치하는 경우를 비어있는 경우로 판정
			// tail이 head 전위치에 있는 경우를 실제로는 한자리가 비어있지만 가득찬 경우로 판정한다.

			Queue<int> queue1 = new Queue<int>();

			for (int i = 0; i < 5; i++)
			{
				queue1.Enqueue(i);
			}

			Console.WriteLine(queue.Peek());

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(queue1.Dequeue());
			}

			Console.WriteLine(queue1.Peek());

			for (int i = 5; i < 10; i++)
			{
				queue1.Enqueue(i);
			}

			Console.WriteLine(queue.Peek());

			while (queue1.Count > 0)
			{
				Console.WriteLine(queue1.Dequeue());
			}

			// 이진탐색트리
			// 이진속성과 탐색속성을 적용한 트리이다.
			// 이진탐색을 통한 탐색영역을 절반으로 풀어가며 탐색 가능하다.
			// 이진 : 부모노드는 최대 2개의 자식노드를 가질 수 있다.
			// 탐색 : 자신의 노드보다 작은 값들은 왼쪽, 큰 값들은 오른쪽에 위치한다.

			// 이진탐색트리 구현
			// 이진탐색트리는 모든 노드들이 최대 2개의 자식노드를 가질 수 있으며
			// 자신의 노드보다 작은 값들은 왼쪽, 큰 값들은 오른쪽에 위치시킨다.

			// 이진 탐색트리 탐색
			// 아래의 이진탐색트리에서 17을 탐색한다고 치면
			// 루트 노드부터 시작하여 탐색하는 값과 비교하여
			// 작은 경우 왼쪽자시노드로 큰 경우 오른쪽으로 노드를 탐색한다.

			// 이진탐색트리 삽입
			// 아래의 이진탐색트리에서 35를 삽입한다고 하면
			// 작은 경우 왼쪽자식노드로 큰 경우 오른쪽 자식 노드로 하강한다.
			// 만약 빈공간이라면 빈공간에 삽입한다.

			// 이진탐색트리 삭제
			// 1. 자식이 0개인 노드의 삭제 : 단순 삭제를 진행한다.
			// 아래의 이진탐색트리에서 22를 삭제

			// 2. 자식이 1개인 노드의 삭제 : 삭제하는 노드의 부모와 자식을 연결 후 삭제한다.
			// 아래의 이진탐색트리에서 38 삭제

			// 3. 자식이 2개인 노드의 삭제 : 삭제하는 노드를 기준으로 오른쪽 자식중 가장 작은 값 노드와 교체
			// 아래의 이진탐색트리에서 23삭제

			// 이진탐색트리 정렬
			// 이진탐색트리는 중위순회시 오른차순으로 정렬된다.

			// 중위 순회는 왼쪽 가운데 오른쪽 순서대로 하는 것 

			// 이진탐색트리 주의점
			// 이진탐색트리는 최악의 상황에 노드들이 한 쪽 자식으로만 추가되는 불군형 현상이 발생이 가능하다
			// 이 경우 탐색영역이 절반으로 풀여지지 않기 때문에 시간복잡도가 증가한다.

			// 이러한 현상을 막기 위해 자가균형기능을 추가한 트리의 사용이 일반적이다.
			// 자가균형트리는 회전을 이용하여 불균형이 있는 상황을 해결한다.

			// 대표적인 방식으로 Red-Black Tree, AVL Tree 등을 통해 불균형 상황을 파악한다.

			// 이진탐색트리 평균 접근 logn 탐색 logn 삽입 logn 삭제 logn
			// 최악 접근 n 탐색 n 삽입 n 삭제 n

			// 이진탐색트리 기반의 SortedSet 자료구조
			// 중복이 없는 정렬을 보장한 저장소

			// 삽입
			SortedSet<int> sortedSet = new SortedSet<int>();

			sortedSet.Add(1);
			sortedSet.Add(3);
			sortedSet.Add(4);
			sortedSet.Add(6);
			sortedSet.Add(7);
			sortedSet.Add(8);
			sortedSet.Add(9);
			sortedSet.Add(9); // 중복 추가는 무시한다.
			sortedSet.Add(2);

			// 삭제
			sortedSet.Remove(4);

			// 탐색
			sortedSet.Contains(6);

			foreach (int value1 in sortedSet)
			{
				Console.WriteLine(value1);
			}

			// 이진탐색트리 기반의 sortedDictionary 자료구조
			// 중복을 허용하지 않는 key를 기준으로 정렬을 보장한 value 저장소이다.
			SortedDictionary<string, Book> sortedDictionary = new SortedDictionary<string, Book>();

			sortedDictionary.Add("BookA", new Book("BookA", "WriterA", 100));
			sortedDictionary.Add("BookC", new Book("BookC", "WriterC", 200));
			sortedDictionary.Add("BookB", new Book("BookB", "WriterB", 300));
			sortedDictionary.Add("BookD", new Book("BookD", "WriterD", 400));
			sortedDictionary.Add("BookE", new Book("BookE", "WriterE", 500));
			// 동일한 키값으로 할 수는 없다. BookC를 또 사용할 수는 없다.
			// 키 가나다 순? 으로 해줌

			// 삭제
			sortedDictionary.Remove("BookD");

			// 탐색 
			sortedDictionary.ContainsKey("BookB"); // 포함을 하고 있는지
			sortedDictionary.TryGetValue("BookE", out Book book); // 탐색시도
			string str = sortedDictionary["BookA"].ToString();

			// 순서대로 출력시 정렬된 결과 확인
			foreach (string key in sortedDictionary.Keys)
			{
				Console.WriteLine(key);
			}

			foreach (Book value1 in sortedDictionary.Values)
			{
				Console.WriteLine(value1);
			}

			// 트리

			// 계층적인 자료를 나타내는데 자주 사용되는 자료구조이다
			// 부모노드가 여러자식노드들을 가질 수 있는 1대 다 구조
			// 한 노드에서 출발하여 다시 자기 자신의 노드로 돌아오는 순환구조를 가지지 않음

			// 트리 구성
			// 부모 : 루트 노드 방향으로 직접 연결된 노드
			// 자식 : 루트 노드 반대방향으로 직접 연결된 노드

			// 뿌리 : 부모노드가 없는 최상위 노드, 트리의 깊이 0에 하나만 존재
			// 가지 : 부모노드와 자식노드가 모두 있는 노드, 트리의 중간에 존재
			// 잎 : 자식노드가 없는 노드, 트리의 끝에 존재

			// 길이 : 출발 노드에서 도착 노드까지 거치는 수
			// 깊이 : 루트 노드부터의 길이
			// 차수 : 자식노드의 갯수

			// 트리 사용처
			// 주로 계층구조를 가질 수 있는 자료나 효율적인 검색에 많이 사용된다.
			// ex) 윈도우의 폴더 구조, 문서의 목차, 데이터 베이스 검색 엔진의 구조
			// 상위 스킬을 배워야 하위스킬을 배울 수 있는 스킬트리

			// 트리 구현
			// 노드를 기반으로 부모노드와 자식노드들을 볼관할 수 있도록 구성
			// 자식노드들의 최대갯수가 정해져 있는 경우 배열로 정해지지 않은 경우 리스트로 구현한다.

			// 이진트리
			// 부모노드가 자식노드를 최대 2개까지만 자실 수 있는 트리
			// n개의 자식을 가질 수 있는 트리를 연결구조를 변경하여 이진트리로 변환 가능
			// 그러므로 특별한 이유가 없는 이상은 이진트리로 구현하는 것이 일반적이다.

			// 이진트리 순회
			// 트리는 비선형 자료구조로 순차적 처리를 위해 순서에 대해 규칙을 선정해야한다.
			// 순회의 방식은 크게 전위, 중위, 후위 순회가 있다
			// 전위순회 노드 왼쪽 오른쪽
			// 중위순회 왼쪽 노드 오른쪽
			// 후위순회 왼쪽 오른쪽 노드

			// 힙
			// 부모 노드가 자식노드보다 우선순위가 높은 속성을 만족하는 트리기반의 자료구조
			// 많은 자료중 우선순위가 가장 높은 요소를 빠르게 가져오기 위해 사용

			// 힙 구현
			// 힙은 노드들이 트리의 빈틈없이 채운 완전이진트리를 구조를 가지며
			// 부모 노드가 두 자식노드보다 우선순위가 높은 값을 위치시킴
			// 힙 상태를 만족하는 경우 가장 최상단 노드가 모든 노드 중 우선순위가 가장 높다.

			// 힙 노드 삽입
			// 1. 힙의 최고 싶이 마지막에 새 노드를 추가한다.

			// 2. 삽입한 노드와 부모 노드를 비교하여 운선위가 더 높은 경우 교체한다.

			// 3. 더이상 교체되지 않을 때 가지 과정을 반복한다.

			// 힙 노드 삭제
			// 1. 최상단의 노드와 마지막 노드를 교체한 뒤 마지막 노드를 삭제한다.

			// 2. 교체된 노드와 두 자식 노드를 비교하여 우선순위가 더 높은 노드와 교체한다.

			// 3. 더 이상 교체되지 않을 때 까지 과정을 반복한다.

			// 힙 구현
			// 힙의 완전이진트리 특징의 경우 배열을 통해서 구현하기 좋음
			// 노드의 위치를 배열에 순서대로 저장
			// 노드가 위치한 인덱스에 연산을 진행하여 노드 이동이 가능하다.

			// 부모로 이동 (inex - 1) / 2
			// 왼쪽 자식으로 이동 2 * index + 1
			// 오른쪽 자식으로 이동 2 * index + 2

			// 오름차순 기본 int 우선순위
			PriorityQueue<string, int> pq1 = new PriorityQueue<string, int>();

			pq1.Enqueue("Data1", 1);
			pq1.Enqueue("Data7", 7);
			pq1.Enqueue("Data5", 5);
			pq1.Enqueue("Data3", 3);
			pq1.Enqueue("Data9", 9);

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(pq1.Dequeue());
			}

			pq1.Enqueue("Data4", 4);
			pq1.Enqueue("Data2", 2);
			pq1.Enqueue("Data6", 6);
			pq1.Enqueue("Data8", 8);

			while (pq1.Count > 0)
			{
				Console.WriteLine(pq1.Dequeue());
			}

			// 내림차순 int 우선순위에 * -1을 적용하여 사용

			PriorityQueue<string, int> pq2 = new PriorityQueue<string, int>();
			pq2.Enqueue("Data1", -1);
			pq2.Enqueue("Data7", -7);
			pq2.Enqueue("Data5", -5);
			pq2.Enqueue("Data3", -3);
			pq2.Enqueue("Data9", -9);

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(pq2.Dequeue());
			}

			pq2.Enqueue("Data4", -4);
			pq2.Enqueue("Data2", -2);
			pq2.Enqueue("Data6", -6);
			pq2.Enqueue("Data8", -8);

			while (pq2.Count > 0)
			{
				Console.WriteLine(pq2.Dequeue());
			}

			// 해시테이블
			// 키 값을 해시함수로 해싱하여 해시테이블의 특정 위치로 직접 엑서스하도록 만든 방식
			// 해시 : 임의의 길이를 가진 데이터를 고정된 길이를 가진 데이터로 매핑

			// 해시테이블 구현
			// 데이터를 담을 테이블을 이미 크게 확보해 놓은 후
			// 입력 받은 키를 해싱하여 테이블 고유한 index를 계산하고 데이이터를 담아 보관한다.

			// 해시함수
			// 키 값을 해싱하여 고유한 index를 만드는 함수이다
			// 조건 : 하나의 키값을 해싱하는 경우 반드시 항상 같은 index를 반환해야한다.
			// 효율 1. : 해시함수 과정이 빠를수록 좋다.
			// 2. 해시함수의 결과 index의 분산이 클수록 좋다
			// 3. 해시함수의 결과가 충돌이 적을수록 좋다.

			// 나눔셋법 : 데이터 % 테이블 크기 예시 : 132031 % 1000 = 31
			// 자리수접기 : 데이터의 각 자리수의 합 예시 : hash h 104 a 97 s 115 h 104 = 420

			// 해시에티블 주의점 - 충돌
			// 해시함수가 서로 다른 입력 값에 대해 동일한 해시테이블 주소를 반환하는 것
			// 모든 입력 값에 대해 고유한 해시 값을 만드는 것은 불가능하며 충돌은 피할 수 없다

			// 충돌해결방안 - 체이닝
			// 해시 충돌이 발생하면 연결리스트로 데이터들을 연결하는 방식
			// 장점 : 해시테이블에 자료상승률에 따른 성능저하가 적다
			// 단점 : 해시테이블 외 추가적인 저장공간이 필요하며 삽입삭제시 오버헤드가 발생한다

			// 충돌해결방안 - 개방주소법
			// 해시 충돌이 발생하면 다른 빈 공간에 데이터를 삽입하는 방식
			// 해시 충돌시 선형탐색, 제곱탐색, 이중해시 등을 통해 다른 빈 공간을 선정
			// 장점 : 추가적인 저장공간이 필요하지 않음, 삽입삭제시 오버헤드가 적음
			// 단점 : 해시테이블에 자료사용률이 임계치 이후 급격한 성능저하가 발생한다

			// 개방주소법 해시테이블의 공간 사용률이 높을 경우(통계적으로 70% 이상) 급격한 성능저하가 발생한다.
			// 이런 경우 재해싱을 통해 공간 사용률을 낮추어 다시 효율을 확보한다.
			// 재해싱 : 해시테이블의 크기를 늘리고 테이블 내의 모든 데이터를 다시 해싱하여 보관한다.

			// 해시테이블의 시간 복잡도 접근 x 탐색 1 삽입 1 삭제 1

			// 해시테이블 기반의 HashSet 자료구조
			// 중복이 없는 해싱을 통한 빠른 탐색의 저장소
			HashSet<int> hashSet = new HashSet<int>();

			// 삽입
			hashSet.Add(1);
			hashSet.Add(3);
			hashSet.Add(4);
			hashSet.Add(5);
			hashSet.Add(2);
			hashSet.Add(3);
			hashSet.Add(3); // 중복 추가는 무시한다.
			hashSet.Add(3);

			// 삭제
			hashSet.Remove(4);

			// 탐색
			hashSet.Contains(3); // 포함하고 있는지

			foreach (int value1 in hashSet)
			{
				Console.WriteLine(value1);
			}

			// 해시에티블 기반의 Dictionary 자료구조
			// 중복을 허용하지 않는 key를 기준으로 해싱을 통한 빠른 탐색의 value 저장소

			Dictionary<string, Book> dictionary = new Dictionary<string, Book>();
			dictionary.Add("BookA", new Book("BookA", "writerA", 100));
			dictionary.Add("BookB", new Book("BookB", "writerB", 200));
			dictionary.Add("BookD", new Book("BookD", "writerD", 300));
			dictionary.Add("BookC", new Book("BookC", "writerC", 400));
			dictionary.Add("BookE", new Book("BookE", "writerE", 500));
			// 동일한 키값의 데이터는 사용할 수 없다.

			// 삭제
			dictionary.Remove("BookD");

			// 탐색
			dictionary.ContainsKey("BookB"); // 포함 확인
			dictionary.TryGetValue("BookE", out Book book1); // 탐색 시도
			string str1 = dictionary["BookA"].ToString();

			foreach (string key in dictionary.Keys)
			{
				Console.WriteLine(key);
			}

			foreach (Book value1 in dictionary.Values)
			{
				Console.WriteLine(value);
			}

			// 알고리즘 설계기법
			// 어떤 문제를 해결하는 과정에서 해당 문제의 답을 효과적으로 찾아가기 위한 전략과 접근 방식이다
			// 문제를 풀 때 어떤 알고리즘 설계 기법을 쓰는지에 따라 효율성이 막대하게 차이난다.
			// 문제의 성질과 조겐에 따라 알맞은 알고리즘 설계기법을 선택하여 사용한다.

			// 재귀
			// 어떠한 것을 정의할 때 자기 자신을 참조하는 것
			// 함수를 정의할 때 자기자신을 이용하여 표현하는 방법

			// 재귀함수 조건
			// 1. 함수내용중 자기자신함수를 다시 호츌해야한다.
			// 2. 종료조건이 있어야 한다.

			// 재귀함수 사용
			// Factorial : 정수를 1이 될 때까지 차감하며 곱한 값
			// x! = x * (x-1)!;
			// ex) 5! = 5 * 4!
			// = 5 * 4 * 3!
			// = 5 * 4 * 3 * 2!
			// = 5 * 4 * 3 * 2 * 1!
			// = 5 * 4 * 3 * 2 * 1

			int Factorial(int x)
			{
				if (x == 1)
				{
					return 1;
				}
				else
				{
					return x * Factorial(x - 1);
				}
			}

			Console.WriteLine(Factorial(3));

			// 백트래킹
			// 모든 경우의 수를 전부 고려하는 알고리즘
			// 후보해를 검증 도중 해가 아닌 경우 되돌아가서 다시 해를 찾아가는 기법
			// 예시 - 순열

			List<int> list6 = new List<int>();

			void Permutation(int n, int r, int count = 0)
			{
				if (count == r)
				{
					Console.WriteLine(string.Join(' ', list6));
					return;
				}

				for (int i = 1; i <= n; i++)
				{
					if (list6.Contains(i))
					{
						continue;
					}

					list6.Add(i);
					Permutation(n, r, i + 1);
					list6.RemoveAt(list6.Count - 1);
				}
			}

			// 분할정복
			// 큰 문제를 작은 문제로 나눠서 푸는 하향식 접근 방식
			// 분할을 통해서 해결하기 쉬운 작은 문제로 나눈 후 정복한 후 병합하는 과정이다

			int Pow(int x, int n)
			{
				if (n == 1)
				{
					return x;
				}

				int halfPow = Pow(x, n / 2);
				if (n % 2 == 0)
				{
					return halfPow * halfPow;
				}
				else
				{
					return halfPow * halfPow * x;
				}
			}

			// 동적 계획법
			// 작은 문제의 해답을 큰 문제의 해당의 부분으로 이용하는 상향식 접근 방식
			// 주어진 문제를 해결하기 위해 부분 문제에 대한 답을 계속적으로 활용해 나가는 기법이다.

			// 예시 - 피보나치 수열
			int Fibonachi(int x)
			{
				int[] fibonachi = new int[x + 1];
				fibonachi[1] = 1;
				fibonachi[2] = 1;

				for (int i = 3; i <= x; i++)
				{
					fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
				}

				return fibonachi[x];
			}

			// 탐욕 알고리즘
			// 문제를 해결하는데 사용되는 근시안(짧은시야)적 방법
			// 문제를 직면한 당시에 당장 최적인 답을 선택하는 과정을 반복
			// 단, 반드시 최적의 해를 구해준다는 보장이 없음

			// 예시 자판기 거스름돈

			void CoinMachine(int money)
			{
				int[] coinType = { 500, 100, 50, 10, 5, 1 };

				foreach (int coin in coinType)
				{
					while (money <= coin)
					{
						Console.WriteLine(coin);
						money -= coin;
					}
				}
			}



			Random random = new Random();
			int count = 20;

			List<int> selectionList = new List<int>(count);
			List<int> insertionList = new List<int>(count);
			List<int> bubbleList = new List<int>(count);
			List<int> mergeList = new List<int>(count);
			List<int> quickList = new List<int>(count);
			List<int> heapList = new List<int>(count);
			List<int> introList = new List<int>(count);

			Console.WriteLine("랜덤 데이터 : ");
			for (int i = 0; i < count; i++)
			{
				int rand = random.Next() % 100;
				Console.Write($"{rand,3}");

				selectionList.Add(rand);
				insertionList.Add(rand);
				bubbleList.Add(rand);
				heapList.Add(rand);
				mergeList.Add(rand);
				quickList.Add(rand);
				introList.Add(rand);
			}
			Console.WriteLine();

			Console.WriteLine("선택 정렬 결과 : ");
			Sorting.SelectionSort(selectionList);
			foreach (int i in selectionList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();

			Console.WriteLine("삽입 정렬 결과 : ");
			Sorting.InsertionSort(insertionList);
			foreach (int i in insertionList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();

			Console.WriteLine("버블 정렬 결과 : ");
			Sorting.BubbleSort(bubbleList);
			foreach (int i in bubbleList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();


			Console.WriteLine("합병 정렬 결과 : ");
			Sorting.MergeSort(mergeList);
			foreach (int i in mergeList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();


			Console.WriteLine("퀵 정렬 결과 : ");
			Sorting.QuickSort(quickList);
			foreach (int i in quickList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();


			Console.WriteLine("힙 정렬 결과 : ");
			Sorting.HeapSort(heapList);
			foreach (int i in heapList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();


			Console.WriteLine("인트로 정렬 결과 : ");
			introList.Sort();
			foreach (int i in introList)
			{
				Console.Write($"{i,3}");
			}
			Console.WriteLine();

			// 순차 탐색
			int index1;
			int index2;
			int[] array1 = { 1, 3, 5, 7, 9, 8, 6, 4, 2, 0 };
			Console.Write("배열 : ");
			foreach (int i in array1)
			{
				Console.Write($"{i,2}");
			}
			Console.WriteLine();

			index1 = Array.IndexOf(array1, 2);
			index2 = Searching.SequentialSearch(array1, 2);
			Console.WriteLine($"순차탐색 결과 위치 : {index1}");
			Console.WriteLine($"구현한 순차탐색 결과 위치 : {index2}");
			Console.WriteLine();

			// 이진 탐색
			index1 = Array.BinarySearch(array1, 2);
			index2 = Searching.BinarySearch(array1, 2);
			Console.WriteLine("정렬 전 결과");
			Console.WriteLine($"이진탐색 결과 위치 : {index1}");
			Console.WriteLine($"구현한 이진탐색 결과 위치 : {index2}");
			Console.WriteLine();

			Array.Sort(array1); // 이진탐색의 경우 우선 정렬이 필요하다
			Console.Write("정렬된 배열 : ");
			foreach (int i in array1)
			{
				Console.Write($"{i,2}");
			}
			Console.WriteLine();

			index1 = Array.BinarySearch(array1, 2);
			index2 = Searching.BinarySearch(array1, 2);
			Console.WriteLine("정렬 후 결과");
			Console.WriteLine($"이진탐색 결과 위치 : {index1}");
			Console.WriteLine($"구현한 이진탐색 결과 위치 : {index2}");
			Console.WriteLine();

			bool[,] graph = new bool[8, 8]
			{
				{ false,  true, false, false, false, false, false, false },
				{  true, false,  true, false, false,  true, false, false },
				{ false,  true, false, false,  true,  true, false, false },
				{ false, false, false, false, false,  true, false, false },
				{ false, false,  true, false, false, false,  true,  true },
				{ false,  true,  true,  true, false, false, false, false },
				{ false, false, false, false,  true, false, false, false },
				{ false, false, false, false,  true, false, false, false },
			};

			// DFS 탐색
			Console.WriteLine("<DFS>");
			Searching.DFS(graph, 0, out bool[] dfsVisited, out int[] dfsParents);
			PrintGraphSearch(dfsVisited, dfsParents);
			Console.WriteLine();

			// BFS 탐색
			Console.WriteLine("<BFS>");
			Searching.BFS(graph, 0, out bool[] bfsVisited, out int[] bfsParents);
			PrintGraphSearch(bfsVisited, bfsParents);
			Console.WriteLine();

			static void PrintGraphSearch(bool[] visited, int[] parents)
			{
				Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Parent",8}");

				for (int i = 0; i < visited.Length; i++)
				{
					Console.WriteLine($"{i,8}{visited[i],8}{parents[i],8}");
				}
			}

			int[,] graph1 = new int[9, 9]
			{
				{   0, INF,   1,   7, INF, INF, INF,   5, INF},
				{ INF,   0, INF, INF, INF,   4, INF, INF, INF},
				{ INF, INF,   0, INF, INF, INF, INF, INF, INF},
				{   5, INF, INF,   0, INF, INF, INF, INF, INF},
				{ INF, INF,   9, INF,   0, INF, INF, INF,   2},
				{   1, INF, INF, INF, INF,   0, INF,   6, INF},
				{ INF, INF, INF, INF, INF, INF,   0, INF, INF},
				{   1, INF, INF, INF,   4, INF, INF,   0, INF},
				{ INF,   5, INF,   2, INF, INF, INF, INF,   0}
			};

			Dijkstra.ShortestPath(graph1, 0, out bool[] visited, out int[] distance, out int[] parents);
			PrintDijkstra(visited, distance, parents);

			bool[,] tileMap = new bool[9, 9]
			{
				{ false, false, false, false, false, false, false, false, false },
				{ false,  true,  true,  true, false, false, false,  true, false },
				{ false,  true, false,  true, false, false, false,  true, false },
				{ false,  true, false,  true,  true,  true,  true,  true, false },
				{ false,  true, false,  true, false,  true,  true,  true, false },
				{ false,  true, false,  true, false,  true,  true,  true, false },
				{ false, false, false, false, false, false, false,  true, false },
				{ false,  true,  true,  true,  true,  true,  true,  true, false },
				{ false, false, false, false, false, false, false, false, false },
			};


		}

		private static void PrintDijkstra(bool[] visited, int[] distance, int[] parents)
		{
			Console.WriteLine($"{"Vertex",-12}{"Visit",-12}{"Distance",-12}{"Parent",-12}");

			for (int i = 0; i < visited.Length; i++)
			{
				Console.Write($"{i,-12}");

				Console.Write($"{visited[i],-12}");

				if (distance[i] >= INF)
				{
					Console.Write($"{"INF",-12}");
				}
				else
				{
					Console.WriteLine($"{distance[i],-12}");
				}

				Console.WriteLine($"{parents[i],-12}");
			}
		}

		static void PrintResult(in bool[,] tileMap, in List<Point> path)
		{
			char[,] pathMap = new char[tileMap.GetLength(0), tileMap.GetLength(1)];
			for (int y = 0; y < pathMap.GetLength(0); y++)
			{
				for (int x = 0; x < pathMap.GetLength(1); x++)
				{
					if (tileMap[y, x])
						pathMap[y, x] = ' ';
					else
						pathMap[y, x] = 'X';
				}
			}

			foreach (Point point in path)
			{
				pathMap[point.y, point.x] = '*';
			}

			Point start = path.First();
			Point end = path.Last();
			pathMap[start.y, start.x] = 'S';
			pathMap[end.y, end.x] = 'E';

			for (int i = 0; i < pathMap.GetLength(0); i++)
			{
				for (int j = 0; j < pathMap.GetLength(1); j++)
				{
					Console.Write(pathMap[i, j]);
				}
				Console.WriteLine();
			}
		}
	}

	public class Book
	{
		public string name;
		public string writer;
		public int pages;

		public Book(string name, string writer, int pages)
		{
			this.name = name;
			this.writer = writer;
			this.pages = pages;
		}

		public override string ToString()
		{
			return $"{name}, {writer}, {pages}";
		}
	}

	public class Sorting
	{
		// 선택정렬
		// 데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
		// 시간 복자도 n2 공간복잡도 1 안정정렬 0

		public static void SelectionSort(IList<int> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				int minIndex = i;
				for (int j = i; j < list.Count; j++)
				{
					if (list[j] < list[minIndex])
					{
						minIndex = j;
					}
				}
				Swap(list, i, minIndex);
			}
		}

		// 삽입정렬
		// 데이터를 하나씩 꺼내어 정렬된 자료중 적합한 위치에 삽입하여 정렬
		// 시간 복자도 n2 공간 복잡도 1 안정정렬 0

		public static void InsertionSort(IList<int> list)
		{
			for (int i = 1; i < list.Count; i++)
			{
				for (int j = i; j > 0; j--)
				{
					if (list[j - 1] > list[j])
					{
						Swap(list, j - 1, j);
					}
					else
					{
						break;
					}
				}
			}
		}

		// 버블정렬
		// 서로 인접한 데이터를 비교하여 정렬
		// 시간복잡도 n2 공간복잡도 1 안정정렬 - 0

		public static void BubbleSort(IList<int> list)
		{
			for (int i = 1; i < list.Count; i++)
			{
				for (int j = 0; j < list.Count - i; j++)
				{
					if (list[j] > list[j + 1])
					{
						Swap(list, j, j + 1);
					}
				}
			}
		}

		// 병합정렬
		// 데이터를 2분할하여 정렬 후 합병
		// 데이터 갯수만큼의 추가적인 메모리가 필요
		// 시간복잡도 nlogn 공간복잡도 n 안정정렬 0

		public static void MergeSort(IList<int> list) => MergeSort(list, 0, list.Count - 1);

		public static void MergeSort(IList<int> list, int start, int end)
		{
			if (start == end)
			{
				return;
			}

			int mid = (start + end) / 2;
			MergeSort(list, start, mid);
			MergeSort(list, mid + 1, end);
			Merge(list, start, mid, end);
		}

		private static void Merge(IList<int> list, int start, int mid, int end)
		{
			List<int> sortedList = new List<int>();
			int leftIndex = start;
			int rightIndex = mid + 1;

			while (leftIndex <= mid && rightIndex <= end)
			{
				if (list[leftIndex] < list[rightIndex])
				{
					sortedList.Add(list[leftIndex++]);
				}
				else
				{
					sortedList.Add(list[rightIndex++]);
				}
			}

			if (leftIndex > mid)
			{
				for (int i = rightIndex; i <= end; i++)
				{
					sortedList.Add(list[i]);
				}
			}
			else // if (rightIndex > end)
			{
				for (int i = leftIndex; i <= mid; i++)
				{
					sortedList.Add(list[i]);
				}
			}

			for (int i = 0; i < sortedList.Count; i++)
			{
				list[start + i] = sortedList[i];
			}
		}

		// 퀵정렬
		// 하나의 피벗을 기준으로 작은값과 큰값을 2분할하여 정렬
		// 최악의 경우(피벗이 최소값 또는 최대값)인 경우 시간복잡도 n2
		// 시간복잡도 - 평균 nlogn 최악 n2
		// 공간복잡도 1
		// 안정정렬 x

		public static void QuickSort(IList<int> list) => QuickSort(list, 0, list.Count - 1);

		public static void QuickSort(IList<int> list, int start, int end)
		{
			if (start >= end)
			{
				return;
			}

			int pivot = start;
			int left = pivot + 1;
			int right = end;

			while (left <= right)
			{
				while (list[left] <= list[pivot] && left < right)
				{
					left++;
				}
				while (list[right] > list[pivot] && left <= right)
				{
					right--;
				}

				if (left < right)
				{
					Swap(list, left, right);
				}
				else
				{
					Swap(list, pivot, right);
					break;
				}
			}

			QuickSort(list, start, right - 1);
			QuickSort(list, right + 1, end);
		}


		// 힙정렬
		// 힙을 이용하여 우선순위가 가장 높은 요소가 가장 마지막 요소와 교체된 후 제거되는 방법을 이용
		// 배열에서 연속적인 데이터를 사용하지 않기 때문에 캐시 메모리를 효율적으로 사용할 수 없어 상대적으로 느림
		// 시간복잡도 nlogn
		// 공간복잡도 1
		// 안정정렬 x

		public static void HeapSort(IList<int> list)
		{
			MakeHeap(list);

			for (int i = list.Count - 1; i > 0; i--)
			{
				Swap(list, 0, i);
				Heapify(list, 0, i);
			}
		}

		private static void MakeHeap(IList<int> list)
		{
			for (int i = list.Count / 2 - 1; i >= 0; i--)
			{
				Heapify(list, i, list.Count);
			}
		}

		private static void Heapify(IList<int> list, int index, int size)
		{
			int left = index * 2 + 1;
			int right = index * 2 + 2;
			int max = index;
			if (left < size && list[left] > list[max])
			{
				max = left;
			}
			if (right < size && list[right] > list[max])
			{
				max = right;
			}

			if (max != index)
			{
				Swap(list, index, max);
				Heapify(list, max, size);
			}
		}

		private static void Swap(IList<int> list, int left, int right)
		{
			int temp = list[left];
			list[left] = list[right];
			list[right] = temp;
		}
	}

	public class Graph
	{
		// 그래프
		// 정점의 모음과 이 정점을 잇는 간선의 모음의 결합
		// 한 노드에서 출발하여 다시 자기 자신의 노드로 돌아오는 순환구조를 가졌다
		// 간선의 방향성에 따라 단 방향 그래프, 양 방향 그래프가 있다.
		// 간선의 가중치에 따라 연결 그래프, 가중치 그래프가 있다.

		// 인접행렬 그래프
		// 그래프 내의 각 정점의 인접 관계를 나타내는 행렬
		// 2차원 배열을 [출발정점, 도착정점]으로 표현한다.
		// 장점 : 인접여부 접근이 빠르다.
		// 단점 : 메모리 사용량이 많다.

		// 예시 양방향 연결 그래프
		bool[,] matrixGraph1 = new bool[5, 5]
		{
				{ false, false, false, false,  true },
				{ false, false,  true, false, false },
				{ false,  true, false,  true, false },
				{ false, false,  true, false,  true },
				{  true, false, false,  true, false },
		};

		const int INF = int.MaxValue;

		// 예시 - 단방향 가중치 그래프(단절은 최대값으로 표현한다.)
		int[,] matrixGraph2 = new int[5, 5]
		{
				{   0, 132, INF, INF,  16 },
				{  12,   0, INF, INF, INF },
				{ INF,  38,   0, INF, INF },
				{ INF,  12, INF,   0,  54 },
				{ INF, INF, INF, INF,   0 },
		};

		// 인접리스트 그래프
		// 그래프 내의 각 정점의 인접 관계를 표현하는 리스트
		// 인접한 간선만큼 리스트에 추가하여 관리한다.
		// 장점 : 메모리 사용량이 적다
		// 단점 : 인접여부를 확인하기 위해 리스트 탐색이 필요하다

		// 예시 
		List<int>[] listGraph1;
		List<(int, int)>[] listGraph2;
		public void CreateGraph()
		{
			listGraph1 = new List<int>[5];

			listGraph1[0].Add(1);
			listGraph1[1].Add(0);
			listGraph1[1].Add(3);
			listGraph1[2].Add(0);
			listGraph1[2].Add(1);
			listGraph1[2].Add(4);
			listGraph1[3].Add(1);
			listGraph1[4].Add(3);
		}
	}

	public class Searching
	{
		// 순차 탐색
		// 자료구조에서 순차적으로 찾고자 하는 데이터를 탐색
		// 시간 복잡도 - n
		public static int SequentialSearch<T>(IList<T> list, in T item) where T : notnull
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Equals(item))
				{
					return i;
				}
			}

			return -1;
		}

		// 이진 탐색
		// 정렬이 되어 있는 자료구조에서 2분할을 통해 데이터를 탐색
		// 단, 이진 탐색은 정렬이 되어 있는 자료에만 적용 가능하다
		// 시간복잡도 logn
		public static int BinarySearch<T>(IList<T> list, in T item) where T : IComparable<T>
		{
			int low = 0;
			int high = list.Count - 1;
			while (low <= high)
			{
				int middle = (low + high) / 2;
				int compare = list[middle].CompareTo(item);

				if (compare < 0)
				{
					low = middle + 1;
				}
				else if (compare > 0)
				{
					high = middle - 1;
				}
				else
				{
					return middle;
				}
			}

			return -1;
		}

		// 깊이 우선 탐색
		// 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤
		// 분기의 탐색을 마쳤을 때 다음 분기를 탐색
		// 스택을 통해
		public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
		{
			int size = graph.GetLength(0);
			visited = new bool[size];
			parents = new int[size];

			for (int i = 0; i < size; i++)
			{
				visited[i] = false;
				parents[i] = -1;
			}

			SearchNode(graph, start, visited, parents);
		}

		private static void SearchNode(bool[,] graph, int vertex, bool[] visited, int[] parents)
		{
			int size = graph.GetLength(0);
			visited[vertex] = true;
			for (int i = 0; i < size; i++)
			{
				if (graph[vertex, i] && !visited[i]) // 연결되어 있는 정점이며 방문한 적 없는 정점
				{
					parents[i] = vertex;
					SearchNode(graph, i, visited, parents);
				}
			}
		}

		// 너비 우선 탐색
		// 그래프의 분기를 만났을 때 모든 분기들을 탐색한 뒤
		// 다음 깊이의 분기들을 탐색
		// 큐를 통해 탐색한다.
		public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
		{
			int size = graph.GetLength(0);
			visited = new bool[size];
			parents = new int[size];

			for (int i = 0; i < size; i++)
			{
				visited[i] = false;
				parents[i] = -1;
			}

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(start);
			visited[start] = true;

			while (queue.Count > 0)
			{
				int next = queue.Dequeue();

				for (int i = 0; i < size; i++)
				{
					if (graph[next, i] && !visited[i])
					{
						visited[i] = true;
						parents[i] = next;
						queue.Enqueue(i);
					}
				}
			}
		}
	}

	public class Dijkstra
	{
		// 다익스트라 알고리즘
		// 특정한 노드에서 출발하여 다른 노드로 가는 각각의 최단 경로를 구함
		// 방문하지 않은 노드 중에서 최단 거리가 가장 짧은 노드를 선택 후
		// 해당 노드를 거쳐 다른 노드로 가는 비용 계산

		const int INF = 99999;

		public static void ShortestPath(int[,] graph, int start, out bool[] visited, out int[] distance, out int[] parents)
		{
			int size = graph.GetLength(0);
			visited = new bool[size];
			distance = new int[size];
			parents = new int[size];

			for (int i = 0; i < size; i++)
			{
				distance[i] = INF;
				parents[i] = -1;
				visited[i] = false;
			}
			distance[start] = 0;

			for (int i = 0; i < size; i++)
			{
				// 1. 방문하지 않은 정점 중 가장 가까운 정점부터 탐색
				int next = -1;
				int minCost = INF;
				for (int j = 0; j < size; j++)
				{
					if (!visited[j] && distance[j] < minCost)
					{
						next = j;
						minCost = distance[j];
					}
				}

				if (next < 0)
				{
					break;
				}
				visited[next] = true;

				// 2. 직접연결된 거리보다 거쳐서 더 짧아진다면 갱신
				for (int j = 0; j < size; j++)
				{
					// distance[j] : 목적지까지 직접 연결된 거리
					// distance[next] : 탐색중인 정점까지 거리
					// graph[next, j] : 탐색중인 정점부터 목적지의 거리

					if (distance[j] > distance[next] + graph[next, j])
					{
						distance[j] = distance[next] + graph[next, j];
						parents[j] = next;
					}
				}
			}
		}
	}

	public class Astar
	{
		// a 알고리즘
		// 다익스트라 알고리즘을 확장하여 만든 최단경로 탐색 알고리즘
		// 결로 탐색의 우선순위를 두고 유망한 해부터 우선적으로 탐색

		const int CostStraight = 10;
		const int CostDiagonal = 14;

		static Point[] Direction =
		{
			new Point(  0, +1 ),            // 상
			new Point(  0, -1 ),            // 하
			new Point( -1,  0 ),            // 좌
			new Point( +1,  0 ),            // 우
			new Point( -1, +1 ),            // 좌상
			new Point( -1, -1 ),            // 좌하
			new Point( +1, +1 ),            // 우상
			new Point( +1, -1 )             // 우하
		};

		public static bool PathFinding(in bool[,] tileMap, in Point start, in Point end, out List<Point> path)
		{
			int ySize = tileMap.GetLength(0);
			int xSize = tileMap.GetLength(1);

			ASNode[,] nodes = new ASNode[ySize, xSize];
			bool[,] visited = new bool[ySize, xSize];
			PriorityQueue<ASNode, int> nextPointPQ = new PriorityQueue<ASNode, int>();

			// 0. 시작 정점을 생성하여 추가
			ASNode startNode = new ASNode(start, new Point(), 0, Heuristic(start, end));
			nodes[startNode.point.y, startNode.point.x] = startNode;
			nextPointPQ.Enqueue(startNode, startNode.f);

			while (nextPointPQ.Count > 0)
			{
				// 1. 다음으로 탐색할 정점 꺼내기
				ASNode nextNode = nextPointPQ.Dequeue();

				// 2. 방문한 정점은 방문표시
				visited[nextNode.point.y, nextNode.point.x] = true;

				// 3. 다음으로 탐색할 정점이 도착지인 경우
				// 도착했다고 판단해서 경로 반환

				if(nextNode.point.x == end.x && nextNode.point.y == end.y)
				{
					path = new List<Point>();

					Point point = end;
					while(point.x == start.x && point.y == start.y == false)
					{
						path = new List<Point>();

						Point point1 = end;
						while(point1.x == start.x && point1.y == start.y == false)
						{
							path.Add(start);
							point = nodes[point.y, point.x].parent;
						}

						path.Add(start);
						path.Reverse();

						return true;
					}
				}

				// 4. AStar 탐색을 진행
				// 방향 탐색
				for (int i = 0; i < Direction.Length; i++)
				{
					int x = nextNode.point.x + Direction[i].x;
					int y = nextNode.point.y + Direction[i].y;

					// 4-1. 탐색하면 안되는 경우
					// 맵을 벗어났을 경우
					if (x < 0 || x >= xSize || y < 0 || y >= ySize)
						continue;
					// 탐색할 수 없는 정점일 경우
					else if (tileMap[y, x] == false)
						continue;
					// 이미 방문한 정점일 경우
					else if (visited[y, x])
						continue;
					// 대각선으로 이동이 불가능 지역인 경우
					else if (i >= 4 && tileMap[y, nextNode.point.x] == false && tileMap[nextNode.point.y, x] == false)
						continue;

					// 4-2. 탐색한 정점 만들기
					int g = nextNode.g + ((nextNode.point.x == x || nextNode.point.y == y) ? CostStraight : CostDiagonal);
					int h = Heuristic(new Point(x, y), end);
					ASNode newNode = new ASNode(new Point(x, y), nextNode.point, g, h);

					// 4-3. 정점의 갱신이 필요한 경우 새로운 정점으로 할당
					if (nodes[y, x] == null ||      // 탐색하지 않은 정점이거나
						nodes[y, x].f > newNode.f)  // 가중치가 높은 정점인 경우
					{
						nodes[y, x] = newNode;
						nextPointPQ.Enqueue(newNode, newNode.f);
					}
				}
			}
			path = null;
			return false;
		}

		// 휴리스틱 : 최상의 경로를 추정하는 순위값 휴릭스틱에 의해 경로 탐색 효율이 결정된다.
		private static int Heuristic(Point start, Point end)
		{
			int xSize = Math.Abs(start.x - end.x);
			int ySize = Math.Abs(start.y - end.y);

			// 맨허튼거리 : 직선을 통해 이동하는거리
			// 유클리드 거리 : 대각선을 통해 이동하는거리
			// 타일맵 거리 : 직선과 대각선을 통해 이동하는 거리

			int straightCount = Math.Abs(xSize - ySize);
			int diagonalCount = Math.Max(xSize, ySize) - straightCount;
			return CostStraight * straightCount + CostDiagonal * diagonalCount;
		}

		private class ASNode
		{
			public Point point;
			public Point parent;

			public int g;
			public int h;
			public int f;

			public ASNode(Point point, Point parent, int g, int h)
			{
				this.point = point;
				this.parent = parent;
				this.g = g;
				this.h = h;
				this.f = g + h;
			}
		}
	}

	public struct Point
	{
		public int x;
		public int y;

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}

	public class Tilemap
	{
		// 타일맵
		// 2차원 평면의 그래프를 정점이 아닌 위치를 통해 표현하는 그래프
		// 위치의 이동가능 유무만을 표현하는 bool 이차원 타일맵
		// 타일의 종류를 표현한 이차원 타일맵이 있음
		// 인접한 이동가능한 위치간 간선이 있으며 가중치는 동일함

		// 타일맵 그래프
		// 예시 - 위치의 이동가능 표현한 이차원 타일맵
		bool[,] tileMap1 = new bool[7, 7]
		{
			{ false, false, false, false, false, false, false },
			{ false,  true, false,  true, false, false, false },
			{ false,  true, false,  true, false,  true, false },
			{ false,  true, false,  true,  true,  true, false },
			{ false,  true, false,  true, false, false, false },
			{ false,  true,  true,  true,  true,  true, false },
			{ false, false, false, false, false, false, false },
		};

		// 예시 - 타일의 종류를 표현한 이찬원 타일맵

		enum TileType
		{
			None = ' ',
			Wall = '#',
			Door = '*',
			Shop = 'S',
			Gate = 'G'
		}

		char[,] tileMap = new char[9, 9]
		{
			{ '#', '#', '#', '#', '#', '#', '#', '#', '#' },
			{ '#', ' ', '#', '#', ' ', ' ', '#', '#', '#' },
			{ '#', ' ', '#', '#', ' ', '#', '#', ' ', '#' },
			{ '#', ' ', '#', '#', '*', '#', '#', '*', '#' },
			{ '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
			{ '#', ' ', '#', ' ', '#', '#', '#', ' ', '#' },
			{ '#', ' ', '#', ' ', '#', '#', '#', ' ', '#' },
			{ '#', ' ', ' ', 'S', ' ', ' ', ' ', 'G', '#' },
			{ '#', '#', '#', '#', '#', '#', '#', '#', '#' },
		};
	}

}
