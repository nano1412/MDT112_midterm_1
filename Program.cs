using System;

namespace Midterm_1{
          class Program{
                    static void Main(string[] args){
                              //input variable
                              double x1 = double.Parse(Console.ReadLine());
                              double y1 = double.Parse(Console.ReadLine());
                              double w1 = double.Parse(Console.ReadLine());
                              double h1 = double.Parse(Console.ReadLine());
                              double x2 = double.Parse(Console.ReadLine());
                              double y2 = double.Parse(Console.ReadLine());
                              double w2 = double.Parse(Console.ReadLine());
                              double h2 = double.Parse(Console.ReadLine());

                              //edge variable
                              double top1 =    y1 + h1;
                              double bottom1 = y1 - h1;
                              double left1 =   x1 - w1;
                              double right1 =  x1 + w1;
                              double top2 =    y2 + h2;
                              double bottom2 = y2 - h2;
                              double left2 =   x2 - w2;
                              double right2 =  x2 + w2;

                              //is intersect variable
                              bool isfromtop =    top1 > bottom2 && top1 < top2;
                              bool isfrombottom = top2 > bottom1 && top2 < top1;
                              bool isfromright =  right1 > left2 && right1 < right2;
                              bool isfromleft =   right2 > left1 && right2 < right1;

                              //intersect case variable
                              double h3 = 0;
                              double w3 = 0;

                              //find h and w of area
                              if(isfromtop){
                                        h3 = top1 - bottom2;
                              } else if(isfrombottom){
                                        h3 = top2 - bottom1;
                              } 

                              if(isfromright){
                                        w3 = right1 - left2;
                              } else if(isfromleft){
                                        w3 = right2 - left1;
                              } 

                              //calculate area
                              double a = w3 * h3;;

                              //output
                              if((isfromtop || isfrombottom) && (isfromright || isfromleft)){
                                        if(a > 8){
                                                  Console.WriteLine("Too Much Overlapping");
                                        } else {
                                                  Console.WriteLine("Not Much Overlapping");
                                        }
                              } else {
                                        Console.WriteLine("No overlapping");
                              }
                    }
          }
}