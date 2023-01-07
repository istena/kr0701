
Console.Clear();
Console.Write("Введите количество элементов в массиве ");
int n =int.Parse(Console.ReadLine());
string []massiv = new string[n];
string []newmassiv = new string[n];
int j=0;
for (int i=0;i<n;i++){
    Console.Write($"{i+1})");
    massiv[i]=Convert.ToString(Console.ReadLine());
    if (massiv[i].Length<=3){
        newmassiv[j]=massiv[i];
        j++;
    }
}
for (int i=0;i<j;i++) Console.Write($"{newmassiv[i]}    ");
