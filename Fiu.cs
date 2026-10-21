using System;

class Fiu:Mama
{
    protected int nota2Mate = 7;

    public override void Nota()
    {
        base.Nota();
        Console.WriteLine("Iar noua nota este " + nota2Mate);
    }
} 