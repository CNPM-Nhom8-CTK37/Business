using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Phone : Model<Phone>
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Khóa ngoại của bảng Categories
        /// </summary>
        public int category_id { get; set; }

        /// <summary>
        /// Tên điện thoại
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Số lượng điện thoại
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// Giá của điện thoại
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// Ngày giờ nhập điện thoại
        /// </summary>
        public DateTime created_at { get; }

        /// <summary>
        /// Tên hãng điện thoại
        /// </summary>
        public string category_name
        {
            get
            {
                return Category.FindById(category_id).name;
            }
        }

        protected override object[] Attributes()
        {
            return new object[] { id, category_id, name, amount, price };
        }
    }
}
