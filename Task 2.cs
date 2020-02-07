using System;
public class FoodDelivery
{
  int NumberOfOrders, DeliveryMan1Capacity, DeliveryMan2Capacity;
  string[] ArrayOfIntegers = new string[3];
  int[] DeliveryMan1deliveryTips = new int[100];
  int[] DeliveryMan2deliveryTips = new int[100];
  int DeliveryIndex1 = 0, DeliveryIndex2 = 0;
  int tip = 0;

  public void getInputValues ()
  {
    Console.WriteLine ("Number of orders and delivery Capacity of a delivery man 1 and 2 are");
    ArrayOfIntegers = Console.ReadLine ().Split (' ');
	  
    NumberOfOrders = Convert.ToInt32 (ArrayOfIntegers[0]);
    DeliveryMan1Capacity = Convert.ToInt32 (ArrayOfIntegers[1]);
    DeliveryMan2Capacity = Convert.ToInt32 (ArrayOfIntegers[2]);
	  
    Console.WriteLine ("DeliveryMan1 tips for his deliveries is");
    DeliveryMan1deliveryTips = Array.ConvertAll (Console.ReadLine ().Split (' '), int.Parse);
	  
    Console.WriteLine ("DeliveryMan2 tips for his deliveries is");
    DeliveryMan2deliveryTips = Array.ConvertAll (Console.ReadLine ().Split (' '), int.Parse);
	  
    Array.Sort (DeliveryMan1deliveryTips);
    Array.Reverse (DeliveryMan1deliveryTips);
	  
    Array.Sort (DeliveryMan2deliveryTips);
    Array.Reverse (DeliveryMan2deliveryTips);
  }
  public void ToCalculateMaxTips ()
  {
    while (NumberOfOrders > 0)
      {
	if (DeliveryIndex1 < DeliveryMan1Capacity && DeliveryIndex2 < DeliveryMan2Capacity && DeliveryMan1deliveryTips[DeliveryIndex1] > DeliveryMan2deliveryTips[DeliveryIndex2])
	  {
	    tip += DeliveryMan1deliveryTips[DeliveryIndex1];
	    DeliveryIndex1++;
	  }
	else if (DeliveryIndex1 < DeliveryMan1Capacity && DeliveryIndex2 < DeliveryMan2Capacity && DeliveryMan1deliveryTips[DeliveryIndex1] < DeliveryMan2deliveryTips[DeliveryIndex2])
	  {
	    tip += DeliveryMan2deliveryTips[DeliveryIndex2];
	    DeliveryIndex2++;
	  }
	else if (DeliveryIndex1 < DeliveryMan1Capacity)
	  {
	    tip += DeliveryMan1deliveryTips[DeliveryIndex1];
	    DeliveryIndex1++;
	  }
	else if (DeliveryIndex2 < DeliveryMan2Capacity)
	  {
	    tip += DeliveryMan2deliveryTips[DeliveryIndex2];
	    DeliveryIndex2++;
	  }
	NumberOfOrders--;
      }
    Console.WriteLine ("The maximum delivery Tips of both DeliveryMan1 and DeliveryMan2 is");
    Console.WriteLine (tip);
  }
  public static void Main ()
  {
    FoodDelivery f = new FoodDelivery ();
    f.getInputValues ();
    f.ToCalculateMaxTips ();
    Console.ReadLine ();
  }

}
