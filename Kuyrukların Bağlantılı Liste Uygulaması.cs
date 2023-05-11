using System;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[0]; 

        while (true)
        {
            Console.WriteLine("Lutfen asagidaki islemlerden birini seciniz:");
            Console.WriteLine("1. Ekleme");
            Console.WriteLine("2. Silme");
            Console.WriteLine("3. Goruntule");
            Console.WriteLine("4. Cikis");
            Console.WriteLine();
            Console.Write("Seciminiz:");

            int choice = int.Parse(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Eklemek istediginiz degeri giriniz: ");
                    int elementToAdd = int.Parse(Console.ReadLine());

                    Array.Resize(ref myArray, myArray.Length + 1);
                    myArray[myArray.Length - 1] = elementToAdd;

                    Console.WriteLine(" {0} degeri diziye eklendi.", elementToAdd);
                    Console.WriteLine();
                    break;

                case 2:
                    if (myArray.Length == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Dizi bos!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Su anki dizi: ");
                        foreach (int item in myArray)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        Console.Write("Cikarmak istediginiz degeri giriniz:: ");
                        int elementToRemove = int.Parse(Console.ReadLine());

                        int indexToRemove = Array.IndexOf(myArray, elementToRemove);
                        if (indexToRemove == -1)
                        {
                            Console.WriteLine("{0} degeri dizide bulunamadi.", elementToRemove);
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int i = indexToRemove; i < myArray.Length - 1; i++)
                            {
                                myArray[i] = myArray[i + 1];
                            }
                            Array.Resize(ref myArray, myArray.Length - 1);

                            Console.WriteLine("{0} degeri diziden cikarildi.", elementToRemove);
                            Console.WriteLine();
                        }
                    }
                    break;

                case 3:

                    Console.WriteLine();
                    Console.WriteLine("Su anki dizi: ");
                    foreach (int item in myArray)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Cikis yapiyorum");
                    return;

                default:
                    Console.WriteLine("Gecersiz girdi. Bir daha deneyin");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
