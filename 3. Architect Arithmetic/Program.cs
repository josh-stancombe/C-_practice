/* 

-- Architect Arithmetic --

Architects have big ideas – but big ideas can be expensive. How expensive? Depends on the size... In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan... Hint: A building can be (approximately) broken into circles and rectangles. 

Using basic formulas, we can calculate the area of each shape and find the total. 

See attached image for the blueprint of the Mexican building 'Teotihuacan'. Although the floor plan isn’t exactly one circle and rectangle, this approximation is good enough for estimating costs. 

*/

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args){
      
      // Building info and floor material costs
      string building = "Teotihuacan";
      double floorMaterial = 180;  //180 Mexican Pesos
      
      // Calculate building area calculations:
      double rectangleArea = Rectangle(2500,1500);
      double circleArea  = Circle(375);
      double triangleArea = Triangle(750,500);
      double totalArea = rectangleArea + circleArea + triangleArea;

      // Calculate Cost
      double totalCost = Math.Round(totalArea * floorMaterial, 2);

      Console.WriteLine($"The total cost of building {building} will be {totalCost} Mexican Pesos.");

    }

    static double Rectangle(double length, double width){
      return length * width;
    }

    static double Circle(double radius){
      return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangle(double bottom, double height){
      return (0.5 * bottom * height);
    }

  }
}
