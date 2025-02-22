using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MainData;
namespace StudentListManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSV = 2;
            int nGV = 1;

            Student sv;
            Lecturer gv;

            object[] obj = new object[nSV + nGV];

            for (int i = 0; i <nSV; i++)
            {
                sv = new Student();
                sv.InputInfo();
                obj[i] = (Student)sv;
            }

            for (int i = 0; i < nGV; i++)
            {
                gv = new Lecturer();
                gv.InputInfo();
                obj[nSV + i] = (Lecturer)gv;   
            }

            for (int i = 0; i < nSV+nGV; i++)
            {
                if (obj[i].GetType() == typeof(Student))
                {
                    Console.WriteLine("Information of Student:");
                    sv = (Student)obj[i];
                    sv.DisplayInfo();
                }
                else
                {
                    Console.WriteLine("Information of Lecturer:");
                    gv = (Lecturer)obj[i];
                    gv.DisplayInfo();
                }
            }
            Console.ReadLine();
        }
    }
}
namespace MainData
{
    public class NegativeNumException: Exception
    {
        public NegativeNumException() { }
        public NegativeNumException(string message): base(message) {}
    }
    
    public class Student
    {
        public void InputInfo()
        {
            Console.Write("Input Student Name:");
            name = Console.ReadLine();
            Console.Write("Input Student Code:");
            code = Console.ReadLine();
            Console.Write("Input Student Age:");
            string str = Console.ReadLine();
            try
            {
                age = int.Parse(str);
                if (age <= 0)
                    throw new NegativeNumException();
            }
            catch (FormatException)
            {
                Console.Write("Not input a Number. Please Reinput a Number:");
                str = Console.ReadLine();
                age = int.Parse(str);
            }
            catch (NegativeNumException)
            {
                Console.Write("Negative Age is not accepted. Please Reinput a Number:");
                str = Console.ReadLine();
                age = int.Parse(str);
            }
        }

        private string name = "Not Assgined";
        private string code = "Not Assgined";
        private int age = 0;
        public Student(string name = "", string code = "", int age = 0)
        {
            this.name = name;
            this.code = code;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Code = {0}, Name = {1}, Age = {2}", code, name, age);
        }
        public override string ToString()
        {
            return "Code = " + code + ", Name = " + name + ", Age = " + age;
        }
    }
    public class Lecturer
    {
        public void InputInfo()
        {
            Console.Write("Input Lecturer Name:");
            name = Console.ReadLine();
            Console.Write("Input Lecturer Department:");
            department = Console.ReadLine();
            Console.Write("Input Lecturer Age:");
            string str = Console.ReadLine();
            try
            {
                age = int.Parse(str);
                if (age <= 0)
                    throw new NegativeNumException();
            }
            catch (FormatException)
            {
                Console.Write("Not input a Number. Please Reinput a Number:");
                str = Console.ReadLine();
                age = int.Parse(str);
            }
            catch (NegativeNumException)
            {
                Console.Write("Negative Age is not accepted. Please Reinput a Number:");
                str = Console.ReadLine();
                age = int.Parse(str);
            }
        }

        private string name = "Not Assgined";
        private string department = "Not Assgined";
        private int age = 0;
        public Lecturer(string name = "", string department = "", int age = 0)
        {
            this.name = name;
            this.department = department;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Department = {0}, Name = {1}, Age = {2}", department, name, age);
        }
        public override string ToString()
        {
            return "Department = " + department + ", Name = " + name + ", Age = " + age;
        }
    }
}

// Ham InputAge()
public class Student
{
    public void InputInfo()
    {
        Console.Write("Input Student Name:");
        name = Console.ReadLine();
        Console.Write("Input Student Code:");
        code = Console.ReadLine();
        InputAge();
    }
    public void InputAge()
    {
        bool isCompleted = false;

        Console.Write("Input Student Age:");
        string str = Console.ReadLine();
        try
        {
            age = int.Parse(str);
            if (InputAge <= 0)
                throw new NegativeNumException();
            isCompleted = true;
        }
        catch (FormatException)
        {
            Console.Write("Not input a Number. Please Reinput a number");
        }
        catch (NegativeNumException)
        {
            Console.Write("Negative Age is not accepted. Please Reinput a number");
        }
        finally
        {
            if (!isCompleted)
            {
                InputAge();
            }
        }
    }
