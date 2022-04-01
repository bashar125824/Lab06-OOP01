using System;
using System.Text;


// I declared 'Eat' and 'Sound' methods as STRING to make tests on them 
// Other methods are VOID type

namespace OOP1
{
    public class Program
    {

        // an interface that indecates a runable animal , like horses and cates 
        // contains high speed method , distance method and accelearation method
        public interface Irunable { 
                // mutiple inheritance 
                // 
                string highSpeed();
                string Distance();
            string Acceleration();
        }

        // an interface that determine if animal can be raised at home , like cats
       
        public interface Idomestic {

            string animalisDomestic();
        }
        public abstract class animal // Abstract , Parent class for 'animal' class
    {

        //   Abstraction
        abstract public String Eat();
        abstract public void Sleep();
        abstract public String Sound();

        abstract public void numberOfLegs();

            //

           
        }


        // Inheritance
        public abstract class mammals : animal // Abstract , Child of 'animal' class , Parent class for 'Horse' , 'Elephant' and 'Cats' classes
    {

        // Encapsiolation

        // Access Modifieres
        protected string color;
        protected bool hasTail;
        //

        //

        abstract public string Color { get; set; }
        abstract public bool HasTail { get; set; }


        public override string Eat()
        {
            return "Mammals Eat";
        }

        public override void Sleep()
        {
            Console.WriteLine("Mammals Sleep");
        }

        public override string Sound()
        {
            return "Mammals Sound";
        }



        public override void numberOfLegs()
        {
            Console.WriteLine("Mammals Number Of Legs");
        }
    }

        // Inheritance
        public abstract class birds : animal // Abstract , Child of 'animal' class , Parent for 'Owls' and 'Penguens' classes
    {
        protected bool isFly;
        protected string color;

        virtual public bool Isfly
        {
            set; get;
        }

        virtual public string Color {
            set; get;
        }

    

        public override string Eat()
        {
            return "Birds Eat";
        }

        public override void Sleep()
        {
            Console.WriteLine("Birds Sleep");
        }

        public override string Sound()
        {
            return "Birds Sound";
        }

        public override void numberOfLegs()
        {
            Console.WriteLine("Birds Number Of Legs");
        }
    }

        // Inheritance
        public class Horse : mammals , Irunable // Concrete class , Child of 'mammals' class
    {
            public string highSpeed() { return "Horses high speed is 54.7 miles per hour"; }
            public string Distance() { return "Horses can cut a distance up to five miles per one run"; }
            public string Acceleration() { return "Horses accelerate by 17 miles per hour"; }


            public override string Color
        {
            set { this.color = "Brown"; }
            get { return color; }
        }


        public override bool HasTail
        {

            set { this.hasTail = true; }

            get { return hasTail; }
        }

        public override String Eat()
        {
            return "Horses eat grass";
        }

        public override void Sleep()
        {
            Console.WriteLine("Horses sleep 3 hours per day");
        }

        public override string Sound()
        {
            return "Horses Sound";
        }

        public override void numberOfLegs()
        {
            Console.WriteLine("Horses have 4 legs");
        }

        public void horsesFeature()
        {
            Console.WriteLine("Horses have a nearly 360 degree field of vision");
        }


    }

        // Inheritance
        public class Elephant : mammals // Concrete class , Child of 'mammals' class
    {

        public override string Color
        {
            set { this.color = "Grey"; }
            get { return this.color; }
        }

        public override bool HasTail
        {
            set { this.hasTail = true; }
            get { return this.hasTail; }
        }

        public override String Eat()
        {
            return "Elephants Eat grass";
        }

        public override void Sleep()
        {
            Console.WriteLine("Elephants Sleep 5 hours per day");
        }

        public override string Sound()
        {
           return "Elephants Sound";
        }



        public override void numberOfLegs()
        {
            Console.WriteLine("Elephants have 4 legs");
        }

        public void elephantsFeature()
        {
            Console.WriteLine("Elephants communicate through vibrations");
        }


    }

        // Inheritance
        public class Cat : mammals , Irunable , Idomestic  // Concrete class , Child of 'mammals' class
        {

            

            public string highSpeed() {

                return "Cats high speed is 30 miles per hour";
            }

            public string Acceleration() {

               return "Cats accelerate by 7 miles per hour";
            }

            public string Distance() {

              return "Cats can cut a distance between 40 and 200 metres per one run";
            }

            public string animalisDomestic() {

               return "Cats are domestic animals";
            }


        public override bool HasTail
        {
            set { this.hasTail = true; }
            get { return this.hasTail; }
        }

        public override string Color
        {
            set { this.color = "camel color"; }
            get { return this.color; }
        }


            public override String Eat()
        {
            return "Cats Eat mice";
        }

        public override void Sleep()
        {
            Console.WriteLine("Cats Sleep 8 hours per day");
        }

        public override string Sound()
        {
            return "Cats Sound";
        }



        public override void numberOfLegs()
        {
            Console.WriteLine("Cats have 4 legs");
        }

        public void catsFeature()
        {
            Console.WriteLine("Feline flexibility");
        }
    }

        // Inheritance
        public class Owls : birds { // Concrete class , Child of 'birds' class

        public override bool Isfly { 
            set { this.isFly = true; }
            get { return this.isFly; }
        }

        public override string Color {
            set { this.color = "Black and Brown"; }
            get { return this.color; }
        }

        public override String Eat()
        {
            return "Owls Eat small Insects";
        }

        public override void Sleep()
        {
            Console.WriteLine("Owls Sleep 1 hour per day");
        }

        public override string Sound()
        {
            return "Owls Sound";
        }

        public override void numberOfLegs()
        {
            Console.WriteLine("Owls have 2 legs");
        }
    }

        // Inheritance
        public class Penguens : birds  // Concrete class , Child of 'birds' class
    { 
        public override bool Isfly
        {
            set { this.isFly = false; }
            get { return this.isFly; }
        }

        public override string Color
        {
            set { this.color = "Black and White"; }
            get { return this.color; }
        }

        public override String Eat()
        {
            return "Penguens Eat small fishes";
        }

        public override void Sleep()
        {
            Console.WriteLine("Penguens Sleep 5 hour per day");
        }

        public override string Sound()
        {
            return"Penguens Sound";
        }

        public override void numberOfLegs()
        {
            Console.WriteLine("Penguens have 2 legs");
        }

    }

    

            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

            Penguens P = new Penguens();
            P.numberOfLegs();
            P.Eat();
            Cat C = new Cat();
            C.catsFeature();
            Irunable run = new Horse();
            run.Distance();
            
            }
        }
    }


