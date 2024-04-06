# Welcome API

Bem-vindo à Welcome API! Esta API foi desenvolvida em .NET 8 e possui o objetivo de fornecer um único endpoint para retornar uma mensagem aleatória de boas-vindas.

## Funcionalidades

- **Welcome Endpoint:** O endpoint `/welcome` retorna uma mensagem aleatória de boas-vindas.

## Tecnologias Utilizadas

- **Linguagem de Programação:** C# (.NET 8)
- **Framework:** ASP.NET Core
- **Padrão de Arquitetura:** DDD (Domain-Driven Design)
- **Princípios SOLID:** Aplicados
- **Testes Unitários:** Implementados com xUnit
- **Injeção de Dependência:** Utilizada para a gestão de dependências
- **Logging:** Implementado para registrar informações relevantes
- **Swagger:** Documentação automática da API

## Configuração do Projeto

1. **Clone o Repositório:** `git clone https://github.com/seu-usuario/welcome-api.git`
2. **Acesse o Diretório:** `cd welcome-api`
3. **Restaure as Dependências:** `dotnet restore`
4. **Execute o Projeto:** `dotnet run`
5. **Acesse a API:** Abra o navegador e acesse `https://localhost:5001/welcome`

## Como Usar

Para usar a API, basta acessar o endpoint `/welcome`. Você receberá uma mensagem de boas-vindas aleatória.

Exemplo de uso:

```http
GET https://localhost:5001/welcome
```

Resposta:

```json
{
  "message": "Bem-vindo! Esperamos que tenha uma excelente experiência com nossa API."
}
```

## Testes

A API possui testes unitários implementados com xUnit. Para executar os testes, utilize o comando:

```bash
dotnet test
```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](https://github.com/seu-usuario/welcome-api/blob/main/LICENSE).

---

Se tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato! 😊
