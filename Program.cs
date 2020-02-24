using System;

namespace LinkedList1
{
    class Driver
    {
        static Fruit head = new Fruit("head", 0, null, null);
        static Fruit tail = new Fruit("tail", 0, null, null);
        static void Main(String[] args)
        {
            FruitBasket basket1 = new FruitBasket();
            Fruit pineapple = new Fruit("PineApple", 100, head, null);
            head.nextFruit = pineapple;
            basket1.firstFruit = pineapple;
            Fruit mango = new Fruit("Mango", 100, pineapple, null);
            Fruit apple = new Fruit("Apple", 100, mango, tail);
            pineapple.nextFruit = mango;
            mango.nextFruit = apple;
            tail.previousFruit = apple;
            Driver.traverseLinkedList();
        }

        public static void traverseLinkedList()
        {
            int TotalCalories = 0;
            Fruit currentNode = head;
            while (!((currentNode.fruitName).Equals("tail")))
            {
                Console.WriteLine(currentNode.fruitName);
                TotalCalories += currentNode.Calories;
                currentNode = currentNode.nextFruit;
            }
            Console.WriteLine("total calories is {0}", TotalCalories);

            // get a handle on the first node
            // get a handle on the next node
            // keep going till End of List = TAIL

        }

    }
    class FruitBasket
    {
        public Fruit firstFruit;
    }

    class Fruit
    {
        public Fruit(String thisFruitName, int thisCalories, Fruit pFruit, Fruit nFruit)
        {
            fruitName = thisFruitName;
            Calories = thisCalories;
            nextFruit = nFruit;
            previousFruit = pFruit;
        }
        public String fruitName = "";
        public int Calories;
        public Fruit nextFruit;
        public Fruit previousFruit;
    }

}