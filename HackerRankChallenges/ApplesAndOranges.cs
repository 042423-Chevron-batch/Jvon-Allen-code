public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        //declare variables that will hold the count of apples and oranges
     int numberOfApples = 0;
     int numberOfOranges = 0;
        
        //loop through the distances held in the list arrays
     foreach (int x in apples){
        if (a+x >= s &&  a+x <= t) //if the distance fell is in between start point & end point, increment apples count
            numberOfApples++;
     }
        //display apple count
        Console.WriteLine(numberOfApples);
        
        //loop through the distances held in the list arrays
      foreach (int y in oranges){
        if (b+y >= s &&  b+y <= t) //if the distance fell is in between start point & end point, increment oranges count
            numberOfOranges++;
     }
        //display orange count
        Console.WriteLine(numberOfOranges);         
    }
