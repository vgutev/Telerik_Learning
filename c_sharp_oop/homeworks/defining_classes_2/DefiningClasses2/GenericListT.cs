using System;

namespace DefiningClasses2
{
    class GenericList<T>
        where T : System.IComparable

    {
        private T[] elements;
        private int lastElement = 0;
        private int initialCapacity = 0;

        public GenericList(int initCapacity)
        {
            this.elements = new T[initCapacity];
            this.initialCapacity = initCapacity;
        }

        public void AddElement(T element)
        {
            if (lastElement == this.elements.Length - 1)
            {
                AutoGrow();
            }
            this.elements[lastElement] = element;
            lastElement++;
        }
        public T GetElement(int index)
        {
            T element;
            if (0 > index || index >= this.lastElement)
            {
                Console.WriteLine("Index out of range");
                Environment.Exit(0);
            }
            element = elements[index];
            return element;
        }
        public void RemoveElement(int index)
        {
            if (0 > index || index >= this.lastElement)
            {
                Console.WriteLine("Index out of range");
                Environment.Exit(0);
            }

            for (int i = index; i < this.lastElement - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            lastElement--;
        }
        public void InsertElement(T element, int index)
        {
            if (lastElement == this.elements.Length - 1)
            {
                AutoGrow();
            }
            if (0 > index || index >= this.lastElement)
            {
                Console.WriteLine("Index out of range");
                Environment.Exit(0);
            }

            for (int i = this.lastElement; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            lastElement++;
        }
        public void ClearList()
        {
            this.elements = new T[initialCapacity];
            lastElement = 0;
        }
        public int FindElement(T element)
        {
            int index = -1;
            for (int i = 0; i < lastElement; i++)
            {
                if (this.elements[i].CompareTo(element) == 0)
                {
                    index = i;
                }
            }
            return index;

        }
        void AutoGrow()
        {
            T[] doubleElements = new T[this.elements.Length * 2];
            this.elements.CopyTo(doubleElements, 0);
            this.elements = doubleElements;
        }
        public T Min()
        {
            T minElement = this.elements[0];

            for (int i = 0; i < lastElement; i++)
            {
                if (minElement.CompareTo(elements[i]) >= 0)
                {
                    minElement = elements[i];
                }
            }

            return minElement;
        }
        public T Max()
        {
            T maxElement = this.elements[0];

            for(int i = 0; i < lastElement; i++)
            {
                if (maxElement.CompareTo(this.elements[i]) <= 0)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }
    }
}
