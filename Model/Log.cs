﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Log : Model<Log>
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Khóa ngoại nhân viên
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Nhân viên thực hiện
        /// </summary>
        public User user { get { return User.FindById(user_id); } }

        /// <summary>
        /// Hành động
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// Hành động tại thời điểm
        /// </summary>
        public DateTime created_at { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, user_id, action };
        }
    }
}
