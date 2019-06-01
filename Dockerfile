FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY dist .
EXPOSE 80/tcp
ENTRYPOINT [ "dotnet", "hello-core-mvc.dll" ]