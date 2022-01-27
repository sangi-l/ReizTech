namespace ReizTech_2
{
    public class Tree
    {
        public Branch Branch { get; set; }
        public Tree(Branch branch)
        {
            Branch = branch;
        }
        public int CalculateDepth(Branch branch)
        {
            // Search depth for each path
            foreach (var item in branch.branches)
            {
                int depth = CalculateDepth(item);
                return depth + 1;
            }
            return 1;
        }
    }
}
