  public static void bonAppetit(List<int> bill, int k, int b)
  {
      int annaDidntEat = k;
      int initialCharge = b;
      int sumOfBill = bill.Sum();

      sumOfBill -= bill[annaDidntEat];
      int realCharge = sumOfBill/2;
      int billDiff = initialCharge - realCharge;
      if(billDiff == 0)
      {
          Console.WriteLine("Bon Appetit");
      }
      else
      {
          Console.WriteLine($"{billDiff}");
      }
  }
