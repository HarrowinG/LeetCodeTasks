namespace LeetCodeTasks._2424LongestUploadedPrefix
{
    public class Runner
    {
        public void Run()
        {
            LUPrefix server = new LUPrefix(4);   // Initialize a stream of 4 videos.
            server.Upload(3);                    // Upload video 3.
            Console.WriteLine(server.Longest());                    // Since video 1 has not been uploaded yet, there is no prefix.
                                                                    // So, we return 0.
            server.Upload(1);                    // Upload video 1.
            Console.WriteLine(server.Longest());                    // The prefix [1] is the longest uploaded prefix, so we return 1.
            server.Upload(2);                    // Upload video 2.
            Console.WriteLine(server.Longest());                    // The prefix [1,2,3] is the longest uploaded prefix, so we return 3.
        }
    }
}
