using System;

namespace Midterm_1{
          class Program{
                    static void Main(string[] args){
                              double x1 = double.Parse(Console.ReadLine()); //5
                              double y1 = double.Parse(Console.ReadLine()); //6
                              double w1 = double.Parse(Console.ReadLine()); //3.5
                              double h1 = double.Parse(Console.ReadLine()); //1
                              double x2 = double.Parse(Console.ReadLine()); //2
                              double y2 = double.Parse(Console.ReadLine()); //2.5
                              double w2 = double.Parse(Console.ReadLine()); //1
                              double h2 = double.Parse(Console.ReadLine()); //2

                              double top1 =       y1 + h1;
                              double buttom1 =    y1 - h1;
                              double left1 =      x1 - w1;
                              double right1 =     x1 + w1;
                              double top2 =       y2 + h2;
                              double buttom2 =    y2 - h2; 
                              double left2 =      x2 - w2;
                              double right2 =     x2 + w2;

                              bool isfromtop = top1 > buttom2 && buttom1 < top2; //the interset is on top relate to Poster1
                              bool isfromleft = right1 < left2 && left1 > right2; //the interset is on left relate to Poster1
                              bool isfrombuttom = top2 > buttom1 && buttom2 < top1;
                              bool isfromright = right2 < left1 && left2 > right1;

                              double h3 = 0;
                              double w3 = 0;
                              double a = 0;

                              if(isfrombuttom || isfromleft || isfromright || isfromtop){
                                        if(isfromtop){
                                                  h3 = top1 - buttom2;
                                        } else if(isfrombuttom){
                                                  h3 = top2 - buttom1;
                                        } else {
                                                  if(top1 - buttom1 > top2 - buttom2){
                                                            h3 = h2*2;
                                                  } else {
                                                            h3 = h1*2;
                                                  }
                                        }

                                        if(isfromright){
                                                  w3 = right2 - left1;
                                        } else if(isfromleft){
                                                  w3 = right1 - left2;
                                        } else {
                                                  if(right1 - left1 > right2 - left1){
                                                            w3 = w2*2;
                                                  } else {
                                                            w3 = w1*2;
                                                  }
                                        }

                                        a = w3 * h3;
                                        if(a >= 8){
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