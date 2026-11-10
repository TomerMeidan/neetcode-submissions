public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, HashSet<int>> courses = new Dictionary<int, HashSet<int>>();
        Stack<(int k, HashSet<int> preqs)> stack = new  Stack<(int k, HashSet<int> preqs)>();
        HashSet<int> visited = new HashSet<int>();

        for(int i = 0 ; i < numCourses ; i++){
            courses.Add(i, new HashSet<int>());
        }

        for(int i = 0 ; i < prerequisites.Length ; i++){
            courses[prerequisites[i][1]].Add(prerequisites[i][0]);
        }
        
        foreach(var course in courses){

            stack.Push((course.Key, course.Value));               
            visited = new HashSet<int>();

            while(stack.Count > 0){
                var n = stack.Pop();

                if(!visited.Contains(n.k)){
                    visited.Add(n.k);             
                }else 
                    return false;

                foreach(var preq in n.preqs){
                    if(courses.ContainsKey(preq) && courses[preq].Count > 0){
                        stack.Push((preq, courses[preq]));
                    }
                }
            }
        }

        return true;

    }
}
