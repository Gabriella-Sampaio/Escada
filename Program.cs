Console.Clear();

Console.WriteLine("Escada");

Console.Write("Altura da escada: ");
double comprimentoEscada = Convert.ToDouble(Console.ReadLine());

Console.Write("Angulo em graus: ");
double anguloEmGraus = Convert.ToDouble(Console.ReadLine());

double anguloEmRadianos = Math.PI * anguloEmGraus / 180;
double altura = comprimentoEscada * Math.Sin(anguloEmRadianos);

Console.WriteLine($"Uma escada de {comprimentoEscada}m a {anguloEmGraus}° alcança {altura:N}m");