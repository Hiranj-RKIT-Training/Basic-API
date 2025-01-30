namespace Collection_Demo
{
    internal class JaggedArrayDemo
    {
        public static void JaggedMain()
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 90, 78 };
            studentScores[1] = new int[] { 88, 76 };
            studentScores[2] = new int[] { 92, 81, 74, 89 };

            foreach (dynamic scores in studentScores)
            {
                foreach (int score in scores)
                {
                    Console.Write(score + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
