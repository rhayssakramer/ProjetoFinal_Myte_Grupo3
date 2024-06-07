# ProjetoFinal_Myte_Grupo3

Uma aplica��o para o registro e gest�o de horas trabalhadas, baseada no Myte, com funcionalidades para diferentes n�veis de usu�rios, incluindo administradores e funcion�rios.

## �ndice

- [Sobre](#sobre)
- [Requisitos do Projeto](#requisitos-do-projeto)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Instala��o](#instala��o)
- [Como Usar](#como-usar)
- [Autores](#autores)

## Sobre

O Sistema de Lan�amento de Horas � uma aplica��o projetada para facilitar o registro e a gest�o de horas trabalhadas por funcion�rios. Este sistema oferece diversas funcionalidades que atendem a diferentes n�veis de usu�rios, incluindo administradores e funcion�rios.

### Funcionalidades Principais

- **Registro de Horas:** Permite que os funcion�rios registrem suas horas de trabalho de forma simples e eficiente com sua WBS especificada.
- **Dados de Usu�rio:** Permite que os usu�rios do programa gerenciem suas informa��es pessoais em uma aba dedicada.
- **Gerenciamento de Usu�rios:** Administradores podem adicionar, editar e remover usu�rios, bem como definir suas permiss�es e n�veis de acesso.
- **Gerenciamento de WBS:** Administradores podem adicionar, editar e remover WBS.
- **Relat�rios de Horas:** Gera relat�rios detalhados das horas trabalhadas por funcion�rio, departamento ou projeto.

## Requisitos do Projeto

O Sistema MYTE ("My Time Entries") foi desenvolvido para registrar horas trabalhadas em atividades espec�ficas (WBS - Work Breakdown Structure). Os principais requisitos incluem:

### Funcionalidades

- **Gerenciamento de Departamentos:**
  - Criar, recuperar, atualizar e excluir registros de departamentos.
  - Adicionar e listar departamentos, com filtragem por nome ou ID.

- **Gerenciamento de Funcion�rios:**
  - Criar, recuperar, atualizar e excluir registros de funcion�rios.
  - Cada registro cont�m id, nome, departamento e data de contrata��o.

- **Login:**
  - Permitir que usu�rios fa�am login para acessar as funcionalidades do sistema.

- **Cria��o e Manuten��o de WBS:**
  - Criar, editar e excluir WBS.
  - Visualizar lista de WBS, com valida��es de c�digo e descri��o.

- **Registro de Horas:**
  - Permitir que funcion�rios registrem horas trabalhadas em atividades espec�ficas.
  - Interface com linhas representando WBS e colunas representando dias da quinzena.
  - Valida��o de horas m�nimas por dia �til e visualiza��o do total de horas.

- **Navega��o entre Quinzenas:**
  - Permitir navega��o entre quinzenas para registrar horas de per�odos anteriores ou futuros.

- **Relat�rios:**
  - Relat�rios no Power BI com an�lise das WBS com maior n�mero de horas registradas.
  - Visualiza��o gr�fica e filtragem por per�odo de tempo.

### Fluxos Principais

1. **Login:** Autentica��o de usu�rios com redirecionamento ap�s sucesso.
2. **Gerenciamento de WBS:** CRUD de WBS com valida��es de c�digo e descri��o.
3. **Registro de Horas:** Interface intuitiva para registro de horas, com valida��es.
4. **Navega��o entre Quinzenas:** Navega��o para quinzenas anteriores e futuras.
5. **Relat�rios:** Gera��o de relat�rios detalhados no Power BI.

## Tecnologias Utilizadas

### Linguagens de Programa��o

<div align="center">

| ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) |
|---|

</div>

### Ferramentas e Tecnologias

<div align="center">

| ![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_MVC-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white) | ![Identity](https://img.shields.io/badge/Identity-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white) | ![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white) |
|---|---|---|

</div>

## Instala��o

Siga as instru��es abaixo para configurar e executar o projeto localmente.

1. **Clone o reposit�rio:**
   ```bash
   git clone https://github.com/seu-usuario/ProjetoFinal_Myte_Grupo3.git
   cd ProjetoFinal_Myte_Grupo3

2.Abra o Visual Studio, carregue o projeto e restaure as depend�ncias.

3.Configure o banco de dados:
Update-Database

4.Execute o projeto:
Pressione F5 ou clique em "Iniciar" no Visual Studio.

## Como Usar
Login:
Acesse a aplica��o e fa�a login com suas credenciais.

Gerenciamento de Departamentos:
Navegue at� a se��o de departamentos para criar, editar ou excluir registros.

Gerenciamento de Funcion�rios:
Adicione, edite ou remova funcion�rios e atribua-os a departamentos espec�ficos.

Registro de Horas:
Navegue at� a tela de registro de horas para inserir as horas trabalhadas nas WBS apropriadas.

Relat�rios:
Acesse a se��o de relat�rios para visualizar e analisar as horas trabalhadas por funcion�rio, departamento ou projeto.

## Autores

Rhayssa Kramer Bezerra de�Melo
Leila Mirelle da Silva Vasconcelos
Yuri Henrique Da Silva
Caetano Mesquita Londres Barreto
Beatriz Mozer Arag�o