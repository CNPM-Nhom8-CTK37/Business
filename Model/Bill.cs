﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Bill : Model<Bill>
    {
        /// <summary>
        /// Khóa chính của hóa đơn
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// id của nhân viên thực hiện
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// id của người mua (khách hàng)
        /// </summary>
        public int customer_id { get; set; }

        /// <summary>
        /// Tổng giá của hóa đơn
        /// </summary>
        public double total { get; set; }

        /// <summary>
        /// Ngày mua
        /// </summary>
        public DateTime date { get; set; }

        protected override object[] Attributes()
        {
            throw new NotImplementedException();
        }
    }
}
