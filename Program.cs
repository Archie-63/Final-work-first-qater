// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

  Console.WriteLine("Inpunt array length");
  int n = int.Parse(Console.ReadLine());
  string[] stringArray = new string [n];
  for(int i=0;i<n;i++)
  {
   Console.WriteLine("Inpunt array elements");
   stringArray[i] = Convert.ToString(Console.ReadLine());
  }
  string[] strarr=new string[n];
  int Count = 0;
  for(int i=0;i<n;i++)
  {
    string str = stringArray[i];
    int l = str.Length;
    if(l<=3)
    {
     strarr[i]=stringArray[i];
     Count++;
    }
  }     
  strarr = strarr.Where(x=>x!=null).ToArray();
  for(int i=0;i<Count;i++)
  {
   Console.Write($" {strarr[i]}");
  }