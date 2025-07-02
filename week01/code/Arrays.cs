public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // Step 1: Create a new array of doubles with the specified length.
        // Step 2: Use a for loop to go from 0 to length - 1.
        // Step 3: In each iteration, multiply the number by (i + 1) and store the result in the array.
        // Step 4: Return the completed array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3, 
    /// the result should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // Step 1: Determine the number of items in the list using Count.
        // Step 2: Use GetRange to extract the last 'amount' elements.
        // Step 3: Remove those last 'amount' elements from the list.
        // Step 4: Insert the extracted elements at the beginning of the list using InsertRange.

        int n = data.Count;
        List<int> LastPart = data.GetRange(n - amount, amount);
        data.RemoveRange(n - amount, amount);
        data.InsertRange(0, LastPart);
    }
}
