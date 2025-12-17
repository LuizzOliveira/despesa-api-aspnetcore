# 💰 despesa-api-aspnetcore | API de Gerenciamento de Despesas

## Visão Geral

Esta é a API RESTful principal para o sistema de controle de despesas **Despesa Manager**. O projeto foi desenvolvido em ASP.NET Core e segue os princípios de **Clean Architecture** (Arquitetura Limpa) com o padrão Repository e Injeção de Dependência, garantindo alta coesão, baixo acoplamento e um sistema facilmente testável e escalável.

## 🚀 Tecnologias Utilizadas

| Categoria | Tecnologia | Versão |
| :--- | :--- | :--- |
| Linguagem | C# | .NET 8 (ou sua versão) |
| Framework | ASP.NET Core | |
| Banco de Dados | PostgreSQL | Docker |
| ORM | Entity Framework Core (EF Core) | |
| Arquitetura | Clean Architecture (Camadas) | |

## 📐 Estrutura do Projeto (Clean Architecture)

O projeto é dividido em quatro camadas principais para isolar as preocupações e garantir a **Inversão de Dependência**: 

1.  **`MeuProjeto.Domain`**: O núcleo. Contém apenas os modelos de dados (`Despesa.cs`).
2.  **`MeuProjeto.Application`**: Contém a lógica de negócio (Services) e as Interfaces de Repositório/Serviço.
3.  **`MeuProjeto.Infrastructure`**: Contém a implementação dos Repositórios (acesso a dados) e a configuração do EF Core + PostgreSQL.
4.  **`MeuProjeto.Api`**: A camada de entrada. Contém os Controllers, configura a Injeção de Dependência (DI) e expõe a documentação Swagger/OpenAPI.

## ⚙️ Configuração e Setup

### Pré-requisitos

* .NET SDK (versão compatível com o projeto).
* Docker (para rodar o PostgreSQL).
* Visual Studio ou VS Code.

### 1. Configurar o PostgreSQL via Docker

Inicie o container do PostgreSQL:

```bash
docker run --name despesa-postgres -e POSTGRES_PASSWORD=sua_senha_secreta -p 5432:5432 -d postgres
