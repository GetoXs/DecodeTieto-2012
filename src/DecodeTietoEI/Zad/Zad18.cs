﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DecodeTietoEI.Zad
{
    class Zad18
    {
        public int result;
        public string input;
        private Field[,] grid = new Field[15,40];
        private List<Point> log = new List<Point>();
        public void Run()
        {
            Fill();
            grid[0, 0].sumMinValue = 2;
            grid[0, 0].isOut = true;
            Field curr, next;
            curr = grid[0, 0];
            bool isNext=true;
            while (isNext)
            {
                next = FindNextMinField(curr);
                if (next == null)
                {
                    Field lowest = null;
                    for (int i = 0; i < 15; i++)
                        for (int j = 0; j < 39; j++)
                            if (grid[i, j].isOut == false)
                            {
                                if (lowest == null)
                                    lowest = grid[i, j];
                                else if (grid[i, j].sumMinValue < lowest.sumMinValue)
                                    lowest = grid[i, j];
                            }
                    next = lowest;
                }
                next.isOut = true;
                log.Add(new Point(curr.i, curr.j));
                curr = next;
                isNext = false;
                for (int i = 0; i < 15; i++)
                    for (int j = 0; j < 39; j++)
                        if (grid[i, j].isOut == false)
                            isNext = true;
            }
            result = grid[14,39].sumMinValue.Value;
        }
        Field FindNextMinField(Field field)
        {
            int calc;
            Field curr, lowestField;
            lowestField = new Field()
            {
                sumMinValue = int.MaxValue
            };
            if (field.i > 0)
            {
                curr = grid[field.i - 1, field.j];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.j > 0)
            {
                curr = grid[field.i, field.j-1];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.i < 14)
            {
                curr = grid[field.i + 1, field.j];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.j < 39)
            {
                curr = grid[field.i, field.j+1];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.i > 0 && field.j > 0)
            {
                curr = grid[field.i - 1, field.j-1];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.i > 0 && field.j < 39)
            {
                curr = grid[field.i - 1, field.j+1];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.i < 14 && field.j > 0)
            {
                curr = grid[field.i +1 , field.j-1];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (field.i < 14 && field.j < 39)
            {
                curr = grid[field.i + 1, field.j+1];
                if (curr.isOut == false)
                {
                    calc = field.sumMinValue.Value + curr.addValue;
                    if (calc < curr.sumMinValue)
                        curr.sumMinValue = calc;
                    if (curr.sumMinValue < lowestField.sumMinValue)
                        lowestField = curr;
                }
            }
            if (lowestField.sumMinValue == int.MaxValue)
            {
                //MessageBox.Show("Koniec ścieżki");
                return null;
            }
            return lowestField;
        }
        void Fill()
        {
            input = @"2	4	4	6	9	3	1	1	5	1	2	5	5	8	5	8	1	8	6	1	1	9	4	8	4	6	1	8	7	4	3	7	1	7	6	5	7	8	4	2
5	6	3	3	6	9	4	1	9	5	4	9	8	3	5	3	1	6	1	1	6	5	3	1	1	6	7	9	1	7	5	4	7	1	4	6	5	9	4	8
3	9	6	2	1	3	6	1	7	4	8	5	1	9	9	1	6	3	7	1	3	1	7	7	3	6	3	8	2	2	6	3	2	6	1	8	6	5	5	7
4	7	6	3	1	6	3	8	9	2	2	3	8	6	1	8	1	9	4	8	7	4	3	3	2	1	4	4	5	1	2	3	5	9	3	7	6	3	9	1
1	2	5	9	4	9	7	5	4	3	2	5	6	1	2	5	4	9	2	4	9	5	8	9	5	4	8	5	3	8	7	5	3	7	4	9	6	7	3	2
4	4	8	1	2	1	1	4	7	7	7	8	5	9	6	3	3	7	8	3	5	2	9	4	2	4	2	3	7	5	6	8	8	2	7	2	1	5	9	2
8	2	3	9	4	2	5	9	3	4	3	5	3	3	3	8	3	8	9	5	5	2	4	5	1	8	9	7	1	8	2	9	8	7	4	3	7	3	2	2
8	9	5	6	9	8	8	7	3	8	2	2	4	1	3	9	3	5	5	5	1	2	5	4	5	4	9	6	8	1	8	3	7	8	2	2	8	4	1	8
3	1	8	2	8	5	7	6	3	2	5	1	1	6	5	2	5	7	2	2	1	8	7	1	6	8	6	5	2	5	2	6	1	2	1	8	3	7	2	8
9	9	6	3	5	8	5	5	8	5	9	1	4	3	9	2	7	6	1	6	9	4	2	2	4	9	5	7	5	9	7	6	8	1	7	8	6	7	5	9
5	6	1	2	2	7	5	2	9	9	8	3	9	9	1	8	1	5	3	5	4	6	9	8	4	7	5	1	1	9	1	9	6	7	5	4	1	2	2	2
7	2	1	5	6	8	8	2	1	3	8	3	2	1	6	3	8	1	4	5	4	6	1	4	7	7	7	7	3	8	2	3	1	3	7	2	8	5	1	8
9	3	1	5	7	7	1	3	5	5	9	8	6	4	6	8	5	7	4	9	9	8	7	3	9	1	9	8	5	6	5	3	6	5	3	5	6	9	8	9
8	1	7	4	6	6	5	4	3	5	9	6	8	5	8	7	9	4	3	1	7	3	9	6	9	8	1	5	3	4	3	4	3	2	8	3	8	7	8	4
2	8	1	9	2	7	8	2	2	7	5	2	7	6	9	7	4	2	8	6	4	3	7	2	5	4	5	3	3	4	8	4	2	9	6	2	9	3	4	6";
            string[] rows = input.Split('\r');
            for (int i = 0; i < 15; i++)
            {
                string[] cols = rows[i].Split('\t');
                for(int j=0; j<40; j++)
                {
                    grid[i, j] = new Field()
                    {
                        addValue = int.Parse(cols[j]),
                        i = i,
                        j = j,
                    };
                }
            }
        }
        class Field
        {
            public int i, j;
            public int addValue;
            public int? sumMinValue = int.MaxValue;
            public bool isOut = false;
        }
    }
}
