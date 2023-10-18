using System;

public class Solution
{
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] sol = new int[n + m - 1];
        int count = 0;
        int i = 0;
        int j = 0;
        while (i < n && j < m)
        {
            if (nums2[i] > nums1[j])
            {
                sol[count] = nums1[j];
                j++;
            }
            else
            {
                sol[count] = nums2[i];
                i++;
            }

            count++;
        }

        if (i == n)
        {
            while (j < m)
            {
                sol[count] = nums1[j];
                count++;
            }
        }
        else
        {
            while (i < n)
            {
                sol[count] = nums2[i];
                count++;
            }
        }

        return sol;
    }
}