﻿//Isaiah Keith Ferguson
//10/18/2022
//Restaurant picker
//Prompt the user to pick catagories depeneding on the catagorie picked we will display a restaurant
//reviewed by:

Console.Clear();
string outloopstring = "";
string input = "";
string inputfood = "";
int num1 = 0;
int num2 = 0;
bool tro = true;
bool outloop = true;
string[] Asian = {"Ramen King",  "Legendary Wok", "Pho King", "Phu Lucky", "Fox Creek Soup spot", "Hana Sushi", "Domo's", "Luu's Sushi Bowl", "Tora Sushi", "Fuji Sushi"};

string[] fastFood = {"Mcdonalds", "Five Guys", "Jack N the Box",  "Burger King", "Wendy's", "PizzaHut", "Dominoes", "fired Pizza", "Little Ceaser's", "Costco Pizza"};

string[] SitDown = {"BJ's", "Outback", "Texas RoadHouse", "Chili's", "Olive Garden", "Black Bear Diner", "Mimosa Gourmet", "Chuck's", "HuckleBerries", "IHOP"};

Random Randm = new Random();


while (outloop == true)
{
num2 = Randm.Next();


Console.WriteLine("Lets eat!");
Console.WriteLine("What are you feeling like? 'Asian Food', 'Fast Food' or 'Sit Down' restaurants?");
input = Console.ReadLine();

tro = Int32.TryParse(input, out num1);

if (input == "asian food")
{
    Console.WriteLine("What kind of asian food 'Pho' or 'Sushi?'");
    inputfood = Console.ReadLine().ToLower();

if (inputfood == "pho"){
    num2 = Randm.Next(0, 4);

switch (1)
{
    case 1:
    Console.WriteLine($"lets go to {Asian[num2]}");
    break;
}
}
if (inputfood == "sushi")
{
num2 = Randm.Next(5, 8);

switch (1)
{
    case 1:
    Console.WriteLine($"lets go to {Asian[num2]}");
    break;
}
}
}
if (input == "fast food")
{
    Console.WriteLine("What kind of Fast food 'Burgers' or 'Pizza?'");
    inputfood = Console.ReadLine().ToLower();

if (inputfood == "burgers"){
    num2 = Randm.Next(0, 4);

switch (1)
{
    case 1:
    Console.WriteLine($"Lets get some {fastFood[num2]}");
    break;
}
}
if (inputfood == "pizza")
{
num2 = Randm.Next(5, 8);

switch (1)
{
    case 1:
    Console.WriteLine($"Lets get some {fastFood[num2]}");
    break;
}
}
}
if (input == "SitDown")
{
        Console.WriteLine("What kind of Fast food 'Dinner' or 'BreakFast?'");
    inputfood = Console.ReadLine().ToLower();

if (inputfood == "dinner"){
    num2 = Randm.Next(0, 4);

switch (1)
{
    case 1:
    Console.WriteLine($"Lets go to {SitDown[num2]} since we have some extra time");
    break;
}
}
if (inputfood == "breakfast")
{
num2 = Randm.Next(5, 8);

switch (1)
{
    case 1:
    Console.WriteLine($"Lets go to {SitDown[num2]} since we have some extra time");
    break;
}
}

if (tro)
{
    Console.WriteLine("That was invalid");
    break;
}
}

Console.WriteLine("Press enter to replay or Type 'End' to quit.");
outloopstring = Console.ReadLine().ToLower();

if (outloopstring == "end")
{
    outloop = false;
}
}