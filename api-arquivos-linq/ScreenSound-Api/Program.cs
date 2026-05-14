// neste projeto faremos requisićões http, logo, usaremos uma biblioteca (HttpClient) para nos auxiliar neste processo, onde a váriavel: client é o nome que damos a instância do objeto tipo HttpClient e quando atribuimos = new HttpClient() estamos INICIALIZANDO um objeto do tipo HTTPCLIENT)
// como após o USING não fechamos as chaves, quer dizer que vamos gerenciar esse pacote/recurso dentro das {}
using (HttpClient client = new HttpClient())
{
    try
    {
        // tipo string pois a resposta que teremos provavelmente será do tipo string
        // getStringAsync pois NÃO sabemos quantas músicas tem, como é um método asincrono, ele não vai simplesmente pegar uma música e passar para a póxima, claro Do endpoint da api passada por parâmetro nos parenteses (endpoint == link/url), e claro como é um método ASSINCRONO, ele precisa do await, que basicamente diz para a máquina: espere essa atividade (retornos do endpoint da api) serem finalizados antes de prosseguir para a próxima linha
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        System.Console.WriteLine(resposta);
    }
    catch (Exception e)
    {
        // Message == $th->getMessage, Message pega a mensagem que o objeto do tipo Exception pode ter
        System.Console.WriteLine($"Temos um problema: {e.Message}");
    }

}