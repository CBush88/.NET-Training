using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    //Creating custom a custom non-generic collection by implementing IEnumerator and IEnumberable
    public class Person
    {
        public string firstName;
        public string lastName;

        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
    }

    //create collection of person objects

    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[]pArray)
        {
            _people = new Person[pArray.Length];
            for(int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        //Implementation of GetEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;
        int position = -1;

        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }
        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Person Current
        {
            get 
            {
                try
                {
                    return _people[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    public class TestItem
    {
        public int id;
        public string name;

        public TestItem(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    public class TestItems : IEnumerable
    {
        private TestItem[] _items;
        public TestItems(TestItem[] items)
        {
            _items = new TestItem[items.Length];
            for(int i = 0; i < items.Length; i++)
            {
                _items[i] = items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public ItemsEnum GetEnumerator()
        {
            return new ItemsEnum(_items);
        }
    }

    public class ItemsEnum: IEnumerator
    {
        public TestItem[] _items;
        int position = -1;

        public ItemsEnum(TestItem[] items)
        {
            _items = items;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public TestItem Current
        {
            get
            {
                try
                {
                    return _items[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public bool MoveNext()
        {
            position++;
            return (position < _items.Length);
        }

        public void Reset()
        {
            position = -1 ;
        }
    }

    internal class EnumeratorDemo
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Kelly", "Rabon")
            };

            People peopleList = new People(peopleArray);
            foreach(Person p in peopleList)
            {
                Console.WriteLine(p.firstName+ " " + p.lastName);
            }

            Console.WriteLine();

            TestItem[] ti = new TestItem[3]
            {
                new TestItem(1, "Item 1"),
                new TestItem(2, "Item 2"),
                new TestItem(3, "Item 3")
            };

            TestItems testItems = new TestItems(ti);

            foreach(TestItem item in testItems)
            {
                Console.WriteLine(item.id + " " + item.name);
            }

            Console.ReadKey();
        }
    }
}
