using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public class GravarTxt : GravarArquivo
    {
        public override void Gravar(string dados)
        {
            string fileName = @"C:\Temp\Mahesh.txt";

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(dados / ",");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Login");
                    fs.Write(author, 0, author.Length);
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }

        /// <summary>
        /// Sobrecarga responsável por separ texto.
        /// </summary>
        /// <param name="dados">Informações</param>
        /// <param name="dividor">operador que irá dividir</param>
        /// <returns></returns>
        public static GravarTxt operator /(string dados, string dividor)
        {
            return dados.split(dividor);
        }

    }
}
