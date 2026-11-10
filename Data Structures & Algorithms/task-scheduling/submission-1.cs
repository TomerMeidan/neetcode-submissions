public class Solution {
public int LeastInterval(char[] tasks, int n) {
    if (tasks == null) return 0;
    
    // 1. Frequency Map
    Dictionary<char, int> map = new Dictionary<char, int>();
    foreach (char t in tasks) {
        if (!map.ContainsKey(t)) map[t] = 0;
        map[t]++;
    }

    // 2. PriorityQueue (Max Heap) based on FREQUENCY
    // We store the count directly. C# PriorityQueue is Min-Heap by default, 
    // so we use negative count (or a custom comparer) to simulate Max-Heap.
    PriorityQueue<int, int> availableTasks = new PriorityQueue<int, int>();
    
    foreach(var count in map.Values) {
        // Priority is -count so larger counts come out first
        availableTasks.Enqueue(count, -count); 
    }

    // 3. Queue for tasks in cooldown: (remainingCount, timeToPickup)
    Queue<(int count, int unlockTime)> cooldownQ = new Queue<(int, int)>();

    int time = 0;

    // Run until both queues are empty
    while (availableTasks.Count > 0 || cooldownQ.Count > 0) {
        
        // Advance time
        time++;

        // A. Process available task
        if (availableTasks.Count > 0) {
            int currentCount = availableTasks.Dequeue();
            currentCount--; // Run the task
            
            // If still tasks left, push to cooldown queue
            if (currentCount > 0) {
                // It becomes available at current time + n
                cooldownQ.Enqueue((currentCount, time + n));
            }
        }
        
        // B. Check if any cooling task is now ready
        // If the task at front of cooldownQ has unlockTime == time, it's ready.
        // NOTE: We check == time because we just incremented time. 
        if (cooldownQ.Count > 0 && cooldownQ.Peek().unlockTime == time) {
            var readyTask = cooldownQ.Dequeue();
            // Add back to available heap
            availableTasks.Enqueue(readyTask.count, -readyTask.count);
        }
    }

    return time;
}
}
