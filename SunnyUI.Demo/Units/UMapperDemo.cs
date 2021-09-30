﻿using Sunny.UI.Static;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sunny.UI.Demo
{
    public static class MapperDemo
    {
        public static void Demo()
        {
            MapperT1 t1 = new MapperT1();
            t1.A = "Hello world.";
            t1.B = 1024;
            t1.C = 768;
            t1.D = DateTime.Now;
            t1.E = new Point(100, 200);
            t1.F = new MapperT3("Struct String", '\n', new MapperT4("I am T4"));
            t1.G = new Size(100, 200);
            t1.H = new List<string>() { "AA", "BB" };
            t1.I = new string[2] { "AA", "BB" };

            MapperT2 t2 = new MapperT2();
            t2.MapperFrom(t1);
            t2.WriteConsole();
        }
    }

    public class MapperT1
    {
        public string A { get; set; }

        public int B { get; set; }

        public double C { get; set; }

        public DateTime D { get; set; }

        public Point E { get; set; }

        public MapperT3 F { get; set; }

        public Size G { get; set; }

        public List<string> H { get; set; }

        public string[] I { get; set; }
    }

    public class MapperT2
    {
        public string A { get; set; }

        public int B { get; set; }

        public double C { get; set; }

        public DateTime D { get; set; }

        public Point E { get; set; }

        public MapperT3 F { get; set; }

        public List<string> H { get; set; }

        public string[] I { get; set; }
    }

    public struct MapperT3
    {
        public string String { get; set; }
        public char Char { get; set; }

        public MapperT4 T4 { get; set; }

        public MapperT3(string str, char c, MapperT4 t4)
        {
            String = str;
            Char = c;
            T4 = t4;
        }
    }

    public class MapperT4
    {
        public string String { get; set; }

        public MapperT4()
        {

        }

        public MapperT4(string str)
        {
            String = str;
        }
    }
}