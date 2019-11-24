FROM microsoft/dotnet:3.0-sdk
WORKDIR /sample-app/

# kopiujemy plik .csproj oraz u¿ywamy polecenia dotnet restore
COPY *.csproj ./
RUN dotnet restore

# kopiujemy i dokonujemy build'a ca³ej reszty
COPY . ./sample-app
RUN dotnet build -c Release
ENTRYPOINT ["dotnet", "run", "-c", "Release", "--no-build"]