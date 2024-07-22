Imports System.Net
Imports Newtonsoft.Json

Module ModuleApi


    Public Class cep
        Property cep As String
        Property logradouro As String
        Property complemento As String
        Property unidade As String
        Property bairro As String
        Property localidade As String
        Property uf As String
        Property ibge As Integer
        Property gia As Integer
        Property ddd As Integer
        Property siafi As Integer


        Public Shared Function ObterEndereco(cep_ As String) As cep
            Dim url = "https://viacep.com.br/ws/" + cep_ + "/json/"
            Dim json = New WebClient().DownloadString(url)

            Dim cepRetorno = JsonConvert.DeserializeObject(Of cep)(json)
            Return cepRetorno
        End Function

    End Class




End Module
