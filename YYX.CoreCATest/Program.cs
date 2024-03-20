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
var directoryInfo = new DirectoryInfo("D:\\tcm\\v103_tcm\\dbl\\std");

CollectFileExtensions(directoryInfo, fileExtendions);

return;

void CollectFileExtensions(DirectoryInfo directoryInfo, List<string> fileExtendions)
{
    if (directoryInfo == null || fileExtendions == null)
    {
        return;
    }

    foreach (var directory in directoryInfo.GetDirectories())
    {
        CollectFileExtensions(directory, fileExtendions);
    }

    foreach (var fileInfo in directoryInfo.GetFiles())
    {
        if (!fileExtendions.Contains(fileInfo.Extension))
        {
            fileExtendions.Add(fileInfo.Extension);
        }
    }
}