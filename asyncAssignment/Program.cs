using System;
using System.IO;
public class Program{
    async static Task<string[]> read(string filename){
        var data = await File.ReadAllLinesAsync(filename);
        System.Console.WriteLine(data);
        return data;
    }
    static async Task write(string[] data,string filename){
        await File.WriteAllLinesAsync(filename,data);
        System.Console.WriteLine("coppied");
    }
    static public async Task perform(){
        var data = read("file1.txt");
        await write(data.Result,"file2.txt");
    }
    public static void Main(string[] args){
        perform();
    }
}