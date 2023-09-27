// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Rolnaldo", 12);
ronaldo.Display();

Player Jack = new Player("Jack", 12);
Jack.Display();

Team Dragons = new Team("Dragons");
Dragons.AddPLayer(ronaldo);
Dragons.AddPLayer(Jack);

Dragons.DisplayRoster();