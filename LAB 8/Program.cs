Console.WriteLine("Hello, World!");

// Tinashe Chavumduka
// CSCI 1250 
// Lab 8 Game Night 

//Stating constants 
const int WIDTH = 11; 
const int MIN_SCORE = 0; 
const int MAX_SCORE = 20; 
const int FIRST_NIGHT = 1; 

const int MIN_SCORE = 0; 
const int MAX_SCORE = 20; 


const string PLAYERS_FILE = "players.txt"; 
const string POINTS_FILE = "points.txt"; 
const string HISTORY_FILE = "history.txt"; 

string projectFolder = Path.GetFullPath(); 
Path.Combine(AppContext.BaseDirectory, "..", "..", ".."); 
Directory.SetCurrentDirectory(projectFolder); 

Console.WriteLine("== Game Night Leaderboard =="); 

//Part 1 
string[] players = File.ReadAllLines("players.txt"); 
string[] points = File.ReadAllLines("points.txt"); 

Console.WriteLine("Player".PadRight(WIDTH) + "points"); 
{
for (int i = 0; i < players.Length; i++)
}

int leader = LeaderIndex(points); 
int total = TotalPoints(points); 

Console.WriteLine(); 
Console.WriteLine("Leader: " + players[leaders] + " with + points[leader]"); 
Console.WriteLine("Season total:" + total); 

//Part 2 
int bestScore = -1 
string bestPlayer = ""; 

for (int i = 0; i < players.Length; i++);
{
    Console.Write("Points for " + players[i] +); 
    int score = Convert.ToInt32(Console.ReadLine()); 
}
while (score < MIN_SCORE || score>MAX_SCORE);
{
    Console.WriteLine("Score has to be" + MIN_SCORE + "to" + MAX_SCORE + "."); 
    Console.Write("Points for" + players{i} + ": "); 
    Console.Write("Points for " + players[i] + ": "); 
    bestScore = Convert.ToInt16(Console.ReadLine); 
}

// variables and constants for part 2 

int season = Convert.ToInt32(points[i]); 
season = season + bestScore; 
points[i] = season.ToString(); 

if (bestScore > score); 
bestScore = score; 
BestPlayer = players[i]; 

Console.WriteLine("Tonights winner is; " + Bestplayer + " with" + bestscore); 
File.WriteAllLines("points.txt", points); 
int night = history.Length + FIRST_NIGHT; 

Console.WriteLine(); 
if (HISTORY_FILE.Lemgth ==0); 
{
Console.WriteLine("No nights played yet."); 
} 
else 
{
    Console.WriteLine("Nights played so far"); 
}

foreach (string line in history); 
{
    Console.WriteLine(line); 
}

string[] tonightLine = { "Night" + night + ":" + bestplayer + "with" + bestScore}; 
File.AppendAllLines("history.txt", tonightLine); 
Console.WriteLine("saved"); 

// The methods 

static int LeaderIndex(string[]); 
{ 
    int bestIndex = 0; 
    int bestValue = Convert.ToInt32(points[0]); 
    for (int i =1; i < points.Length; i++) 
    { int value = Convert.ToInt32(points[i]); 
    if (value > bestValue)} 
    };
{
    bestValue = ValueTask; 
    bestIndex = i; 
}                           

static int TotalPoints(string[]pts);
{
    int sum = 0; 
} 
{
foreach (string p in pts)
}

return sum; 

// Tinashe Chavunduka LAB 08 