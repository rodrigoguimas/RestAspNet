Imports System.Net.Http

Imports System.Net

Imports System.Web.Http



Namespace ProdutosWebAPI



    Public Class ProdutosController

        Inherits ApiController



        Private produtos As Produto() = New Produto() {New Produto() With {.Id = 1, .Nome = "Suco de Tomate", .Categoria = "Alimentos", .Preco = 2.39D}, New Produto() With {.Id = 2, .Nome = "Tablet Ipad", .Categoria = "Informática", .Preco = 1230.75D}, New Produto() With {.Id = 3, .Nome = "NoteBook CCE", .Categoria = "Informática", .Preco = 1500.25D}, New Produto() With {.Id = 4, .Nome = "Caneta", .Categoria = "Papelaria", .Preco = 0.75D}, New Produto() With {.Id = 5, .Nome = "Caderno Espiral", .Categoria = "Papelaria", .Preco = 1.99D}}


        Public Function GetTodosProdutos() As IEnumerable(Of Produto)

            Return produtos

        End Function


        Public Function GetProdutoPorId(id As Integer) As Produto

            Dim produto = produtos.FirstOrDefault(Function(p) p.Id = id)


            If produto Is Nothing Then

                Dim resp = New HttpResponseMessage(HttpStatusCode.NotFound)

                Throw New HttpResponseException(resp)

            End If

            Return produto

        End Function


        Public Function GetProdutosPorCategoria(categoria As String) As IEnumerable(Of Produto)

            Return produtos.Where(Function(p) String.Equals(p.Categoria, categoria, StringComparison.OrdinalIgnoreCase))


        End Function

    End Class

End Namespace