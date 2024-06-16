/*
 * Created by SharpDevelop.
 * User: othon
 * Date: 24/05/2024
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabalhos
{
    struct Paciente
    {
    // Struct para ficha de pacientes
    public string nome;
    public string cpf;
    public string email;
    public string planoSaude;
}

	class Program
	{
    // Declaração de um array para armazenar até 100 pacientes
    static Paciente[] pacientes = new Paciente[100];
    // Contador para manter o controle do número de pacientes cadastrados
    static int pacienteCount = 0;
    // Variável para armazenar o nome do paciente logado
    static string pacienteLogado = "";

    static void Main(string[] args)
    {
        //tela inicial
        Console.WriteLine("========================================================================================================================");
        Console.WriteLine("|                                   SEJA BEM-VINDO A CLÌNICA SAÙDE E BEM ESTAR !!!                                     |");
        Console.WriteLine("========================================================================================================================");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Pressione qualquer tecla para continuar . . . ");
        Console.ReadKey(true);
        Console.Clear();

        //chamando o menu principal
        MenuPrincipal();
    }

	    //definição do menu principal
	    static void MenuPrincipal()
    {
        inicio:
        Console.Clear();
        // Marcador para o início do menu principal
        Console.Clear();
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Médico");
        Console.WriteLine("2 - Paciente");
        Console.WriteLine("3 - Registro");
        int perfil;
        //validar se a entrada do usuário pode ser convertida em um número inteiro.
        if (!int.TryParse(Console.ReadLine(), out perfil))
        {
            Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
            goto inicio; // Retorna ao início do menu principal
        }

        Console.Clear();
		//Inicializando o switch do MP
		
        switch (perfil)
        {
            case 1:
                MenuMedico();
                break;
            case 2:
                CadastroPaciente();
                TelaDeLogin();
                break;
            case 3:
                //Ficha do pacente para o registro
                   Console.WriteLine("==================================================Fichas de Pacientes==================================================");

	        if (pacienteCount == 0)
	        {
	            Console.WriteLine("Nenhum paciente cadastrado.");
	        }
	        else
	        {
	            for (int i = 0; i < pacienteCount; i++)
	            {
	            //Saída do registro	
	                Console.WriteLine("Nome: " + pacientes[i].nome);
	                Console.WriteLine("CPF: " + pacientes[i].cpf);
	                Console.WriteLine("E-mail: " + pacientes[i].email);
	                Console.WriteLine("Plano de Saúde: " + pacientes[i].planoSaude); // plano de sáude por string
	                Console.WriteLine("Motivos de Consultas anteriores: xxxxxx");
	                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
	            }
	        }
	                Console.WriteLine("Pressione qualquer tecla para continuar . . . ");
	                Console.ReadKey(true);
	                break;
	            default:
	                Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar . . . ");
	                Console.ReadKey(true);
	                goto inicio; // Retorna ao início do menu principal
	        }
	
	        goto inicio; // Retorna ao início do menu principal após o fluxo principal
	    }
		    	    	
	    static void MenuMedico()
	    {
	        menuMedico: // Marcador para o início do menu do médico
	        Console.Clear();
	        Console.WriteLine("=======================================================================================================================");
	        Console.WriteLine("|                                                Menu do Médico                                                       |");
	        Console.WriteLine("=======================================================================================================================");
	        Console.WriteLine("|1 - Consultas do Dia                                                                                                 |");
	        Console.WriteLine("|2 - Exames                                                                                                           |");
	        Console.WriteLine("|3 - Sair                                                                                                             |");
	        Console.WriteLine("=======================================================================================================================");
	        Console.Write("Escolha uma opção: ");
	        int opcao;
	        
        if (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
            goto menuMedico; // Retorna ao início do menu do médico
        }

        switch (opcao)
        {
            case 1:
                ConsultasDoDia();
                break;
            case 2:
                Exames();
                break;
            case 3:
                Console.Clear();
                goto fim; // Sai do menu do médico e retorna ao menu principal
                
            default:
                Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar . . . ");
                Console.ReadKey(true);
                goto menuMedico; // Retorna ao início do menu do médico
        }

	        goto menuMedico; // Retorna ao início do menu do médico após as operações
	       fim:
	        return; // Marca o fim do menu do médico e retorna ao menu principal
	    }
	    	
						
        //Incrementação de vetores
        //PR para ConsultasDoDia 
		    static void ConsultasDoDia()
		    {
		        string[] pacientes = {
		            "Ana Silva",
		            "Carlos Souza",
		            "Mariana Silva",
		            "José Santos",
		            "Paula Almeida",
		            "João Pereira",
		            "Clara Costa",
		            "Ricardo Lopes",
		            "Fernanda Lima",
		            "Miguel Ferreira"
		        };
		
		        string[] motivos = {
		            "Dor de cabeça",
		            "Check-up anual",
		            "Dor abdominal",
		            "Febre",
		            "Dor no peito",
		            "Consulta de rotina",
		            "Dor nas costas",
		            "Alergia",
		            "Insônia",
		            "Tosse persistente"
		        };
				//Uso do new
		        DateTime horarioInicial = new DateTime(1, 1, 1, 7, 0, 0); // 7:00 AM
		
		        Console.Clear();
		        Console.WriteLine("|================================================Consultas do Dia=====================================================|");
		        Console.WriteLine("| Hora   | Paciente          | Motivo da Consulta                                                                     |");
		        Console.WriteLine("|=====================================================================================================================|");
		        
		        for (int i = 0; i < pacientes.Length; i++)
		        {
		        	//1 - ToShortTimeString() - transforma data e hora para uma string.
		        	//2 - Exibe o nome do paciente com uma largura mínima de 15 caracteres, alinhado à esquerda.
		        	//3 - Exibe o motivo da consulta com uma largura mínima de 30 caracteres, alinhado à esquerda.
		        	
		            Console.WriteLine("| " + horarioInicial.ToShortTimeString() + " | " + pacientes[i].PadRight(15) + " | " + motivos[i].PadRight(80) + " |");
		            horarioInicial = horarioInicial.AddMinutes(20); // Incrementa 20 minutos para cada paciente
		        }
		        
		        Console.WriteLine("=======================================================================================================================");
		        Console.Write("Pressione qualquer tecla para voltar ao menu do médico . . . ");
		        Console.ReadKey(true);
		    }

			    // PR para exames
		         static void Exames()
		    {
		        Console.Clear();
		        Console.WriteLine("======================================================Exames==========================================================");
		        Console.WriteLine("Lista de Exames Disponíveis:");
		        Console.WriteLine("1 - Exame de Sangue");
		        Console.WriteLine("2 - Raio-X");
		        Console.WriteLine("3 - Ecocardiograma");
		        Console.WriteLine("4 - Endoscopia");
		        Console.WriteLine("5 - Ressonância Magnética");
		        Console.WriteLine("6 - Tomografia Computadorizada");
		        Console.WriteLine("7 - Eletrocardiograma");
		        Console.WriteLine("0 - Voltar ao Menu Principal");
		        Console.Write("Escolha um exame para ver mais detalhes (digite o número): ");
		        int opcao = int.Parse(Console.ReadLine());
		        Console.Clear();

        switch (opcao)
        {
        	  //iniciando os switch de exames DENTRO DO MENU MÈDICO
            case 1:
                Console.WriteLine("Detalhes do Exame de Sangue:");
                Console.WriteLine("Descrição: Exame para análise do sangue");
                Console.WriteLine("Instruções preparatórias: Jejum de 8 horas");
                Console.WriteLine("Duração estimada: 10 minutos");
                break;
            case 2:
                Console.WriteLine("Detalhes do Raio-X:");
                Console.WriteLine("Descrição: Exame de imagem para visualizar ossos e tecidos");
                Console.WriteLine("Instruções preparatórias: Sem preparação especial");
                Console.WriteLine("Duração estimada: 15 minutos");
                break;
            case 3:
                Console.WriteLine("Detalhes do Ecocardiograma:");
                Console.WriteLine("Descrição: Exame de ultrassom do coração");
                Console.WriteLine("Instruções preparatórias: Não é necessário preparo");
                Console.WriteLine("Duração estimada: 30 minutos");
                break;
            case 4:
                Console.WriteLine("Detalhes da Endoscopia:");
                Console.WriteLine("Descrição: Exame visual do interior do trato digestivo");
                Console.WriteLine("Instruções preparatórias: Jejum de 6 horas");
                Console.WriteLine("Duração estimada: 1 hora");
                break;
            case 5:
                Console.WriteLine("Detalhes da Ressonância Magnética:");
                Console.WriteLine("Descrição: Exame de imagem para visualizar estruturas internas do corpo");
                Console.WriteLine("Instruções preparatórias: Sem preparação especial");
                Console.WriteLine("Duração estimada: 45 minutos");
                break;
            case 6:
                Console.WriteLine("Detalhes da Tomografia Computadorizada:");
                Console.WriteLine("Descrição: Exame de imagem para visualizar estruturas internas do corpo em camadas");
                Console.WriteLine("Instruções preparatórias: Sem preparação especial");
                Console.WriteLine("Duração estimada: 20 minutos");
                break;
            case 7:
                Console.WriteLine("Detalhes do Eletrocardiograma:");
                Console.WriteLine("Descrição: Exame para registrar a atividade elétrica do coração");
                Console.WriteLine("Instruções preparatórias: Sem preparação especial");
                Console.WriteLine("Duração estimada: 5 minutos");
                break;
            case 0:
                // Voltar ao menu principal
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.Write("Pressione qualquer tecla para voltar ao menu do médico . . . ");
        Console.ReadKey(true);
    }


        static void CadastroPaciente()
	{
	    //cadastro do paciente usando (paciente.)
	    if (pacienteCount >= pacientes.Length)
	    {
	        Console.WriteLine("Limite de pacientes cadastrados atingido.");
	        return;
	    }
	
	    Console.WriteLine("================================================Pré Cadastro==========================================================");

            Paciente paciente;

            Console.WriteLine("Digite seu nome:");
            paciente.nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite seu CPF:");
            paciente.cpf = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Digite seu e-mail:");
            paciente.email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Informe qual é o seu plano de saúde dentre as opções abaixo:");
            Console.WriteLine("|1 - Unimed                                                |");
            Console.WriteLine("|2 - Amil                                                  |");
            Console.WriteLine("|3 - GNDI (Grupo Notredame Intermédica)                    |");
            Console.WriteLine("|4 - SulAmérica                                            |");
            Console.WriteLine("|5 - Bradesco saúde                                        |");
            Console.WriteLine("|6 - One Health                                            |");

            int planoSaudeOption;
            if (!int.TryParse(Console.ReadLine(), out planoSaudeOption) || planoSaudeOption < 1 || planoSaudeOption > 6)
            {
                Console.WriteLine("Opção de plano de saúde inválida.");
                Console.WriteLine("Pressione qualquer tecla para continuar . . . ");
                Console.ReadKey(true);
                Console.Clear();
                return;
            }

            // Armazenar o nome do plano de saúde correspondente à opção escolhida
            switch (planoSaudeOption)
            {
                case 1:
                    paciente.planoSaude = "Unimed";
                    break;
                case 2:
                    paciente.planoSaude = "Amil";
                    break;
                case 3:
                    paciente.planoSaude = "GNDI (Grupo Notredame Intermédica)";
                    break;
                case 4:
                    paciente.planoSaude = "SulAmérica";
                    break;
                case 5:
                    paciente.planoSaude = "Bradesco saúde";
                    break;
                case 6:
                    paciente.planoSaude = "One Health";
                    break;
                default:
                    paciente.planoSaude = "Plano não especificado";
                    break;
            }

            // Adiciona o paciente ao array
            pacientes[pacienteCount] = paciente;

            // Incrementa o contador de pacientes
            pacienteCount++;

            // Mensagem de cadastro concluído
            Console.Clear();
            Console.WriteLine("=========================================Cadastro concluído com sucesso!==============================================");
            Console.Write("Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
            Console.Clear();

            // Pergunta ao usuário se deseja cadastrar outro paciente
            Console.WriteLine("Deseja cadastrar outro paciente? (s/n)");
            string resposta = Console.ReadLine().Trim().ToLower();
            Console.Clear();

            // Se a resposta for 's', chama CadastroPaciente novamente, caso contrário chama TelaDeLogin
            if (resposta == "s")
            {
                CadastroPaciente();
            }
            else
            {
                // Redireciona para a tela de login após o cadastro
                TelaDeLogin();
            }
        }

        static void TelaDeLogin()
        {
            Console.Clear();
            Console.WriteLine("================================================= Login de Paciente ====================================================");

            while (true)
            {
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Digite seu CPF:");
                string cpf = Console.ReadLine();
                Console.Clear();

                bool encontrado = false;

                for (int i = 0; i < pacienteCount; i++)
                {
                    if (pacientes[i].cpf == cpf && pacientes[i].nome == nome)
                    {
                        pacienteLogado = pacientes[i].nome;  // Definindo a variável pacienteLogado com o nome do paciente logado
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine("Login realizado com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para continuar . . . ");
                    Console.ReadKey(true);
                    MenuPaciente();
                    break;
                }
                else
                {
                    Console.WriteLine("Nome ou CPF incorretos. Tente novamente.");
                    Console.WriteLine("Pressione qualquer tecla para continuar . . . ");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }
        	
  

        static void MenuPaciente()
        {
            int opcao;
             do
            {
             	
            	Console.Clear();
                Console.WriteLine("============================================================================================================");
                Console.WriteLine("|                                         Menu de Opções                                                   |");
                Console.WriteLine("============================================================================================================");
                Console.WriteLine("|1 - Orçamento                                                                                             |");
                Console.WriteLine("|2 - Fale conosco                                                                                          |");
                Console.WriteLine("|3 - Dúvidas frequentes                                                                                    |");
                Console.WriteLine("|4 - Sobre                                                                                                 |");
                Console.WriteLine("|5 - Agendamentos                                                                                          |"); 
           		Console.WriteLine("|6 - Resultado de exames                                                                                   |");
                Console.WriteLine("|7 - Atendimentos                                                                                          |");
                Console.WriteLine("|8 - Sair                                                                                                  |");
                Console.WriteLine("|9 - Voltar para o menu principal                                                                          |");
                Console.WriteLine("============================================================================================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
				Console.Clear();
                switch (opcao)
                {
                	//Iniciando switch para o menu o	
                    case 1:
                		Orcamento();
                        Console.WriteLine("Opção de Orçamento selecionada.");
                        break;
                    case 2:
                        Console.WriteLine("|===========================================================================================================|");
                        Console.WriteLine("|                                       Fale com a gente.                                                   |");
                        Console.WriteLine("|===========================================================================================================|");
                        Console.WriteLine("|1 - Chat on-line                                                                                           |");
		                Console.WriteLine("|2 - Fale conosco via e-mail                                                                                |");
		                Console.WriteLine("|3 - Telefone Clínica Saúde e Bem Estar                                                                     |");
		                Console.WriteLine("|4 - Ouvidoria                                                                                              |");
		                Console.WriteLine("|5 - SAC - Deficientes auditivos ou de fala                                                                 |");
		                Console.WriteLine("|6 - Canal Confidencial                                                                                     |");
		                Console.WriteLine("|7 - SAC - Clínica Saúde e Bem estar                                                                        |");
		                Console.WriteLine("|8 - Sala de imprensa                                                                                       |");	 
						Console.WriteLine("|===========================================================================================================|");		                
                        break;
                    case 3:
                        Console.WriteLine("|==============================================================================|");
                        Console.WriteLine("|                           Dúvidas frequentes                                 |");
                        Console.WriteLine("|==============================================================================|");
                        Console.WriteLine("|1 - Pronto Atendimento                                                        |");
                        Console.WriteLine("|2 - Internação e cirurgia                                                     |");
                        Console.WriteLine("|3 - Guia Médico                                                               |");
                        Console.WriteLine("|4 - Ambulâcia                                                                 |");
                        Console.WriteLine("|5 - Carteirinha do plano                                                      |");
                        Console.WriteLine("|6 - Programs de atenção à saúde                                               |");
                        Console.WriteLine("|==============================================================================|");
                        break;
                    case 4:
                        Sobre();
                        break;
                    case 5:
                        Agendamentos();
                        break;
                    case 6:
                        ResultadoExames();
                        break;
                    case 7:
                        Atendimentos();
                        break;
                    case 8:
                        Console.WriteLine("Saindo do Menu de Opções...");
                        break;
                    case 9:
                        MenuPrincipal();
                        break; 
					                        
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente...");
                        EsperarTecla();
                        break;
                }

                if (opcao != 8)
                {
                    EsperarTecla();
                }

            } while (opcao != 8);
        }

        static void Sobre()
        	//PR Sobre
        {
            Console.Clear();
            Console.WriteLine("=================================================================================================================");
            Console.WriteLine("|                                              Sobre a Clínica                                                  |");
            Console.WriteLine("=================================================================================================================");
            Console.WriteLine("Nossa clínica oferece uma ampla gama de serviços médicos, incluindo consultas, exames laboratoriais e de imagem, ");
            Console.WriteLine("e atendimento de alta qualidade por profissionais experientes. Estamos comprometidos com a saúde e o bem-estar ");
            Console.WriteLine("dos nossos pacientes, proporcionando um ambiente acolhedor e seguro.");
            Console.WriteLine();
            Console.WriteLine("Endereço: Rua da Saúde, 123 - Centro, Belo Horizonte - MG");
            Console.WriteLine("Telefone: (31) 3514-7000");
            Console.WriteLine("Horário de funcionamento: Segunda a Sexta, das 8h às 18h");
            Console.WriteLine();
            Console.WriteLine("Para mais informações, visite nosso site: www.clinicabemestar.com.br ou entre em contato pelo número de telefone \n(31) 3514-7000");
            Console.WriteLine("|================================================================================================================|");
        }
			
	       static void Orcamento()
	       	//PR Orçamento
		{
	       	//Vetor para exames 
		    string[] exames = {
	        "Hemograma",
	        "Colesterol",
	        "Ureia e Creatinina",
	        "Papanicolau",
	        "Exames de urina",
	        "Exames de fezes",
	        "Glicemia",
	        "Transaminases (ALT e AST) ou TGP e TGO",
	        "TSH e T4 livre",
	        "Ecocardiograma",
	        "Ultrassom",
	        "Ressonância Magnética",
	        "Radiografia",
	        "Eletrocardiograma",
	        "Tomografia Computadorizada"
	    };
			//Vetor para o preço de cada exame
	    decimal[] precos = {
	        80.00m,
	        100.00m,
	        120.00m,
	        50.00m,
	        70.00m,
	        60.00m,
	        90.00m,
	        110.00m,
	        130.00m,
	        250.00m,
	        200.00m,
	        400.00m,
	        150.00m,
	        180.00m,
	        350.00m
	    };
		//Chamando o vetor string e decimal
	    string[] examesEscolhidos = new string[exames.Length];
	    decimal[] precosEscolhidos = new decimal[precos.Length];
	    int contador = 0;
	    decimal total = 0.0m;	

    while (true)
    {
	    	//Iniciando tabela de preços
	        Console.Clear();
	        Console.WriteLine("=============================================== Tabela de Preços =====================================================");
	        Console.WriteLine("Selecione o exame ou procedimento desejado pelo número correspondente:");
	        for (int i = 0; i < exames.Length; i++)
	        {
	            Console.WriteLine((i + 1) + " - " + exames[i] + " - R$ " + precos[i].ToString("F2")); // Formatando preços para mostrar duas casas decimais
	        }
	        Console.WriteLine("0 - Concluir");
	
	        Console.Write("Digite o número do exame ou procedimento desejado: ");
	        string escolha = Console.ReadLine();

        if (escolha == "0")
        {
        	//Saida do orçamento
            Console.Clear();
            Console.WriteLine("                                                                                                           __________ ");
            Console.WriteLine("                                                                                                          |06/06/2024|");
            Console.WriteLine("|Endereço : Rua da Saúde, 123 - Centro, Belo Horizonte - MG|");
            Console.WriteLine("|Telefone : (31) 3514-7000|");
            Console.WriteLine("|Cliente  : " + pacienteLogado); // Mostrar o nome do paciente logado
            Console.WriteLine("=============================================== Resumo do Orçamento ==================================================");
            Console.WriteLine("Exames Selecionados:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(examesEscolhidos[i] + " - R$ " + precosEscolhidos[i].ToString("F2"));
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2")); // Formatando o preço total para mostrar duas casas decimais
            Console.Write("Pressione qualquer tecla para voltar ao menu de opções . . . ");
            Console.ReadKey(true);
            break;
        }

        int indice;
        if (int.TryParse(escolha, out indice) && indice >= 1 && indice <= exames.Length)
        {
        	//Iniciando contador
            examesEscolhidos[contador] = exames[indice - 1];
            precosEscolhidos[contador] = precos[indice - 1];
            total += precos[indice - 1];
            contador++;
        }
        else
        {
            Console.WriteLine("Escolha inválida! Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey(true);
        }
    }
}
              
        static void Agendamentos()
        	//PR Agendamentos
        {
            Console.Clear();
			Console.WriteLine("Informe a data e horário que você quer fazer sua consulta:");
			Console.Write("Data (dd/mm/aaaa): ");
			string data = Console.ReadLine();
			Console.Write("Horário (hh:mm): ");
			string horario = Console.ReadLine();
			Console.WriteLine("Motivo da consulta:");
			string motivo = Console.ReadLine(); 
			Console.WriteLine("Consulta agendada para " + data + " às " + horario + " com o motivo: " + motivo + " com o médico Dr. José com especialidade em Clínico Geral, Pediatra, Cardiologista, Dermatologista, Ortopedista: ");
			Console.WriteLine("Para mais informações entre em contato com a gente pelo número (31) 3514-7000");
        }

        static void ResultadoExames()
        	//PR ResultadoExames
        {
            Console.Clear();
            Console.WriteLine("Qual exame que voçê realizou?");
            string Rexame = Console.ReadLine();
            Console.WriteLine("Seu exame de " + Rexame + " está pronto.");
            Console.WriteLine("Local da realização: Laboratório de Análises Clínicas - Rua JK, 456");
            Console.WriteLine("Hemograma Valores encontrados:");
            Console.WriteLine("Eritrócito --- 4,63 . 10^6 /mm³");
            Console.WriteLine("Plaquetas --- 87 mil/mm³");
            Console.WriteLine("Leucócitos totais --- 6,04 mil/mm³");
            Console.WriteLine("Neutrófilos --- 3,18 mil/mm³");
            Console.WriteLine("Basófilo --- 0,05 mil/mm³");
            Console.WriteLine("Monócitos --- 0,23 mil/mm³");
            Console.WriteLine("Linfócitos típicos --- 2,42 mil/mm³");
            Console.WriteLine("Para mais informações entre em contato com a gente pelo número (31) 3514-7000");
        }

        static void Atendimentos()
        	//PR Atendimentos
        {
            Console.Clear();
            Console.WriteLine("|                                                Atendimentos                                                      |");
            Console.WriteLine("Nossas unidades estão localizadas nos seguintes endereços:");   
            Console.WriteLine("Laboratório de Análises Clínicas e Posto de Coleta\nRua Rio de Janeiro, 471\nCentro\nBelo Horizonte\n(31) 3514-7000");
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine("Unidade Lourdes\nRua São Paulo, 267\nLourdes\nBelo Horizonte\n(31) 3514-7000");
        }

        static void EsperarTecla()
               	
        {
            Console.Write("Pressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
                
            