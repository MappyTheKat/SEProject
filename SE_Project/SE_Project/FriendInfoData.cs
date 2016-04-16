using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Project
{
    public class FriendInfoData
    {
        public bool IsTrusted;
        public bool IsAnnoying;
        public string Name;
        public int UID;
        public Gender Gender;
    }

    public enum Gender
    {
        None,
        Male,
        Female
    }
}
