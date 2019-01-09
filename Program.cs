using System;
using System.Threading;
using System.IO;

namespace training
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("初始化程式～");
      string input = "";
      string[] files = File.ReadAllLines("./movie-list.txt");
      int idx = 0;
      if (files.Length != 0)
        do
        {
          Console.WriteLine($"播放影片：{files[idx]}");
          idx++;
          Console.WriteLine("使用播放器1來播放影片");
          Console.WriteLine("播放器1開始播放影片");
          Console.WriteLine("播放中～～～");
          Thread.Sleep(3000);
          Console.WriteLine("播放完畢～釋放資源");
        } while (idx < files.Length);
      else
        Console.WriteLine("列表中沒有資訊");
      Console.WriteLine("離開程式");
    }
  }
}
