using System;
using Someone;


One one = new(7);


int Foo(int num) => num * num;

Console.WriteLine(Foo(10));

var x = Foo;
Console.WriteLine(x(10));