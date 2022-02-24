using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    CanadaQuestion();
    BirdQuestion();
    QuestionQuestion();
    TheFinalQuestion();
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

void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }
};
void BirdQuestion()
{
    bool isTrue = MooseAsks("Are birds real?");
    if (isTrue)
    {
        MooseSays("Wake up. You have been brainwashed.");
    } 
    else 
    {
        MooseSays("Correct. Today's 'birds' are surveillance drones.");
    }
};
void QuestionQuestion()
{
    bool isTrue = MooseAsks("Is this a question?");
    if (isTrue)
    {
        MooseSays("Right. Kind of meta, but I am a moose so.");
    } 
    else 
    {
        MooseSays("Well...");
    }
};
void TheFinalQuestion()
{
    bool isTrue = MooseAsks("Is this really the end?");
    if (isTrue)
    {
        MooseSays("If you insist.");
    } else 
    {
        MooseSays("Oh?");
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