using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DublaPlay.Common
{
    public class GravarTxt : GravarArquivo
    {
        public string Dados { get; set; }
        public override void Gravar(string dados)
        {
            string fileName = @"C:\Temp\log.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes(dados);
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

        public static GravarTxt operator /(GravarTxt gravar, char sepatador)
        {
            GravarTxt gravarSplit = new GravarTxt();
            gravarSplit.Dados = gravar.Dados.Split(sepatador).ToString();

            return gravarSplit;
        }
    }
}


