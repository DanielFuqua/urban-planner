using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building OneElevenOcean = new Building("111 Ocean Blvd");
            OneElevenOcean.Width = 10.5;
            OneElevenOcean.Depth = 9.5;
            OneElevenOcean.Stories = 15;
            OneElevenOcean.Construct();
            OneElevenOcean.Purchase("Daniel Fuqua");

            Building SixtyTwoTwelve = new Building("6212 Springdale Dr");
            SixtyTwoTwelve.Width = 20.32;
            SixtyTwoTwelve.Depth = 15.65;
            SixtyTwoTwelve.Stories = 30;
            SixtyTwoTwelve.Construct();
            SixtyTwoTwelve.Purchase("Billy Bob");

            Building EightyEightyEightNewLine = new Building("8088 New Line Blvd");
            EightyEightyEightNewLine.Width = 42.33;
            EightyEightyEightNewLine.Depth = 20.11;
            EightyEightyEightNewLine.Stories = 15;
            EightyEightyEightNewLine.Construct();
            EightyEightyEightNewLine.Purchase("Tom Arnold");

            Building OneHundredOakley = new Building("100 Oakley St");
            OneHundredOakley.Width = 16.87;
            OneHundredOakley.Depth = 22.34;
            OneHundredOakley.Stories = 40;
            OneHundredOakley.Construct();
            OneHundredOakley.Purchase("Big Daddy");



            OneElevenOcean.ProjectPlanner("Bill Baker");
            Console.WriteLine();
            SixtyTwoTwelve.ProjectPlanner("Homer Simpson");
            Console.WriteLine();
            EightyEightyEightNewLine.ProjectPlanner("Peter Griffin");
            Console.WriteLine();
            OneHundredOakley.ProjectPlanner("Rick Sanchez");
        }
    }
}
