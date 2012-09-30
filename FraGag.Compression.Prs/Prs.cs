namespace FraGag.Compression
{
    using System;
    using System.IO;

    /// <summary>
    /// A port of fuzziqer's PRS compression/decompression utility to the .NET Framework.
    /// </summary>
    public static partial class Prs
    {
        public static byte[] Decompress(string sourceFilePath)
        {
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output);
                    return output.ToArray();
                }
            }
        }

        public static void Decompress(byte[] sourceData, string destinationFilePath)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output);
                }
            }
        }

        public static void Decompress(string sourceFilePath, string destinationFilePath)
        {
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output);
                }
            }
        }

        public static byte[] Decompress(byte[] sourceData)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output);
                    return output.ToArray();
                }
            }
        }

        public static void Decompress(Stream input, Stream output)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            Decode(input, output);
        }

        public static byte[] Compress(string sourceFilePath)
        {
            byte[] input = File.ReadAllBytes(sourceFilePath);
            using (MemoryStream output = new MemoryStream())
            {
                Encode(input, output);
                return output.ToArray();
            }
        }

        public static void Compress(byte[] sourceData, string destinationFilePath)
        {
            using (FileStream output = File.Create(destinationFilePath))
            {
                Encode(sourceData, output);
            }
        }

        public static void Compress(string sourceFilePath, string destinationFilePath)
        {
            byte[] input = File.ReadAllBytes(sourceFilePath);
            using (FileStream output = File.Create(destinationFilePath))
            {
                Encode(input, output);
            }
        }

        public static byte[] Compress(byte[] sourceData)
        {
            using (MemoryStream output = new MemoryStream())
            {
                Encode(sourceData, output);
                return output.ToArray();
            }
        }

        public static void Compress(Stream input, Stream output)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            long size = input.Length - input.Position;
            byte[] inputBytes = new byte[size];
            input.Read(inputBytes, 0, checked((int)size));

            Encode(inputBytes, output);
        }
    }
}
