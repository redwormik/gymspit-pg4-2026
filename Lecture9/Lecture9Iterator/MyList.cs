namespace Lecture9Iterator;

using System.Collections;


class MyList<T> : IEnumerable<T>
{
	class MyNode(T value, MyNode? next = null)
	{
		public T value = value;

		public MyNode? next = next;
	}


	public class Enumerator(MyList<T> list) : IEnumerator<T>
	{
		private readonly MyList<T> list = list;

		private MyNode? current = null;

		public T Current
		{
			get
			{
				Console.WriteLine($"Current: {(current != null ? current.value : "null")}");

				return current != null ?
					current.value :
					throw new InvalidOperationException();
			}
		}

		object IEnumerator.Current => Current;


		public bool MoveNext()
		{
			Console.WriteLine($"MoveNext: {(current != null ? current.value : "null")}");

			current = current == null ? list.head : current.next;
			return current != null;
		}


		public void Reset()
		{
			Console.WriteLine($"Reset: {(current != null ? current.value : "null")}");

			current = null;
		}


		public void Dispose()
		{
		}
	}


	private MyNode? head = null;

	public bool Empty => head == null;

	public T First => head != null ?
		head.value :
		throw new InvalidOperationException();

	public IEnumerable<T> Values
	{
		get
		{
			Console.WriteLine("Values called");
			MyNode? current = head;
			while (current != null) {
				Console.WriteLine($"Values: {(current != null ? current.value : "null")}");
				yield return current.value;
				current = current.next;
			}
			Console.WriteLine("Values finished");
		}
	}


	public void InsertFirst(T value)
	{
		head = new MyNode(value, head);
	}


	public bool InsertBefore(T value, T before)
	{
		MyNode? next = head;
		MyNode? previous = null;
		
		while (next != null && !ValueEquals(next.value, before)) {
			previous = next;
			next = next.next;
		}

		if (next == null) {
			return false;
		}

		MyNode newNode = new(value, next);
		if (previous == null) {
			head = newNode;
		} else {
			previous.next = newNode;
		}

		return true;
	}


	public bool InsertAfter(T value, T after)
	{
		MyNode? previous = head;

		while (previous != null && !ValueEquals(previous.value, after)) {
			previous = previous.next;
		}

		if (previous == null) {
			return false;
		}

		previous.next = new MyNode(value, previous.next);
		return true;
	}


	public void RemoveFirst()
	{
		if (head == null) {
			throw new InvalidOperationException();
		}

		head = head.next;
	}


	public bool Remove(T value)
	{
		MyNode? next = head;
		MyNode? previous = null;

		while (next != null && !ValueEquals(next.value, value)) {
			previous = next;
			next = next.next;
		}

		if (next == null) {
			return false;
		}

		if (previous == null) {
			head = next.next;
		} else {
			previous.next = next.next;
		}

		return true;
	}


	public IEnumerator<T> GetEnumerator()
	{
		Console.WriteLine("GetEnumerator called");
		return new Enumerator(this);
	}


	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}


	private bool ValueEquals(T left, T right)
	{
		return left == null ?
			right == null :
			left.Equals(right);
	}
}
