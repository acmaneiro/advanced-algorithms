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

        public void DFSearchGroupsCounter()
        {
            Dictionary<T, Boolean> visitados = new Dictionary<T, bool>();
            var totalGroups = 0;
            foreach (KeyValuePair<T, List<T>> entry in AdjList)
            { 
                if(!visitados.ContainsKey(entry.Key))
                {
                    SearchAdj(entry.Key, visitados);
                    totalGroups++;
                }               
            }
            Console.WriteLine("Resultado {0}", totalGroups);
        }

        public void SearchAdj(T value, Dictionary<T, Boolean> visitados)
        {
            if (visitados.ContainsKey(value))
                return;

            visitados.Add(value, true);
            foreach (var entry in AdjList[value])
            {                
                SearchAdj(entry, visitados);
            }
        }
    }
}
