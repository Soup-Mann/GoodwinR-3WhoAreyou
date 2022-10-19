//Reed Goodwin
//10-19-2022
//Mini Challenge #3 "WHo are you when did You awaken"
//THis is will ask you when you woke up then will tell you 
//goodmorning and tell you when you woke up

bool isconverted = true;
long validNum = 0;
string quit = "";

while (isconverted){
while(quit != "no"){
Console.WriteLine("Hey! WHat is your name?");
string myname = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("What time did you wake up?");

string mytime = Console.ReadLine();

bool isNumber = Int64.TryParse(myname, out validNum);
bool isNumber2 = Int64.TryParse(mytime, out validNum);
Console.WriteLine("");
if (isNumber == false && isNumber2 == true){
Console.WriteLine("Good Morning " + myname + " You woke up at " + mytime + "! LazyBones :)");
Console.WriteLine("");
Console.WriteLine("Would you like to play again?");
Console.WriteLine("yes or no");
quit = Console.ReadLine();
}else{
    Console.WriteLine("Invalid Entry");
    Console.WriteLine("Press enter to restart");
    quit = Console.ReadLine();
}
}
}