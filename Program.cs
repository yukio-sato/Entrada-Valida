string answer;
int converted_answer;
void dialog(string txt, int cooldown)
{
for (int i = 0; i < txt.Length; i++)
{
    Console.Write(txt[i]);
    Thread.Sleep(cooldown);
}
}
void loop()
{
Console.ForegroundColor = ConsoleColor.White;
dialog("Escolha um numero entre ",25);
Console.ForegroundColor = ConsoleColor.Yellow;
dialog("1 ",25);
Console.ForegroundColor = ConsoleColor.White;
dialog("a ",25);
Console.ForegroundColor = ConsoleColor.Yellow;
dialog("9 ",25);
Console.ForegroundColor = ConsoleColor.Red;
dialog("(0 = Cancelar)",25);
Console.ForegroundColor = ConsoleColor.White;
dialog(": ",25);
Console.ForegroundColor = ConsoleColor.Yellow;
answer = Console.ReadLine()!;
if (int.TryParse(answer, out converted_answer))
{
converted_answer = int.Parse(answer);
if (converted_answer == 0) 
{
Console.ForegroundColor = ConsoleColor.DarkRed;
dialog("Operação Cancelada!\n",25);
}
else if (converted_answer >= 1 && converted_answer <= 9) 
{
Console.ForegroundColor = ConsoleColor.Cyan;
dialog("Número escolhido: ",25);
Console.ForegroundColor = ConsoleColor.Green;
dialog($"{converted_answer}\n",25);
}
else
{
    loop();
}
}
else
{
    loop();
}
}
loop();
Console.ForegroundColor = ConsoleColor.DarkYellow;
dialog("\n\nVolte Sempre!\n",25);
Console.ResetColor();