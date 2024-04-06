// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using YYX.CoreCATest;


var fileExtendions = new List<string>();
var directoryInfo = new DirectoryInfo(@"D:\tcm\v103_tcm\dbl\std");

CollectFileExtensions(directoryInfo, fileExtendions);

return;

static void CollectFileExtensions(DirectoryInfo directoryInfo, List<string> fileExtensions)
{
    if (fileExtensions == null)
    {
        throw new ArgumentNullException(nameof(fileExtensions));
    }


    foreach (var directory in directoryInfo.GetDirectories())
    {
        CollectFileExtensions(directory, fileExtensions);
    }

    foreach (var fileInfo in directoryInfo.GetFiles())
    {
        if (!fileExtensions.Contains(fileInfo.Extension))
        {
            fileExtensions.Add(fileInfo.Extension);
        }
    }
}