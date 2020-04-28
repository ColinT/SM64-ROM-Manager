using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Collections.Extensions;

namespace SM64_ROM_Manager.PatchScripts
{
    public class EmbeddedFilesContainer
    {
        [JsonProperty("CompressedFiles")]
        private readonly Dictionary<string, byte[]> compressedFiles = new Dictionary<string, byte[]>();

        [JsonIgnore]
        public IEnumerable<string> AllFileNames
        {
            get => compressedFiles.Keys;
        }

        public Task<bool> AddFileAsync(string fileName, string filePath)
        {
            return Task.Run(() => AddFile(fileName, filePath));
        }

        public bool AddFile(string fileName, string filePath)
        {
            bool success;
            FileStream fs = null;
            MemoryStream compressed = null;

#if !DEBUG
            try
            {
#endif
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            compressed = new MemoryStream();
            using (var compressor = new DeflateStream(compressed, CompressionLevel.Optimal, true))
                fs.CopyTo(compressor);
            success = true;
#if !DEBUG
            }
            catch (Exception)
            {
                success = false;
            }
#endif

            if (success)
                compressedFiles.AddOrUpdate(fileName, compressed.ToArray());
            compressed?.Close();
            fs?.Close();

            return success;
        }

        public void RemoveFile(string fileName)
        {
            compressedFiles.RemoveIfContainsKey(fileName);
        }

        public bool HasFile(string fileName)
        {
            return compressedFiles.ContainsKey(fileName);
        }

        public Task<Stream> GetStreamAsync(string fileName)
        {
            return Task.Run(() => GetStream(fileName));
        }

        public Stream GetStream(string fileName)
        {
            Stream decompressed = null;

            if (compressedFiles.ContainsKey(fileName))
            {
                decompressed = new MemoryStream();
                DecompressToStream(decompressed, compressedFiles[fileName]);
            }

            return decompressed;
        }

        public Task<string> GetLocalFilePathAsync(string fileName)
        {
            return Task.Run(() => GetLocalFilePath(fileName));
        }

        public string GetLocalFilePath(string fileName)
        {
            string filePath = string.Empty;

            if (compressedFiles.ContainsKey(fileName))
            {
                filePath = Path.GetTempFileName();

                if (Path.HasExtension(fileName))
                    filePath = Path.ChangeExtension(filePath, Path.GetExtension(fileName));

                var decompressed = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                DecompressToStream(decompressed, compressedFiles[fileName]);
                decompressed.Flush();
                decompressed.Close();
            }

            return filePath;
        }

        private void DecompressToStream(Stream decompressed, byte[] compressedData)
        {
            var compressed = new MemoryStream(compressedData);
            var decompressor = new DeflateStream(compressed, CompressionMode.Decompress, true);
            decompressor.CopyTo(decompressed);
            decompressor.Close();
            compressed.Close();
        }
    }
}
