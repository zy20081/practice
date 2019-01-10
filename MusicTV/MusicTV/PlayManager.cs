using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
namespace MusicTV
{
    [Serializable]
   public class PlayManager
    {
       public PlayManager() 
       {
           m_PlaySong = new Dictionary<string, SongInfo>();
           m_lyric = new Dictionary<string, lyric>();
       }
       private Dictionary<string, SongInfo> m_PlaySong;
       /// <summary>
       /// 歌曲信息
       /// </summary>
       public Dictionary<string, SongInfo> PlaySong
       {
           get { return m_PlaySong; }
           set { m_PlaySong = value; }
       }
       /// <summary>
       /// 存入歌词
       /// </summary>
       private Dictionary<string, lyric> m_lyric;

       public Dictionary<string, lyric> Lyric
       {
           get { return m_lyric; }
           set { m_lyric = value; }
       }
     
  
    }
}
