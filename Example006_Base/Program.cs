﻿int a = 1;
int b = 2;
int c = 5;
int d = 8;
int e = 3;
int f = 6;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
if (f > max) max = f;

Console.Write("max = ");
Console.WriteLine(max);
