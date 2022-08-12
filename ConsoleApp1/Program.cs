
using ConsoleApp1;
using System.Net.WebSockets;
using System.Reflection;
using Windows.Storage;


var sampleFileToRead = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
var ccwForStorageFile = new CcwForStorageFile(await StorageFile.GetFileFromPathAsync(sampleFileToRead + "\\ConsoleApp1.runtimeconfig.json"));
var fileText = await FileIO.ReadTextAsync(ccwForStorageFile);
Console.WriteLine(fileText);