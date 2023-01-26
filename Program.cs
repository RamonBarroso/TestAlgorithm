using System;
using System.Text;




public class Program
{

    static void Main(string[] args)
    {
        var stars = GetPercentageRounds_3(0.7);
        Console.WriteLine(stars);

    }

    /// <summary>
    /// Less elegant way, but it increases the application's performance by replacing the ifs with a swift 
    /// and converting the doubles to an integer. Much more readable, but still not the best scenario for the algorithm
    /// </summary>
    /// <param name="percentage"></param>
    /// <returns></returns>
    public static string GetPercentageRounds_3(double percentage)
    {
        var stars = (int)Math.Ceiling(percentage * 10);
        switch (stars)
        {
            case 0:
                return "----------";
            case 1:
                return "*---------";
            case 2:
                return "**--------";
            case 3:
                return "***-------";
            case 4:
                return "****------";
            case 5:
                return "*****-----";
            case 6:
                return "******----";
            case 7:
                return "*******---";
            case 8:
                return "********--";
            case 9:
                return "*********-";
            case 10:
                return "**********";

            default:
                return "**********";
        }
        return new string('*', stars) + new string('-', 10 - stars);
    }

    static Dictionary<int, string> answers = new();
    /// <summary>
    /// More performative way and with less code, more of a much greater complexity of understanding. 
    /// Decreasing the cyclomatic complexity.
    /// </summary>
    /// <param name="percentage"></param>
    /// <returns></returns>
    public static string GetPercentageRounds_2(double percentage)
    {
        var stars = (int)Math.Ceiling(percentage * 10);
        if (stars < 0 || stars > 10) stars = 10;
        if (!answers.ContainsKey(stars))
            answers.Add(stars, (new string('*', stars) + new string('-', 10 - stars)));
        return answers[stars];
    }
    /// <summary>
    /// Initial way in which the algorithm was presented
    /// </summary>
    /// <param name="percentage"></param>
    /// <returns></returns>
    public static string GetPercentageRounds(double percentage)
    {
        if (percentage == 0)
            return "----------";
        else if (percentage > 0.0 && percentage <= 0.1)
            return "*---------";
        else if (percentage > 0.1 && percentage <= 0.2)
            return "**--------";
        else if (percentage > 0.2 && percentage <= 0.3)
            return "***-------";
        else if (percentage > 0.3 && percentage <= 0.4)
            return "****------";
        else if (percentage > 0.4 && percentage <= 0.5)
            return "*****-----";
        else if (percentage > 0.5 && percentage <= 0.6)
            return "******----";
        else if (percentage > 0.6 && percentage <= 0.7)
            return "*******---";
        else if (percentage > 0.7 && percentage <= 0.8)
            return "********--";
        else if (percentage > 0.8 && percentage <= 0.9)
            return "*********-";

        return "**********";

    }




}
