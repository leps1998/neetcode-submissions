public class Solution {
    public int CalPoints(string[] operations) {
var scores = new Stack<int>();

    foreach (var op in operations)

    {

        switch (op)

        {

            case "+":

                var top = scores.Pop();

                var newScore = top + scores.Peek();

                scores.Push(top);

                scores.Push(newScore);

                break;

            case "D":

                scores.Push(2 * scores.Peek());

                break;

            case "C":

                scores.Pop();

                break;

            default:

                scores.Push(int.Parse(op));

                break;

        }

    }

    int total = 0;

    foreach (var score in scores)

    {

        total += score;

    }

    return total;
    }
}