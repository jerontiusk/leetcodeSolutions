public partial class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int value = 0;
       foreach (string operation in operations)
        {
            if (GetSummaryValue(operation) > 0)
            {
                value++;
            }
            else value--;
        }
        return value;
    }
    public int GetSummaryValue(string operation)
    {
        switch (operation)
        {
            case "--X":
                return -1;
            case "X++":
                return 1;
            case "++X":
                return 1;
            case "X--":
                return -1;
            default:
                return 0;
        }
    }
}