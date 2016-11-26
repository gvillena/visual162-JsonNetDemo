Imports Newtonsoft.Json

Module Module1

    Sub Main()

        ' Manzanas (Cant. 10)
        Dim manzanas As New Fruta()
        manzanas.Nombre = "Manzana"
        manzanas.Cantidad = 10

        ' Peras (Cant. 20)
        Dim peras As New Fruta()
        peras.Nombre = "Pera"
        peras.Cantidad = 20

        ' Naranjas (Cant. 30)
        Dim naranjas As New Fruta()
        naranjas.Nombre = "Manzana"
        naranjas.Cantidad = 30

        ' Lista de Frutas
        Dim frutas As New List(Of Fruta)
        frutas.Add(manzanas)
        frutas.Add(peras)
        frutas.Add(naranjas)

        ' Serializar objeto lista de frutas a json
        Dim output = JsonConvert.SerializeObject(frutas, Formatting.Indented)
        Console.WriteLine(output)
        Console.ReadKey()

        ' Deserializar json a objeto lista de frutas 
        Dim jsonFrutas As List(Of Fruta) = JsonConvert.DeserializeObject(Of List(Of Fruta))(output)
        Console.WriteLine(jsonFrutas.Count)
        Console.ReadKey()



    End Sub

End Module

