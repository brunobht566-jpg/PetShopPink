# PetShopPink Web

A interface Windows Forms permanece no projeto original. O novo projeto `PetShopPink.Web` reaproveita o domínio e as regras de negócio para oferecer cadastro, pesquisa, edição e exclusão de animais pelo navegador.

## Executar localmente

Pré-requisito: .NET 10 SDK.

Na raiz do repositório, execute:

```bash
dotnet run --project PetShopPink.Web
```

Abra a URL local apresentada pelo comando. Os dados são gravados em `PetShopPink.Web/App_Data/animais.json` por padrão. Para escolher outro caminho, defina `PetShopPink_DATA_PATH` antes de iniciar a aplicação.

## Publicar fora do GitHub Pages

O GitHub Pages hospeda somente conteúdo estático; esta aplicação precisa de um serviço que execute containers/.NET. O repositório inclui um `Dockerfile` para construir o site em um serviço compatível com Docker, por exemplo Azure App Service (container), Render ou outro provedor.

1. Crie um serviço web a partir deste repositório e selecione Dockerfile na raiz.
2. Configure a porta HTTP do container como `8080` (ou use a detecção automática do provedor).
3. Configure um volume/disco persistente montado em `/data`.
4. Defina `PetShopPink_DATA_PATH=/data/animais.json` nas variáveis de ambiente do serviço.
5. Faça o deploy da branch `adaptacao-web-pages`; depois de concluir o build, abra o domínio fornecido pelo provedor.

Sem volume persistente, o arquivo JSON pode ser perdido quando o serviço for reiniciado ou implantado novamente. O armazenamento JSON é uma primeira versão para uso simples; para vários usuários e uso real, migre para um banco de dados persistente. O login antigo do WinForms (credenciais fixas no código) não foi transportado: este protótipo web ainda não tem autenticação e não deve ser usado para dados privados/publicamente acessíveis sem adicionar login seguro.

## API

- `GET /api/animais?termo=...&campo=nome|codigo|especie|raca|idade|responsavel`
- `POST /api/animais`
- `PUT /api/animais/{codigo}`
- `DELETE /api/animais/{codigo}`
- `GET /api/health`
