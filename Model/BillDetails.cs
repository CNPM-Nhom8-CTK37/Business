﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class BillDetails : Model<BillDetails>
    {
        /// <summary>
        /// Khóa chính của chi tiết hóa đơn
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Khóa ngoại hóa đơn
        /// </summary>
        public int bill_id { get; set; }

        /// <summary>
        /// Khóa ngoại điện thoại
        /// </summary>
        public int phone_id { get; set; }

        /// <summary>
        /// Số lượng
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// Đơn giá
        /// </summary>
        public double price { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, bill_id, phone_id, amount, price };
        }
    }
}
