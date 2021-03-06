﻿/*
This source file is subject to version 3 of the GPL license, 
that is bundled with this package in the file LICENSE, and is 
available online at http://www.gnu.org/licenses/gpl.txt; 
you may not use this file except in compliance with the License. 

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for
the specific language governing rights and limitations under the License.

All portions of the code written by Whoaverse are Copyright (c) 2014 Whoaverse
All Rights Reserved.
*/

using OpenGraph_Net;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Whoaverse.Utils
{
    public static class UrlUtility
    {

        // return domain from URI
        public static string GetDomainFromUri(string completeUri)
        {
            try
            {
                var tmpUri = new Uri(completeUri);
                return tmpUri.GetLeftPart(UriPartial.Authority).Replace("/www.", "/").Replace("http://", "").Replace("https://", "");      
            }
            catch (Exception)
            {
                return "http://whoaverse.com";
            }                  
        }

        // return remote page title from URI
        public static string GetTitleFromUri(string @remoteUri)
        {
            try
            {
                var graph = OpenGraph.ParseUrl(@remoteUri);
                if (!string.IsNullOrEmpty(graph.Title))
                {
                    return graph.Title;
                }
                var req = (HttpWebRequest)WebRequest.Create(@remoteUri);
                req.Timeout = 3000;
                var sr = new StreamReader(req.GetResponse().GetResponseStream());

                var buffer = new Char[256];
                var counter = sr.Read(buffer, 0, 256);
                while (counter > 0)
                {
                    var outputData = new String(buffer, 0, counter);
                    var match = Regex.Match(outputData, @"<title>([^<]+)", RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        return match.Groups[1].Value;
                    }
                    counter = sr.Read(buffer, 0, 256);
                }

                return "We were unable to suggest a title.";

            }
            catch (Exception)
            {
                return "We were unable to suggest a title.";
            }            
        }

    }

    
}