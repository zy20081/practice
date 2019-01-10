using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicTV
{[Serializable]
   public class SongInfo
    {
       public string name { set; get; }  //歌名
       public string FilePath { set; get; } //歌曲地址
       public string Singer { set; get; }//歌手名
       public lyric SongWord { set; get; }//歌词
       public string lyrics { get; set; }
    }
}
