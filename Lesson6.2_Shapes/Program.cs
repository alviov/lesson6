using System;
using lesson6;
using System.Collections.Generic;
using static Lesson6.Shape;

namespace Lesson6._2_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявляем начальный куб
            Box box = new Box(0);
            box = box.GenerateNewShape();
            box.ShowParameters();
            double volume = box.Volume();
            //задаём лист фигур, которые будем складывать в наш куб
            List<Shape> shapes = new List<Shape>();
            //далее - зацикливаем запрос на добавление новых фигур до переполнения
            bool test = true;
            while (test)
            {
                Console.WriteLine($"Do you want to generate new object to put in the Box? there is steel {box.Space(shapes),2:F} free volume. If yes, please type the name of shape. If no, type: STOP");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "box":
                        Box box1 = new Box(0);
                        box1 = box1.GenerateNewShape();
                        //проверяем на размер (условие задачаи)
                        if (!box.Add(box1))
                        {
                            Console.WriteLine("Your figure is too big to be put in the box");
                            test = false;
                        }
                        //проверяем на возможность положить новую фигуру с учётом предыдущих
                        else
                        {
                            shapes.Add(box1);
                            if (box.Space(shapes) < 0)
                            {
                                shapes.RemoveAt(shapes.Count - 1);
                                Console.WriteLine("Your figure is too big to be put in the box");
                                test = false;
                            }
                        }
                        break;
                    case "ball":
                        Ball ball = new Ball(0);
                        ball = ball.GenerateNewShape();
                        if (!box.Add(ball))
                        {
                            Console.WriteLine("Your figure is too big to be put in the box");
                            test = false;
                        }
                        else
                        {
                            shapes.Add(ball);
                            if (box.Space(shapes) < 0)
                            {
                                shapes.RemoveAt(shapes.Count - 1);
                                Console.WriteLine("Your figure is too big to be put in the box");
                                test = false;
                            }
                        }
                        break;
                    case "cylinder":
                        Cylinder cylinder = new Cylinder(0, 0);
                        cylinder = cylinder.GenerateNewShape();
                        if (!box.Add(cylinder))
                        {
                            Console.WriteLine("Your figure is too big to be put in the box");
                            test = false;
                        }
                        else
                        {
                            shapes.Add(cylinder);
                            if (box.Space(shapes) < 0)
                            {
                                shapes.RemoveAt(shapes.Count - 1);
                                Console.WriteLine("Your figure is too big to be put in the box");
                                test = false;
                            }
                        }
                        break;
                    case "pyramid":
                        Pyramid pyramid = new Pyramid(0, 0);
                        pyramid = pyramid.GenerateNewShape();
                        if (!box.Add(pyramid))
                        {
                            Console.WriteLine("Your figure is too big to be put in the box");
                            test = false;
                        }
                        else
                        {
                            shapes.Add(pyramid);
                            if (box.Space(shapes) < 0)
                            {
                                shapes.RemoveAt(shapes.Count - 1);
                                Console.WriteLine("Your figure is too big to be put in the box");
                                test = false;
                            }
                        }
                        break;
                    case "STOP":
                        test = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect shape, try one of that: box, ball, pyramid, cylinder");
                        break;
                }
            }
            //выводим фигуры, которые поместились в наш куб
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"There are now in the Box:");
                Console.WriteLine($"{i + 1}. {shapes[i].ToString().Remove(0,8)} with parameters:");
                shapes[i].ShowParameters();
            }
            Console.ReadKey();
        }
    }
}
