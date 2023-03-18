public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
    
        if (m > n) {
            return FindMedianSortedArrays(nums2, nums1); // ensure nums1 is the shorter array
        }

           int left = 0;
    int right = m;
    int halfLength = (m + n + 1) / 2; // half length of the merged array
    
    while (left <= right) {
        int i = (left + right) / 2;
        int j = halfLength - i;
        
        if (i < right && nums2[j-1] > nums1[i]) {
            left = i + 1; // i is too small, increase it
        }
        else if (i > left && nums1[i-1] > nums2[j]) {
            right = i - 1; // i is too big, decrease it
        }
        else { // i is perfect
            int maxLeft = 0;
            if (i == 0) {
                maxLeft = nums2[j-1];
            }
            else if (j == 0) {
                maxLeft = nums1[i-1];
            }
            else {
                maxLeft = Math.Max(nums1[i-1], nums2[j-1]);
            }
            
            if ((m + n) % 2 == 1) { // odd number of elements
                return maxLeft;
            }
            
            int minRight = 0;
            if (i == m) {
                minRight = nums2[j];
            }
            else if (j == n) {
                minRight = nums1[i];
            }
            else {
                minRight = Math.Min(nums1[i], nums2[j]);
            }
            
            return (maxLeft + minRight) / 2.0; // even number of elements
        }
    }
    return 0.0; // arrays are not sorted
    }
}