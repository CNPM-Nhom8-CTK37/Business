using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class User : Model<User>
    {
        /// <summary>
        /// Khóa chính nhân viên
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Tên tài khoản đăng nhập
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Mật khẩu đăng nhập
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Số điện thoại nhân viên
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Địa chỉ nhân viên
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Ngày sinh nhân viên
        /// </summary>
        public DateTime birthday { get; set; }

        /// <summary>
        /// Chức vụ của nhân viên
        /// </summary>
        public string position { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, name, username, password, phone_number, address, birthday, position };
        }
    }
}
