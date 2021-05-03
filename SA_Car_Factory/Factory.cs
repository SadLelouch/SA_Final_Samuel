using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa cliente = new Pessoa();
            Pessoa funcionario = new Pessoa();
            Carro carro = new Carro();
            Parts pecas = new Parts();
            Maintence manuntencao = new Maintence();
            Concessionaria concessionaria = new Concessionaria();
            Vendas vendas = new Vendas();

            List<Pessoa> listCliente = new List<Pessoa>();
            List<Pessoa> listFuncionario = new List<Pessoa>();
            List<Carro> listCarro = new List<Carro>();
            List<Parts> listPecas = new List<Parts>();
            List<Maintence> listManuntencao = new List<Maintence>();
            List<Concessionaria> listConcessionaria = new List<Concessionaria>();
            List<Vendas> listVendas = new List<Vendas>();
            int resp = 0;
            char repetir = ' ';
            bool repete = false;

            do
            {
                Console.Clear();
                Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                Console.WriteLine("Menu");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("4. Sair da Aplicação");
                Console.Write("\n");
                Console.Write("Escolha: ");
                resp = Convert.ToInt32(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        resp = 0;
                        Console.Clear();
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                        Console.WriteLine("Cadastrar");
                        Console.WriteLine("1. Cadastrar Cliente");
                        Console.WriteLine("2. Cadastrar Funcionario");
                        Console.WriteLine("3. Cadastrar Carro");
                        Console.WriteLine("4. Cadastrar Peças");
                        Console.WriteLine("5. Cadastrar Manuntenção");
                        Console.WriteLine("6. Cadastrar Concessionária");
                        Console.WriteLine("7. Cadastrar Venda");
                        Console.WriteLine("8. Voltar ao menu");
                        Console.Write("\n");
                        Console.Write("Escolha: ");
                        resp = Convert.ToInt32(Console.ReadLine());

                        #region Cadastro
                        switch (resp)
                        {
                            case 1:
                                do
                                {

                                    Console.Clear();
                                    repete = false;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("- Cadastro de Clientes");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui o nome do Cliente no qual você deseja cadastrar: ");
                                    cliente.nome = Console.ReadLine();
                                    Console.Write("Escreva aqui o telefone do Cliente no qual você deseja cadastrar: ");
                                    cliente.telefone = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o CPF do Cliente no qual você deseja cadastrar: ");
                                    cliente.cpf = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o endereço do Cliente no qual você deseja cadastrar: ");
                                    cliente.endereco = Convert.ToString(Console.ReadLine());
                                    Console.Write("\n");
                                    listCliente.Add(cliente);
                                    Console.Write("Você deseja cadastrar mais algum Cliente? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    repetir = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        repete = true;
                                    }

                                } while (repete);

                                break;

                            case 2:
                                do
                                {

                                    Console.Clear();
                                    repete = false;
                                    funcionario.codigo = 1 + funcionario.codigo;
                                    int decidirCargo = 0;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("- Cadastro de Funcionários");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui o nome do Funcionário no qual você deseja cadastrar: ");
                                    funcionario.nome = Console.ReadLine();
                                    Console.Write("Escreva aqui o telefone do Funcionário no qual você deseja cadastrar: ");
                                    funcionario.telefone = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o CPF do Funcionário no qual você deseja cadastrar: ");
                                    funcionario.cpf = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o endereço do Funcionário no qual você deseja cadastrar: ");
                                    funcionario.endereco = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o turno do Funcionário no qual você deseja cadastrar: ");
                                    funcionario.turno = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o cargo do Funcionário no qual você deseja cadastrar: ");
                                    Console.Write("\n -  [ 1] - Linha de Montagem");
                                    Console.Write("\n -  [ 2] - Estoque de peças e insumos");
                                    Console.Write("\n -  [ 3] - TI");
                                    Console.Write("\n -  [ 4] - Pátio");
                                    Console.Write("\n -  [ 5] - Engenharia");
                                    Console.Write("\n -  [ 6] - Manuntenção da Fábrica");
                                    Console.Write("\n -  [ 7] - Segurança Patrimonial");
                                    Console.Write("\n -  [ 8] - Importação e Exportação");
                                    Console.Write("\n -  [ 9] - Compras e Vendas");
                                    Console.Write("\n -  [10] - Administração Geral");
                                    Console.WriteLine("\n -  Codigo: ");
                                    decidirCargo = Convert.ToInt32(Console.ReadLine());
                                    do
                                        {
                                        Console.Clear();
                                        Console.Write("\n - Cargo Invalido, por favor, digite um cargo de acordo com a listagem acima.");
                                        Console.Write("\n -  [ 1] - Linha de Montagem");
                                        Console.Write("\n -  [ 2] - Estoque de peças e insumos");
                                        Console.Write("\n -  [ 3] - TI");
                                        Console.Write("\n -  [ 4] - Pátio");
                                        Console.Write("\n -  [ 5] - Engenharia");
                                        Console.Write("\n -  [ 6] - Manuntenção da Fábrica");
                                        Console.Write("\n -  [ 7] - Segurança Patrimonial");
                                        Console.Write("\n -  [ 8] - Importação e Exportação");
                                        Console.Write("\n -  [ 9] - Compras e Vendas");
                                        Console.Write("\n -  [10] - Administração Geral\n");
                                        Console.WriteLine("\n -  Codigo: ");
                                        decidirCargo = Convert.ToInt32(Console.ReadLine());

                                    } while (decidirCargo < 1 || decidirCargo > 10);
                                    if (decidirCargo == 1)
                                    {
                                        funcionario.cargo = "Linha de Montagem";
                                    }
                                    else if  (decidirCargo == 2)
                                    {
                                        funcionario.cargo = "Estoque de peças e insumos";
                                    }
                                    else if (decidirCargo == 3)
                                    {
                                        funcionario.cargo = "TI";
                                    }
                                    else if (decidirCargo == 4)
                                    {
                                        funcionario.cargo = "Pátio";
                                    }
                                    else if (decidirCargo == 5)
                                    {
                                        funcionario.cargo = "Engenharia";
                                    }
                                    else if (decidirCargo == 6)
                                    {
                                        funcionario.cargo = "Manuntenção da Fábrica";
                                    }
                                    else if (decidirCargo == 7)
                                    {
                                        funcionario.cargo = "Segurança Patrimonial";
                                    }
                                    else if (decidirCargo == 8)
                                    {
                                        funcionario.cargo = "Importação e Exportação";
                                    }
                                    else if (decidirCargo == 9)
                                    {
                                        funcionario.cargo = "Compras e Vendas";
                                    }
                                    else if (decidirCargo == 10)
                                    {
                                        funcionario.cargo = "Administração Geral";
                                    }
                                    listFuncionario.Add(funcionario);
                                    Console.Write("\n");
                                    Console.Write("Você deseja cadastrar mais algum Funcionário? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    repetir = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        repete = true;
                                    }

                                } while (repete);

                                break;


                            case 3:

                                do
                                {

                                    Console.Clear();
                                    repete = false;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("Cadastrar carro");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui o modelo do carro no qual será fabricado: ");
                                    carro.modelo = Console.ReadLine();
                                    Console.Write("Escreva aqui o ano do carro no qual será fabricado: ");
                                    carro.ano = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Escreva aqui o preço do carro no qual será fabricado: ");
                                    carro.preco = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Escreva aqui a descrição do motor do carro no qual será fabricado: ");
                                    carro.dscMotor = Convert.ToString(Console.ReadLine());
                                    Console.Write("\n");
                                    Console.Write("Você deseja cadastrar mais algum Carro? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    listCarro.Add(carro);
                                    repetir = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        repete = true;
                                    }

                                } while (repete);

                                break;

                            case 4:

                                do
                                {
                                    Console.Clear();
                                    repete = false;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("Cadastrar Peças");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui o nome da peça no qual será utilizada: ");
                                    pecas.nome = Console.ReadLine();
                                    Console.Write("Escreva aqui a quantidade de peças nas quais serão utilizadas: ");
                                    pecas.quantidade = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Escreva aqui o preço unitario da peça na qual será utilizada: ");
                                    pecas.preco = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Escreva aqui o tipo da peça qual será utilizada: ");
                                    pecas.tipo = Convert.ToString(Console.ReadLine());
                                    Console.Write("\n");
                                    Console.Write("Você deseja cadastrar mais algum Peça? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    listPecas.Add(pecas);
                                    repetir = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        repete = true;
                                    }

                                } while (repete);

                                break;


                            case 5:

                                do
                                {

                                    Console.Clear();
                                    repete = false;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("Cadastrar Manuntenção");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui a descrição da manuntenção na qual será realizada: ");
                                    manuntencao.dscMaintence = Console.ReadLine();
                                    Console.Write("Escreva aqui a data da manuntenção na qual será realizada: ");
                                    manuntencao.data = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Para está manuntenção, será utilizada alguma peça? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    char respotarPeça = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        foreach(var item in listPecas)
                                        {
                                            Console.WriteLine("\nSelecione a peça que será utilizada nesta manuntenção:");
                                            for(int k = 0; k <= listPecas.Count; k++)
                                            {
                                                Console.WriteLine("" + item.nome);
                                            }
                                            string nomeDaPeca = Console.ReadLine();
                                            if (item.nome == nomeDaPeca)
                                            {
                                                Console.WriteLine("A "+ nomeDaPeca +" foi adiconada para está manuntenção.");
                                                manuntencao.nomeDaPeca = nomeDaPeca;
                                                double precoManuntencao = (item.preco * 2);
                                                Console.WriteLine("Considerando  o preço desta peça ("+ item.preco +"), o custo minimo desta manuntenção deve ser R$" + precoManuntencao);
                                                manuntencao.preco = precoManuntencao;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Peça não encontrada.");
                                            }
                                        }
                                    }
                                    Console.Write("\n");
                                    Console.Write("Você deseja cadastrar mais algum Manuntenção? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    manuntencao.codigo = 1 + manuntencao.codigo;
                                    listManuntencao.Add(manuntencao);
                                    repetir = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        repete = true;
                                    }

                                } while (repete);

                                break;

                            case 6:

                                do
                                {

                                    Console.Clear();
                                    repete = false;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("Cadastrar Concessionaria");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui o nome da concessionaria qual será cadastrada:");
                                    concessionaria.nome = Console.ReadLine();
                                    Console.Write("Escreva aqui a endereço da concessionaria na qual será cadastrada:");
                                    concessionaria.endereco = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o telefone da concessionaria na qual será cadastrada:");
                                    concessionaria.telefone = Convert.ToString(Console.ReadLine());
                                    Console.Write("Escreva aqui o CNPJ da concessionaria na qual será cadastrada:");
                                    concessionaria.cnpj = Convert.ToString(Console.ReadLine());
                                    Console.Write("\n");
                                    Console.Write("Você deseja cadastrar mais algum Concessionaria? Digite [s] para SIM | Digite [n] para NÃO): ");
                                    concessionaria.codigo = 1 + concessionaria.codigo;
                                    listConcessionaria.Add(concessionaria);
                                    repetir = Convert.ToChar(Console.ReadLine());
                                    if (repetir == 's' || repetir == 'S')
                                    {
                                        repete = true;
                                    }

                                } while (repete);

                                break;

                            case 7:

                                do
                                {

                                    Console.Clear();
                                    repete = false;
                                    Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                    Console.WriteLine("Cadastrar Venda");
                                    Console.Write("\n");
                                    Console.Write("Escreva aqui o nome da concessionaria que está venda será cadastrada:");
                                    foreach (var item in listConcessionaria)
                                    {
                                        Console.WriteLine("\nConcessionarias Cadastradas:");
                                        for (int i = 1; i <= listConcessionaria.Count; i++)
                                        {
                                            Console.WriteLine("\n" + item.nome);
                                        }
                                        string nomeDaConcessionaria = Console.ReadLine();
                                        if (item.nome == nomeDaConcessionaria)
                                        {
                                            Console.WriteLine("\nEsta venda será associada a concessionaria: " + item.nome);
                                            Console.WriteLine("\nDeste modo, insira o modelo do carro que será vendido:");
   
                                            foreach (var item1 in listCarro)
                                            {
                                                Console.WriteLine("\nCarros Cadastrados");
                                                for (int j = 1; j <= listCarro.Count; j++)
                                                {
                                                    Console.WriteLine("\n"+ item1.modelo);
                                                }
                                                string nmodeloDoCarro = Console.ReadLine();
                                                if (item1.modelo == nmodeloDoCarro)
                                                {
                                                    Console.WriteLine("Esta venda será associada a concessionaria: " + item.nome);
                                                    Console.WriteLine("Que venderá o carro: " + item1.modelo);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Este modelo não pertence ao nossos catalogos de carro.");
                                                }
                                                Console.WriteLine("Deste modo, por favor, selecione o preço no qual este carro será vendido:");
                                                double precoDoCarro = Convert.ToDouble(Console.ReadLine());
                                                if (precoDoCarro >= item1.preco)
                                                {
                                                    Console.WriteLine("Com este valor estipulado, você obterá um total de R$:" + (precoDoCarro - item1.preco) + " de lucro na venda.");
                                                    Thread.Sleep(5000);
                                                    Console.Clear();
                                                    Console.WriteLine("Sua venda foi adicionada a");
                                                    Console.WriteLine("Concessionaria " + item.nome);
                                                    Console.WriteLine("Vendendo o modelo" + item1.modelo);
                                                    Console.WriteLine("Por" + item1.preco);
                                                    vendas.nomeConcessionaria = item.nome;
                                                    vendas.modeloCarro = item1.modelo;
                                                    vendas.precoVenda = item1.preco;
                                                    Thread.Sleep(5000);
                                                    Console.Clear();
                                                    listVendas.Add(vendas); 
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Você não pode vender um carro com o mesmo preço ou com o preço inferior ao catalogo de fábrica.");
                                                }
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("O nome da concessionaria digitada não é credenciada com a nossa fábrica.");
                                        }
                                    }
                          
                                    repete = true;
                                 

                                } while (repete);

                                break;
                        }


                        break;
                    #endregion

                    #region Consulta
                    case 2:
                        resp = 0;
                        Console.Clear();
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                        Console.WriteLine("Consultar");
                        Console.WriteLine("1. Consultar Cliente");
                        Console.WriteLine("2. Consultar Funcionario");
                        Console.WriteLine("3. Consultar Carro");
                        Console.WriteLine("4. Consultar Peças");
                        Console.WriteLine("5. Consultar Manuntenção");
                        Console.WriteLine("6. Consultar Concessionária");
                        Console.WriteLine("7. Consultar Venda");
                        Console.WriteLine("8. Voltar ao menu");
                        Console.Write("\n");
                        Console.Write("Escolha: ");
                        resp = Convert.ToInt32(Console.ReadLine());

                        switch (resp)
                        {
                            case 1:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de Cliente");
                                Console.WriteLine("Digite por favor o CPF do Cliente no qual deverá ser encontrado:");
                                string cpfDePesquisaDoCliente = Console.ReadLine();
                                foreach (var item in listCliente)
                                {
                                    if (item.cpf == cpfDePesquisaDoCliente)
                                    {
                                        Console.WriteLine("Nome do Cliente: " + item.nome);
                                        Console.WriteLine("Endereço do Cliente:: " + item.endereco);
                                        Console.WriteLine("Telefone do Cliente: " + item.telefone);
                                        Console.WriteLine("CPF do Cliente: " + item.cpf);
                                    }
                                    else
                                    {
                                        Console.WriteLine("CPF não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja consultar mais algum Cliente? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 2:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de Funcionarios");
                                Console.WriteLine("Digite por favor o CPF do Funcionário no qual deverá ser encontrado:");
                                string cpfDePesquisaDoFuncionario = Console.ReadLine();
                                foreach (var item in listFuncionario)
                                {
                                    if (item.cpf == cpfDePesquisaDoFuncionario)
                                    {
                                        Console.WriteLine("Nome do Funcionário: " + item.nome);
                                        Console.WriteLine("Endereço do Funcionário:: " + item.endereco);
                                        Console.WriteLine("Telefone do Funcionário: " + item.telefone);
                                        Console.WriteLine("CPF do Funcionário: " + item.cpf);
                                        Console.WriteLine("Cargo do Funcionário: " + item.cargo);
                                        Console.WriteLine("Turno do Funcionário: " + item.turno);
                                    }
                                    else
                                    {
                                        Console.WriteLine("CPF não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja consultar mais algum Funcionário? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 3:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de carro");
                                Console.WriteLine("Digite por favor o modelo do Carro no qual deverá ser encontrado:");
                                string carroDePesquisa = Console.ReadLine();
                                foreach (var item in listCarro)
                                {
                                    if (item.modelo == carroDePesquisa)
                                    {
                                        Console.WriteLine("Modelo do Carro: " + item.modelo);
                                        Console.WriteLine("Ano do Carro " + item.ano);
                                        Console.WriteLine("Descrição do Motor do Carro: " + item.dscMotor);
                                        Console.WriteLine("Preço do Carro: " + item.preco);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Modelo não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja consultar mais algum Carro? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 4:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de Peças");
                                Console.WriteLine("Digite por favor o nome da Peça na qual deverá ser encontrado:");
                                string pecaDePesquisa = Console.ReadLine();
                                foreach (var item in listPecas)
                                {
                                    if (item.nome == pecaDePesquisa)
                                    {
                                        Console.WriteLine("Nome da Peça: " + item.nome);
                                        Console.WriteLine("Tipo da Peça" + item.tipo);
                                        Console.WriteLine("Quantidade de Peças: " + item.quantidade);
                                        Console.WriteLine("Preço únitario de cada Peça: " + item.preco);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Peça não encontrada");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja consultar mais alguma Peça? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 5:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de Manuntenção");
                                Console.WriteLine("Digite por favor o nome da Peça na qual deverá ser encontrado:");
                                int codDaManutencao = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listManuntencao)
                                {
                                    if (item.codigo == codDaManutencao)
                                    {
                                        Console.WriteLine("Descrição da Manuntenção: " + item.dscMaintence);
                                        Console.WriteLine("Data da Manuntenção" + item.data);
                                        Console.WriteLine("Peça a ser utilizada: " + item.nomeDaPeca);
                                        Console.WriteLine("Preço da Manuntenção: " + item.preco);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Manuntenção não encontrada");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja consultar mais alguma Manunteção? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;


                            case 6:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de Concessionaria");
                                Console.WriteLine("Digite por favor o CNPJ da Concessionaria na qual deverá ser encontrado:");
                                string concessionariaDePesquisa = Console.ReadLine();
                                foreach (var item in listConcessionaria)
                                {
                                    if (item.cnpj == concessionariaDePesquisa)
                                    {
                                        Console.WriteLine("Nome da Concessionaria: " + item.nome);
                                        Console.WriteLine("Telefone da Concessionaria" + item.telefone);
                                        Console.WriteLine("Endereço da Concessionaria: " + item.endereco);
                                        Console.WriteLine("CNPJ da Concessionaria: " + item.cnpj);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Concessionaria não encontrada");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja consultar mais alguma COncessionaria? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 7:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Consulta de Vendas");
                                Console.WriteLine("Digite por favor o modelo do carro no qual a Venda esta associado e que deverá ser encontrado:");
                                string modeloCarro = Console.ReadLine();
                                foreach (var item in listVendas)
                                {
                                    if (item.modeloCarro == modeloCarro)
                                    {
                                        Console.WriteLine("Esta venda está associada a Concessionaria:" + item.nomeConcessionaria);
                                        Console.WriteLine("O carro a ser vendido é:" + item.modeloCarro);
                                        Console.WriteLine("Com o preço de: " + item.precoVenda);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Este modelo não está a venda.");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja cadastrar mais alguma Venda? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;
                        }
                        break;
                    #endregion
                    #region Editar
                    case 3:
                        resp = 0;
                        Console.Clear();
                        Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                        Console.WriteLine("Editar");
                        Console.WriteLine("1. Editar Cliente");
                        Console.WriteLine("2. Editar Funcionario");
                        Console.WriteLine("3. Editar Carro");
                        Console.WriteLine("4. Editar Peças");
                        Console.WriteLine("5. Editar Manuntenção");
                        Console.WriteLine("6. Editar Concessionária");
                        Console.WriteLine("7. Editar Venda");
                        Console.WriteLine("8. Voltar ao menu");
                        Console.Write("\n");
                        Console.Write("Escolha: ");
                        resp = Convert.ToInt32(Console.ReadLine());

                        switch (resp)
                        {
                            case 1:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Cliente");
                                Console.WriteLine("Digite por favor o CPF do Cliente no qual deverá ser encontrado:");
                                string cpfDePesquisaDoCliente = Console.ReadLine();
                                foreach (var item in listCliente)
                                {
                                    if (item.cpf == cpfDePesquisaDoCliente)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo deste Cliente você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Nome");
                                        Console.Write("\n -  [ 2] - Telefone");
                                        Console.Write("\n -  [ 3] - CPF");
                                        Console.Write("\n -  [ 4] - Endereço");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Cliente receberá:");
                                            string novoNomeDoCliente = Console.ReadLine();
                                            item.nome = novoNomeDoCliente;
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Cliente receberá:");
                                            string novoTelefone = Console.ReadLine();
                                            item.telefone = novoTelefone;
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Cliente receberá:");
                                            string novoCPF = Console.ReadLine();
                                            item.cpf = novoCPF;
                                        }
                                        else if (campoDeEdicao == 4)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Cliente receberá:");
                                            string novoEndereco = Console.ReadLine();
                                            item.endereco = novoEndereco;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Opção Invalida");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("CPF não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais algum Cliente? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 2:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Funcionário");
                                Console.WriteLine("Digite por favor o CPF do Funcionário no qual deverá ser encontrado:");
                                string cpfDePesquisaDoFuncionario = Console.ReadLine();
                                foreach (var item in listFuncionario)
                                {
                                    if (item.cpf == cpfDePesquisaDoFuncionario)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo deste Funcionário você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Nome");
                                        Console.Write("\n -  [ 2] - Telefone");
                                        Console.Write("\n -  [ 3] - CPF");
                                        Console.Write("\n -  [ 4] - Endereço");
                                        Console.Write("\n -  [ 5] - Turno");
                                        Console.Write("\n -  [ 6] - Cargo");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Funcionário receberá:");
                                            string novoNomeDoCliente = Console.ReadLine();
                                            item.nome = novoNomeDoCliente;
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Funcionário receberá:");
                                            string novoTelefone = Console.ReadLine();
                                            item.telefone = novoTelefone;
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Funcionário receberá:");
                                            string novoCPF = Console.ReadLine();
                                            item.cpf = novoCPF;
                                        }
                                        else if (campoDeEdicao == 4)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Funcionário receberá:");
                                            string novoEndereco = Console.ReadLine();
                                            item.endereco = novoEndereco;
                                        }
                                        else if (campoDeEdicao == 5)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual este Funcionário receberá:");
                                            string novoTurno = Console.ReadLine();
                                            item.turno = novoTurno;
                                        }
                                        else if (campoDeEdicao == 6)
                                        {
                                            Console.WriteLine("Digite o novo cargo no qual este Funcionário receberá:");
                                            Console.Write("Escreva aqui o cargo do Funcionário no qual você deseja cadastrar: ");
                                            Console.Write("\n -  [ 1] - Linha de Montagem");
                                            Console.Write("\n -  [ 2] - Estoque de peças e insumos");
                                            Console.Write("\n -  [ 3] - TI");
                                            Console.Write("\n -  [ 4] - Pátio");
                                            Console.Write("\n -  [ 5] - Engenharia");
                                            Console.Write("\n -  [ 6] - Manuntenção da Fábrica");
                                            Console.Write("\n -  [ 7] - Segurança Patrimonial");
                                            Console.Write("\n -  [ 8] - Importação e Exportação");
                                            Console.Write("\n -  [ 9] - Compras e Vendas");
                                            Console.Write("\n -  [10] - Administração Geral");
                                            int decidirNovoCargo = Convert.ToInt32(Console.ReadLine());
                                            do
                                            {
                                                Console.Clear();
                                                Console.Write("Escreva aqui o cargo do Funcionário no qual você deseja cadastrar: ");
                                                Console.Write("\n -  [ 1] - Linha de Montagem");
                                                Console.Write("\n -  [ 2] - Estoque de peças e insumos");
                                                Console.Write("\n -  [ 3] - TI");
                                                Console.Write("\n -  [ 4] - Pátio");
                                                Console.Write("\n -  [ 5] - Engenharia");
                                                Console.Write("\n -  [ 6] - Manuntenção da Fábrica");
                                                Console.Write("\n -  [ 7] - Segurança Patrimonial");
                                                Console.Write("\n -  [ 8] - Importação e Exportação");
                                                Console.Write("\n -  [ 9] - Compras e Vendas");
                                                Console.Write("\n -  [10] - Administração Geral");
                                                Console.Write("\n - Cargo Invalido, por favor, digite um cargo de acordo com a listagem acima.");
                                            } while (decidirNovoCargo < 1 && decidirNovoCargo > 10);
                                            if (decidirNovoCargo == 1)
                                            {
                                                funcionario.cargo = "Linha de Montagem";
                                            }
                                            else if (decidirNovoCargo == 2)
                                            {
                                                funcionario.cargo = "Linha de Montagem";
                                            }
                                            else if (decidirNovoCargo == 3)
                                            {
                                                funcionario.cargo = "TI";
                                            }
                                            else if (decidirNovoCargo == 4)
                                            {
                                                funcionario.cargo = "Pátio";
                                            }
                                            else if (decidirNovoCargo == 5)
                                            {
                                                funcionario.cargo = "Engenharia";
                                            }
                                            else if (decidirNovoCargo == 6)
                                            {
                                                funcionario.cargo = "Manuntenção da Fábrica";
                                            }
                                            else if (decidirNovoCargo == 7)
                                            {
                                                funcionario.cargo = "Segurança Patrimonial";
                                            }
                                            else if (decidirNovoCargo == 8)
                                            {
                                                funcionario.cargo = "Importação e Exportação";
                                            }
                                            else if (decidirNovoCargo == 9)
                                            {
                                                funcionario.cargo = "Compras e Vendas";
                                            }
                                            else if (decidirNovoCargo == 10)
                                            {
                                                funcionario.cargo = "Administração Geral";
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("CPF não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais algum Funcionário? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 3:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Carro");
                                Console.WriteLine("Digite por favor o CPF do Funcionário no qual deverá ser encontrado:");
                                string modeloDePesquisa = Console.ReadLine();
                                foreach (var item in listCarro)
                                {
                                    if (item.modelo == modeloDePesquisa)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo deste Funcionário você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Ano");
                                        Console.Write("\n -  [ 2] - Descrição do Motor");
                                        Console.Write("\n -  [ 3] - Preço");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite o novo ano no qual este Carro receberá:");
                                            int novoAnoDoCarro = Convert.ToInt32(Console.ReadLine());
                                            item.ano = novoAnoDoCarro;
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite a nova descrição na qual o motor deste Carro receberá:");
                                            string novaDescricaoDoMotor = Console.ReadLine();
                                            item.dscMotor = novaDescricaoDoMotor;
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite o novo preço no qual este carro receberá:");
                                            double novoPreco = Convert.ToDouble(Console.ReadLine());
                                            item.preco = novoPreco;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Modelo não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais algum Carro? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 4:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Peças");
                                Console.WriteLine("Digite por o nome da peça na qual deverá ser encontrado:");
                                string nomeDePesquisa = Console.ReadLine();
                                foreach (var item in listPecas)
                                {
                                    if (item.nome == nomeDePesquisa)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo deste Funcionário você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Nome");
                                        Console.Write("\n -  [ 2] - Tipo");
                                        Console.Write("\n -  [ 3] - Quantidade");
                                        Console.Write("\n -  [ 4] - Preço");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual esta Peça receberá:");
                                            string novoNomeDaPeca = Console.ReadLine();
                                            item.nome = novoNomeDaPeca;
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite o novo tipo na qual esta Peça receberá:");
                                            string novoTIpoDaPeca = Console.ReadLine();
                                            item.tipo = novoTIpoDaPeca;
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite a nova quantidade na qual esta Peça receberá:");
                                            int novaQuantidadeDePecas = Convert.ToInt32(Console.ReadLine());
                                            item.quantidade = novaQuantidadeDePecas;
                                        }
                                        else if (campoDeEdicao == 4)
                                        {
                                            Console.WriteLine("Digite o novo preço na qual esta Peça receberá:");
                                            double novaPrecoDePecas = Convert.ToDouble(Console.ReadLine());
                                            item.preco = novaPrecoDePecas;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Peça não encontrada");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais alguma Peça? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 5:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Manuntenção");
                                Console.WriteLine("Digite o codigo da Manuntenção na qual deverá ser encontrado:");
                                int codigoDaManuntencao = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in listManuntencao)
                                {
                                    if (item.codigo == codigoDaManuntencao)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo desta manuntenção você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Descrição da Manuntenção");
                                        Console.Write("\n -  [ 2] - Data");
                                        Console.Write("\n -  [ 3] - Peças");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite a nova descrição na qual esta Manuntenção receberá:");
                                            string novaDescricao = Console.ReadLine();
                                            item.dscMaintence = novaDescricao;
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite a nova data na qual esta Manuntenção receberá:");
                                            string novaData = Console.ReadLine();
                                            item.data = novaData;
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite a nova peça na qual esta Manuntenção receberá:");
                                           
                                            foreach (var item1 in listPecas)
                                            {
                                                Console.WriteLine("\nSelecione a peça que será utilizada nesta manuntenção:");
                                                for (int k = 0; k <= listPecas.Count; k++)
                                                {
                                                    Console.WriteLine("" + item1.nome);
                                                }
                                                string novoPeca = Convert.ToString(Console.ReadLine());
                                                if (item1.nome == novoPeca)
                                                {

                                                    item.nomeDaPeca = novoPeca;
                                                    manuntencao.nomeDaPeca = novoPeca;
                                                    double precoManuntencao = (item1.preco * 2);
                                                    Console.WriteLine("O preço desta manuntenção foi alterado de acordo com o preço da peça.");
                                                    manuntencao.preco = precoManuntencao;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Peça não encontrada.");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Manuntenção não encontrada");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais alguma Manuntenção? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 6:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Concessionaria");
                                Console.WriteLine("Digite o CNPJ da Concessionaria na qual deverá ser encontrado:");
                                string nomeDaConcessionaria = Console.ReadLine();
                                foreach (var item in listConcessionaria)
                                {
                                    if (item.cnpj == nomeDaConcessionaria)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo deste Funcionário você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Nome");
                                        Console.Write("\n -  [ 2] - Endereço");
                                        Console.Write("\n -  [ 3] - CNPJ");
                                        Console.Write("\n -  [ 4] - Telefone");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite o novo nome no qual esta Concessionaria receberá:");
                                            string novoNomeDaPeca = Console.ReadLine();
                                            item.nome = novoNomeDaPeca;
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite o novo endereço na qual esta Concessionaria receberá:");
                                            string novoEndereco = Console.ReadLine();
                                            item.endereco = novoEndereco;
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite o novo CNPJ na qual esta Concessionaria receberá:");
                                            string novoCNPJ = Convert.ToString(Console.ReadLine());
                                            item.cnpj = novoCNPJ;
                                        }
                                        else if (campoDeEdicao == 4)
                                        {
                                            Console.WriteLine("Digite o novo telefone na qual esta Concessionaria receberá:");
                                            string novoTelefone = Convert.ToString(Console.ReadLine());
                                            item.telefone = novoTelefone;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Concessionaria não encontrada");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais alguma Concessionaria? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;

                            case 7:
                                Console.Clear();
                                Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
                                Console.WriteLine("Edição de Vendas");
                                Console.WriteLine("Digite por favor o modelo do carro no qual a Venda esta associado e que você deseja alterar:");
                                string modeloDaVenda = Console.ReadLine();
                                foreach (var item in listVendas)
                                {
                                    if (item.modeloCarro == modeloDaVenda)
                                    {
                                        Console.WriteLine("Por favor, digite qual campo deste Funcionário você deseja alterar:");
                                        Console.Write("\n -  [ 1] - Nome da Concessionaria");
                                        Console.Write("\n -  [ 2] - Modelo do Carro");
                                        Console.Write("\n -  [ 3] - Preço da Venda");
                                        int campoDeEdicao = Convert.ToInt32(Console.ReadLine());
                                        if (campoDeEdicao == 1)
                                        {
                                            Console.WriteLine("Digite o novo nome da Concessionaria na qual esta Venda estará associada:");
                                            foreach(var item1 in listConcessionaria)
                                            {
                                                for(int f = 0; f <= listConcessionaria.Count; f++)
                                                {
                                                    Console.WriteLine("" + item1.nome);
                                                }
                                                string nomeDaConcessaria = Console.ReadLine();
                                                if (item1.nome == nomeDaConcessaria)
                                                {
                                                    item.nomeConcessionaria = nomeDaConcessaria;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Concessaria não encontrada.");
                                                }
                                            }
                                        }
                                        else if (campoDeEdicao == 2)
                                        {
                                            Console.WriteLine("Digite o novo Modelo na qual esta Venda estará associada:");
                                            foreach (var item1 in listCarro)
                                            {
                                                for (int g = 0; g <= listConcessionaria.Count; g++)
                                                {
                                                    Console.WriteLine("" + item1.modelo);
                                                }
                                                string nomeDoModelo = Console.ReadLine();
                                                if (item1.modelo == nomeDoModelo)
                                                {
                                                    item.modeloCarro = nomeDoModelo;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Concessaria não encontrada.");
                                                }
                                            }
                                        }
                                        else if (campoDeEdicao == 3)
                                        {
                                            Console.WriteLine("Digite o Modelo do carro no qual o preço estará associado a está Venda:");
                                            foreach (var item1 in listCarro)
                                            {
                                                for (int s = 0; s <= listConcessionaria.Count; s++)
                                                {
                                                    Console.WriteLine("" + item1.modelo);
                                                }
                                                string nomeDoModelo = Console.ReadLine();
                                                if (item1.modelo == nomeDoModelo)
                                                {
                                                    Console.WriteLine("Digite o novo preço deste modelo");
                                                    double precoDoCarro = Convert.ToDouble(Console.ReadLine());
                                                    if (precoDoCarro > item1.preco)
                                                    {
                                                        Console.WriteLine("Com este valor estipulado, você obterá um total de R$:" + (precoDoCarro - item1.preco) + " de lucro na venda.");
                                                        item.precoVenda = precoDoCarro;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Você não pode vender um carro com o mesmo preço ou com o preço inferior ao catalogo de fábrica.");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Modelo não encontrado.");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Modelo não encontrado");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("Você deseja editar mais alguma Venda? Digite [s] para SIM | Digite [n] para NÃO): ");
                                repetir = Convert.ToChar(Console.ReadLine());
                                if (repetir == 's' || repetir == 'S')
                                {
                                    repete = true;
                                }
                                break;
                        }
                        break;
                        #endregion
                    case 4:
                        resp = 0;
                        Console.Clear();
                        Console.WriteLine("Saida do Console \n");
                        Console.WriteLine("Obrigado por utilizar o nosso Software.");
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }

            } while (resp != 7 || (resp > 7 || resp < 1));
        }
    }

}