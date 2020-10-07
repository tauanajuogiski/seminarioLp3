using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.Controler
{
    public class ComandosLogin
    {
        public bool exists = false;
        public String aviso = "";
        SqlCommand c = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;
        bool[] tipoU = new bool[2];

        public bool[] verificarLogin(String login, String senha)
        {
            c.CommandText = "select * from Users where username = @login and password = @senha";
            c.Parameters.AddWithValue("@login", login);
            c.Parameters.AddWithValue("@senha", senha);

            try
            {
                c.Connection = con.conectar();
                dtr = c.ExecuteReader();
                if (dtr.HasRows)
                {
                    exists = true;
                    if (dtr.Read())
                    {
                        MessageBox.Show(dtr[6].ToString());
                        if (dtr[6].ToString().Contains("admin"))
                            tipoU[1] = true;
                        else
                            tipoU[1] = false;
                    }
                }
            }
            catch (SqlException)
            {
                this.aviso = "Erro com o banco de dados!";
            }
            tipoU[0] = exists;
            return tipoU;
        }
        public String cadastrar(String cpf, string nome, String login, String senha, String confSenha)
        {
            if (senha != confSenha)
            {
                this.aviso = "Senhas não coincidem!";
            }
            else
            {
                bool status = true;

                c.CommandText = "INSERT INTO Users VALUES(@id, @name, @lg, @pass, @sts, 'user')";
                c.Parameters.AddWithValue("@id", cpf);
                c.Parameters.AddWithValue("@name", nome);
                c.Parameters.AddWithValue("@lg", login);
                c.Parameters.AddWithValue("@pass", senha);
                c.Parameters.AddWithValue("@sts", status);

                try
                {
                    c.Connection = con.conectar();
                    dtr = c.ExecuteReader();
                    this.aviso = "Inserido com sucesso";
                }
                catch (SqlException)
                {
                    this.aviso = "Erro com o banco de dados!";
                }
            }
            return aviso;
        }
    }
}

