FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
COPY . ./
CMD [ "dotnet", "run", "--server.urls", "http://0.0.0.0:5000" ]
