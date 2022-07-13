using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace NGSA.App
{
    public class JsonHistoryFile
    {
        public readonly string Path;
        public readonly double[] Xs;
        public readonly double[] Ys;
        public readonly double[] LogYs;
        public override string ToString() => System.IO.Path.GetFileNameWithoutExtension(Path);

        public JsonHistoryFile(string path)        {
            Path = path;

            using JsonDocument doc = JsonDocument.Parse(File.ReadAllText(path));

            List<double> xs = new();
            List<double> ys = new();

            foreach (JsonElement recipeElement in doc.RootElement.GetProperty("downloads").EnumerateArray())
            {
                JsonElement countProperty = recipeElement.GetProperty("count");
                if (countProperty.ValueKind != JsonValueKind.Number)
                    continue;

                int? countValue = countProperty.GetInt32();
                string? weekValue = recipeElement.GetProperty("week").GetString()!;

                ys.Add(countValue.Value);
                xs.Add(DateTime.Parse(weekValue).ToOADate());
            }

            Xs = xs.ToArray();
            Ys = ys.ToArray();
            LogYs = ys.Select(x => Math.Log10(x)).ToArray();

            if (Xs.Length == 0)
                throw new InvalidDataException($"{Path} contains no valid records");
        }
    }
}
