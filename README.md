
# Documentação API Atleta e Clube

Estou realizando esta documentação referente a API que desenvolvi para o Teste na empresa Ploomes


## Autores

- [@igor-goes](https://www.github.com/igor-goes)


## Tecnologias

- Utilizei Entity Framework
- (aquele negocio que o gui disse sobre criar tabela atraves do codigo)
- Core 6
- C#


## Documentação da API

#### Retorna todos os atletas

```http
  GET apiatletasclube.azurewebsites.net/api/Atleta
```

#### Retorna um atleta específico

```http
  GET apiatletasclube.azurewebsites.net/api/Atleta/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do atleta que você quer verificar|

#### Excluir um atleta específico

```http
  DELETE apiatletasclube.azurewebsites.net/api/Atleta/api/Atleta/deletar/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do atleta que você quer deletar|

#### Inserir um novo atleta
```http
  POST apiatletasclube.azurewebsites.net/api/Atleta/api/Atleta/inserir
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

#### Alterar um atleta já existente

```http
  PUT apiatletasclube.azurewebsites.net/api/Atleta/api/Atleta/alterar
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
  GET apiatletasclube.azurewebsites.net/api/Atleta/api/Clube
```

#### Retorna um clube específico

```http
  GET apiatletasclube.azurewebsites.net/api/Atleta/api/Clube/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do clube que você quer verificar|

#### Excluir um clube específico

```http
  DELETE apiatletasclube.azurewebsites.net/api/Atleta/api/Clube/deletar/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do clube que você quer deletar|

#### Inserir um novo clube
```http
  POST apiatletasclube.azurewebsites.net/api/Atleta/api/Clube/inserir
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
  PUT apiatletasclube.azurewebsites.net/api/Atleta/api/Clube/alterar
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





