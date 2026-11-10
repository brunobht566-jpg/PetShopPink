FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish PetShopPink.Web/PetShopPink.Web.csproj --configuration Release --output /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_HTTP_PORTS=8080
ENV PetShopPink_DATA_PATH=/data/animais.json
EXPOSE 8080
ENTRYPOINT ["dotnet", "PetShopPink.Web.dll"]
