using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Project
{
    public class User
    {
        public int UID;

        public List<FriendInfoData> Friends;

        // 사진 : cdn에 올려두고 주소를 지정하게 해야 할 것 같다.
        public string PhotoAddress;
        // 한마디 : string
        public string Comment;
        // 음성녹음 : cdn에 올려두고 주소를 지정하게 해야 할 것 같다
        public string AudioCommentAddress;

        // 그 외 기본정보
        // 이름
        // 내가 지정한 이름, 본인이 지정한 이름(자신일 경우에는 동일함)
        // 나이
        // 사는 지역
        // 키
        // 체형
        // 직업

        public User(int uid)
        {
            UID = uid;
        }

        public void Init()
        {
            // 서버에서 정보를 받아와야 한다.
        }
    }
}
