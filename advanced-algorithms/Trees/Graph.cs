namespace advanced_algorithms.Trees
{
    public class Graph<T> where T : notnull
    {
         public int EdgesNumber { get; set; }
         public Dictionary<T, List<T>> AdjList { get; set; } = new Dictionary<T, List<T>>();

        public void AddVert(T value)
        {
            if (!AdjList.ContainsKey(value))
            {
                AdjList.Add(value, new List<T>());
            }
        }

        public void AddEdge(T a, T b)
        {
            AdjList[a].Add(b);
            AdjList[b].Add(a);
        }

        public void Print()
        {
            foreach (KeyValuePair<T, List<T>> entry in AdjList)
            {
                Console.WriteLine(entry.Key);
                foreach(T v in entry.Value)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine("---------");
            }
        }
    }
}
