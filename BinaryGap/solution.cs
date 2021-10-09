using System;

class Solution {
    public int solution(int N) {
        
        String number = Convert.ToString(N, 2);
        int count = 0;
        int maxCount = 0;

        for (int i = 0; i < number.Length; i++) {
            if (number[i] == '0') {
                count++;
            }
            else {
                maxCount = Math.Max(maxCount, count);
                count = 0;
            }
        }
        return maxCount;
    }
}
