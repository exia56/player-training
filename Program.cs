using System;
using System.Threading;

namespace training
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("初始化程式～");
      string input = "";
      do
      {
        Console.Write("輸入要播放的影片(若不播放則輸入\"exit\")：");
        input = Console.ReadLine();
        if (input.Equals("exit")) continue;
        Console.WriteLine($"選擇播放的影片：{input}");
        Console.WriteLine("使用播放器2來播放影片");
        Console.WriteLine("播放器2開始播放影片");
        Console.WriteLine("播放中～～～");
        Thread.Sleep(3000);
        Console.WriteLine("播放完畢～釋放資源");
      } while (!input.Equals("exit"));
      Console.WriteLine("離開程式");
    }
  }
}
