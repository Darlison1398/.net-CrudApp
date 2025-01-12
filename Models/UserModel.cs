namespace CrudApp.Models
{
    public class UserModel 
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Mensagem { get; set; }

        public UserModel()
        {
            Nome = string.Empty;
            Mensagem = string.Empty;
        }

    }
}