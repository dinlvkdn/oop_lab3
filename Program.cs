using System;

namespace lab_3_c_
{ 
 class Animal
 {
        protected int weight;
        protected int age;
        protected int price;
        public Animal(int weight, int age, int price)
        {
            this.weight = weight;
            this.age = age;
            this.price = price;
        }
        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public int Price
        {
            get { return price; }
            set { this.price = value; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Вага: " + Weight);
            Console.WriteLine("Вiк: " + Age);
            Console.WriteLine("Цiна: " + Price);
        }

    }
  class Wolf : Animal
    {
        protected string breed;
        protected string location;
        public string Breed
        {
            get { return breed; }
            set { this.breed = value; }
        }
        public string Location
        {
            get { return location; }
            set { this.location = value; }
        }



        public Wolf(string breed, string location, int weight, int age, int price) : base(weight, age, price)
        {
            this.breed = breed;
            this.location=location;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Мiсце розташування вовка:"+Location);
            Console.WriteLine("Порода вовка: "+Breed);
            Console.WriteLine("Вага вовка: "+Weight);
            Console.WriteLine("Вiк вовка: "+Age);
            Console.WriteLine("Цiна вовка: "+Price);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Animal animal = new Animal(100, 5, 5000);
            animal.ShowInfo();
            Console.WriteLine("----------------------------------------");
            Wolf wolf = new Wolf("звичайний", "Дрогобич", 100, 3, 3000);
            wolf.ShowInfo();
            Console.WriteLine("----------------------------------------");
            Wolf wolf1 = new Wolf("незвичайний", "Коломия", 100, 7, 9000);
            wolf.ShowInfo();
        }
    }
}
