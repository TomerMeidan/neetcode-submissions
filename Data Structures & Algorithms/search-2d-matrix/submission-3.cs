public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0;
        int right = matrix.Length;

        if(matrix.Length == 1 && matrix[0].Length == 1) return target == matrix[0][0];

        while(left <= right){
            int middle = left + (right - left) / 2;
            if (middle >= matrix.Length) return false;
            
            for(int i = 0 ; i < matrix[0].Length; i++){

                if(target == matrix[middle][i]) 
                    return true;
                if(target < matrix[middle][i]){
                    right = middle - 1;
                    break;
                }
                if(i == matrix[0].Length - 1)
                    if(target > matrix[middle][i]){
                        left = middle + 1;
                        break;
                    }       
            }
        }

        return false;
    }
}
