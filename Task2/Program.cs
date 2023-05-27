namespace Task2{
    class Program{

        static int CalculateDepth(Branch node) {

            if(node == null){
                return 0;
            }

            int deepest = 0;
            foreach (Branch child in node.branches) {
                int depthChild = CalculateDepth(child);
                if(depthChild > deepest){
                    deepest = depthChild;
                }
            }

            return deepest + 1;
        }

        static void Main(string[] args){
            Branch root = new Branch();
            int[] perLevelChildren = {2, 1, 3, 0, 1, 2, 0, 0, 1, 0};

            List<Branch> queue = new List<Branch>();
            Branch pointer = root;
            foreach (int numChild in perLevelChildren){
                for(int i=0;i<numChild;i++){
                    Branch temp = new Branch();
                    pointer.branches.Add(temp);
                    queue.Add(temp);
                }
                pointer = queue[0];
                queue.Remove(pointer);
            }


            int depth = CalculateDepth(root);
            Console.WriteLine(depth);
        }
    }

    class Branch{
        public List<Branch> branches;

        public Branch(){
            this.branches = new List<Branch>();
        }
    }
}