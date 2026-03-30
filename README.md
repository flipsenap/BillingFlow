# 💰 BillingFlow API

API de gestão de faturamento desenvolvida com .NET, focada no controle de clientes, cobranças e pagamentos.

---

## 🚀 Tecnologias utilizadas

* ASP.NET Core
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger (documentação da API)

---

## 📦 Funcionalidades

* ✅ Cadastro de clientes
* 💰 Criação de cobranças
* 💳 Registro de pagamentos
* 🔐 Autenticação com JWT
* 📊 Consulta de inadimplentes
* 🗑️ Soft delete (desativação de clientes)

---

## 🔐 Autenticação

A API utiliza autenticação via JWT para proteger os endpoints.

### 🔑 Como usar:

1. Faça login:

```http
POST /api/auth/login
```

2. Copie o token retornado

3. No Swagger, clique em **Authorize 🔐** e insira:

```
Bearer SEU_TOKEN
```

---

## ▶️ Como executar o projeto

### 📌 Pré-requisitos

* .NET 8 SDK
* SQL Server

---

### ⚙️ Passos

```bash
# Clonar o repositório
git clone https://github.com/flipsenap/BillingFlow.git

# Acessar pasta
cd BillingFlow

# Restaurar dependências
dotnet restore

# Aplicar migrations
dotnet ef database update

# Rodar API
dotnet run
```

---

## 🧪 Acessar documentação (Swagger)

Após rodar o projeto:

```
http://localhost:5000/swagger
```

---

## 📌 Estrutura do projeto

```
BillingFlow/
│
├── Controllers/   # Endpoints da API
├── Models/        # Entidades
├── Data/          # DbContext
├── Services/      # Regras de negócio
├── Migrations/    # Controle do banco
└── Program.cs     # Configuração da aplicação
```

---

## 💡 Regras de negócio

* Clientes podem ter múltiplas cobranças
* Cobranças podem ser pagas parcialmente
* Sistema identifica clientes inadimplentes
* Exclusão de clientes é feita via **soft delete**

---

## 🔥 Melhorias futuras

* 🔐 Criptografia de senha (BCrypt)
* 📊 Dashboard visual (React)
* 📈 Relatórios financeiros
* 🧪 Testes automatizados

---

## 👨‍💻 Autor

Desenvolvido por **Filipe Sena**

---

## 📌 Status do projeto

🚧 Em evolução — melhorias contínuas sendo aplicadas

---

## ⭐ Contribuição

Sinta-se à vontade para contribuir ou dar sugestões!
