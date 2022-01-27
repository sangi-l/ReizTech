using System;

namespace ReizTech_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st layer
            Tree tree = new Tree(new Branch());

            // 2nd layer
            tree.Branch.branches.Add(new Branch());
            tree.Branch.branches.Add(new Branch());
            tree.Branch.branches.Add(new Branch());

            // 3rd layer
            tree.Branch.branches[0].branches.Add(new Branch());
            tree.Branch.branches[0].branches.Add(new Branch());
            tree.Branch.branches[1].branches.Add(new Branch());
            tree.Branch.branches[2].branches.Add(new Branch());

            // 4th layer
            tree.Branch.branches[0].branches[0].branches.Add(new Branch());
            tree.Branch.branches[0].branches[1].branches.Add(new Branch());
            tree.Branch.branches[0].branches[1].branches.Add(new Branch());
            tree.Branch.branches[1].branches[0].branches.Add(new Branch());

            // Calculate and print out tree depth
            int depth = tree.CalculateDepth(tree.Branch);
            Console.WriteLine("Tree depth: {0}", depth);
        }
    }
}
