using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Category : Model<Category>
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Tên hãng sản xuất
        /// </summary>
        public string name { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, name };
        }
    }
}
