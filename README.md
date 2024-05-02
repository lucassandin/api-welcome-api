# Welcome API

Welcome to the Welcome API! This API was developed in .NET 8 and aims to provide a single endpoint to return a random welcome message.

## Features

- **Welcome Endpoint:** The `/welcome/random` endpoint returns a random welcome message.

## Technologies Used

- **Programming Language:** C# (.NET 8)
- **Framework:** .NET 8
- **Architecture Pattern:** DDD (Domain-Driven Design)
- **SOLID Principles:** Applied
- **Unit Tests:** Implemented with xUnit
- **Dependency Injection:** Used for dependency management
- **Logging:** Implemented to log relevant information
- **Swagger:** Automatic API documentation

## Project Setup

1. **Clone the Repository:** `git clone git@github.com:lucassandin/api.welcome.github.io.git`
2. **Access the Directory:** `cd api.welcome.github.io`
3. **Restore Dependencies:** `dotnet restore`
4. **Run the Project:** `dotnet run`
5. **Access the API:** Open your browser and access `https://localhost:5001/swagger/index.html`

## How to Use

To use the API, simply access the `/swagger/index.html` endpoint. You will receive a random welcome message.

Example usage:

```http
GET https://localhost:5001/swagger/index.html
```

Resposta:

```json
{
  "message": "Welcome! We hope you have an excellent experience with our API."
}
```

## Testing

The API has unit tests implemented with xUnit. To run the tests, use the command:

```bash
dotnet test
```

## Usage HELM

[Helm](https://helm.sh) must be installed to use the charts. Please refer to
Helm's [documentation](https://helm.sh/docs) to get started.

Once Helm has been set up correctly, add the repo as follows:

helm repo add welcome-api https://github.com/lucassandin/api.welcome.github.io/charts

If you had already added this repo earlier, run `helm repo update` to retrieve
the latest versions of the packages. You can then run `helm search repo
welcome-api` to see the charts.

To install the welcome-api chart:

    helm install welcome-api welcome-api/welcome-api

To uninstall the chart:

    helm delete welcome-api

## Contribution

Contributions are welcome! Feel free to open an issue or submit a pull request.

## Licença

This project is licensed under the [MIT License](https://github.com/lucassandin/api.welcome.github.io/blob/main/LICENSE).

---

If you have any questions or suggestions, feel free to contact us! 😊
