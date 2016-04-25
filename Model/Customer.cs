using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Customer : Model<Customer>
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Họ và tên khách hàng
        /// </summary>
        public int name { get; set; }

        /// <summary>
        /// Số điện thoại khách hàng
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// Địa chỉ khách hàng
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// Số CMND khách hàng
        /// </summary>
        public int identity_number { get; set; }

        /// <summary>
        /// Ngày sinh khách hàng
        /// </summary>
        public DateTime birthday { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, name, phone_number, address, identity_number, birthday };
        }
    }
}
