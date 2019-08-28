using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiSeUser
{
    public class UserRequest
    {
        public string User_id { get; set; }
        public string User_phone { get; set; }
        public int User_pos_x { get; set; }
        public int User_pos_y { get; set; }
        public int User_pos_z { get; set; }

        public UserRequest()
        {

        }

        public UserRequest(string user_id, string user_phone, int user_pos_x, int user_pos_y, int user_pos_z)
        {
            User_id = user_id;
            User_phone = user_phone;
            User_pos_x = user_pos_x;
            User_pos_y = user_pos_y;
            User_pos_z = user_pos_z;
        }
    }
}