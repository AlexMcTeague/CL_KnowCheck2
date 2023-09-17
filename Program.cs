namespace CL_KnowCheck2 {
    internal class Program {
        static void Main() {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Car>();
            for (int i = 0; i < numberOfRecords; i++) {
                // In this loop, populate the object's properties using Console.ReadLine()
                Car car = new Car();
                Console.WriteLine("\nPlease enter details for your next car:");

                Console.WriteLine("What is your car's name?");
                car.name = Console.ReadLine();
                Console.WriteLine("What color is your car?");
                car.color = Console.ReadLine();
                Console.WriteLine("Is your car \"cool\"? (Please input \"true\" or \"false\")");
                car.isCool = bool.Parse(Console.ReadLine());
                Console.WriteLine("In one word, what honk noise does your car make? (ex. \"beep\")");
                car.honkNoise = Console.ReadLine();

                recordList.Add(car);
            }


            // Print out the list of records
            Console.WriteLine("\nYour cars:");
            foreach (var record in recordList) {
                Console.WriteLine(record.ToString());
            }
        }
    }
}