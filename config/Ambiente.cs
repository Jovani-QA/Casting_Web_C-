using System;

public class Ambiente
{
    public string UrlLocal { get; private set; } = "http://localhost";
    public string UrlHomologacao { get; private set; } = "http://169.62.128.221/Casting/CASTING_ADM_HOMO/Account/Login";

    public string UrlPWA { get; private set; } = "https://ser-casting.web.app/login";
    public string UrlProducao { get; private set; } = "http://producao.com";

    // Método para obter a URL com base no ambiente
    public string ObterUrl(AmbienteEnum ambiente)
    {
        switch (ambiente)
        {
            case AmbienteEnum.Local:
                return UrlLocal;
            case AmbienteEnum.Homologacao:
                return UrlHomologacao;
            case AmbienteEnum.PWA:
                return UrlPWA;
            case AmbienteEnum.Producao:
                return UrlProducao;
            default:
                throw new ArgumentOutOfRangeException(nameof(ambiente), ambiente, null);
        }
    }
}

public enum AmbienteEnum
{
    Local,
    Homologacao,
    PWA,
    Producao
}
