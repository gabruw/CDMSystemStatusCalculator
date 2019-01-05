using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculadoraPontosRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            var apk = true;

            while (apk == true)
            {
                Console.Clear();
                Program newProg = new Program();

                var listType = newProg.tipoStatus();
                var listVal = new List<string>();

                Console.WriteLine("Digite a classificação do HP: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do MP: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do DMGF: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do DMGM: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do DEF: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do FUR: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do DET: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do CRIT: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do ACR: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                Console.WriteLine("Digite a classificação do WILL: [B|N|M]");
                listVal.Add(Console.ReadLine().ToString());

                var dictStatus = newProg.separarPontos(listVal, listType);

                foreach (var status in dictStatus)
                {
                    switch (status.Key)
                    {
                        case "HP":
                        case "MP":
                        case "DMGF":
                        case "DMGM":
                        case "DEF":
                            Console.WriteLine(status.Key + ":   " + status.Value);
                            break;

                        case "FUR":
                        case "DET":
                        case "CRIT":
                        case "ACR":
                        case "WILL":
                            Console.WriteLine(status.Key + ":   " + status.Value + "%");
                            break;
                    }

                }

                Console.ReadLine();

                Console.WriteLine("Calcular mais um status? [N]");
                if (Console.ReadLine().ToString().Equals("N"))
                {
                    apk = false;
                }
            }
        }

        public Dictionary<string, Int16> separarPontos(List<string> listVal, List<string> listType)
        {
            var dictStatus = new Dictionary<string, Int16>();
            var listSt = new List<Int16>();

            for (int i = 0; i < listVal.Count; i++)
            {
                switch (listType[i])
                {
                    case "HP":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(100);
                                break;
                            case "N":
                                listSt.Add(150);
                                break;
                            case "M":
                                listSt.Add(200);
                                break;
                        }
                        break;

                    case "MP":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(90);
                                break;
                            case "N":
                                listSt.Add(120);
                                break;
                            case "M":
                                listSt.Add(170);
                                break;
                        }
                        break;

                    case "DMGF":
                    case "DMGM":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(30);
                                break;
                            case "N":
                                listSt.Add(60);
                                break;
                            case "M":
                                listSt.Add(90);
                                break;
                        }
                        break;

                    case "DEF":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(20);
                                break;
                            case "N":
                                listSt.Add(50);
                                break;
                            case "M":
                                listSt.Add(80);
                                break;
                        }
                        break;

                    case "FUR":
                    case "DET":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(5);
                                break;
                            case "N":
                                listSt.Add(10);
                                break;
                            case "M":
                                listSt.Add(15);
                                break;
                        }
                        break;

                    case "CRIT":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(3);
                                break;
                            case "N":
                                listSt.Add(4);
                                break;
                            case "M":
                                listSt.Add(7);
                                break;
                        }
                        break;

                    case "ACR":
                    case "WILL":
                        switch (listVal[i])
                        {
                            case "B":
                                listSt.Add(0);
                                break;
                            case "N":
                                listSt.Add(0);
                                break;
                            case "M":
                                listSt.Add(4);
                                break;
                        }
                        break;
                }
            }

            for (int i = 0; i < listSt.Count; i++)
            {
                dictStatus.Add(listType[i], listSt[i]);
            }

            return dictStatus;
        }

        public List<string> tipoStatus()
        {
            var listaTipoStatus = new List<string>();

            listaTipoStatus.Add("HP");
            listaTipoStatus.Add("MP");
            listaTipoStatus.Add("DMGF");
            listaTipoStatus.Add("DMGM");
            listaTipoStatus.Add("DEF");
            listaTipoStatus.Add("FUR");
            listaTipoStatus.Add("DET");
            listaTipoStatus.Add("CRIT");
            listaTipoStatus.Add("ACR");
            listaTipoStatus.Add("WILL");

            return listaTipoStatus;
        }
    }
}
