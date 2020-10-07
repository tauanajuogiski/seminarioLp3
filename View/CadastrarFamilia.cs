using e_aquila.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_aquila.View
{
    public partial class CadastrarFamilia : Form
    {
        List<string> list = new List<string>();
        SqlCommand c = new SqlCommand();
        SqlCommand c1 = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dtr;
        SqlDataReader dtr1;
        string titulo;
        string descricao;
        float valor;
        int desconto;
        string familia;
        FamiliaProdutos fa = new FamiliaProdutos();
        List<Produto> lista = new List<Produto>();


        public CadastrarFamilia()
        {
            InitializeComponent();
            carregarList();
        }

        private void carregarList()
        {
            con.conectar();

            c.CommandText = "select * from Produtos";
            c.Connection = con.conectar();
            dtr = c.ExecuteReader();

            while (dtr.Read())
            {
                Produto p1 = new Produto();
                p1.ID = int.Parse(dtr[0].ToString());
                p1.Path = dtr[1].ToString();
                p1.Titulo = dtr[2].ToString();
                p1.Descrição = dtr[3].ToString();
                p1.Preço = float.Parse(dtr[4].ToString());
                p1.Estoque = int.Parse(dtr[5].ToString());
                p1.Status = dtr[6].ToString();

                list.Add(p1.Titulo);

            }
            checkedListBox1.DataSource = list;
            con.desconectar();
        }

        private void CadastrarFamilia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.conectar();

            foreach (string itemChecked in checkedListBox1.CheckedItems)
            {
                c1.CommandText = "select * from Produtos where Titulo = @t";
                c1.Parameters.AddWithValue("@t", itemChecked.ToString());
                c1.Connection = con.conectar();
                dtr1 = c1.ExecuteReader();

                if (dtr1.Read())
                {
                    Produto p1 = new Produto();
                    p1.Path = dtr1[1].ToString();
                    p1.Titulo = dtr1[2].ToString();
                    p1.Descrição = dtr1[3].ToString();
                    p1.Preço = float.Parse(dtr1[4].ToString());
                    p1.Estoque = int.Parse(dtr1[5].ToString());
                    p1.Status = dtr1[6].ToString();

                    fa.adicionarProduto(p1);
                  

                    /*
                    ListViewItem item = new ListViewItem(p1.Titulo);
                    item.SubItems.Add(p1.Preço.ToString());
                    item.SubItems.Add(familia);
                    item.SubItems.Add(desconto.ToString());
                    this.listView1.Items.Add(item);

                    fa.adicionarProduto(p1);
                    con.desconectar();*/
                }

                lista = fa.retornaLista();


                foreach (var a in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(a.Titulo);
                    item.SubItems.Add(a.Preço.ToString());
                    item.SubItems.Add(familia);
                    item.SubItems.Add(desconto.ToString());
                    this.listView1.Items.Add(item);
                }



                /* titulo = dtr[2].ToString();
                 valor = float.Parse(dtr[4].ToString());
                 desconto = int.Parse(textBox1.Text);
                 descricao = textBox3.Text;
                 familia = textBox2.Text;

                 dtr.Close();

                 c.CommandText = "insert into Familia Values(@t, @v, @do, @de, @fa)";
                 c.Parameters.AddWithValue("@t", titulo);
                 c.Parameters.AddWithValue("@v", valor);
                 c.Parameters.AddWithValue("@do", desconto);
                 c.Parameters.AddWithValue("@de", descricao);
                 c.Parameters.AddWithValue("@fa", familia);
                 c.Connection = con.conectar();
                 dtr = c.ExecuteReader();
                 */
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }
    }
}
