﻿// Найти сумму элементов от M до N, N и M заданы

int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
            else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
            else if (M == N) return M;                       // Если M=N
            else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
            else return N + SumNumbers(M, N + 1);            // Если M>N
}

Console.WriteLine(SumNumbers(2, 11));
