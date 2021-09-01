using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorSTFolha
{
    class Util
    {
        public static List<string> ProcuraSTFolha(string path)
        {
            List<string> diretorios = new List<string>(Directory.EnumerateDirectories(path));
            List<string> sistemas = new List<string>();

            foreach (var elemento in diretorios)
            {
                if (File.Exists(elemento + "\\STFolha.exe"))
                {
                    sistemas.Add(elemento);
                }
            }

            return sistemas;
        }

        public static string SenhaDoDia()
        {
            int diaDoMes = DateTime.Now.Day;
            int mesAtual = DateTime.Now.Month;

            int chaveMes, chaveDia;

            if(diaDoMes % 2 == 0)
            {
                chaveMes = 3 * mesAtual;
                chaveDia = 5 * diaDoMes;
            }
            else
            {
                chaveMes = 6 * mesAtual;
                chaveDia = 2 * diaDoMes;
            }
            return Convert.ToString(chaveMes) + Convert.ToString(chaveDia);
        }
    }
}
