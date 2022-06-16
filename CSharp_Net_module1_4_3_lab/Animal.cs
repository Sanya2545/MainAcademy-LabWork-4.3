using System;
using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{
    // 12) change methods of sorting to properties

    // 1) implement interface IComparable
    public class Animal : IComparable
    {
        // 2) declare properties and parameter constructor
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public Animal(string name = "", string type = "", int age = 0, double weight = 0)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
        }
        public static bool operator < (Animal animal1, Animal animal2)
        {
            if (animal1.CompareTo(animal2) == -1)
                return true;
            return false;
        }
        public static bool operator >(Animal animal1, Animal animal2)
        {
            if (animal1.CompareTo(animal2) == 1)
                return true;
            return false;
        }
        public static bool operator <=(Animal animal1, Animal animal2)
        {
            if (animal1.CompareTo(animal2) <= 0)
                return true;
            return false;
        }
        public static bool operator >=(Animal animal1, Animal animal2)
        {
            if (animal1.CompareTo(animal2) >= 0)
                return true;
            return false;
        }
        public int CompareTo(object obj)
        {
            if(obj is Animal animal)
            {
                return Type.CompareTo(animal.Type);
            }
            else
            {
                throw new ArgumentException("You have been putted not Animal object !");
            }
        }
        // 3) implement method ComareTo()
        // it comares Genus of type string - return result of method String.Compare 
        // for this.genus and argument object
        // don't forget to cast object to Animal
        private class SortWeightAscendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                if(x is Animal animal1  && y is Animal animal2)
                {
                    return animal1.Weight.CompareTo(animal2.Weight);
                }
                else
                {
                    throw new ArgumentException("You have been putted not Animal object !");
                }
            }
        }
        private class SortTypeDescendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                if(x is Animal animal1 && y is Animal animal2)
                {
                    return (animal1.Type.CompareTo(animal2.Type)) * -1;
                }
                else
                {
                    throw new ArgumentException("You have been putted not Animal object !");
                }
            }
        }
        public static IComparer SortWeightAscending ()
        {
            return new SortWeightAscendingHelper();
        }
        public static IComparer SortTypeDescending ()
        {
            return new SortTypeDescendingHelper();
        }
        // 4) declare methods SortWeightAscending(), SortGenusDescending()
        // they are static and return IComparer
        // return type is custed from constructor of classes SortWeightAscendingHelper, 
        // SortGenusDescendingHelper calling 


        // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
        // they implement interface IComparer
        // every nested class has implemented method Compare with 2 parameters of object and return int
        // class SortWeightAscendingHelper sort weight by ascending
        // class SortGenusDescendingHelper sort genus by descending
    }
}
