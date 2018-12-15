#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 50369
EXPOSE 44349

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["Inzynierka Shop/Inzynierka Shop.csproj", "Inzynierka Shop/"]
RUN dotnet restore "Inzynierka Shop/Inzynierka Shop.csproj"
COPY . .
WORKDIR "/src/Inzynierka Shop"
RUN dotnet build "Inzynierka Shop.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Inzynierka Shop.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Inzynierka Shop.dll"]