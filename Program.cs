

    int[] cal = new int[10];
    int sum = 0;
    double prom;

    cal[0] = 50;
    cal[1] = 65;
    cal[2] = 89;
    cal[3] = 71;
    cal[4] = 55;
    cal[5] = 98;
    cal[6] = 71;
    cal[7] = 79;
    cal[8] = 80;
    cal[9] = 94;


Console.WriteLine("calificaciones");


    for (int i = 0; i < cal.Length; i++)
    {
        Console.WriteLine($"calificacion {i + 1}:{cal[i]}");
    }

    Array.Sort( cal );
    
    foreach (int i in cal)
    { 
    sum += i;
    }
    Console.WriteLine("la longitud del arreglo es " + cal.Length);
    Console.WriteLine("la sumatoria es " + sum);

    prom = sum / cal.Length;
    Console.WriteLine("el promedio es " + prom);
   
