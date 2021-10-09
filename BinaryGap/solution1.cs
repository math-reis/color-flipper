using System;

class Solution {
	public int solution(int N) {
		bool started = false;
		int length = 0, max = 0;
		for (uint i = 1; i <= N; i <<= 1) {
			if ((i & N) != 0) {
				if (started) {
				    if (length > max)
						max = length;
					length = 0;
				}
				started = true;
			}
			else if (started)
				++length;
		}
		return max;
	}
}

///////////////////////////////////////////////////

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
