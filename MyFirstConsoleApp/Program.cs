using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using GenericExtension;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
#if HelloWorld
            // ******** Hello World **********  //
            /*Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadKey();*/
#endif
#if BuiltInTypes
            
            /*int a = 4, b = 5, sum = a + b;
            Console.WriteLine("Printing multiple var's: {0} + {1} = {2}", a, b, sum);

            char[] myArray = new char[] { 'a', 'b', 'c' };
            Console.WriteLine("Char array size: {0}", myArray.Length);
           
            char[] myArrayTwo = new char[4];
            myArrayTwo[0] = 'a';
            myArrayTwo[1] = 'b';
            myArrayTwo[2] = 'c';
            myArrayTwo[3] = 'd';
            for(int i = 0; i < myArrayTwo.Length; i++)
            {
                Console.WriteLine(myArrayTwo[i]);
            }

            string result = "";
            while(true)
            {
                Console.WriteLine("Please enter in a word: ");
                string word = Console.ReadLine();
                if (word == "")
                {
                    break;
                }
                else
                {
                    result += word + " ";
                }
            }

            Console.WriteLine("Result is {0}", result);

            StringBuilder builder = new StringBuilder();
            while (true)
            {
                Console.WriteLine("Please enter in a word: ");
                string word = Console.ReadLine();
                if (word == "")
                {
                    break;
                }
                else
                {
                    builder.Append(word + " ");
                }
            }

            Console.WriteLine("Result is {0}", builder.ToString()); // one concatenation */

#endif

#if MethodOverloading
            myMethod();
            myMethod(2);
            myMethod(2, 2);
#endif

#if PassByValue
            double myDouble = 4.56;
            Console.WriteLine("myDouble in Main {0}", myDouble);
            IncrementDouble(myDouble);
            Console.WriteLine("myDouble in Main {0}", myDouble);
#endif

#if PassByRef
            StringBuilder builder = new StringBuilder();
            builder.Append("Hello World");
            Console.WriteLine("builer in Main: {0}", builder.ToString());
            AddExclamationsAtTheEnd(builder);
            Console.WriteLine("builer after adding exclamation in Main: {0}", builder.ToString());
#endif

#if PassValueByRef
            double myDouble = 4.56;
            Console.WriteLine("myDouble in Main {0}", myDouble);
            IncrementDouble(ref myDouble);
            Console.WriteLine("myDouble in Main after incrementing {0}", myDouble);
#endif

#if OutMethod
            int a = 4, b = 5, sum, diff, product;
            doEverything(a, b, out sum, out diff, out product);
            Console.WriteLine("Sum {0}", sum);
            Console.WriteLine("Diff {0}", diff);
            Console.WriteLine("Product {0}", product);
#endif

#if Classes
            Person p = new Person(); // new instance of the class
            p.FirstName = "John";
            p.LastName = "Smith";
            p.Age = 25;
            //Person p = new Person("John","Smith", 25); 
            Console.WriteLine("My name is {0} {1} and my age is {2}!", p.FirstName, p.LastName, p.Age);
            if(p.Age < Person.MinAge)
            {
                Console.WriteLine("Too young!");
            }
#endif

#if Inheritance
            Student s = new Student("John", "Smith", 25);
            s.University = "Fullsail University";
            s.AvgGrade = 8;
            s.SayHello();
            //Console.WriteLine("My name is {0} {1} and I'm {2} years old!", s.FirstName, s.LastName, s.Age);
            Console.WriteLine(s);
#endif

#if Interface
            //Person p = new Person("John", "Smith", 25);
            //p.Run(2);
            Person slowRunner = new Person("John", "Smith", 25, new SlowRun());
            slowRunner.Run(4);
            Person fastRunner = new Person("Alice", "Wunderland", 30, new FastRun());
            fastRunner.Run(4);
            Dog fastDog = new Dog("Rocky", new FastRun());
            fastDog.Run(5);
#endif

#if Enums
            Movie movie = new Movie("Titanic", 1995, MovieGenre.Romance);
            PrintMovieGenre(movie);
#endif

#if structs
            Coordinates c = new Coordinates();
            c.Longitude = 45.896;
            c.Latittude = 36.894;
            Console.WriteLine("I'm here : ( {0} ,  {1} )", c.Longitude, c.Latittude);
#endif
#if GenericCollection
            List<string> games = new List<string>();
            games.Add("Mass Effect");
            games.Add("Crash Bandicoot");
            games.Add("Uncharted 4");

            Console.WriteLine("My fav games are - ");
            foreach (String g in games)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine();

            List<int> rand = new List<int>();
            Random r = new Random();
            rand.Add(r.Next(1, 10));
            rand.Add(r.Next(1, 10));
            rand.Add(r.Next(1, 10));

            foreach(int num in rand)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            MyStack<string> friends = new MyStack<string>();
            friends.Push("John");
            friends.Push("Rocky");
            friends.Push("Jimmy");

            Console.WriteLine("Names are being popped of the list ");
            while (!friends.IsEmpty())
            {
                string namedPoped = friends.Pop();
                Console.WriteLine(namedPoped);
            }
#endif
#if TypeChecking
            Person p = new Person("John", "Smith", 34);
            if(p is Person)
            {
                Console.WriteLine("p is a Person");
            }
            else
            {
                Console.WriteLine("p is not a Person");
            }
            Student s = new Student("John", "Smith", 34, "MIT", 9);
            
            if (s is Student)
            {
                Console.WriteLine("s is a Student");
            }
            else
            {
                Console.WriteLine("s is not a Student");
            }
    
            if (s is Person)
            {
                Console.WriteLine("s is a Person");
            }
            else
            {
                Console.WriteLine("s is not a Person");
            }

            if (p is Student)
            {
                Console.WriteLine("p is a Student");
            }
            else
            {
                Console.WriteLine("p is not a Student");
            }

            Object o = new Person("John", "Smith", 45);
            DoSomething(o);
#endif

#if ReadAndWriteToFromFiles
            readFile();
            //writeFile();
#endif
#if Tuples
            /*var car = GetCar();
            Console.WriteLine($"Model: {car.Item1}");
            Console.WriteLine($"Model Price: {car.Item2}");
            Console.WriteLine($"Currency: {car.Item3}");*/
            // Refactoring for better readability
            /*var car = getCar();
            Console.WriteLine($"Model: {car.model}");
            Console.WriteLine($"Model Price: {car.price}");
            Console.WriteLine($"Currency: {car.curr}");*/
            //Construction
            (string model, double price, string currency) = getCar();
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Currency: {currency}");
#endif

#if PatternMatching
            Person p = new Student("John", "Smith", 15, StudentLevel.HighSchool);
            describeType(p);
            Person person = new Employee("Bob", "Roode", 34, EmployeeType.Salaried);
            describeEmployee(person);
#endif

#if RefLocalsAndReturns
            Person p = new Person("John", "Smith", 23, "xyz@yahoo.com");
            string emailAddr = p.GetEmailAddress();
            ref string emailAddrRef = ref p.GetEmailAddress();
#endif

#if InlineOutVar
            //Calculate(8, 2, out int sum, out int diff);
            Calculate(8, 2, out var sum, out var diff);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Diff: {diff}");
#endif

#if DelegateObserverPattern
            Machine machine = new Machine();
            //machine.RegisterTempWatcher(LogTempToFile);
            //machine.RegisterTempWatcher(LogTempToConsole);
            machine.RegisterTempWatcher((double prev, double current) =>
            {
                Console.WriteLine($"Machine temperature changed from {prev} to {current}");
            });
            machine.RegisterTempWatcher(async(double prev, double current) =>
            {
                using (StreamWriter writer = new StreamWriter("temp.txt", true))
                {
                    await writer.WriteLineAsync($"Machine temperature changed from {prev} to {current}");
                }
            });
            machine.TurnOn();
#endif

#if Threading
            //WriteLog();
            writeFiles();
#endif

#if LINQ
            ServerManager manager = new ServerManager();
            // manager.PrintOfflineAsianServerWithLotsOfRam();
            //manager.printOfflineAsianServerWithLotsOfRam();
            //manager.printOfflineServerWithLocation();
            manager.printOfflineServerWithLocationSecon();
#endif
            testExtensions();
            Console.ReadKey();


        } //End of Main()

        //  -------------------------------------------------------------------------------------- //
        // Creating Methods for diff logic 
#if MethodOverloadingLogic
        static void myMethod()
        {
            Console.WriteLine("Hi, this is my new method");
        }
        static void myMethod(int myNum)
        {
            Console.WriteLine("Number: {0}", myNum);
        }
        static void myMethod(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum is {0}", result);
        }
#endif

#if PassByValueLogicDoesntRetainValueOutside
        static void IncrementDouble(double d)
        {
            d++;
            Console.WriteLine("myDouble after incrementing it {0}", d);
        }
#endif

#if PassValueByRefRetainsValue
        static void IncrementDouble(ref double d)
        {
            d++;
            Console.WriteLine("myDouble after incrementing it {0}", d);
        }
#endif

#if PassByRefLogic
        static void AddExclamationsAtTheEnd(StringBuilder b)
        {
            b.Append("!!!!!!!!!");
        }
#endif

#if PrintingMultipleStuff
        static void doEverything(int a, int b, out int sum, out int diff, out int prod)
        {
            sum = a + b;
            diff = a - b;
            prod = a * b;
        }
#endif

#if EnumLogicPrinitngMovieGenres
        public static void PrintMovieGenre(Movie m)
        {
            switch (m.Genre)
            {
                case MovieGenre.Action:
                    Console.WriteLine("It is a Action Movie!");
                    break;
                case MovieGenre.Comedy:
                    Console.WriteLine("It is a Comedy Movie!");
                    break;
                case MovieGenre.Romance:
                    Console.WriteLine("It is a Romance Movie!");
                    break;
                case MovieGenre.Horror:
                    Console.WriteLine("It is a Horror Movie!");
                    break;
                case MovieGenre.Scifi:
                    Console.WriteLine("It is a Sci-Fi Movie!");
                    break;
                default:
                    Console.WriteLine(" Please enter a valid movie!");
                    break;
            }
        }
#endif

#if TypeCheckingAsOperatorLogic
        public static void DoSomething(Object o)
        {
            Person p = o as Person;
            if(p == null)
            {
                throw new ArgumentException("Argument is not a person.");
            }
            else
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }
#endif

#if ReadAndWriteToFile
        private async static void readFile()
        {
            /*StreamReader reader = new StreamReader("TestFile.txt");
            string contents = reader.ReadToEnd();
            Console.WriteLine("File Contents: ");
            Console.WriteLine(contents);
            reader.Close();*/

            /*using (StreamReader reader = new StreamReader("TestFile.txt"))
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine("File Contents: ");
                Console.WriteLine(contents);
            } */

            try
            {
                using (StreamReader reader = new StreamReader("TestFile.txt"))
                {
                    string contents = await reader.ReadToEndAsync();
                    Console.WriteLine("File Contents: ");
                    Console.WriteLine(contents);
                }
            }catch(FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
            }catch(FileLoadException e)
            {
                Console.WriteLine("File load failed.");
            }catch(Exception e)
            {
                Console.WriteLine("File operation failed.");
            }
        }

        /*private static void writeFile()
        {
            StreamWriter writer = new StreamWriter("TestFile.txt");
            writer.WriteLine("You're the best VS");
            writer.Close();
            Console.WriteLine("Wrote to file");
        }*/

#endif

#if TuplesLogic
        // General Tuples
        private static (string, double, string)GetCar()
    {
            return ("Tesla Model S", 75000, "USD");
    }
    //Named Tuples
    private static (string model, double price, string curr)getCar()
    {
            return ("Tesla Model S", 75000, "USD");
    }
#endif

#if PatternMatchingLogic
        private static void describeEmployee(Person _person)
        {
            if(_person is Employee e)
            {
                if (e.Type == EmployeeType.Hourly)
                    Console.WriteLine($"{_person}a hourly employee");
                else
                    Console.WriteLine($"{_person}a salaried employee");
            }
            else
            {
                Console.WriteLine($"{_person} is not an Employee!");
            }
        
        }
        private static void describeType(Person p)
        {
            switch(p)
            {
                case Student s when s.Level == StudentLevel.HighSchool:
                    Console.WriteLine($"{s} is a high school student");
                    break;
                case Student s when s.Level == StudentLevel.UnderGraduate:
                    Console.WriteLine($"{s} is a under graduate student");
                    break;
                case Student s when s.Level == StudentLevel.Graduate:
                    Console.WriteLine($"{s} is a post graduate student");
                    break;
                case Employee e:
                    Console.WriteLine($"{e} is an Employee");
                    break;
                case Athlete a:
                    Console.WriteLine($"{a} is an Athlete");
                    break;
                case Person person:
                    Console.WriteLine($"{person} is a Person");
                    break;
                default:
                    throw new ArgumentException("p is not a person");
            }
        }
#endif

#if InlineOutLogic
        public static void Calculate(int a, int b, out int sum, out int diff)
        {
            sum = a + b;
            diff = a - b;
        }
#endif

#if delegateLogic
        private static void LogTempToConsole(double prev, double current)
        {
            Console.WriteLine($"Machine temperature changed from {prev} to {current}");
        }

        private static async void LogTempToFile(double prev, double current)
        {
            using (StreamWriter writer = new StreamWriter("temp.txt", true))
            {
                await writer.WriteLineAsync($"Machine temperature changed from {prev} to {current}");
            }
        }
#endif

#if ThreadingUsingThreadsThreadPoolAndTasks
        private static void WriteLog()
        {
            int logAmount = 10;
            Thread[] thread = new Thread[logAmount];
            Console.WriteLine("Start writer thread.....");
            for (int i = 0; i < logAmount; i++)
            {
                var logManager = new LogManager($"log {i + 1}.txt");
                thread[i] = new Thread(logManager.Generate);
                thread[i].Start();
            }

            //When all of our threads are finished
            for (int i = 0; i < logAmount; i++)
            {
                thread[i].Join();
            }
            Console.WriteLine("All writer threads are finished....");
        }

        private static void secondWriteLog()
        {
            int logAmount = 10;
            
            for (int i = 0; i < logAmount; i++)
            {
                var logManager = new LogManager($"log {i + 1}.txt");
                ThreadPool.QueueUserWorkItem(new WaitCallback((o) =>
                {
                    //So the threadpool will be responsible for creating operations through available threads
                    //to execute it 
                    logManager.Generate();
                }));
            }
            Console.WriteLine("Files written...");
        }

        private static void writeFiles()
        {
            int taskAmount = 10;
            Task[] tasks = new Task[taskAmount];
            Console.WriteLine("Writing tasks started..");
            for (int i = 0; i < taskAmount; i++)
            {
                string fileName = $"log-{i + 1}.txt";
                int id = i + 1;
                tasks[i] = Task.Run(() =>
                {
                    Console.WriteLine($"Task {id} running on thread: {Thread.CurrentThread.ManagedThreadId} / writing file {fileName}");
                    var generator = new LogManager(fileName);
                    generator.Generate();
                });
            }
            Task.WaitAll(tasks);
            Console.WriteLine("Writing tasks finished....");
        }
#endif

        private static void testExtensions()
        {
            List<string> colors = new List<string>()
            {
                "blue",
                "green",
                "red",
                "violet",
            };
            var stack = colors.ToStack();
            Console.Write("Colors - List: ");
            foreach (var color in colors)
            {
                Console.Write($"{color}");
            }
            Console.WriteLine();

            Console.Write("Color - Stack: ");
            while(stack.Count > 0)
            {
                Console.Write($"{stack.Pop()}");
            }
            Console.WriteLine();
        }
    }
}
