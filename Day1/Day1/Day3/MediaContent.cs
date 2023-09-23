using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day3
{
    internal class MediaContent
    {
        public void StratplayingContent()
        {
            Console.WriteLine("Start");
        }
        public void StopplayingContent()
        {
            Console.WriteLine("Stop");
        }
        public void PauseplayingContent()
        {
            Console.WriteLine("Pause");
        }
        public void ContinueplayingContent()
        {
            Console.WriteLine("Continue");
        }
    }
    internal class AudioContent : MediaContent 
    {
        //Public override void StartPlayingContent(
        //By Defult it is not possible to ovveride the method form child to parent 
        //parent to permit the child over 
        //Virtual method can be override by childern
        //method for parents class must be virtual to override 
        //bydefult virtual in java
        //A "Final" class cant be inheritant 
        //Override the method and Sealed the Method 
        //
    }
    internal class VideoContent : MediaContent 
    
    {

    }
    internal class MediaTester{
        public static void TestOne() {

        }
    }
}
