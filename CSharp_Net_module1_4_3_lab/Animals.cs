using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{
    //6) implement interface IEnumerable
    class Animals : IEnumerable
    {
        int length = 0;
        Animal[] animals;
        public  Animal this [int index]
        {

            get
            {
                return animals[index];
            }
            set
            {
                animals[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
            private set 
            {
                length = value;
            }
        }
        // 7) declare private array of Animal
        public Animals(Animal [] animals)
        {
            this.animals = animals;
            Length = animals.Length;
        }
        // 8) declare parameter constructor to initialize array   

        // 9) implement method GetEnumerator(), which returns IEnumerator
        // use foreach on array of Animal
        // and yield return for every animal
        public IEnumerator GetEnumerator()
        {
            foreach (Animal item in animals)
            {
                yield return item;
            }
        }
    }
}
