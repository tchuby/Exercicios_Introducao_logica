using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhandoComArquivosDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando a variavel do tipo StreamWriter para
            //abrir ou criar um arquivo para escrita
            StreamWriter x;

            //Colocando o caminho físico e o nome do arquivo a ser criado
            //finalizando com .txt
            string CaminhoNome = "C:\\Users\\daniel.andrade\\Desktop\\arq01.txt";

            //utilizando o método para criar um arquivo texto
            //e associando o caminho e nome ao metodo
            x = File.CreateText(CaminhoNome);

            //aqui, exemplo de escrever no arquivo texto
            //como se fossemos criar um recibo de pagamento

            //escrevendo o título
            x.WriteLine("Termo de Uso");
            //pulando linha sem escrita
            x.WriteLine();
            //escrevendo o conteudo do termo
            x.WriteLine("Art. 1º - ACEITAÇÃO");
            x.WriteLine("Você reconhece que analisou e aceitou as condições de uso. Leia-as atentamente " +
                "pois o uso deste aplicativo significa que você aceitou todos os termos e concorda em " +
                "cumpri-los.Se você, usuário, for menor de idade oudeclarado incapaz em quaisquer aspectos, " +
                "precisará da permissão de seus pais ou responsáveis que também deverão concordar com estes" +
                " mesmos termos e condições.");
            x.WriteLine("Art. 2º - LIMITAÇÕES");
            x.WriteLine("O aplicativo deverá ser utilizado por você, usuário. A venda, transferência, modificação," +
                " engenharia reversa ou distribuição bem como a cópia de textos, imagens ou quaisquer partes " +
                "nele contido é expressamente proibida.");
            x.WriteLine($"Blumenau,{DateTime.Now}");
            //fechando o arquivo texto com o método .Close()
            x.Close();
        }
    }
}
