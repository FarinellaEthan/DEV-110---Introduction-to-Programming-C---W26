namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");


        Console.WriteLine("What is your full name?");
        string Name = Console.ReadLine();

        Console.WriteLine("Where are you from?(city and state)");
        string CityState = Console.ReadLine();

        Console.WriteLine("What is your favorite color?");
        string FavColor = Console.ReadLine();

        Console.WriteLine("What is your dream job?");
        string DreamJob = Console.ReadLine();


        Console.WriteLine("What is your major?");
        string Major = Console.ReadLine();

        double GPA;
        do
        {
            Console.WriteLine("What is your GPA? (0.0 - 4.0)");
            GPA = double.Parse(Console.ReadLine());

            if (GPA < 0 || GPA > 4.0)
            {
                Console.WriteLine("Invalid input, please try again.");

            }

        } while (GPA < 0 || GPA > 4.0);

        Console.WriteLine("What year do you graduate?");
        int GraduationYear = int.Parse(Console.ReadLine());

        bool isFullTime;
        Console.WriteLine("Are you a full-time student?(yes/no)");
        string Input = Console.ReadLine();
        isFullTime = Input == "yes";


        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your height in inches?");
        double HeightInches = double.Parse(Console.ReadLine());

        Console.WriteLine("What is your favorite number?");
        int FavNum = int.Parse(Console.ReadLine());


        Console.WriteLine("");
        Console.WriteLine("-----PERSONAL INFORMATION-----");
        Console.WriteLine("");

        Console.WriteLine(Name);
        Console.WriteLine(CityState);
        Console.WriteLine("Favorite color: " + FavColor);
        Console.WriteLine("Dream job: " + DreamJob);

        Console.WriteLine("");
        Console.WriteLine("-----ACADEMIC DETAILS-----");
        Console.WriteLine("");

        Console.WriteLine("Major: " + Major);
        Console.WriteLine("GPA: " + GPA);
        Console.WriteLine("Graduation year: " + GraduationYear);
        if (isFullTime)
        {
            Console.WriteLine("Full time student");
        }
        else
        {
            Console.WriteLine("Part time student");
        }
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height(inches): " + HeightInches);
        Console.WriteLine("Favorite number: " + FavNum);

        Console.WriteLine("");
        Console.WriteLine("-----CALCULATED STATISTICS-----");
        Console.WriteLine("");
        int BirthYear = 2026 - age;
        Console.WriteLine("Birth Year: " + (2026 - age));

        Console.WriteLine("Years to graduation: " + (GraduationYear - 2026));

        Console.WriteLine("Height in feet: " + (HeightInches / 12) + (HeightInches % 12));

        Console.WriteLine("Is honor student?");
        if (GPA >= 3.5)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine("Age in months: " + age * 12);

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting


        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
