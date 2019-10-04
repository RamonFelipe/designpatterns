FROM microsoft/dotnet:sdk AS build

WORKDIR /app

COPY . ./

RUN dotnet publish -c release -o ./out

RUN ls /app/out

FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "ChocolateBoiler.ConsoleApp.dll" ]