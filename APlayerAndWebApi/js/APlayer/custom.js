jQuery.support.cors = true;
var postlink = "http://localhost:58982/";

$(function () {
    initMusicList();
});

var initMusicList = function () {
    var link = postlink + "api/getmusiclist";//调用WebAPI的接口获取音乐列表数据
    var param = {  };
    $.ajax({
        type: "GET",
        url: link,
        cache: false,  //禁用缓存
        data: param,  //传入组装的参数
        dataType: "json",
        success: function (data) {
            if (data != null) {
                var musicData = data;
                var apmusic = new APlayer({
                    element: document.getElementById('musicplayer'),
                    narrow: false,
                    autoplay: false,
                    showlrc: false,
                    mutex: true,
                    theme: '#ad7a86',
                    music: musicData
                });
                apmusic.volume(0.3);
                apmusic.on('play', function () {
                    //此处为记录动作，比如用户点击了播放，用户自定义，详细查看API
                });
            }
        },
        error: function (ex) {
            //alert(ex);
        }
    });
}

