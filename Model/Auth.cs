﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Auth : Model<Auth>
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
        /// Khóa ngoại chức năng
        /// </summary>
        public int function_id { get; set; }

        /// <summary>
        /// Thời điểm kích hoạt
        /// </summary>
        public DateTime active_at { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, user_id, function_id, active_at };
        }
    }
}