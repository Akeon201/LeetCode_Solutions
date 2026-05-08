public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int maxNum = arr[arr.Length - 1];
        arr[arr.Length - 1] = -1;
        int indexValue;

        for (int i = arr.Length - 2; i >= 0; i--)
        {
            indexValue = arr[i];
            arr[i] = maxNum;
            maxNum = Math.Max(maxNum, indexValue);
        }

        return arr;
    }
}
