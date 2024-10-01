
int[] arreglos = new int[5];

arreglos[0] = 5;
arreglos[1] = 1;
arreglos[2] = 4;
arreglos[3] = 2;
arreglos[4] = 8;

for(var y = 0; y < 4; y++)
{
    for(var x = 0; x < 4; x++)
    {
        if(arreglos[x]>arreglos[x+1])
        {
            int temporal = arreglos[x];
            arreglos[x] = arreglos[x+1];
            arreglos[x+1] = temporal;
        }
    }
}

for(var w = 0; w < 5; w++)
{
    Console.WriteLine(arreglos[w]);
}
