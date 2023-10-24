using CustomCollection.List;


IntList a = new IntList();

a.Add(4); // 5
a.Add(1); // 4
a.Print();
a.Add(new int[] { 3, 5 });
a.Add(new int[] {2});
a.Add(new int[] {});
a.InsertionSort();
//a.SelectionSort();
Console.WriteLine();
a.Print();
Console.WriteLine(a.BinarySearch(2));
Console.WriteLine(a.JumpSearch(2));