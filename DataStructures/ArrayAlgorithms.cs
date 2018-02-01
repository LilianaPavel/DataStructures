
namespace DataStructures
{
    public class ArrayAlgorithms
    {
        // find max value -> iterate through array -> O(n)
        public int FindMax(int[] array)
        {           
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            int max = array[0];
            for(int i=1; i<array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        // find max value -> compare to all values -> O(n^2)
        public int FindMaxCompareToAll(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            bool isMax;
            for(int i=0;i<array.Length;i++)
            {
                isMax = true;
                for (int j=i+1; j<array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        isMax = false;
                        break;
                    }
                }

                if (isMax == true)
                {
                    return array[i];
                }
            }

            return -1;
        }

    }
}
