using System;

public class TwoSum{
    public static void Main(string[] args){
        
        static int[] twoPosition(int[] nums, int target){
            int[] result = new int[2];
            for(int i = 0; i < nums.Length; i++){
                for(int j = i + 1; j < nums.Length; j++){
                    if(nums[i] + nums[j] == target){
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return null;
        }
        
        int[] arrNums = {2, 3, 4, 6, 7, 77777, 2000};
        int targetValue = 10;
        
        int[] positions = twoPosition(arrNums, targetValue);
        
        if (positions != null){
            Console.WriteLine($"indices: {positions[0]}, {positions[1]}");
        } else {
            Console.WriteLine("Nenhuma combinação encontrada.");
        }
    }
}

// Complexidade de Tempo O(n2)
// Complexidade de Espaço O(1)