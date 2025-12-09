# 📘 API de Disciplinas

Este projeto foi desenvolvido como parte da **Prova Prática – Desenvolvimento de API REST com Swagger + Banco de Dados**. O objetivo principal é demonstrar a criação de uma API REST completa, documentada, organizada e com persistência de dados.

---

## ✨ **Objetivos Atendidos**

* ✔ Criar um projeto de **API REST** com Controllers
* ✔ Documentar a API utilizando **Swagger**
* ✔ Implementar um **CRUD completo** (Create, Read, Update, Delete)
* ✔ Criar e aplicar **Migrations com Entity Framework Core**
* ✔ Persistir dados em **SQL Server**
* ✔ Seguir boas práticas de organização

---

## 🏗 **Tecnologias Utilizadas**

* **.NET 6**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **SQL Server**
* **Swagger / Swashbuckle**

---

## 📦 **Instalação e Configuração**

### 🔹 1. Clonar o repositório

```bash
git clone <url-do-repositorio>
cd DisciplinasApi
```

### 🔹 2. Restaurar dependências

```bash
dotnet restore
```

### 🔹 3. Configurar o banco de dados

No arquivo **appsettings.json**, configure sua conexão:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=DisciplinasDb;Trusted_Connection=True;Encrypt=False;"
}
```

### 🔹 4. Aplicar migrations

```bash
dotnet ef database update
```

---

## 📚 **Estrutura do Projeto**

```
DisciplinasApi/
├── Controllers/
│   └── DisciplinasController.cs
├── Models/
│   └── Disciplina.cs
├── Data/
│   └── AppDbContext.cs
├── Program.cs
└── appsettings.json
```

---

## 🧪 **Endpoints da API**

![swagger](https://github.com/user-attachments/assets/8a16c6b9-6007-42a1-bb41-c7907cb13396)

Todos os endpoints estão documentados automaticamente no Swagger.

### 📍 **GET /api/disciplinas**

Retorna todas as disciplinas.

### 📍 **GET /api/disciplinas/{id}**

Retorna uma disciplina específica.

### 📍 **POST /api/disciplinas**

Cria uma nova disciplina.

Exemplo de JSON:

```json
{
  "nome": "Programação Web",
  "professor": "Maria Souza",
  "cargaHoraria": 80
}
```

### 📍 **PUT /api/disciplinas/{id}**

Atualiza uma disciplina existente.

### 📍 **DELETE /api/disciplinas/{id}**

Remove uma disciplina do sistema.

---

## 🧰 **Como Executar o Projeto**

```bash
dotnet run
```

Acesse o Swagger em:

➡ [http://localhost:5062/swagger](http://localhost:5062/swagger)

---

## 🗄 **Inserindo Dados no SQL Server**

```sql
INSERT INTO Disciplinas (Nome, Professor, CargaHoraria)
VALUES ('Matemática', 'João Silva', 60);
```
![print_bd](https://github.com/user-attachments/assets/525d9a04-dc93-4c0a-ab73-4cb7265caea6)
![print_update](https://github.com/user-attachments/assets/820d2848-d7ed-4b45-a85b-7af02fca2e66)

---

## ✔ **Conformidade com os requisitos da prova**

| Requisito             | Atendido |
| --------------------- | -------- |
| API REST funcionando  | ✔        |
| Swagger configurado   | ✔        |
| CRUD completo         | ✔        |
| Migrations + EF       | ✔        |
| Banco SQL Server      | ✔        |
| Organização do código | ✔        |

---

## 👩‍💻 **Autor**

*Caroline — FATEC Matão*

---

Se quiser adicionar prints, explicações mais detalhadas ou diagrama de classes, posso incluir também!
