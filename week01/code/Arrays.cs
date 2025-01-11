public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // first of all I will create a new array with the length that matches the number of multiples
        // then I will make a for loop that puts the multiple of the number in the index of that iteration
        // lastly I will return the array

        //create array with given length
        double[] result = new double[length];

        //multiply the number and add to the result array
        for (int i = 0; i < length; i++){
            result[i] = (i + 1) * number;
        }

        //return the result array
        return result; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I love modulo, its like magic. Best thing programming has to offer. So I will solve this issue using it.
        // so first of all I will need to create a new List.
        // then I will iterate through the original list and find the new list with this algorithm: (originalIndex + rotationAmount) % lengthOfList

        //create new array to store the results in
        int[] result = new int[data.Count];

        // iterate over the list and assign the new index numbers using the algorithm: (originalIndex + rotationAmount) % lengthOfList
        for (int i = 0; i < data.Count; i++) {
            int index = (i + amount) % data.Count;
            result [index] = data[i];
        }

        //now simply push the numbers into the original list
        for (int i = 0; i < data.Count; i++) {
            data[i] = result[i];
        }
    }
}
