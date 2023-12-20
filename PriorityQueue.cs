
class PriorityQueue<T>(bool isMaxHeap = true) where T : IComparable<T>
{
    private readonly List<T> _heap = [];

    public int Count => _heap.Count;

    public void Enqueue(T item)
    {
        _heap.Add(item);
        BubbleUp(_heap.Count - 1);
    }

    public T Dequeue()
    {
        T item = _heap[0];
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];
        _heap.RemoveAt(lastIndex);
        BubbleDown(0);
        return item;
    }

    public T Peek() => _heap[0];

    private void BubbleUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (isMaxHeap)
            {
                if (_heap[parentIndex].CompareTo(_heap[index]) >= 0)
                    break;
            }
            else
            {
                if (_heap[parentIndex].CompareTo(_heap[index]) <= 0)
                    break;
            }
            Swap(parentIndex, index);
            index = parentIndex;
        }
    }

    private void BubbleDown(int index)
    {
        while (index < _heap.Count)
        {
            int leftChildIndex = index * 2 + 1;
            int rightChildIndex = index * 2 + 2;
            if (!isMaxHeap)
            {
                int smallestchildIndex = index;
                if (leftChildIndex < _heap.Count && _heap[leftChildIndex].CompareTo(_heap[smallestchildIndex]) < 0)
                    smallestchildIndex = leftChildIndex;
                if (rightChildIndex < _heap.Count && _heap[rightChildIndex].CompareTo(_heap[smallestchildIndex]) < 0)
                    smallestchildIndex = rightChildIndex;
                if (smallestchildIndex == index)
                    break;

                Swap(smallestchildIndex, index);
                index = smallestchildIndex;
                return;
            }

            int largestChildIndex = index;
            if (leftChildIndex < _heap.Count && _heap[leftChildIndex].CompareTo(_heap[largestChildIndex]) > 0)
                largestChildIndex = leftChildIndex;
            if (rightChildIndex < _heap.Count && _heap[rightChildIndex].CompareTo(_heap[largestChildIndex]) > 0)
                largestChildIndex = rightChildIndex;
            if (largestChildIndex == index)
                break;

            Swap(largestChildIndex, index);
            index = largestChildIndex;
        }
    }

    private void Swap(int i, int j) =>
        (_heap[j], _heap[i]) = (_heap[i], _heap[j]);
}

class Person(string name, int age) : IComparable<Person>
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public int CompareTo(Person? other)
    {
        if (this.Age < other?.Age) return -1;
        if (this.Age == other?.Age) return 0;
        return 1;
    }
}
