




Action<string> print = Console.WriteLine;
print("hola");


Action<string> hi = nombre => Console.WriteLine($"hola {nombre}");
hi("juan");


// como siempre retorna algo, el ultimo es lo que retorna
Func<int, int, int> sum = (a, b) => a + b;

print(sum(2, 5).ToString());