using System;

namespace PlantioRecomendado
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe a data no formato dia/mes/ano");
            Console.Write("Data do plantio: ");
            DateTime data;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
            {
                Console.WriteLine("Data inválida. Informe novamente no formato dia/mes/ano:");
            }

            string estacao = ObterEstacaoDoAno(data);

            Console.WriteLine($"Estações do ano: {estacao}");
            Console.WriteLine("Regiões: norte, nordeste, sul, sudeste, centro-oeste");
            Console.Write("Informe a região onde a empresa atua: ");
            string regiao = Console.ReadLine();

            RecomendarPlantio(estacao, regiao);

        }

        static bool ValidarCnpj(string cnpj)
        {
            // Implementação da validação do CNPJ
            // Aqui você pode usar alguma biblioteca externa ou implementar a validação manualmente
            // Retorne true se o CNPJ for válido, false caso contrário
            // Neste exemplo, apenas retornamos true para qualquer CNPJ informado
            return true;
        }

        static string ObterEstacaoDoAno(DateTime data)
        {
            int mes = data.Month;
            switch (mes)
            {
                case 12:
                case 1:
                case 2:
                    return "Verão";
                case 3:
                case 4:
                case 5:
                    return "Outono";
                case 6:
                case 7:
                case 8:
                    return "Inverno";
                case 9:
                case 10:
                case 11:
                    return "Primavera";
                default:
                    return "Desconhecida";
            }
        }

        static void RecomendarPlantio(string estacao, string regiao)
        {
            // faça uma recomendação de plantio com base na estação do ano e na região informada (as duas condições devem ser consideradas)
            // Exemplo: "Recomenda-se o plantio de milho na região sul durante o inverno"

            if (string.IsNullOrEmpty(estacao)) { Console.WriteLine("Estação inválida"); return; }
            if (string.IsNullOrEmpty(regiao)) { Console.WriteLine("Região inválida"); return; }

            switch (estacao)
            {
                case "Verão":
                    switch (regiao)
                    {
                        case "norte":
                            Console.WriteLine("Recomenda-se o plantio de milho, feijão, cacau e açaí na Região Norte durante o Verão");
                            break;
                        case "nordeste":
                            Console.WriteLine("Recomenda-se o plantio de algodão, mamona, mandioca e amendoim na Região Nordeste durante o Verão");
                            break;
                        case "sul":
                            Console.WriteLine("Recomenda-se o plantio de soja, milho, feijão e trigo na Região Sul durante o Verão");
                            break;
                        case "sudeste":
                            Console.WriteLine("Recomenda-se o plantio de café, cana-de-açúcar, laranja e tomate na Região Sudeste durante o Verão");
                            break;
                        case "centro-oeste":
                            Console.WriteLine("Recomenda-se o plantio de algodão, arroz, sorgo e feijão na Região Centro-Oeste durante o Verão");
                            break;
                        default:
                            Console.WriteLine("Região inválida");
                            break;
                    }
                    break;
                case "Outono":
                    switch (regiao)
                    {
                        case "norte":
                            Console.WriteLine("Recomenda-se o plantio de maracujá, pupunha, guaraná e pupunha na Região Norte durante o Outono");
                            break;
                        case "nordeste":
                            Console.WriteLine("Recomenda-se o plantio de cana-de-açúcar, manga, goiaba e banana na Região Nordeste durante o Outono");
                            break;
                        case "sul":
                            Console.WriteLine("Recomenda-se o plantio de maçã, uva, trigo e cevada na Região Sul durante o Outono");
                            break;
                        case "sudeste":
                            Console.WriteLine("Recomenda-se o plantio de café, batata, cebola e alface na Região Sudeste durante o Outono");
                            break;
                        case "centro-oeste":
                            Console.WriteLine("Recomenda-se o plantio de milho, girassol, feijão e trigo na Região Centro-Oeste durante o Outono");
                            break;
                        default:
                            Console.WriteLine("Região inválida");
                            break;
                    }
                    break;
                case "Inverno":
                    switch (regiao)
                    {
                        case "norte":
                            Console.WriteLine("Recomenda-se o plantio de tucumã, castanha-do-brasil, açaí e cupuaçu na Região Norte durante o Inverno");
                            break;
                        case "nordeste":
                            Console.WriteLine("Recomenda-se o plantio de feijão, mandioca, melancia e abóbora na Região Nordeste durante o Inverno");
                            break;
                        case "sul":
                            Console.WriteLine("Recomenda-se o plantio de maçã, uva, trigo e cevada na Região Sul durante o Inverno");
                            break;
                        case "sudeste":
                            Console.WriteLine("Recomenda-se o plantio de café, alface, cenoura e batata na Região Sudeste durante o Inverno");
                            break;
                        case "centro-oeste":
                            Console.WriteLine("Recomenda-se o plantio de soja, milho, feijão e algodão na Região Centro-Oeste durante o Inverno");
                            break;
                        default:
                            Console.WriteLine("Região inválida");
                            break;
                    }
                    break;
                case "Primavera":
                    switch (regiao)
                    {
                        case "norte":
                            Console.WriteLine("Recomenda-se o plantio de bananeira, abacaxi, mandioca e cupuaçu na Região Norte durante a Primavera");
                            break;
                        case "nordeste":
                            Console.WriteLine("Recomenda-se o plantio de milho, feijão, melancia e abóbora na Região Nordeste durante a Primavera");
                            break;
                        case "sul":
                            Console.WriteLine("Recomenda-se o plantio de trigo, cevada, milho e feijão na Região Sul durante a Primavera");
                            break;
                        case "sudeste":
                            Console.WriteLine("Recomenda-se o plantio de café, milho, feijão e batata na Região Sudeste durante a Primavera");
                            break;
                        case "centro-oeste":
                            Console.WriteLine("Recomenda-se o plantio de soja, milho, girassol e feijão na Região Centro-Oeste durante a Primavera");
                            break;
                        default:
                            Console.WriteLine("Região inválida");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Estação inválida");
                    break;
            }

        }
    }
    }


        

