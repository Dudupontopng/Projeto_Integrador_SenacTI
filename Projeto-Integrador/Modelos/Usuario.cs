using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Integrador.Modelos
{
    public class Usuario
    {
        
       
        public Usuario() { }
        public Usuario(string nickname, string senha)
        {
            
            Nickname = nickname;
            setSenhaNova(senha);
        }
        public Usuario(string nome, string nickname, DateTime dataNascimento)
        {
            Nome = nome;
            Nickname = nickname;
            DataNascimento = dataNascimento;
        }

       
        public Usuario(string nome, string nickname, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Nickname = nickname;
            setSenhaNova(senha);
            DataNascimento = dataNascimento;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 255 caracteres")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo 'Nickname' é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo 'Nickname' deve ter entre 3 e 50 caracteres")]
        public string Nickname { get; private set; }

        [Required(ErrorMessage = "O campo 'Data de Nascimento' é obrigatório")]
        public DateTime DataNascimento { get; private set; }

        public string Senha { get; private set; }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setNickname(string nickname)
        {
            Nickname = nickname;
        }

        public void setDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }

        public void setSenhaNova(string senhaEmPuroTexto)
        {
            if (string.IsNullOrWhiteSpace(senhaEmPuroTexto))
            {
                throw new ArgumentException("A senha não pode ser vazia");
            }
            Senha = BCrypt.Net.BCrypt.HashPassword(senhaEmPuroTexto);
        }

        public bool validarSenha(string senhaDigitada)
        {
            if (string.IsNullOrEmpty(senhaDigitada))
            {
                return false;
            }
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, Senha);
        }
    }
}