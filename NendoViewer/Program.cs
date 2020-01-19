﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NendoViewer {
    class Program {
        static void Main(string[] args) {
            DateTime parsed;
            while (true) { 
                Console.Write("日付を入力 >> ");
                var accepted = Console.ReadLine();

                if (DateTime.TryParse(accepted, out parsed)) break;
            }


            Console.WriteLine($"現在年度は{parsed.Year}年度です。");
            Console.Read();
        }
    }
}
