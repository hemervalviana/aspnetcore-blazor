# ScreenSound - Blazor WebAssembly + ASP.NET Core API

Projeto desenvolvido com **Blazor WebAssembly** no frontend e **ASP.NET Core Web API** no backend, utilizando arquitetura em camadas e compartilhamento de modelos.

---

## 📌 Tecnologias Utilizadas

- .NET 9
- ASP.NET Core Web API
- Blazor WebAssembly
- C#
- Entity Framework Core
- SQL Server (ou outro compatível)
- Minimal APIs
- Migrations

---

## 📁 Estrutura do Projeto

ScreenSoud.WebAssembly → Frontend (Blazor WASM)
ScreenSound.API → Backend (Web API)
ScreenSound.Shared.Dados → Camada de dados
ScreenSound.Shared.Modelos → Models e DTOs


### Descrição das Camadas

- **WebAssembly**: Interface do usuário
- **API**: Exposição de endpoints e regras de negócio
- **Shared.Dados**: Acesso ao banco de dados
- **Shared.Modelos**: Entidades, requests e responses

---

## 🚀 Funcionalidades

- Interface web em Blazor WebAssembly
- API REST com ASP.NET Core
- Persistência com Entity Framework Core
- Comunicação frontend ↔ backend via HTTP
- Estrutura modularizada
- Migrations para versionamento do banco

---

## ⚙️ Pré-requisitos

Antes de executar o projeto, instale:

- .NET SDK 9
- Visual Studio 2022+ ou VS Code
- SQL Server (ou outro banco configurado)
- Git

---

## ▶️ Como Executar o Projeto

### 1️⃣ Clonar o repositório

```bash
git clone https://github.com/hemervalviana/aspnetcore-blazor.git
cd aspnetcore-blazor

