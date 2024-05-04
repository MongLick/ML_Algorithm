namespace _04.Queue__Stack_Task
{
	internal class Program
	{
		// 1번 문제

		// 아래와 같이 추가와 삭제가 순서대로 진행될 경우 스택, 큐의 출력 순서를  적어주자.(코딩없이) 꺼내기 마다 모두 출력 적어주자.
		// 1-1 추가(1, 2, 3, 4, 5), 모두 꺼내기 : 
		// 1-2 추가(1,2,3), 꺼내기(2번), 추가(4,5,6), 꺼내기(1번), 추가(7), 모두꺼내기 : 
		// 1-3 추가(3,2,1), 꺼내기(1번), 추가(6,5,4), 꺼내기(3번), 추가(9,8,7), 모두꺼내기 :
		// 1-4 추가(1,3,5), 꺼내기(1번), 추가(2,4,8), 꺼내기(2번), 추가(1,3), 모두꺼내기 : 
		// 1-5 추가(3,2,1), 꺼내기(2번), 추가(3,2,1), 꺼내기(2번), 추가(3,2,1), 모두꺼내기 : 

		// 2번 문제

		// <괄호 검사기를 구현하자>
		// 괄호 : 괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻

		// 텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수 작성
		// bool IsOk(string text) { }

		// 검사할 괄호 : [], {}, ()

		// 예시 : () 완성, (() 미완성, [) 미완성, [[(){}]] 완성

		static void Main(string[] args)
		{
			// 1번 문제

			//1-1
			// 스택 : 5, 4, 3, 2, 1
			// 큐 : 1, 2, 3, 4, 5

			//1-2
			// 스택 : 7, 5, 4, 1
			// 큐 : 5, 6, 7

			//1-3
			// 스택 : 7, 8, 9, 2, 3
			// 큐 : 2, 4, 8, 1, 3

			//1-4
			// 스택 : 3, 1, 2, 3, 1
			// 큐 : 2, 4, 8, 1, 3

			//1-5
			// 스택 : 3, 3, 3, 2, 1
			// 큐 : 2, 1, 2, 1

			// 2번 문제

			Console.WriteLine("괄호를 입력해주세요");
			string text = Console.ReadLine();
			IsOk(text);
			if (IsOk(text))
			{
				Console.WriteLine("완성");
			}
			else
			{
				Console.WriteLine("미완성");
			}
		}


		static public bool IsOk(string text)
		{
			Stack<char> stack = new Stack<char>();
			for(int i = 0; i < text.Length; i++)
			{
				if(text[i] == '[' || text[i] == '{' || text[i] == '(')
				{
					stack.Push(text[i]);
				}
				else 
				{
					if(stack.Peek() == '[' && text[i] == ']')
					{
						stack.Pop();
					}
					else if (stack.Peek() == '{' && text[i] == '}')
					{
						stack.Pop();
					}
					else if (stack.Peek() == '(' && text[i] == ')')
					{
						stack.Pop();
					}
				}
			}
			return stack.Count == 0;
		}
	}
}

