FROM microsoft/dotnet:latest

WORKDIR /app
COPY . .

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 9903/tcp
ENV ASPNETCORE_URLS http://*:9903
ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT ["dotnet", "CityInfo.Web.Mvc.dll"]
