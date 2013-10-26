using System;

namespace InfiniteLayer
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (InfiniteLayerGame game = new InfiniteLayerGame())
            {
                game.Run();
            }
        }
    }
#endif
}

