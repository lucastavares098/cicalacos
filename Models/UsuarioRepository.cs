using System;
using System.Collections.Generic;
using MySqlConnector;

namespace uc4.Models
{
    public class UsuarioRepository
    {
        private const string _strConexao = "Database=cicalacos;Data Source=localhost;User Id=root;";

public Usuario QueryLogin(Usuario u)
{
    MySqlConnection conexao = new MySqlConnection(_strConexao);
    conexao.Open();
    string sql = "SELECT * FROM Usuario WHERE login = @Login AND senha = @Senha";
    MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
    comandoQuery.Parameters.AddWithValue("@Login", u.Login);
    comandoQuery.Parameters.AddWithValue("@Senha", u.Senha);
    MySqlDataReader reader = comandoQuery.ExecuteReader();
    Usuario usr = null;
    if(reader.Read())
    {
        usr = new Usuario();
        usr.Id = reader.GetInt32("Id");
        if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
            usr.Nome = reader.GetString("Nome");
       
        if(!reader.IsDBNull(reader.GetOrdinal("Login")))
            usr.Login = reader.GetString("Login");
        if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
            usr.Senha = reader.GetString("Senha");
    }
   
    conexao.Close();
    return usr;
}
public class PedidosRepository
        {
        private const string _strConexao = "Database=cicalacos;Data Source=localhost;User Id=root;";
            public void Insert(Pedidos novoPedido)
            {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO pedidos(nome, itempedido, endereço, valor, formapag) VALUES (@nome, @ItemPedido, @Endereço, @Valor, @FormaPag)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", novoPedido.Nome);
            comando.Parameters.AddWithValue("@ItemPedido", novoPedido.ItemPedido);
            comando.Parameters.AddWithValue("@Endereço", novoPedido.Endereço);
            comando.Parameters.AddWithValue("@Valor", novoPedido.Valor);
            comando.Parameters.AddWithValue("@FormaPag", novoPedido.FormaPag);
            comando.ExecuteNonQuery();
            conexao.Close();
            }
                public List<Pedidos> Query()
                {
    MySqlConnection conexao = new MySqlConnection(_strConexao);
    conexao.Open();
    string sql = "SELECT * FROM Pedidos ORDER BY nome";
    MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
    MySqlDataReader reader = comandoQuery.ExecuteReader();
    List<Pedidos> lista = new List<Pedidos>();
        while (reader.Read())
        {
        Pedidos usr = new Pedidos();
        usr.Id = reader.GetInt32("Id");
       
        if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
            usr.Nome = reader.GetString("Nome");
        if(!reader.IsDBNull(reader.GetOrdinal("ItemPedido")))
            usr.ItemPedido = reader.GetString("ItemPedido");
        if(!reader.IsDBNull(reader.GetOrdinal("Endereço")))
            usr.Endereço = reader.GetString("Endereço");
        if(!reader.IsDBNull(reader.GetOrdinal("Valor")))
            usr.Valor = reader.GetString("Valor");
        if(!reader.IsDBNull(reader.GetOrdinal("FormaPag")))
            usr.FormaPag = reader.GetString("FormaPag");   
        lista.Add(usr);
        }
    conexao.Close();
    return lista;
}
//UPDATE

public void Editar(Pedidos p)
{
    MySqlConnection conexao = new MySqlConnection(_strConexao);
    conexao.Open();
    string Query = "UPDATE Pedidos SET nome = @Nome, ItemPedido = @ItemPedido, Endereço = @Endereço, Valor = @Valor, FormaPag = @FormaPag WHERE Id = @Id";
    MySqlCommand comandoQuery = new MySqlCommand(Query, conexao);

    comandoQuery.Parameters.AddWithValue("@Id", p.Id);
    comandoQuery.Parameters.AddWithValue("@Nome", p.Nome);
    comandoQuery.Parameters.AddWithValue("@ItemPedido", p.ItemPedido);
    comandoQuery.Parameters.AddWithValue("@Endereço", p.Endereço);
    comandoQuery.Parameters.AddWithValue("@Valor", p.Valor);
    comandoQuery.Parameters.AddWithValue("@FormaPag", p.FormaPag);

    comandoQuery.ExecuteNonQuery();

    conexao.Close();
}
  
public Pedidos BuscarPorId(int Id)
{
    MySqlConnection conexao = new MySqlConnection(_strConexao);
    conexao.Open();
    string Query = "SELECT * FROM Pedidos WHERE Id = @Id";
    MySqlCommand comandoQuery = new MySqlCommand(Query, conexao);
    comandoQuery.Parameters.AddWithValue("@Id", Id);
    MySqlDataReader reader = comandoQuery.ExecuteReader();
    
    Pedidos p = new Pedidos();
    
    if(reader.Read())
    {
        p.Id = reader.GetInt32("Id");

        if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
        {
            p.Nome = reader.GetString("Nome");     
        }
        if(!reader.IsDBNull(reader.GetOrdinal("ItemPedido")))
        {
            p.ItemPedido = reader.GetString("ItemPedido");     
        }
        if(!reader.IsDBNull(reader.GetOrdinal("Endereço")))
        {
            p.Endereço = reader.GetString("Endereço");     
        }
        if(!reader.IsDBNull(reader.GetOrdinal("Valor")))
        {
            p.Valor = reader.GetString("Valor");     
        }
        if(!reader.IsDBNull(reader.GetOrdinal("FormaPag")))
        {
            p.FormaPag = reader.GetString("FormaPag");     
        }
    }

    conexao.Close();

    return p;
}
public void Deletar(int Id)
{
    MySqlConnection conexao = new MySqlConnection(_strConexao);
    conexao.Open();

    string Query = "DELETE FROM Pedidos WHERE Id = @Id";
    MySqlCommand comandoQuery = new MySqlCommand(Query, conexao);
    comandoQuery.Parameters.AddWithValue("@Id", Id);

    comandoQuery.ExecuteNonQuery();

    conexao.Close();


}
    }
}
}