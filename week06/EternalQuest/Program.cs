using System;
using System.Security.Cryptography.X509Certificates;

namespace EternalQuest {
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.Start();
        }
    }
}
