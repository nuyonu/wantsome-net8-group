using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11GenericsAndAsync.AsyncProgramming.ExerciseThree
{
    public static class FileHelper
    {
        public static async Task<string> ReadFileFromPathAsync(string path)
        {
            var result = await File.ReadAllTextAsync(path);

            return result;
        }
    }
}
