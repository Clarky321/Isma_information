using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ISMA_information;
using MySqlConnector;

namespace ISMA_information.Forms
{
    public partial class Authentication : KryptonForm
    {
        private DataBase db;

        bool isAdmin = false;

        public Authentication()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            db = new DataBase("MyConnectionStringSql");

            isAdmin = true;
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            SetMaxLenght();
            LoadUserLogins();
        }

        private void SetMaxLenght()
        {
            ComboBox_log_in.MaxLength = 50;
            TextBox_password.MaxLength = 50;
        }

        private void LoadUserLogins()
        {
            try
            {
                List<string> logins = db.GetUniqueUserLogins();

                ComboBox_log_in.Items.AddRange(logins.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке логинов: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthAccount()
        {
            string loginUser = ComboBox_log_in.Text;
            string passwordUser = TextBox_password.Text;

            string query = $"SELECT isAdmin FROM register WHERE login_user = '{loginUser}' AND password_user = '{passwordUser}'";

            try
            {
                db.OpenConnection();

                var command = db.ExecuteQuery(query);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isAdmin = reader.GetBoolean(0);
                    }
                    else
                    {
                        MessageBox.Show("Неправильное имя пользователя или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (isAdmin)
                {
                    MessageBox.Show("Вы вошли в систему как администратор", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы вошли в систему", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            AuthAccount();
        }
    }
}
