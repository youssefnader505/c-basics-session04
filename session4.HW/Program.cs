#region Q1
double[] prices = { 25.5, 40.0, 33.75 };//0.1.2
Console.WriteLine(prices[1]);
#endregion

#region Q2
int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
Console.WriteLine(shelfCopies[1, 0]);
#endregion

#region Q3
void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the Library!");
}

PrintWelcomeMessage();
#endregion

#region Q4
 void PrintBookTitle(string title)
{
    Console.WriteLine("Book title: " + title);
}

PrintBookTitle("Clean Code");
#endregion

#region Q5
void AddBonusPages(int pages)
{
    pages += 50;
}

int pages = 400;
AddBonusPages(pages);
Console.WriteLine(pages);
//output 400, modify only the local copy
#endregion

#region Q6
void ApplyDiscount(double[] prices1)
{
    prices1[0] -= 5;
}

double[] prices1 = { 25.5, 40.0 };
ApplyDiscount(prices1);
Console.WriteLine(prices[0]);
#endregion

#region Q7
void AddBonusPagesByRef(ref int pages1)
{
    pages1 += 50;
}

int pages1 = 400;
AddBonusPagesByRef(ref pages1);
Console.WriteLine(pages1);
#endregion

#region Q8
void ReplaceArray(ref double[] prices2)
{
    prices2 = new double[] { 10.0, 12.5, 15.0 };
}

double[] prices2 = { 11.1, 6.6, 22.3 };
ReplaceArray(ref prices2);
Console.WriteLine(prices2.Length);
Console.WriteLine(prices2[2]);
#endregion

#region Q9
 bool TryGetPrice(string title, out double price)
{
    if (title == "Clean Code")
    {
        price = 25.5;
        return true;
    }
    price = 0;
    return false;
}


if (TryGetPrice("Clean Code", out double price))
{
    Console.WriteLine($"Price: {price}");
}
else
{
    Console.WriteLine("Price not found.");
}
#endregion

#region Q10,Q11
void PrintBookInfo(string title1, int pages2 = 300)//def 300
{
    Console.WriteLine($"Title: {title1}, Pages: {pages2}");
}

PrintBookInfo("Clean Code");
PrintBookInfo("The Pragmatic Programmer", 352);


PrintBookInfo(pages2: 352, title1: "The Pragmatic Programmer");
#endregion

#region Q12
void PrintAllTitles(params string[] titles2)
{
    foreach (string title2 in titles2)
    {
        Console.WriteLine(title2);
    }
}

PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Hobit");
#endregion