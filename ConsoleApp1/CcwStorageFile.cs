using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;

namespace ConsoleApp1
{
    internal class CcwForStorageFile : IStorageFile
    {
        private StorageFile storageFile;

        public CcwForStorageFile(StorageFile storageFile)
        {
            this.storageFile = storageFile;
        }

        public string ContentType => storageFile.ContentType;

        public string FileType => storageFile.FileType;

        public Windows.Storage.FileAttributes Attributes => storageFile.Attributes;

        public DateTimeOffset DateCreated => storageFile.DateCreated;

        public string Name => storageFile.Name;

        public string Path => storageFile.Path;

        public IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace) => storageFile.CopyAndReplaceAsync(fileToReplace);

        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder) => storageFile.CopyAsync(destinationFolder);

        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder, string desiredNewName) => storageFile.CopyAsync(destinationFolder, desiredNewName);

        public IAsyncOperation<StorageFile> CopyAsync(IStorageFolder destinationFolder, string desiredNewName, NameCollisionOption option) => storageFile.CopyAsync(destinationFolder, desiredNewName, option);

        public IAsyncAction DeleteAsync() => storageFile.DeleteAsync();

        public IAsyncAction DeleteAsync(StorageDeleteOption option) => storageFile.DeleteAsync(option);

        public IAsyncOperation<BasicProperties> GetBasicPropertiesAsync() => storageFile.GetBasicPropertiesAsync();

        public bool IsOfType(StorageItemTypes type) => storageFile.IsOfType(type);

        public IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace) => storageFile.MoveAndReplaceAsync(fileToReplace);

        public IAsyncAction MoveAsync(IStorageFolder destinationFolder) => storageFile.MoveAsync(destinationFolder);

        public IAsyncAction MoveAsync(IStorageFolder destinationFolder, string desiredNewName) => storageFile.MoveAsync(destinationFolder, desiredNewName);

        public IAsyncAction MoveAsync(IStorageFolder destinationFolder, string desiredNewName, NameCollisionOption option) => storageFile.MoveAsync(destinationFolder, desiredNewName, option);

        public IAsyncOperation<IRandomAccessStream> OpenAsync(FileAccessMode accessMode) => storageFile.OpenAsync(accessMode);

        public IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync() => storageFile.OpenReadAsync();

        public IAsyncOperation<IInputStream> OpenSequentialReadAsync() => storageFile.OpenSequentialReadAsync();

        public IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync() => storageFile.OpenTransactedWriteAsync();

        public IAsyncAction RenameAsync(string desiredName) => storageFile.RenameAsync(desiredName);

        public IAsyncAction RenameAsync(string desiredName, NameCollisionOption option) => storageFile.RenameAsync(desiredName, option);
    }
}
