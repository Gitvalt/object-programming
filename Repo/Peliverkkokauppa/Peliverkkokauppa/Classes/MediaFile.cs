using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliverkkokauppa
{
    public class MediaFile
    {
        //_id
        public int MediaID { get; set; }

        public string Name { get; set; }

        //path == filelocation
        public string Path { get; set; }

        public enum filetype
        {
            png,
            jpg,
            jpge
        }

        public filetype Filetype;

        public string Owner;



        public MediaFile(int mediaID, string path)
        {
            MediaID = mediaID;
            Path = path;
        }

        public MediaFile()
        {

        }
    }
}
