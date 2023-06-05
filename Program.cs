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
dialog("Escolha um numero entre 1 a 9: ",25);
answer = Console.ReadLine()!;
if (int.TryParse(answer, out converted_answer))
{
converted_answer = int.Parse(answer);
if (converted_answer == 0) 
{

}
}
else
{
    loop();
}
}
loop();