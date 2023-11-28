
using Unadesk;


static void writeInfo(Triangle triangle) => 
    Console.WriteLine($"size: {triangle.A} {triangle.B} {triangle.C}; type: {triangle.Type}");


var right = new Triangle(8, 6, 10);
writeInfo(right);

var acute = new Triangle(8, 8, 8);
writeInfo(acute);

var obtuse = new Triangle(7, 10, 15);
writeInfo(obtuse);


_ = Console.ReadKey();