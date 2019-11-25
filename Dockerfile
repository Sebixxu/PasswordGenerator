FROM microsoft/dotnet:2.0-sdk
WORKDIR /dodatkowe-zadanie/

COPY /PasswordGenerator/*.csproj ./
RUN dotnet restore

COPY . ./dodatkowe-zadanie
RUN dotnet build -c Release
ENTRYPOINT ["dotnet", "run", "-c", "Release", "--no-build"]