using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Function : Model<Function>
    {
        /// <summary>
        /// Khóa chính của chức năng
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Tên chức năng
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Thông tin chi tiết chức năng
        /// </summary>
        public string details { get; set; }

        protected override object[] Attributes()
        {
            return new object[] { id, name, details };
        }
    }
}
