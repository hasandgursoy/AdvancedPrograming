// 1 . Multi Dimensional Arrays = new int[5,2,3,5] 
// 2.  Jagged Array = new [5][][]

int[] d1 = (int[]) Array.CreateInstance(typeof(int),2);
int[,] d2 = (int[,]) Array.CreateInstance(typeof(int),2,3);

System.Console.WriteLine();

(string s, int i, bool b)[] d3 = new (string s, int i, bool b)[]{

    ("asdasd",123,true)
};

System.Console.WriteLine();