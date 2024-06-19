using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shoppingApp.Classes
{
    internal class sqlAdapter
    {
        private string conns = "Data Source=HUUNGUYEN;Initial Catalog = shoppingApp; Integrated Security = True; Encrypt=False";
        private SqlDataAdapter adapter;


        // Queries of user table
        public DataTable getAllUsers()
        {
            adapter = new SqlDataAdapter("select * from [user]", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getUsersByRole(string role)
        {
            adapter = new SqlDataAdapter("select * from [user] where role = '" + role + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public User getUserByUsername(string username)
        {
            User user = null;

            string q = "select * from [user] where username = '" + username + "'";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    user = new User(username, dr["first_name"].ToString(), dr["last_name"].ToString(),
                        dr["email"].ToString(), dr["password"].ToString(), dr["phone"].ToString(),
                        dr["role"].ToString(), dr["ava"].ToString(), dr["address"].ToString());

                    return user;
                }
            }

            return user;
        }

        public bool insertUser(string username, string firstName, string lastName, string phoneNum, string email, string password, string ava, string role)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [user] (username, first_name, last_name, phone, email, password, ava, role) " +
                    "values (@username, @firstName, @lastName, @phone, @email, @password, @ava, @role)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@firstname", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("phone", phoneNum);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@ava", ava);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public bool updateUserByUsername(string username, string firstname, string lastname, string phone, string email, string password, string role, string ava)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [order] set first_name = @firstname, last_name = @lastname," +
                    "phone = @phone, email = @email, password = @password, role = @role where username = @username";

                if (ava != string.Empty)
                {
                    q = "update [order] set first_name = @firstname, last_name = @lastname," +
                    "phone = @phone, email = @email, password = @password, role = @role, ava = @ava where username = @username";
                }

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@ava", ava);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;

        }

        public string getEmailByUsername(string username)
        {
            string q = "select * from [user] where username = '" + username + "'";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    return dr["email"].ToString();
                }
            }

            return null;
        }

        public bool deleteUserByUsername(string username)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "delete from [user] where username = '" + username + "'";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        // Queries of category table
        public bool insertCategory(string categroryName, string categoryDes)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [category] (name, description) " +
                    "values (@name, @description)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@name", categroryName);
                cmd.Parameters.AddWithValue("@description", categoryDes);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public DataTable getAllCategories()
        {
            adapter = new SqlDataAdapter("select * from [category]", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool updateCategoryById(int id, string categroryName, string categoryDes)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [category] set name = @name, description = @description where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", categroryName);
                cmd.Parameters.AddWithValue("@description", categoryDes);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;

        }

        public bool deleteCategoryById(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "delete from [category] where id = '" + id + "'";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        // Queries of product table
        public bool insertProduct(string name, string subtext, string description, int price, int discount, int quantity, string size, bool sex, string imagesUrl, bool status, int categoryId, DateTime end_day)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [product] (name, sub_text, description, price, discount, quantity, size, sex, images_url, status, category_id, end_day) " +
                    "values (@name, @sub_text, @description, @price, @discount, @quantity, @size, @sex, @images_url, @status, @category_id, @end_day)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sub_text", subtext);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@images_url", imagesUrl);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@category_id", categoryId);

                if (discount == 0)
                    cmd.Parameters.AddWithValue("@end_day", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@end_day", end_day);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public Product getProdOrderByDesc()
        {
            Product product = null;

            string q = "select top 1 * from [ProductCategoryView] order by id desc";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    product = new Product(int.Parse(dr["id"].ToString()), dr["name"].ToString(), dr["sub_text"].ToString(), dr["description"].ToString(),
                        int.Parse(dr["price"].ToString()), int.Parse(dr["discount"].ToString()), int.Parse(dr["quantity"].ToString()),
                        bool.Parse(dr["sex"].ToString()), dr["images_url"].ToString(), bool.Parse(dr["status"].ToString()), dr["size"].ToString(), dr["Expr1"].ToString(),
                        dr["end_day"].ToString());

                    return product;
                }
            }

            else
            {
                product = new Product();
                product.Id = 0;
            }

            return product;
        }

        public DataTable getAllProducts()
        {
            adapter = new SqlDataAdapter("select * from [product]", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getProductsByStatus(bool status)
        {
            adapter = new SqlDataAdapter("select * from [product] where status = '"+ status +"'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getAllDiscountProduct()
        {
            adapter = new SqlDataAdapter("select * from [product] where discount > 0 and status = 'true'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getProductsBySex(bool male)
        {
            adapter = new SqlDataAdapter("select * from [product] where sex = '" + male + "' and status = 'true'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getProductsBySexAndCateId(bool male, int category_id)
        {
            adapter = new SqlDataAdapter("select * from [product] where sex = '" + male + "' and category_id = '" + category_id + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public Product getProductById(int id)
        {
            Product product = null;

            string q = "select * from [ProductCategoryView] where id = '" + id + "' ";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    product = new Product(int.Parse(dr["id"].ToString()), dr["name"].ToString(), dr["sub_text"].ToString(), dr["description"].ToString(),
                        int.Parse(dr["price"].ToString()), int.Parse(dr["discount"].ToString()), int.Parse(dr["quantity"].ToString()),
                        bool.Parse(dr["sex"].ToString()), dr["images_url"].ToString(), bool.Parse(dr["status"].ToString()),
                        dr["size"].ToString(), dr["Expr1"].ToString(), dr["end_day"].ToString());

                    return product;
                }
            }

            else
            {
                product = new Product();
                product.Id = 0;
            }

            return product;
        }

        public bool getProductSexById(int id)
        {
            adapter = new SqlDataAdapter("select * from [product] where id = '" + id + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return (bool)dt.Rows[0]["sex"];
        }

        public DataTable findProductsByNameAndSex(string name, bool male)
        {
            string q = "declare @name nvarchar(max);" +
                "set @name = '" + name + "';" +
                "select * from [product] where charindex (@name, name) > 0 and sex = '" + male + "'";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;

        }

        public bool deleteProductById(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "delete from [product] where id = '" + id + "'";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool updateProductById(int id, string name, string sub_text, string description, int price, int discount, int quantity,
            bool sex, string images_url, bool status, string size, int category_id, DateTime end_day)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [product] set name = @name, sub_text = @sub_text, description = @description, price = @price, discount = @discount, " +
                    "quantity = @quantity, sex = @sex, images_url = @images_url, status = @status, size = @size, category_id = @category_id, end_day = @end_day where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sub_text", sub_text);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@images_url", images_url);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@category_id", category_id);

                if (discount == 0)
                    cmd.Parameters.AddWithValue("@end_day", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@end_day", end_day);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;

        }

        public bool updateProductImagesById(int id, string images_url)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [product] set images_url = @images_url where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@images_url", images_url);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;

        }

        // Queries of cart table
        public DataTable getCartItemByUsername(string username)
        {
            adapter = new SqlDataAdapter("select * from [UserProductCartView] where username = '" + username + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return dt;

            return null;
        }

        public int getQuantityCartItemByUsernameAndProId(string username, int proId)
        {
            adapter = new SqlDataAdapter("select * from [cart] where username = '" + username + "' and prod_id = '" + proId + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                    return int.Parse(dr[2].ToString());
            }

            return -1;
        }

        public bool insertCartItem(string username, int prodId, int quantity, string size)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [cart] (username, prod_id, quantity, size) " +
                    "values (@username, @prod_id, @quantity, @size)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@prod_id", prodId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@size", size);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool checkExistCartItemByUsernameAndProdIdAndSize(string username, int prodId, string size)
        {
            adapter = new SqlDataAdapter("select * from [cart] where username = '" + username + "' and prod_id = '" + prodId + "' and size = '" + size + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public bool updateQuantityCartItemByUsernameAndProdIdAndSize(string username, int prodId, string size, bool plus)
        {

            int quantity = getQuantityCartItemByUsernameAndProId(username, prodId);

            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [cart] set quantity = @quantity where username = @username and prod_id = @prod_id and size = @size";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@prod_id", prodId);
                cmd.Parameters.AddWithValue("@size", size);

                if (plus)
                    cmd.Parameters.AddWithValue("@quantity", quantity + 1);
                else
                    cmd.Parameters.AddWithValue("@quantity", quantity - 1);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return false;
        }

        public bool deleteCartItemByUsernameAndProIdAndSize(string username, int prodId, string size)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "delete from [cart] where username = '" + username + "' and prod_id = '" + prodId + "' and size = '" + size + "'";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool deleteAllCartItemsById(string username)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "delete from [cart] where username = '" + username + "'";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        // Queries of order table
        public bool insertOrder(string username, DateTime date, int total, int payment, string shipAddress, string note)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [order] (username, date, total, payment, ship_address, status, note)" +
                    "values (@username, @date, @total, @payment, @shipAdress, @status, @note)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@payment", payment);
                cmd.Parameters.AddWithValue("@shipAdress", shipAddress);
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.Parameters.AddWithValue("@note", note);

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public int getIdOfOderByAll(string username, DateTime date, int total, string payment, string shipAddress, string note)
        {
            string q = "select id from [order] where username ='" + username + "' and date = '" + date + "' and " +
                        "total = '" + total + "' and payment = '" + payment + "' and ship_address = '" + shipAddress + "' and note = '" + note + "' and status = 'Pending';";

            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                    return int.Parse(dr[0].ToString());
            }

            return -1;
        }

        public bool updateOrderById(int id, int total, string payment, string shipAddress, string status)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [order] set total = @total, payment = @payment, ship_address = @shipAddress, status = @status where id = @id";
                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@payment", payment);
                cmd.Parameters.AddWithValue("@shipAdress", shipAddress);
                cmd.Parameters.AddWithValue("@status", status);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public Order getOrderByOrderId(int order_id)
        {
            Order order = null;

            string q = "select * from [order] where id = '" + order_id + "'";

            adapter = new SqlDataAdapter(q, conns);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    order = new Order((int)dr["id"], dr["username"].ToString(), (DateTime)dr["date"], (int)dr["total"],
                        dr["payment"].ToString(), dr["ship_address"].ToString(), dr["status"].ToString());

                    return order;
                }
            }

            return order;
        }

        public int getOrderIdOrderByDesc()
        {
            adapter = new SqlDataAdapter("select * from [order] order by id desc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return (int)dt.Rows[0][0];
        }

        public DataTable getAllOrdersByUsername(string username)
        {
            adapter = new SqlDataAdapter("select * from [order] where username = '" + username + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }


        // Queries of order items table
        public bool insertOrderItem(int order_id, int prod_id, int quantity, string image_url, string size)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [order_items] (order_id, prod_id, quantity, image_url, size) " +
                    "values (@order_id, @prod_id, @quantity, @image_url, @size)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@order_id", order_id);
                cmd.Parameters.AddWithValue("@prod_id", prod_id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@image_url", image_url);
                cmd.Parameters.AddWithValue("@size", size);

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public DataTable getOrderItemsByOrderId(int order_id)
        {
            string q = "select * from [OderItemsView] where order_id = '" + order_id + "'";
            adapter = new SqlDataAdapter(q, conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;


        }


        // Queries of review table
        public int getRatingOfProductByProdID(int prod_id)
        {
            int rating = 0;
            adapter = new SqlDataAdapter("select * from [review] where prod_id = '" + prod_id + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                    rating += (int)dr["rating"];
            }

            if (rating == 0)
                return rating;

            return rating / dt.Rows.Count;
        }

        public bool checkExistReviewByUsernameAndProId(string username, int prod_id)
        {
            adapter = new SqlDataAdapter("select * from [review] where prod_id = '" + prod_id + "' " +
                "and username = '" + username + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;

            return false;

        }

        public bool insertReview(string username, int prod_id, int rating)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [review] (username, prod_id, rating) " +
                    "values (@username, @prod_id, @rating)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@prod_id", prod_id);
                cmd.Parameters.AddWithValue("@rating", rating);

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public int getNumOfRatingOfProductByProdId(int prod_id)
        {
            adapter = new SqlDataAdapter("select * from [review] where prod_id = '" + prod_id + "'", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt.Rows.Count;
        }


        // Queries of message table

        public DataTable getMessByUsernameOrderByDateDesc(string username)
        {
            adapter = new SqlDataAdapter("select * from [chat] where sender = '" + username + "' order by time desc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getMessByUsernameOrderByDateAsc(string username)
        {
            adapter = new SqlDataAdapter("select * from [chat] where sender = '" + username + "' " +
                "or receiver = '" + username + "' order by time asc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getMessByUsernameAndSeenOrderByDateAsc(string username, bool seen)
        {
            adapter = new SqlDataAdapter("select * from [chat] where (sender = '" + username + "' " +
                "or receiver = '" + username + "') and seen = '" + seen + "' order by time asc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable getMessBySenderAndSeenOrderByDateAsc(string sender, bool seen)
        {
            adapter = new SqlDataAdapter("select * from [chat] where sender = '" + sender + "' and seen = '" + seen + "' order by time asc", conns);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public bool insertMessage(string sender, string receiver, string message, string icon, string image, DateTime time, bool seen)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);
                conn.Open();

                string q = "insert into [chat] (sender, receiver, message, icon, image, time, seen) " +
                    "values (@sender, @receiver, @message, @icon, @image, @time, @seen)";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@receiver", receiver);
                if (message == null)
                    cmd.Parameters.AddWithValue("@message", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@message", message);
                if (icon == null)
                    cmd.Parameters.AddWithValue("@icon", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@icon", icon);
                if (image == null)
                    cmd.Parameters.AddWithValue("@image", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("time", time);
                cmd.Parameters.AddWithValue("@seen", seen);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool updateSeenOfMessageByUsernameAndSeen(string username, bool seen)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conns);

                string q = "update [chat] set seen = @seen where (sender = '" + username + "' " +
                "or receiver = '" + username + "') and seen = 'false'";

                SqlCommand cmd = new SqlCommand(q, conn);

                cmd.Parameters.AddWithValue("@seen", seen);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return false;
        }
    }
}
