using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    MooseQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    MooseQuestion("Are birds real?", "Wake up. You have been brainwashed.", "Correct. Today's 'birds' are surveillance drones.");
    MooseQuestion("Is this a question?", "Right. Kind of meta, but I am a moose so.", "Well...");
    MooseQuestion("Is this really the end?", "If you insist.", "Oh?");
};

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};

void MooseQuestion(string Question, string Yes, string No)
{
    bool isTrue = MooseAsks(Question);
    if (isTrue)
    {
        MooseSays(Yes);
    }
    else
    {
        MooseSays(No);
    }
};

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
};