using System;
using System.Security.Cryptography;
namespace TestingWorkspase
{
    internal class Program
    {
        static void Main()
        {

        }
    }

    public enum BorderSide { Left, Right, Top, Bottom }

    public enum HorisontalAlingment
    {
        Left = BorderSide.Left,
        Right = BorderSide.Right,
        Center
    }

    [Flags]
    public enum BorderSides
    {
        None = 0,
        Left = 1, Riight = 1 << 1, Top = 1 << 2, Bottom = 1 << 3,
        LeftRigt = Left | Riight,
        TopBottom = Top | Bottom,
        All = LeftRigt | TopBottom
    }
}
