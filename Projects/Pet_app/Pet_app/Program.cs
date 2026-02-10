using Animals;

namespace Pet_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INTIALIZE
            int Select = 0; // set to none
            int Action = 0; // set to none
            Animal petSelect;

            //CREATE ANIMALS
            //declare list
            List<Animal> petList = new List<Animal>();

            //Add
            petList.Add(new Cat("Bella", "Tabby", "tuna"));
            petList.Add(new Dog("Max", "Golden", "chicken"));
            petList.Add(new Fish("Bubbles", "Orange", "flakes"));
            petList.Add(new Cat("Shadow", "Black", "salmon"));
            petList.Add(new Dog("Rocky", "Brown", "beef"));

            //INTERACTIONS
            Console.WriteLine("This is a class inheritance app.\n");
            do
            {
                //Seperator
                Console.WriteLine("\n-------------\n");

                //SELECT
                //print list of Animals in petList
                for (int i = 0; i < petList.Count; i++)
                {
                    Console.Write(i + 1 + " "); //Make it seem as it starts at 1
                    Console.WriteLine(petList[i].name);
                }
                Console.WriteLine("Which pet would you like to interact with? (enter pet number)");

                Select = Int32.Parse(Console.ReadLine());
              
                if (Select == 0)
                {
                    break; //Exit the selection
                };

                petSelect = petList[Select-1]; //Select is 1 less due to display
                Console.WriteLine($"You have selected {petSelect.name}");

                //ACTIONS
                do
                {
                    Console.WriteLine($"What would you like to do with {petSelect.name}");
                    Console.WriteLine("1: Eat\n2: Speak\n3: Sleep\n4: Leave");
                    Action = Int32.Parse(Console.ReadLine());

                    //Seperator
                    Console.WriteLine("\n-------------\n");

                    switch (Action)
                    {
                        case 1:
                            petSelect.Eat();
                            break;

                        case 2:
                            petSelect.Speak();
                            break;

                        case 3:
                            petSelect.Sleep();
                            break;

                        default:
                            break;
                    }
                }
                while (Action == 0);
            }
            while (Select != 0);


            //CLOSE
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
