using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPet.Models;
[Table("Cliente")]
public class Cliente
{
    /* atributos de Cliente e seus getters e setters */

    [Key]
    [Column("Id")]
    [Display(Name = "Id")]
    public int Id { get; set; }
    [Column("Nome")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }
    [Column("Cpf")]
    [Display(Name = "Cpf")]
    public string Cpf { get; set; }
    [Column("Email")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    [Column("Paciente")]
    [Display(Name = "Paciente")]
    public string Paciente { get; set; }

    /* Construtor do model Cliente e determinado quais parâmetros são
    necessários na criação das instâncias. */

    public Cliente(int id, string nome, string cpf,
    string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }
}