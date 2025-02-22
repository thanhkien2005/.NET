using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MainData;
namespace AnimalListManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("kiki", 10, 50, 20);
            dog.InputInfo();
            dog.DisplayInfo();
            dog.DisplayBMI();
            dog.CalculateBMI();
            Console.WriteLine(dog.ToString());

            Cat cat = new Cat("Meo", 9, 25, 10);
            cat.InputInfo();
            cat.DisplayInfo();
            cat.DisplayBMI();
            cat.CalculateDailyFood();
            Console.WriteLine(cat.ToString());

            Console.ReadLine();
        }
    }
}
namespace MainData
{
    public class NegativeNumException: Exception
    {
        public NegativeNumException() { }
        public NegativeNumException(string message): base(message) { }
    }
    public class Dog
    {
        public void InputInfo()
        {
            Console.Write("Input Dog Name:");
            name = Console.ReadLine();

            InputAge();

            InputHeight();

            InputWeight();
        }
        public void InputAge()
        {
            bool isCompleted = false;

            Console.Write("Input Dog Age:");
            string str = Console.ReadLine();
            try
            {
                age = int.Parse(str);
                if (age <= 0 || age > 20)
                    throw new NegativeNumException();
                isCompleted = true;
            }
            catch (NegativeNumException)
            {
                Console.Write("Negative Age is not accepted. Please Reinput a number:");
            }
            finally
            {
                if (!isCompleted)
                {
                    InputAge();
                }
            }
        }
        public void InputHeight()
        {
            bool isHeightValid = false;
            while (!isHeightValid)
            {
                Console.Write("Input Dog Height: ");
                string heightInput = Console.ReadLine();
                try
                {
                    height = int.Parse(heightInput);
                    isHeightValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for height.");
                }
            }
        }
        public void InputWeight()
        {
            bool isWeightValid = false;
            while (!isWeightValid)
            {
                Console.Write("Input Dog Weight: ");
                string weightInput = Console.ReadLine();
                try
                {
                    weight = int.Parse(weightInput);
                    isWeightValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for weight.");
                }
            }
        }

        private string name = "Not Assgined";
        private int age = 0;
        private int height = 0;
        private int weight = 0;
        public Dog(string name = "", int age = 0, int height = 0, int weight = 0)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name = {0}, Age = {1}, Height = {2}, Weight = {3}", name, age, height, weight);
        }
        public override string ToString()
        {
            return "Name = " + name + ", Age = " + age + ", Height = " + height + ", Weight = " + weight;
        }
        public double CalculateBMI()
        {
            double heightInMeters = height / 100.0;
            return weight / (heightInMeters * heightInMeters);
        }
        public void DisplayBMI()
        {
            double bmi = CalculateBMI();
            Console.WriteLine("BMI: {0:F2}", bmi);
            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal weight");
            else
                Console.WriteLine("Overweight");
        }
        public void CalculateDailyFood()
        {
            double foodAmount;
            if (weight < 10)
                foodAmount = 0.05 * weight;
            else if (weight < 20)
                foodAmount = 0.04 * weight;
            else
                foodAmount = 0.03 * weight;
            Console.WriteLine("{0} should eat {1:F2} kg of food per day.", name, foodAmount);
        }
    }
    public class Cat
    {
        public void InputInfo()
        {
            Console.Write("Input Cat Name:");
            name = Console.ReadLine();
            
            InputAge();

            InputHeight();

            InputWeight();
        }
        public void InputAge()
        {
            bool isCompleted = false;

            Console.Write("Input Cat Age:");
            string str = Console.ReadLine();
            try
            {
                age = int.Parse(str);
                if (age <= 0 || age > 20)
                    throw new NegativeNumException();
                isCompleted = true;
            }
            catch (NegativeNumException)
            {
                Console.Write("Negative Age is not accepted. Please Reinput a number:");
            }
            finally
            {
                if (!isCompleted)
                {
                    InputAge();
                }
            }
        }
        public void InputHeight()
        {
            bool isHeightValid = false;
            while (!isHeightValid)
            {
                Console.Write("Input Cat Height: ");
                string heightInput = Console.ReadLine();
                try
                {
                    height = int.Parse(heightInput);
                    isHeightValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for height.");
                }
            }
        }
        public void InputWeight()
        {
            bool isWeightValid = false;
            while (!isWeightValid)
            {
                Console.Write("Input Cat Weight: ");
                string weightInput = Console.ReadLine();
                try
                {
                    weight = int.Parse(weightInput);
                    isWeightValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for weight.");
                }
            }
        }

        private string name = "Not Assgined";
        private int age = 0;
        private int height = 0;
        private int weight = 0;
        public Cat(string name = "", int age = 0, int height = 0, int weight = 0)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name = {0}, Age = {1}, Height = {2}, Weight = {3}", name, age, height, weight);
        }
        public double CalculateBMI()
        {
            double heightInMeters = height / 100.0;
            return weight / (heightInMeters * heightInMeters);
        }
        public void DisplayBMI()
        {
            double bmi = CalculateBMI();
            Console.WriteLine("BMI: {0:F2}", bmi);
            if (bmi < 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal weight");
            else
                Console.WriteLine("Overweight");
        }
        public void CalculateDailyFood()
        {
            double foodAmount;
            if (weight < 10)
                foodAmount = 0.05 * weight;
            else if (weight < 20)
                foodAmount = 0.04 * weight;
            else
                foodAmount = 0.03 * weight;
            Console.WriteLine("{0} should eat {1:F2} kg of food per day.", name, foodAmount);
        }
        public override string ToString()
        {
            return "Name = " + name + ", Age = " + age + ", Height = " + height + ", Weight = " + weight;
        }
    }
}