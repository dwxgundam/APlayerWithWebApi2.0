using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
 
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("api/GetMusicList")]
        public IHttpActionResult GetMusicList()
        {
            //获取传过来的
            List<MusicModel> musiclist = new List<MusicModel>();

            MusicModel model = new MusicModel { title = "Wishing", url = "http://p2.music.126.net/SSbLcrSgYE8WnjDB8R-hEw==/1423867572602074.mp3", pic = "http://p3.music.126.net/AAq1qOhfyrClGK1mg3mGYQ==/18776360067593424.jpg", author = "水瀬いのり" };
            musiclist.Add(model);
            //这里先建立两个对象，加入到音乐列表
             model = new MusicModel { title = "Stay Alive", url = "http://p2.music.126.net/HBaT8T5zNfeOs3moefyDSQ==/18766464462962331.mp3", pic = "http://p3.music.126.net/AAq1qOhfyrClGK1mg3mGYQ==/18776360067593424.jpg", author = "高橋李依" };
            musiclist.Add(model);
          

            return Json(musiclist);
        }

    }
}
