// Got 87% without binary search https://codility.com/demo/results/trainingWNABKT-ATU/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        // var response = solution(new int[] { 5, 3, 6, 3, 3 }, new int[] { 2, 3, 1, 1, 2 }, new int[] { -1, 0, -1, 0, 3 });
        // var response = solution(new int[] { 5 }, new int[] { 2 }, new int[] { -1 });
        var response = solution(new int[] { 5 }, new int[] { 6 }, new int[] { -1 });

        Console.WriteLine(response);
    }

    public static int solution(int[] A, int[] B, int[] C)
    {
        Node roof = new Node() { Id = -1, Durability = int.MaxValue, Weight = 0 };

        Node[] nodes = new Node[A.Length]; // node array for O(1) searching

        for (int i = 0; i < A.Length; i++)
        {            
            Node newNode = new Node() { Id = i, Weight = B[i], Durability = A[i] - B[i] };
            nodes[i] = newNode;

            if (newNode.Durability < 0)
            {
                return i - 1;
            }

            if (C[i] == -1)
            {
                roof.Children.Add(newNode);
                newNode.Parent = roof;
                continue; // if hung from the roof, no need to check
            }
            else
            {
                nodes[C[i]].Children.Add(newNode);
                newNode.Parent = nodes[C[i]];
            }

            Node searchNode = nodes[C[i]];
            while (searchNode.Id != -1) // go from leaf to roof
            {
                searchNode.Durability = searchNode.Durability - newNode.Weight;

                if (searchNode.Durability < 0) // rope was broken
                {
                    return i;
                }

                searchNode = searchNode.Parent;
            }
        }

        return A.Length;
    }

    public class Node
    {
        public int Weight { get; set; }

        public int Id { get; set; }

        public int Durability { get; set; }

        public Node Parent { get; set; }

        public List<Node> Children { get; set; }

        public Node()
        {
            this.Children = new List<Node>();
        }
    }
}