# API LockAi - Projeto Final

**Nome:** Laura Beltran Cabrera

## Link da API:
http://lauracabrera20.somee.com/LockAi/Requerimento/GetAll

## Endpoints da API:

### GET todos os Requerimentos
GET http://lauracabrera20.somee.com/LockAi/Requerimento/GetAll

### POST (Adicionar)

POST http://lauracabrera20.somee.com/LockAi/Requerimento
{
  "momento": "testando",
  "tipoRequerimento": "testando",
  "idLocacao": "testando",
  "observacao": "testando",
  "situacao": "Em analise testando",
  "dataAtualizacao": "01/06/2025",
  "idUsuarioAtualizacao": "007"
}

### PUT (Atualizar)

PUT http://lauracabrera20.somee.com/LockAi/Requerimento

```json
{
  "id": 6,
  "momento": "testando Mudança",
  "tipoRequerimento": "testando Mudança",
  "idLocacao": "testando Mudança",
  "observacao": "testando Mudança",
  "situacao": "Em analise testando Mudança",
  "dataAtualizacao": "01/06/2025",
  "idUsuarioAtualizacao": "007"
}
```
### DELET (Deletar)

DELETE - http://lauracabrera20.somee.com/LockAi/Requerimento/6