using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Permission : Model<Permission>
    {
        /// <summary>
        /// Khóa chính của quyền
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Khóa ngoại nhân viên
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Nhân viên
        /// </summary>
        public User user { get { return User.FindById(user_id); } }

        /// <summary>
        /// Khóa ngoại chức năng
        /// </summary>
        public int menu_id { get; set; }

        /// <summary>
        /// Chức năng
        /// </summary>
        public Menu menu { get {return Menu.FindById(menu_id); } }

        protected override object[] Attributes()
        {
            return new object[] { id, user_id, menu_id };
        }
    }
}
