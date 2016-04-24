using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core;

namespace Business
{
    enum SpFunction
    {
        Insert,
        Update,
        Delete
    }

    public abstract class Model<T> where T : class, new()
    {
        /// <summary>
        /// Tên của bảng trong cơ sở dữ liệu
        /// </summary>
        protected virtual string tableName
        {
            get { return GetType().Name; }
        }

        /// <summary>
        /// Khóa chính của bảng
        /// </summary>
        protected virtual string primaryKey
        {
            get { return "@id"; }
        }

        /// <summary>
        /// Tên store procedure
        /// thực hiện chức các chức năng:
        /// Insert, Update, Delete
        /// </summary>
        protected virtual string functionSpName
        {
            get { return GetType().Name + "_Function"; }
        }

        /// <summary>
        /// Tên store procedure
        /// thực hiện chức năng lấy một đối tượng
        /// bằng id
        /// </summary>
        protected virtual string getByIdSpName
        {
            get { return GetType().Name + "_Id"; }
        }

        /// <summary>
        /// Tên store procedure
        /// thực hiện chức năng lấy tất cả
        /// dữ liệu trong bảng
        /// </summary>
        protected virtual string getAllSpName
        {
            get { return "GetAll"; }
        }

        /// <summary>
        /// Danh sách các thuộc tính của class cần thực hiện,
        /// phải theo thứ tự khai báo trong store procedure
        /// </summary>
        /// <returns>Trả về một mảng object</returns>
        protected abstract object[] Attributes();

        /// <summary>
        /// Phương thức dùng để thêm chức năng
        /// khi thực hiện trong store procedure
        /// </summary>
        /// <param name="function">Chọn chức năng</param>
        /// <returns>Trả về một mảng object để truyền vào params</returns>
        private object[] getParams(SpFunction function)
        {
            var param_ = Attributes().ToList<object>();
            param_.Insert(0, function);

            return param_.ToArray<object>();
        }

        /// <summary>
        /// Lấy tất cả dữ liệu
        /// theo từng class
        /// </summary>
        /// <returns>Trả về một List theo kiểu dữ liệu</returns>
        public static List<T> All()
        {
            T t = new T();

            Model<T> model = t as Model<T>;

            return CBO.FillCollection<T>(DataProvider.Instance.ExecuteReader(model.getAllSpName, model.tableName));
        }

        /// <summary>
        /// Tìm một đối tượng bằng id
        /// theo class
        /// </summary>
        /// <param name="id">Khóa chính của bảng</param>
        /// <returns>Trả về một đối tượng khi tìm được hoặc trả về null</returns>
        public static T FindById(int id)
        {
            T t = new T();

            Model<T> model = t as Model<T>;

            return CBO.FillObject<T>(DataProvider.Instance.ExecuteReader(model.getByIdSpName, id));
        }

        /// <summary>
        /// Thêm một đối tượng vào database
        /// </summary>
        /// <param name="model">Đối tượng cần thêm</param>
        /// <returns>Trả về id của đối trượng vừa thêm</returns>
        public static int Insert(Model<T> model)
        {
            return (int)DataProvider.Instance.ExecuteNonQueryWithOutput(
                model.primaryKey, model.functionSpName, model.getParams(SpFunction.Insert)
            );
        }

        /// <summary>
        /// Cập nhập một đối tượng phải có giá trị khóa chính
        /// </summary>
        /// <param name="model">Đối tượng cần cập nhật</param>
        /// <returns>Trả về số dòng bị ảnh hưởng</returns>
        public static int Update(Model<T> model)
        {
            return DataProvider.Instance.ExecuteNonQuery(
                model.functionSpName, model.getParams(SpFunction.Update)
            );
        }

        /// <summary>
        /// Xóa một đối tượng phải có giá trị khóa chính
        /// </summary>
        /// <param name="model">Đối tượng cần xóa</param>
        /// <returns>Trả về số dòng bị ảnh hưởng</returns>
        public static int Delete(Model<T> model)
        {
            return DataProvider.Instance.ExecuteNonQuery(
                model.functionSpName, model.getParams(SpFunction.Delete)
            );
        }
    }
}
