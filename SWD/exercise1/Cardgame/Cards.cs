using System;

namespace exercise1
{
    public abstract class Cards
    {
        public virtual string Color{get;set;}
        public virtual int Number{get;set;}
        public virtual int Value{get;set;}
    }

    public class RedCard : Cards
    {
        public RedCard(int number, string color)
        {   
            Number = number;
            Color = color;
            Value = Number*1;
        }
    }
    public class BlueCard : Cards
    {
        public BlueCard(int number, string color)
        {   
            Number = number;
            Color = color;
            Value = Number*2;
        }
    }
    public class GreenCard : Cards
    {
        public GreenCard(int number, string color)
        {   
            Number = number;
            Color = color;
            Value = Number*3;
        }
    }
    public class YellowCard : Cards
    {
        public YellowCard(int number, string color)
        {   
            Number = number;
            Color = color;
            Value = Number*4;
        }
    }
    public class GoldCard : Cards
    {
        public GoldCard(int number, string color)
        {   
            Number = number;
            Color = color;
            Value = Number*5;
        }
    }
}