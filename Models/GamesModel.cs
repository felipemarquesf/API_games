namespace Games.Models;

public class GamesModel
{
    public GamesModel(String nomeDoJogo ,String nomeDaEmpresa,String estiloDoJogo,bool situacao)
    {
        Id = Guid.NewGuid();
        NomeDoJogo = nomeDoJogo;
        NomeDaEmpresa = nomeDaEmpresa;
        EstiloDoJogo = estiloDoJogo;
        Situacao = situacao;
    }

    public Guid Id { get; init; }
    public String NomeDoJogo { get; private set; }
    public String NomeDaEmpresa { get; private set; }
    public String EstiloDoJogo { get; private set; } 
    
    public bool Situacao { get; private set; }

    public void ChangeName(string nomeDoJogo,string nomeDaEmpresa, string estiloDoJogo,bool situacao)
    {
        NomeDoJogo = nomeDoJogo;
        NomeDaEmpresa = nomeDaEmpresa;
        EstiloDoJogo = estiloDoJogo;
        Situacao = situacao;
    }

    public void SetDelete()
    {
        NomeDoJogo = "delete";
        NomeDaEmpresa = "delete";
        EstiloDoJogo = "delete";
    }

} 