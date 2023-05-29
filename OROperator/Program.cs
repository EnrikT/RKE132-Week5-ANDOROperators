//Math >= 90 OR Chemistry >= 90 OR Biology >= 90

//Math && chemistry || Math && Biology || Chemistry && Biology

int math, biology, chemistry;
Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratz! You are in!");
}
else
{
    Console.WriteLine("You're not good enough!");
}