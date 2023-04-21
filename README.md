
# Documentação API Atleta e Clube

Essa API foi desenvolvida para o processo seletivo da empresa Ploomes e está hospedada na plataforma de cloud computing Azure. Além disso, ela também está integrada com um banco de dados que permite armazenar as informações dos atletas e dos clubes, possibilitando a realização das ações de adicionar, deletar, alterar e verificar esses dados de forma segura e eficiente.


## Autores

- [@igor-goes](https://www.github.com/igor-goes)


## Tecnologias

- Entity Framework Code First
- ASP NET CORE
- C#
- Azure


## Documentação da API

#### Retorna todos os atletas

```http
  GET apiatletasclube.azurewebsites.net/api/atleta
```

#### Retorna um atleta específico

```http
  GET apiatletasclube.azurewebsites.net/api/atleta/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do atleta que você quer verificar|

#### Excluir um atleta específico

```http
  DELETE apiatletasclube.azurewebsites.net/api/atleta/deletar/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do atleta que você quer deletar|

#### Inserir um novo atleta
```http
  POST apiatletasclube.azurewebsites.net/api/atleta/inserir
```
## Post/Exemplo

```Json
{
  "nome": "string",
  "nacionalidade": "string",
  "idade": 0,
  "posicao": "string",
  "clubeId": 0
}
```
| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `ClubeId`      | `int` | **Não é Obrigatório**. Seria o ID do clube que você quer adicionar o atleta.|

#### Alterar um atleta já existente

```http
  PUT apiatletasclube.azurewebsites.net/api/atleta/alterar
```

## Put/Exemplo

```Json
{
  "nome": "string",
  "nacionalidade": "string",
  "idade": 0,
  "posicao": "string"
}
```
#### Retorna todos os clubes

```http
  GET apiatletasclube.azurewebsites.net/api/atleta/clube
```

#### Retorna um clube específico

```http
  GET apiatletasclube.azurewebsites.net/api/atleta/clube/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do clube que você quer verificar|

#### Excluir um clube específico

```http
  DELETE apiatletasclube.azurewebsites.net/api/atleta/clube/deletar/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do clube que você quer deletar|

#### Inserir um novo clube
```http
  POST apiatletasclube.azurewebsites.net/api/atleta/clube/inserir
```

## Post/Exemplo

```Json
{
  "nome": "string",
  "nacionalidade": "string",
  "idade": 0,
  "posicao": "string"
}
```

#### Alterar um clube já existente

```http
  PUT apiatletasclube.azurewebsites.net/api/atleta/clube/alterar
```

## Put/Exemplo

```Json
{
  "nome": "string",
  "nacionalidade": "string",
  "idade": 0,
  "posicao": "string"
}
```





