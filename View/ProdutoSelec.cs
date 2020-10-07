using e_aquila.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class ProdutoSelec : Form
    {
        SqlCommand c = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;

        public ProdutoSelec(int indice)
        {
            InitializeComponent();
            titulo.Text = indice.ToString();
            con.conectar();

            c.CommandText = "select * from Produtos where ID = @id";
            c.Parameters.AddWithValue("@id", indice);

            c.Connection = con.conectar();
            dtr = c.ExecuteReader();

            if (dtr.Read())
            {
                Produto p1 = new Produto();
                p1.ID = int.Parse(dtr[0].ToString());
                p1.Path = dtr[1].ToString();
                p1.Titulo = dtr[2].ToString();
                p1.Descrição = dtr[3].ToString();
                p1.Preço = float.Parse(dtr[4].ToString());
                p1.Estoque = int.Parse(dtr[5].ToString());
                p1.Status = dtr[6].ToString();

                pictureBox.Image = Image.FromFile(p1.Path);
                titulo.Text = p1.Titulo; 
                descricao.Text = p1.Descrição;
                preco.Text = p1.Preço.ToString();
                estoque.Text = p1.Estoque.ToString();
                
                if(p1.Estoque == 0)
                {
                    comprar.Visible = false;
                    aviso.Visible = true;
                    addP.Visible = false;
                }
                else
                {
                    comprar.Visible = true;
                    aviso.Visible = false;
                    addP.Visible = true;
                }

                if(p1.Status == "1")
                {
                    newP.Visible = true;
                }

            }

             dtr.Close();
             con.desconectar();
        }

        private void ProdutoSelec_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaInicial ti = new TelaInicial();
            ti.Show();
            this.Hide();
        }

        private void addP_Click(object sender, EventArgs e)
        {

        }
    }
}
