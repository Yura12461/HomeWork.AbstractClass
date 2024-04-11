


using System.Runtime.CompilerServices;

namespace Animal
{


    abstract class Animal
    {
        public string Name { get; set; }
       




        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Console.WriteLine("Введите имя собаки");
            dog.SetName();
            GetName(dog);
            dog.Eat();
        }
        
        public void SetName()
        {
        
            Name = Console.ReadLine();
        }

        public static void GetName(Animal dog)
        {

           
            Console.WriteLine($"Имя собаки: {dog.Name} ");
        }

        public abstract void Eat();
        
        

        

    }

    class Dog : Animal 
    {
        public override void Eat()
        {
            Console.WriteLine("Собака ест");
        }

        
    }
    
       

       

        
    
}