using System.ComponentModel.DataAnnotations;

namespace AreaLibraries;

public static class AreaLibrary
{
    public static double CircleAreaRadius(double radius)
    {
        return Math.Round((radius * radius) * Math.PI, 4);
    }

    public static double TriangleArea(double part1, double part2, double part3)
    {
        double p = (part1 + part2 + part3) / 2;
        return Math.Round(Math.Sqrt(p * Math.Abs(p - part1) * Math.Abs(p - part2) * Math.Abs(p - part3)), 4);
    }
    public static bool IsTriangle90(double part1, double part2, double part3)
    {
        double other = 0;
        double temp = Math.Max(part1, part2);
        double bigger = Math.Max(temp, part3);
        if (part1 == bigger)
        {
            other = (part2 * part2) + (part3 * part3);
        }
        else if (part2 == bigger)
        {
            other = (part1 * part1) + (part3 * part3);
        }
        else if (part3 == bigger)
        {
            other = (part2 * part2) + (part1 * part1);
        }

        if ((bigger * bigger) == other)
        {
            return true;
        }   

        return false;
    }
}