namespace AssignmentOOP01
{

    #region Q1.WeekDaysEnum
    /*1-Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.*/
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday,
    }
    #endregion

    #region Q2.StructPerson
    /*
        2.Define a struct "Person" with properties "Name" and "Age". Create an 
        array of three "Person" objects and populate it with data. Then, write a C# 
        program to display the details of all the persons in the array.
     */
    public struct Person
    { 
        public string Name { get; set; }
        public double age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} , Age: {age}";
        }

    }

    #endregion

    #region Q3.SeasonEnum
    /*3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)*/

    
    public enum Seasons 
    { 
        Spring ,
        Summer ,
        Autumn ,
        Winter ,
    }

    #endregion

    #region Q4.PermissionsEnum

    /*4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
●	Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
    */
    [Flags]
    public enum Permissions :Byte
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    #endregion

    #region Q5.ColorsEnum
    /*5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.*/
    public enum Colors
    { 
        Red = 0,
        red = 0,
        Green = 1,
        green = 1,
        Blue = 2,
        blue = 2
    }
    #endregion

    #region Q6.PointStruct
    /*6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.*/
    public struct Point
    { 
        public int x { get; set; }
        public int y { get; set; }
        public override string ToString()
        {
            return $"X: {x} , Y: {y}";
        }
        
    }
    #endregion

    #region Q7.PersonStruct
    /*7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.*/

    public struct StructPerson
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} , Age: {Age}";
        }
    }
    
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------Q1------------------------");

            #region Q1.WeekDays
            foreach (WeekDays i in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(i);

            }
            #endregion

            Console.WriteLine("--------------------Q2------------------------");

            #region Q2.StructPerson
            Person[] arrayOfPersons = new Person[3];
            arrayOfPersons[0].Name = "Eman";
            arrayOfPersons[0].age = 23;

            arrayOfPersons[1].Name = "Mohamed";
            arrayOfPersons[1].age = 22;
           
            arrayOfPersons[2].Name = "Ibrahem";
            arrayOfPersons[2].age = 29;

            foreach (Person p in arrayOfPersons)
            {
                Console.WriteLine(p);
            }
            #endregion

            Console.WriteLine("--------------------Q3------------------------");

            #region Q3.SeasonEnum
            bool found;
            Seasons result;
            do
            {
                Console.Write("Enter Season Name Correctly: ");
                String input = Console.ReadLine();
                found = Enum.TryParse<Seasons>(input, out result);
                if (int.TryParse(input, out int Number))
                { 
                    if(Number < 0 || Number > 3) found = false;
                }
            }
            while (!found);
            if (result == Seasons.Spring)
            { 
                Console.WriteLine($"Month Range: march to may");
                
            }
            if (result == Seasons.Summer)
            {
                Console.WriteLine($"Month Range: june to august");

            }
            if (result == Seasons.Autumn)
            {
                Console.WriteLine($"Month Range: September to November");

            }
            if (result == Seasons.Winter)
            {
                Console.WriteLine($"Month Range: December to February");

            }
            #endregion

            Console.WriteLine("--------------------Q4------------------------");

            #region  Q4.PermissionsEnum
            Permissions permission;
            permission = Permissions.Read;
            permission ^= Permissions.Write; //add write permission
            permission ^= Permissions.Write; //delete write permission
            if ((permission & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("Write permission is already exist");    
            }else permission ^= Permissions.Write;

            permission |= Permissions.Execute; // check is found or not if not found added 
            Console.WriteLine(permission);

            #endregion


            Console.WriteLine("--------------------Q5------------------------");

            #region Q5.ColorsEnum

            bool IsExist;
            Colors color;
            Console.Write("Enter Color Name Correctly: ");
            String ColorInput = Console.ReadLine();
            IsExist = Enum.TryParse<Colors>(ColorInput, out color);
            if (int.TryParse(ColorInput, out int ColorNumber))
            {
                if (ColorNumber < 0 || ColorNumber > 2) IsExist = false;
            }
            if (IsExist) Console.WriteLine("color is a primary color ");
            else Console.WriteLine("color is not a primary color ");


            #endregion

            Console.WriteLine("--------------------Q6------------------------");


            #region Q6.PointStruct
            Point P = new();
            Console.WriteLine("Enter Value of X: ");
            P.x = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Value of Y: ");
            P.y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(P);
            #endregion

            Console.WriteLine("--------------------Q7------------------------");
            #region Q7.PersonStruct

            StructPerson[] People = new StructPerson[3];
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine($"Enter the Name Of the Person {j + 1}");
                People[j].Name = Console.ReadLine();
                Console.WriteLine($"Enter the Age Of the Person {j + 1}");
                People[j].Age = Convert.ToInt32( Console.ReadLine());
                j++;
            }


            int maximumAge = Math.Max(People[0].Age, Math.Max(People[1].Age, People[2].Age));
            Console.WriteLine("Details of the oldest person: ");
            if (maximumAge == People[0].Age) Console.WriteLine(People[0]);
            else if (maximumAge == People[1].Age) Console.WriteLine(People[1]);
            else Console.WriteLine(People[2]);
            #endregion
        }
    }
}
