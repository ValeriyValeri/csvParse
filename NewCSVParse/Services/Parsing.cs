using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.IO;

//comment

namespace NewCSVParse.Services
{
    public class ParsingService : IParse
    {
        private char delimiter = ',';

        public List<string[]> Parse(IFormFile file)
        {
            try
            {
                using (var s = file.OpenReadStream())
                {
                    var textReader = new StreamReader(s);

                    List<string[]> l = new List<string[]>();

                    string line = textReader.ReadLine();

                    while (line != null)
                    {
                        string[] columns = line.Split(delimiter);
                        l.Add(columns);
                        line = textReader.ReadLine();
                    }

                    return l;
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
