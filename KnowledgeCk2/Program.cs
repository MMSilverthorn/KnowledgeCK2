namespace KnowledgeCk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many books do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());



            var recordList = new List<myBooks>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new myBooks();

                Console.WriteLine("Enter your the authors name: ");
                entry.AuthorName = Console.ReadLine();

                Console.WriteLine("Enter the book title: ");
                entry.Title = Console.ReadLine();

                recordList.Add(new myBooks() { AuthorName = entry.AuthorName, Title = entry.Title });
            }



            // Print out the list of records using Console.WriteLine()
            foreach (var entry in recordList)
                Console.WriteLine("Author: " + entry.AuthorName + "\nTitle: " + entry.Title + "\n");

        }
    }
}