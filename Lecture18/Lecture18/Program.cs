using Lecture18;

Random random = new Random();
Log log = new WriterLog(Console.Out);

Controller ai = new AI(random);
Character c3PO = new Character(ai, "C-3PO", 15, 2, 12, new Die(random, 8));
Character r2D2 = new Character(ai, "R2-D2", 10, 0, 14, new Die(random, 6));
Character luke = new Character(new Player(Console.In, Console.Out), "Luke", 20, 0, 10, new Die(random, 4));

Game game = new Game(c3PO, r2D2, new Die(random, 20), new Die(random, 6));
game.Run(log);

Game game2 = new Game(c3PO, luke, new Die(random, 20), new Die(random, 6));
game2.Run(log);
