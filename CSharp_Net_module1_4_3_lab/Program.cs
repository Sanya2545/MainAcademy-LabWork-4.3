using System;

namespace CSharp_Net_module1_4_3_lab
{
    class Program
    {
        public static void SelectionSort(Animals animals)
        {
            int n = animals.Length;

            // One by one move boundary of 
            // unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element 
                // in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (animals[j] < animals[min_idx])
                        min_idx = j;

                // Swap the found minimum 
                // element with the first 
                // element 
                Animal temp = animals[min_idx];
                animals[min_idx] = animals[i];
                animals[i] = temp;
            }
        }
        public static void InsertionSort(Animals animals)
        {
            int n = animals.Length;
            for (int i = 1; i < n; ++i)
            {
                Animal key = animals[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && animals[j] > key)
                {
                    animals[j + 1] = animals[j];
                    j = j - 1;
                }
                animals[j + 1] = key;
            }
        }
        public static void BubbleSort(Animals animals)
        {
            int n = animals.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (animals[j] > animals[j + 1])
                    {
                        // swap temp and arr[i] 
                        Animal temp = animals[j];
                        animals[j] = animals[j + 1];
                        animals[j + 1] = temp;
                    }
        }
        public static void PrintAnimals(Animals animals)
        {
            foreach (Animal item in animals)
            {
                Console.WriteLine("\nName : " + item.Name + "\nType : " + item.Type + "\nAge : " + item.Age + "\nWeight : " + item.Weight);
            }
        }
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Animal("Barsik", "Dog", 5, 3.5),
                new Animal("Vasya", "Dog", 5, 7),
                new Animal("Baloon", "Dog", 5, 14),
                new Animal("Kuzya", "Dog", 5, 20)
            };
            Animals animals_spec = new Animals(animals);
            
            // 10) Create an array of Animal objects and object of Animals    
            // print animals with foreach operator for object of Animals 

            // 11) Invoke 3 types of sorting 
            // and print results with foreach operator for array of Animal objects  
            BubbleSort(animals_spec);
            PrintAnimals(animals_spec);
            InsertionSort(animals_spec);
            PrintAnimals(animals_spec);
            SelectionSort(animals_spec);
            PrintAnimals(animals_spec);
            Console.ReadLine();
        }
    }
}
