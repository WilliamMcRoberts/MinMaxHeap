var maxHeap = new PriorityQueue<int>();

maxHeap.Enqueue(5);
maxHeap.Enqueue(4);
maxHeap.Enqueue(3);
maxHeap.Enqueue(2);
maxHeap.Enqueue(9);
maxHeap.Enqueue(8);
maxHeap.Enqueue(7);
maxHeap.Enqueue(6);
maxHeap.Enqueue(1);

int peakElement = maxHeap.Peek();

// Print the peak element
Console.WriteLine("Max Peak element: " + peakElement);

var minHeap = new PriorityQueue<int>(false);

minHeap.Enqueue(5);
minHeap.Enqueue(4);
minHeap.Enqueue(3);
minHeap.Enqueue(20);
minHeap.Enqueue(380);

Console.WriteLine("Min Peak element: " + minHeap.Peek());

var p1 = new Person("John", 30);
var p2 = new Person("Jane", 25);
var p3 = new Person("Jack", 40);
var p4 = new Person("Jill", 35);

var maxHeapPerson = new PriorityQueue<Person>();

maxHeapPerson.Enqueue(p1);
maxHeapPerson.Enqueue(p2);
maxHeapPerson.Enqueue(p3);
maxHeapPerson.Enqueue(p4);

Person maxAgePerson = maxHeapPerson.Peek();

Console.WriteLine("Max age person: " + maxAgePerson.Name);


var minHeapPerson = new PriorityQueue<Person>(false);

minHeapPerson.Enqueue(p1);
minHeapPerson.Enqueue(p2);
minHeapPerson.Enqueue(p3);
minHeapPerson.Enqueue(p4);

Person minAgePerson = minHeapPerson.Peek();

Console.WriteLine("Min age person: " + minAgePerson.Name);
